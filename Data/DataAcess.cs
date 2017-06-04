using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace ERAProject.Data
{
    class DataAcess
    {
        private static string _path = Directory.GetParent((Directory.GetParent(Environment.CurrentDirectory).FullName)).FullName;
        private static string _strCon = "data source=" + _path + "\\Eradb.db";


        private static volatile DataAcess instance;
        private static object syncRoot = new Object();
        private static int utilizacoes = 0;
        private static SQLiteConnection con = null;
        private static SQLiteTransaction trans = null;
        public string Mensagem { get; set; }
        public string DbPath { get => (_path + "\\Eradb.db"); }

        private DataAcess()
        {
            utilizacoes = 0;
        }

        public static DataAcess Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new DataAcess();
                    }
                }
                return instance;
            }
        }


        public bool Connect()
        {
            bool resultado = false;
            Mensagem = "";
            try
            {
                lock (syncRoot)
                {
                    if (utilizacoes == 0)
                    {
                        con = new SQLiteConnection(_strCon);
                        con.Open();
                    }
                    utilizacoes++;
                    resultado = true;
                }
            }
            catch (Exception e)
            {
                Mensagem = "Não foi possível conectar ao DataAcess de dados: " + e.Message;
                Console.Out.WriteLine("Erro Connect(): " + e.Message);
            }
            return resultado;
        }

        public void Disconnect()
        {
            try
            {
                lock (syncRoot)
                {
                    utilizacoes--;
                    if ((utilizacoes == 0) && (con != null) && (con.State == ConnectionState.Open))
                    {
                        con.Close();
                        con = null;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro Disconnect(): " + e.Message);
            }
        }

        public bool BeginTransaction()
        {
            Mensagem = "";
            try
            {
                if ((con != null) && (con.State == System.Data.ConnectionState.Open))
                {
                    trans = con.BeginTransaction();
                    return true;
                }
            }
            catch (Exception e)
            {
                Mensagem = "Não foi possível iniciar a transação: " + e.Message;
                Console.Out.WriteLine("Erro BeginTransaction(): " + e.Message);
            }
            return false;
        }

        public bool CommitTransaction()
        {
            Mensagem = "";
            try
            {
                if ((con != null) && (trans != null) && (con.State == ConnectionState.Open))
                {
                    trans.Commit();
                    trans = null;
                    return true;
                }
            }
            catch (Exception e)
            {
                Mensagem = "Não foi possível concluir a transação: " + e.Message;
                Console.Out.WriteLine("Erro CommitTransaction(): " + e.Message);
            }
            return false;
        }

        public bool RollbackTransaction()
        {
            Mensagem = "";
            try
            {
                if ((con != null) && (trans != null) && (con.State == ConnectionState.Open))
                {
                    trans.Rollback();
                    trans = null;
                    return true;
                }
            }
            catch (Exception e)
            {
                Mensagem = "Não foi possível desfazer a transação: " + e.Message;
                Console.Out.WriteLine("Erro RollbackTransaction(): " + e.Message);
            }
            return false;
        }

        public int GetIdentity()
        {
            int identity = 0;
            GetColumn<int>(0, ref identity, "SELECT @@IDENTITY");
            return identity;
        }

        public bool ExecuteQuery(String sql, out DataTable dt, params Object[] parametros)
        {
            dt = new DataTable();
            Mensagem = "";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                SQLiteDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return true;
            }
            catch (Exception e)
            {
                Mensagem = "Erro ao executar comando: " + e.Message;
                Console.Out.WriteLine("Erro ExecuteQuery(): " + e.Message);
                return false;
            }
        }

        public int ExecuteNonQuery(String sql, params Object[] parametros)
        {
            Mensagem = "";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Mensagem = "Erro ao executar comando: " + e.Message;
                Console.Out.WriteLine("Erro ExecuteNonQuery(): " + e.Message);
                return -1;
            }
        }

        public bool Found(String sql, params Object[] parametros)
        {
            bool found = false;
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                SQLiteDataReader dr = cmd.ExecuteReader();
                found = dr.HasRows;
                dr.Close();
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro Found(): " + e.Message);
            }
            return found;
        }

        public bool GetColumn<tiporetorno>(dynamic columnname, ref tiporetorno valor, String sql, params Object[] parametros)
        {
            bool result = false;
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                SQLiteDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    valor = (tiporetorno)dr[columnname];
                    result = true;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Erro GetColumn(): " + ex.Message);
            }
            return result;
        }
    }
}


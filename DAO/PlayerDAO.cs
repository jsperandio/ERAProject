using ERAProject.Class;
using System.Data.SQLite;
using Dapper;
using System.Linq;
using ERAProject.Model.System;

namespace ERAProject.DAO
{
    public class PlayerDAO
    {
        public Player Carregar(string name)
        {
            Player player = null;

            using (SQLiteConnection connect = new SQLiteConnection(GlobalVariables.StrCon))
            {
                connect.Open();
                player = connect.Query<Player, StatusList, Player>
                    (@"SELECT  p.* ,s.*
                        FROM Player p
                        INNER JOIN Status s ON s.Player=p.PlayerId        
                        where 
                        p.Name = @Name",
                        (p, s) =>
                        {
                            p.StatusPlayer = s;
                            return p;
                        },
                        new { Name = name },
                        splitOn: "StatusId").FirstOrDefault();
                connect.Close();
            }
            return player;
        }
    }
}

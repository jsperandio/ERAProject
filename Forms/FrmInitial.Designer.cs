namespace ERAProject
{
    partial class FrmInitial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInitial));
            this.pnEvents = new System.Windows.Forms.Panel();
            this.rtbEventsLog = new System.Windows.Forms.RichTextBox();
            this.grpbPlayerInfo = new System.Windows.Forms.GroupBox();
            this.prgbHitPoints = new CustomProgress.CustomProgressBar();
            this.lbCurrentStamina = new System.Windows.Forms.Label();
            this.lbCurrentHitPoints = new System.Windows.Forms.Label();
            this.lbCurrentGold = new System.Windows.Forms.Label();
            this.lbCurrentLevel = new System.Windows.Forms.Label();
            this.lbCurrentXp = new System.Windows.Forms.Label();
            this.lbPlayerStamina = new System.Windows.Forms.Label();
            this.lbPlayerExperience = new System.Windows.Forms.Label();
            this.lbPlayerLevel = new System.Windows.Forms.Label();
            this.lbPlayerGold = new System.Windows.Forms.Label();
            this.lbPlayerHitPoints = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbPlayerLuk = new System.Windows.Forms.TextBox();
            this.ttbPlayerDex = new System.Windows.Forms.TextBox();
            this.ttbPlayerSpd = new System.Windows.Forms.TextBox();
            this.ttbPlayerDef = new System.Windows.Forms.TextBox();
            this.ttbPlayerStr = new System.Windows.Forms.TextBox();
            this.btnAddStr = new System.Windows.Forms.Button();
            this.btnRemoveStr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveDef = new System.Windows.Forms.Button();
            this.btnAddDef = new System.Windows.Forms.Button();
            this.btnAddSpd = new System.Windows.Forms.Button();
            this.btnAddDex = new System.Windows.Forms.Button();
            this.btnAddLuk = new System.Windows.Forms.Button();
            this.btnRemoveSpd = new System.Windows.Forms.Button();
            this.btnRemoveDex = new System.Windows.Forms.Button();
            this.btnRemoveLuk = new System.Windows.Forms.Button();
            this.pnEvents.SuspendLayout();
            this.grpbPlayerInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEvents
            // 
            this.pnEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnEvents.Controls.Add(this.rtbEventsLog);
            this.pnEvents.Location = new System.Drawing.Point(13, 354);
            this.pnEvents.Name = "pnEvents";
            this.pnEvents.Size = new System.Drawing.Size(513, 157);
            this.pnEvents.TabIndex = 0;
            // 
            // rtbEventsLog
            // 
            this.rtbEventsLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEventsLog.BackColor = System.Drawing.Color.NavajoWhite;
            this.rtbEventsLog.Location = new System.Drawing.Point(4, 4);
            this.rtbEventsLog.Name = "rtbEventsLog";
            this.rtbEventsLog.Size = new System.Drawing.Size(504, 148);
            this.rtbEventsLog.TabIndex = 0;
            this.rtbEventsLog.Text = "";
            // 
            // grpbPlayerInfo
            // 
            this.grpbPlayerInfo.Controls.Add(this.prgbHitPoints);
            this.grpbPlayerInfo.Controls.Add(this.lbCurrentStamina);
            this.grpbPlayerInfo.Controls.Add(this.lbCurrentHitPoints);
            this.grpbPlayerInfo.Controls.Add(this.lbCurrentGold);
            this.grpbPlayerInfo.Controls.Add(this.lbCurrentLevel);
            this.grpbPlayerInfo.Controls.Add(this.lbCurrentXp);
            this.grpbPlayerInfo.Controls.Add(this.lbPlayerStamina);
            this.grpbPlayerInfo.Controls.Add(this.lbPlayerExperience);
            this.grpbPlayerInfo.Controls.Add(this.lbPlayerLevel);
            this.grpbPlayerInfo.Controls.Add(this.lbPlayerGold);
            this.grpbPlayerInfo.Controls.Add(this.lbPlayerHitPoints);
            this.grpbPlayerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPlayerInfo.Location = new System.Drawing.Point(13, 13);
            this.grpbPlayerInfo.Name = "grpbPlayerInfo";
            this.grpbPlayerInfo.Size = new System.Drawing.Size(262, 115);
            this.grpbPlayerInfo.TabIndex = 1;
            this.grpbPlayerInfo.TabStop = false;
            this.grpbPlayerInfo.Text = "Textix Testoar\'s";
            // 
            // prgbHitPoints
            // 
            this.prgbHitPoints.Fade = 0;
            this.prgbHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prgbHitPoints.Location = new System.Drawing.Point(81, 19);
            this.prgbHitPoints.Name = "prgbHitPoints";
            this.prgbHitPoints.Size = new System.Drawing.Size(174, 13);
            this.prgbHitPoints.Step = 1;
            this.prgbHitPoints.TabIndex = 12;
            this.prgbHitPoints.Text = "95/100";
            this.prgbHitPoints.Value = 95;
            // 
            // lbCurrentStamina
            // 
            this.lbCurrentStamina.AutoSize = true;
            this.lbCurrentStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentStamina.Location = new System.Drawing.Point(78, 90);
            this.lbCurrentStamina.Name = "lbCurrentStamina";
            this.lbCurrentStamina.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentStamina.TabIndex = 11;
            this.lbCurrentStamina.Text = "0";
            // 
            // lbCurrentHitPoints
            // 
            this.lbCurrentHitPoints.AutoSize = true;
            this.lbCurrentHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentHitPoints.Location = new System.Drawing.Point(40, 19);
            this.lbCurrentHitPoints.Name = "lbCurrentHitPoints";
            this.lbCurrentHitPoints.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentHitPoints.TabIndex = 10;
            this.lbCurrentHitPoints.Text = "0";
            // 
            // lbCurrentGold
            // 
            this.lbCurrentGold.AutoSize = true;
            this.lbCurrentGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentGold.Location = new System.Drawing.Point(78, 37);
            this.lbCurrentGold.Name = "lbCurrentGold";
            this.lbCurrentGold.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentGold.TabIndex = 9;
            this.lbCurrentGold.Text = "0";
            // 
            // lbCurrentLevel
            // 
            this.lbCurrentLevel.AutoSize = true;
            this.lbCurrentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentLevel.Location = new System.Drawing.Point(78, 55);
            this.lbCurrentLevel.Name = "lbCurrentLevel";
            this.lbCurrentLevel.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentLevel.TabIndex = 8;
            this.lbCurrentLevel.Text = "0";
            // 
            // lbCurrentXp
            // 
            this.lbCurrentXp.AutoSize = true;
            this.lbCurrentXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentXp.Location = new System.Drawing.Point(78, 73);
            this.lbCurrentXp.Name = "lbCurrentXp";
            this.lbCurrentXp.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentXp.TabIndex = 7;
            this.lbCurrentXp.Text = "0";
            // 
            // lbPlayerStamina
            // 
            this.lbPlayerStamina.AutoSize = true;
            this.lbPlayerStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerStamina.Location = new System.Drawing.Point(6, 90);
            this.lbPlayerStamina.Name = "lbPlayerStamina";
            this.lbPlayerStamina.Size = new System.Drawing.Size(51, 13);
            this.lbPlayerStamina.TabIndex = 6;
            this.lbPlayerStamina.Text = "Stamina :";
            // 
            // lbPlayerExperience
            // 
            this.lbPlayerExperience.AutoSize = true;
            this.lbPlayerExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerExperience.Location = new System.Drawing.Point(6, 73);
            this.lbPlayerExperience.Name = "lbPlayerExperience";
            this.lbPlayerExperience.Size = new System.Drawing.Size(66, 13);
            this.lbPlayerExperience.TabIndex = 5;
            this.lbPlayerExperience.Text = "Experience :";
            // 
            // lbPlayerLevel
            // 
            this.lbPlayerLevel.AutoSize = true;
            this.lbPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerLevel.Location = new System.Drawing.Point(6, 55);
            this.lbPlayerLevel.Name = "lbPlayerLevel";
            this.lbPlayerLevel.Size = new System.Drawing.Size(39, 13);
            this.lbPlayerLevel.TabIndex = 4;
            this.lbPlayerLevel.Text = "Level :";
            // 
            // lbPlayerGold
            // 
            this.lbPlayerGold.AutoSize = true;
            this.lbPlayerGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerGold.Location = new System.Drawing.Point(6, 37);
            this.lbPlayerGold.Name = "lbPlayerGold";
            this.lbPlayerGold.Size = new System.Drawing.Size(35, 13);
            this.lbPlayerGold.TabIndex = 3;
            this.lbPlayerGold.Text = "Gold :";
            // 
            // lbPlayerHitPoints
            // 
            this.lbPlayerHitPoints.AutoSize = true;
            this.lbPlayerHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerHitPoints.Location = new System.Drawing.Point(6, 19);
            this.lbPlayerHitPoints.Name = "lbPlayerHitPoints";
            this.lbPlayerHitPoints.Size = new System.Drawing.Size(28, 13);
            this.lbPlayerHitPoints.TabIndex = 2;
            this.lbPlayerHitPoints.Text = "HP :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveLuk);
            this.groupBox1.Controls.Add(this.btnRemoveDex);
            this.groupBox1.Controls.Add(this.btnRemoveSpd);
            this.groupBox1.Controls.Add(this.btnAddLuk);
            this.groupBox1.Controls.Add(this.btnAddDex);
            this.groupBox1.Controls.Add(this.btnAddSpd);
            this.groupBox1.Controls.Add(this.btnAddDef);
            this.groupBox1.Controls.Add(this.btnRemoveDef);
            this.groupBox1.Controls.Add(this.ttbPlayerLuk);
            this.groupBox1.Controls.Add(this.ttbPlayerDex);
            this.groupBox1.Controls.Add(this.ttbPlayerSpd);
            this.groupBox1.Controls.Add(this.ttbPlayerDef);
            this.groupBox1.Controls.Add(this.ttbPlayerStr);
            this.groupBox1.Controls.Add(this.btnAddStr);
            this.groupBox1.Controls.Add(this.btnRemoveStr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(281, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats ";
            // 
            // ttbPlayerLuk
            // 
            this.ttbPlayerLuk.BackColor = System.Drawing.Color.Tan;
            this.ttbPlayerLuk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttbPlayerLuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ttbPlayerLuk.Location = new System.Drawing.Point(85, 90);
            this.ttbPlayerLuk.Name = "ttbPlayerLuk";
            this.ttbPlayerLuk.ReadOnly = true;
            this.ttbPlayerLuk.Size = new System.Drawing.Size(53, 13);
            this.ttbPlayerLuk.TabIndex = 30;
            this.ttbPlayerLuk.Text = "0";
            this.ttbPlayerLuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ttbPlayerDex
            // 
            this.ttbPlayerDex.BackColor = System.Drawing.Color.Tan;
            this.ttbPlayerDex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttbPlayerDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ttbPlayerDex.Location = new System.Drawing.Point(85, 73);
            this.ttbPlayerDex.Name = "ttbPlayerDex";
            this.ttbPlayerDex.ReadOnly = true;
            this.ttbPlayerDex.Size = new System.Drawing.Size(53, 13);
            this.ttbPlayerDex.TabIndex = 29;
            this.ttbPlayerDex.Text = "0";
            this.ttbPlayerDex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ttbPlayerSpd
            // 
            this.ttbPlayerSpd.BackColor = System.Drawing.Color.Tan;
            this.ttbPlayerSpd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttbPlayerSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ttbPlayerSpd.Location = new System.Drawing.Point(85, 55);
            this.ttbPlayerSpd.Name = "ttbPlayerSpd";
            this.ttbPlayerSpd.ReadOnly = true;
            this.ttbPlayerSpd.Size = new System.Drawing.Size(53, 13);
            this.ttbPlayerSpd.TabIndex = 28;
            this.ttbPlayerSpd.Text = "0";
            this.ttbPlayerSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ttbPlayerDef
            // 
            this.ttbPlayerDef.BackColor = System.Drawing.Color.Tan;
            this.ttbPlayerDef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttbPlayerDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ttbPlayerDef.Location = new System.Drawing.Point(85, 37);
            this.ttbPlayerDef.Name = "ttbPlayerDef";
            this.ttbPlayerDef.ReadOnly = true;
            this.ttbPlayerDef.Size = new System.Drawing.Size(53, 13);
            this.ttbPlayerDef.TabIndex = 27;
            this.ttbPlayerDef.Text = "0";
            this.ttbPlayerDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ttbPlayerStr
            // 
            this.ttbPlayerStr.BackColor = System.Drawing.Color.Tan;
            this.ttbPlayerStr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttbPlayerStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ttbPlayerStr.Location = new System.Drawing.Point(85, 19);
            this.ttbPlayerStr.Name = "ttbPlayerStr";
            this.ttbPlayerStr.ReadOnly = true;
            this.ttbPlayerStr.Size = new System.Drawing.Size(53, 13);
            this.ttbPlayerStr.TabIndex = 26;
            this.ttbPlayerStr.Text = "0";
            this.ttbPlayerStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddStr
            // 
            this.btnAddStr.FlatAppearance.BorderSize = 0;
            this.btnAddStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStr.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStr.Image")));
            this.btnAddStr.Location = new System.Drawing.Point(144, 18);
            this.btnAddStr.Name = "btnAddStr";
            this.btnAddStr.Size = new System.Drawing.Size(27, 15);
            this.btnAddStr.TabIndex = 21;
            this.btnAddStr.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStr
            // 
            this.btnRemoveStr.FlatAppearance.BorderSize = 0;
            this.btnRemoveStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStr.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveStr.Image")));
            this.btnRemoveStr.Location = new System.Drawing.Point(52, 18);
            this.btnRemoveStr.Name = "btnRemoveStr";
            this.btnRemoveStr.Size = new System.Drawing.Size(27, 15);
            this.btnRemoveStr.TabIndex = 4;
            this.btnRemoveStr.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DEX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "LUK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SPD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DEF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "STR";
            // 
            // btnRemoveDef
            // 
            this.btnRemoveDef.FlatAppearance.BorderSize = 0;
            this.btnRemoveDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDef.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveDef.Image")));
            this.btnRemoveDef.Location = new System.Drawing.Point(52, 36);
            this.btnRemoveDef.Name = "btnRemoveDef";
            this.btnRemoveDef.Size = new System.Drawing.Size(27, 15);
            this.btnRemoveDef.TabIndex = 31;
            this.btnRemoveDef.UseVisualStyleBackColor = true;
            // 
            // btnAddDef
            // 
            this.btnAddDef.FlatAppearance.BorderSize = 0;
            this.btnAddDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDef.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDef.Image")));
            this.btnAddDef.Location = new System.Drawing.Point(144, 36);
            this.btnAddDef.Name = "btnAddDef";
            this.btnAddDef.Size = new System.Drawing.Size(27, 15);
            this.btnAddDef.TabIndex = 32;
            this.btnAddDef.UseVisualStyleBackColor = true;
            // 
            // btnAddSpd
            // 
            this.btnAddSpd.FlatAppearance.BorderSize = 0;
            this.btnAddSpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpd.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSpd.Image")));
            this.btnAddSpd.Location = new System.Drawing.Point(144, 54);
            this.btnAddSpd.Name = "btnAddSpd";
            this.btnAddSpd.Size = new System.Drawing.Size(27, 15);
            this.btnAddSpd.TabIndex = 33;
            this.btnAddSpd.UseVisualStyleBackColor = true;
            // 
            // btnAddDex
            // 
            this.btnAddDex.FlatAppearance.BorderSize = 0;
            this.btnAddDex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDex.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDex.Image")));
            this.btnAddDex.Location = new System.Drawing.Point(144, 72);
            this.btnAddDex.Name = "btnAddDex";
            this.btnAddDex.Size = new System.Drawing.Size(27, 15);
            this.btnAddDex.TabIndex = 34;
            this.btnAddDex.UseVisualStyleBackColor = true;
            // 
            // btnAddLuk
            // 
            this.btnAddLuk.FlatAppearance.BorderSize = 0;
            this.btnAddLuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLuk.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLuk.Image")));
            this.btnAddLuk.Location = new System.Drawing.Point(144, 89);
            this.btnAddLuk.Name = "btnAddLuk";
            this.btnAddLuk.Size = new System.Drawing.Size(27, 15);
            this.btnAddLuk.TabIndex = 35;
            this.btnAddLuk.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSpd
            // 
            this.btnRemoveSpd.FlatAppearance.BorderSize = 0;
            this.btnRemoveSpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSpd.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSpd.Image")));
            this.btnRemoveSpd.Location = new System.Drawing.Point(52, 54);
            this.btnRemoveSpd.Name = "btnRemoveSpd";
            this.btnRemoveSpd.Size = new System.Drawing.Size(27, 15);
            this.btnRemoveSpd.TabIndex = 36;
            this.btnRemoveSpd.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDex
            // 
            this.btnRemoveDex.FlatAppearance.BorderSize = 0;
            this.btnRemoveDex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDex.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveDex.Image")));
            this.btnRemoveDex.Location = new System.Drawing.Point(52, 72);
            this.btnRemoveDex.Name = "btnRemoveDex";
            this.btnRemoveDex.Size = new System.Drawing.Size(27, 15);
            this.btnRemoveDex.TabIndex = 37;
            this.btnRemoveDex.UseVisualStyleBackColor = true;
            // 
            // btnRemoveLuk
            // 
            this.btnRemoveLuk.FlatAppearance.BorderSize = 0;
            this.btnRemoveLuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveLuk.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveLuk.Image")));
            this.btnRemoveLuk.Location = new System.Drawing.Point(52, 89);
            this.btnRemoveLuk.Name = "btnRemoveLuk";
            this.btnRemoveLuk.Size = new System.Drawing.Size(27, 15);
            this.btnRemoveLuk.TabIndex = 38;
            this.btnRemoveLuk.UseVisualStyleBackColor = true;
            // 
            // FrmInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(538, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpbPlayerInfo);
            this.Controls.Add(this.pnEvents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "FrmInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERAProject - Epic Rpg Adventure";
            this.Load += new System.EventHandler(this.FrmInitial_Load);
            this.pnEvents.ResumeLayout(false);
            this.grpbPlayerInfo.ResumeLayout(false);
            this.grpbPlayerInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEvents;
        private System.Windows.Forms.RichTextBox rtbEventsLog;
        private System.Windows.Forms.GroupBox grpbPlayerInfo;
        private System.Windows.Forms.Label lbPlayerStamina;
        private System.Windows.Forms.Label lbPlayerExperience;
        private System.Windows.Forms.Label lbPlayerLevel;
        private System.Windows.Forms.Label lbPlayerGold;
        private System.Windows.Forms.Label lbPlayerHitPoints;
        private System.Windows.Forms.Label lbCurrentStamina;
        private System.Windows.Forms.Label lbCurrentHitPoints;
        private System.Windows.Forms.Label lbCurrentGold;
        private System.Windows.Forms.Label lbCurrentLevel;
        private System.Windows.Forms.Label lbCurrentXp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStr;
        private System.Windows.Forms.Button btnRemoveStr;
        private System.Windows.Forms.TextBox ttbPlayerStr;
        private System.Windows.Forms.TextBox ttbPlayerLuk;
        private System.Windows.Forms.TextBox ttbPlayerDex;
        private System.Windows.Forms.TextBox ttbPlayerSpd;
        private System.Windows.Forms.TextBox ttbPlayerDef;
        private CustomProgress.CustomProgressBar prgbHitPoints;
        private System.Windows.Forms.Button btnRemoveLuk;
        private System.Windows.Forms.Button btnRemoveDex;
        private System.Windows.Forms.Button btnRemoveSpd;
        private System.Windows.Forms.Button btnAddLuk;
        private System.Windows.Forms.Button btnAddDex;
        private System.Windows.Forms.Button btnAddSpd;
        private System.Windows.Forms.Button btnAddDef;
        private System.Windows.Forms.Button btnRemoveDef;
    }
}


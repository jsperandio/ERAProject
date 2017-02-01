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
            this.pnEvents = new System.Windows.Forms.Panel();
            this.rtbEventsLog = new System.Windows.Forms.RichTextBox();
            this.grpbPlayerInfo = new System.Windows.Forms.GroupBox();
            this.lbPlayerHitPoints = new System.Windows.Forms.Label();
            this.lbPlayerGold = new System.Windows.Forms.Label();
            this.lbPlayerLevel = new System.Windows.Forms.Label();
            this.lbPlayerExperience = new System.Windows.Forms.Label();
            this.lbPlayerStamina = new System.Windows.Forms.Label();
            this.lbCurrentXp = new System.Windows.Forms.Label();
            this.lbCurrentLevel = new System.Windows.Forms.Label();
            this.lbCurrentGold = new System.Windows.Forms.Label();
            this.lbCurrentHitPoints = new System.Windows.Forms.Label();
            this.lbCurrentStamina = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPlayerLuk = new System.Windows.Forms.Label();
            this.lbPlayerStr = new System.Windows.Forms.Label();
            this.lbPlayerDef = new System.Windows.Forms.Label();
            this.lbPlayerSpd = new System.Windows.Forms.Label();
            this.lbPlayerDex = new System.Windows.Forms.Label();
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
            this.rtbEventsLog.Location = new System.Drawing.Point(4, 4);
            this.rtbEventsLog.Name = "rtbEventsLog";
            this.rtbEventsLog.Size = new System.Drawing.Size(504, 148);
            this.rtbEventsLog.TabIndex = 0;
            this.rtbEventsLog.Text = "";
            // 
            // grpbPlayerInfo
            // 
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
            // lbCurrentXp
            // 
            this.lbCurrentXp.AutoSize = true;
            this.lbCurrentXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentXp.Location = new System.Drawing.Point(78, 68);
            this.lbCurrentXp.Name = "lbCurrentXp";
            this.lbCurrentXp.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentXp.TabIndex = 7;
            this.lbCurrentXp.Text = "0";
            // 
            // lbCurrentLevel
            // 
            this.lbCurrentLevel.AutoSize = true;
            this.lbCurrentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentLevel.Location = new System.Drawing.Point(78, 51);
            this.lbCurrentLevel.Name = "lbCurrentLevel";
            this.lbCurrentLevel.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentLevel.TabIndex = 8;
            this.lbCurrentLevel.Text = "0";
            // 
            // lbCurrentGold
            // 
            this.lbCurrentGold.AutoSize = true;
            this.lbCurrentGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentGold.Location = new System.Drawing.Point(78, 33);
            this.lbCurrentGold.Name = "lbCurrentGold";
            this.lbCurrentGold.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentGold.TabIndex = 9;
            this.lbCurrentGold.Text = "0";
            // 
            // lbCurrentHitPoints
            // 
            this.lbCurrentHitPoints.AutoSize = true;
            this.lbCurrentHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentHitPoints.Location = new System.Drawing.Point(78, 17);
            this.lbCurrentHitPoints.Name = "lbCurrentHitPoints";
            this.lbCurrentHitPoints.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentHitPoints.TabIndex = 10;
            this.lbCurrentHitPoints.Text = "0";
            // 
            // lbCurrentStamina
            // 
            this.lbCurrentStamina.AutoSize = true;
            this.lbCurrentStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCurrentStamina.Location = new System.Drawing.Point(78, 88);
            this.lbCurrentStamina.Name = "lbCurrentStamina";
            this.lbCurrentStamina.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentStamina.TabIndex = 11;
            this.lbCurrentStamina.Text = "0";
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
            this.groupBox1.Controls.Add(this.lbPlayerLuk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbPlayerStr);
            this.groupBox1.Controls.Add(this.lbPlayerDef);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbPlayerSpd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbPlayerDex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(281, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats : 30 Remaining";
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
            // lbPlayerLuk
            // 
            this.lbPlayerLuk.AutoSize = true;
            this.lbPlayerLuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbPlayerLuk.Location = new System.Drawing.Point(54, 90);
            this.lbPlayerLuk.Name = "lbPlayerLuk";
            this.lbPlayerLuk.Size = new System.Drawing.Size(13, 13);
            this.lbPlayerLuk.TabIndex = 16;
            this.lbPlayerLuk.Text = "0";
            // 
            // lbPlayerStr
            // 
            this.lbPlayerStr.AutoSize = true;
            this.lbPlayerStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbPlayerStr.Location = new System.Drawing.Point(54, 19);
            this.lbPlayerStr.Name = "lbPlayerStr";
            this.lbPlayerStr.Size = new System.Drawing.Size(13, 13);
            this.lbPlayerStr.TabIndex = 15;
            this.lbPlayerStr.Text = "0";
            // 
            // lbPlayerDef
            // 
            this.lbPlayerDef.AutoSize = true;
            this.lbPlayerDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbPlayerDef.Location = new System.Drawing.Point(54, 35);
            this.lbPlayerDef.Name = "lbPlayerDef";
            this.lbPlayerDef.Size = new System.Drawing.Size(13, 13);
            this.lbPlayerDef.TabIndex = 14;
            this.lbPlayerDef.Text = "0";
            // 
            // lbPlayerSpd
            // 
            this.lbPlayerSpd.AutoSize = true;
            this.lbPlayerSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbPlayerSpd.Location = new System.Drawing.Point(54, 53);
            this.lbPlayerSpd.Name = "lbPlayerSpd";
            this.lbPlayerSpd.Size = new System.Drawing.Size(13, 13);
            this.lbPlayerSpd.TabIndex = 13;
            this.lbPlayerSpd.Text = "0";
            // 
            // lbPlayerDex
            // 
            this.lbPlayerDex.AutoSize = true;
            this.lbPlayerDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbPlayerDex.Location = new System.Drawing.Point(54, 70);
            this.lbPlayerDex.Name = "lbPlayerDex";
            this.lbPlayerDex.Size = new System.Drawing.Size(13, 13);
            this.lbPlayerDex.TabIndex = 12;
            this.lbPlayerDex.Text = "0";
            // 
            // FrmInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpbPlayerInfo);
            this.Controls.Add(this.pnEvents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "FrmInitial";
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
        private System.Windows.Forms.Label lbPlayerLuk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPlayerStr;
        private System.Windows.Forms.Label lbPlayerDef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPlayerSpd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPlayerDex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


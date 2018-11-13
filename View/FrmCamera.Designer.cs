namespace ERAProject.View
{
    partial class FrmCamera
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
            this.PbMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // PbMap
            // 
            this.PbMap.BackColor = System.Drawing.Color.Tan;
            this.PbMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbMap.Location = new System.Drawing.Point(0, 0);
            this.PbMap.Name = "PbMap";
            this.PbMap.Size = new System.Drawing.Size(214, 211);
            this.PbMap.TabIndex = 0;
            this.PbMap.TabStop = false;
            this.PbMap.Paint += new System.Windows.Forms.PaintEventHandler(this.PbMap_Paint);
            this.PbMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbMap_MouseClick);
            this.PbMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbMap_MouseMove);
            this.PbMap.Resize += new System.EventHandler(this.PbMap_Resize);
            // 
            // FrmCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 211);
            this.Controls.Add(this.PbMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmCamera";
            this.Text = "FrmCamera";
            ((System.ComponentModel.ISupportInitialize)(this.PbMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbMap;
    }
}
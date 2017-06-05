namespace ERAProject
{
    partial class FrmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMap));
            this.pbMapViewer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMapViewer
            // 
            this.pbMapViewer.BackColor = System.Drawing.Color.Blue;
            this.pbMapViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMapViewer.Location = new System.Drawing.Point(0, 0);
            this.pbMapViewer.Name = "pbMapViewer";
            this.pbMapViewer.Size = new System.Drawing.Size(284, 261);
            this.pbMapViewer.TabIndex = 0;
            this.pbMapViewer.TabStop = false;
            this.pbMapViewer.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapViewer_Paint);
            this.pbMapViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMapViewer_MouseClick);
            this.pbMapViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMapViewer_MouseMove);
            this.pbMapViewer.Resize += new System.EventHandler(this.pbMapViewer_Resize);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbMapViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmMap";
            this.Text = "Map Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMap_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMapViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMapViewer;
    }
}
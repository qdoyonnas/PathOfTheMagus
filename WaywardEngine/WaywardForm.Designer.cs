namespace WaywardEngine
{
    partial class WaywardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) ) {
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
            this.components = new System.ComponentModel.Container();
            this.mainContextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContextMenu1
            // 
            this.mainContextMenu1.BackColor = System.Drawing.Color.Black;
            this.mainContextMenu1.Font = new System.Drawing.Font("Berry Rotunda", 9F);
            this.mainContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPageToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mainContextMenu1.Name = "mainContextMenu1";
            this.mainContextMenu1.ShowImageMargin = false;
            this.mainContextMenu1.Size = new System.Drawing.Size(132, 56);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // newPageToolStripMenuItem
            // 
            this.newPageToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.newPageToolStripMenuItem.Name = "newPageToolStripMenuItem";
            this.newPageToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.newPageToolStripMenuItem.Text = "New Page";
            this.newPageToolStripMenuItem.Click += new System.EventHandler(this.newPageToolStripMenuItem_Click);
            // 
            // WaywardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.ContextMenuStrip = this.mainContextMenu1;
            this.Font = new System.Drawing.Font("Berry Rotunda", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WaywardForm";
            this.Text = "WaywardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mainContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPageToolStripMenuItem;
    }
}
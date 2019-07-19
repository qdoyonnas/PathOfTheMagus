namespace WaywardEngine
{
    partial class DescriptivePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleText = new System.Windows.Forms.Label();
            this.pageContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pageContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.BackColor = System.Drawing.Color.Black;
            this.TitleText.ContextMenuStrip = this.pageContextMenu;
            this.TitleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleText.Font = new System.Drawing.Font("Berry Rotunda", 14F);
            this.TitleText.Location = new System.Drawing.Point(0, 0);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(633, 51);
            this.TitleText.TabIndex = 0;
            this.TitleText.Text = "label1";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageContextMenu
            // 
            this.pageContextMenu.BackColor = System.Drawing.Color.Black;
            this.pageContextMenu.Font = new System.Drawing.Font("Berry Rotunda", 9F);
            this.pageContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pageContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.pageContextMenu.Name = "pageContextMenu";
            this.pageContextMenu.ShowImageMargin = false;
            this.pageContextMenu.Size = new System.Drawing.Size(93, 30);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ContextMenuStrip = this.pageContextMenu;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(643, 496);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.TitleText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel2.Size = new System.Drawing.Size(633, 53);
            this.panel2.TabIndex = 2;
            // 
            // DescriptivePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Berry Rotunda", 8.25F);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DescriptivePage";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(647, 500);
            this.pageContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip pageContextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

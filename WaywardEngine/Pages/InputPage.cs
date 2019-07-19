using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaywardEngine
{
    public partial class InputPage : UserControl
    {
        Page page;

        public InputPage(Page page)
        {
            this.page = page;
            InitializeComponent();

            pageContextMenu.Renderer = new ContextRenderer();
        }

        private void closeToolStripMenuItem_Click( object sender, EventArgs e )
        {
             page.Close();
        }
        
        private void OnInputBoxKeyDown( object sender, KeyEventArgs e )
        {
            if( e.KeyCode == Keys.Enter ) {
                e.SuppressKeyPress = true;

                TextBox textBox = sender as TextBox;
                if( textBox == null ) { return; }

                page.SetText("BodyText", '\r'+textBox.Text, true);
                textBox.Text = string.Empty;
            }
        }
    }
}

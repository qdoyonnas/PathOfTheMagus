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
    public partial class BlankPage : UserControl
    {
        Page page;

        public BlankPage(Page page)
        {
            this.page = page;
            InitializeComponent();

            pageContextMenu.Renderer = new ContextRenderer();
        }

        private void closeToolStripMenuItem_Click( object sender, EventArgs e )
        {
             page.Close();
        }
    }
}

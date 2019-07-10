using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaywardEngine
{
    public class ContextRenderer : ToolStripProfessionalRenderer
    {
        public ContextRenderer() : base(new ColorTheme1()) { }
    }

    public class ColorTheme1 : ProfessionalColorTable
    {
        public override Color MenuItemSelected {
            get { return Color.Black; }
        }

        public override Color MenuItemBorder {
            get { return Color.Silver; }
        }
    }

    public partial class WaywardForm : Form
    {
        public Game game;

        public Mouse mouse;
        public List<Page> pages;

        public WaywardForm(Game game)
        {
            this.game = game;

            InitializeComponent();

            mouse = new Mouse(this);
            pages = new List<Page>();

            //Cursor.Hide();

            mainContextMenu1.Renderer = new ContextRenderer();
        }

        private void newPageToolStripMenuItem_Click( object sender, EventArgs e )
        {
            AddPage( new Page(this, PageType.Blank) );
        }

        private void quitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            game.isRunning = false;
        }

        public void AddPage(Page page)
        {
            pages.Add(page);
        }
        public void RemovePage(Page page)
        {
            pages.Remove(page);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WaywardEngine
{
    public class Mouse
    {
        public WaywardForm form;

        private PictureBox cursorImage;

        private Page grabbedPage;
        private Point grabOffset;

        public Mouse(WaywardForm form)
        {
            this.form = form;

            /*cursorImage = new PictureBox();
            cursorImage.Image = Properties.Resources.QuillCursor1;
            form.Controls.Add(cursorImage);*/

            form.game.DoUpdate += Update;
        }

        public void GrabControl(Page page)
        {
            grabbedPage = page;
            grabOffset = new Point( (grabbedPage.control.Location.X - Cursor.Position.X), (grabbedPage.control.Location.Y - Cursor.Position.Y) );
        }
        public void ReleaseControl()
        {
            grabbedPage = null;
        }

        public void Update()
        {
            //SetCursorImage();

            if( grabbedPage != null ) {
                grabbedPage.MoveTo( new Point( (Cursor.Position.X + grabOffset.X), (Cursor.Position.Y + grabOffset.Y)) );
            }
        }

        /*delegate void SetCursorImageDelegate();
        private void SetCursorImage()
        {
            if( cursorImage.InvokeRequired ) {
                SetCursorImageDelegate del = new SetCursorImageDelegate( SetCursorImage );
                cursorImage.Invoke( del );
            } else {
                cursorImage.BringToFront();
                cursorImage.Location = Cursor.Position;
                form.Refresh();
            }
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WaywardEngine
{
    public enum PageType {
        Blank,
        Descriptive,
        Input
    };

    public class Page
    {
        public WaywardForm form;

        public Control control;

        public Page(WaywardForm form, PageType type)
        {
            this.form = form;

            switch( type ) {
                case PageType.Blank:
                    control = new BlankPage(this);
                    break;
                case PageType.Descriptive:
                    control = new DescriptivePage(this);
                    break;
                case PageType.Input:
                    control = new InputPage(this);
                    break;
            }

            if( control == null ) { return; }
            List<Control> allControls = Utility.GetAllControlsRecurs( new List<Control>(), control );
            foreach( Control ctrl in allControls ) {
                if( !ctrl.CausesValidation ) { continue; }

                ctrl.MouseEnter += OnMouseEnter;
                ctrl.MouseLeave += OnMouseLeave;
                ctrl.MouseDown += OnMouseDown;
                ctrl.MouseUp += OnMouseUp;
            }
            
            form.Controls.Add(control);
        }

        private void OnMouseEnter( object sender, EventArgs e )
        {
            control.BackColor = Color.Silver;
        }
        private void OnMouseLeave( object sender, EventArgs e )
        {
            control.BackColor = Color.Gray;
        }
        private void OnMouseDown( object sender, MouseEventArgs e )
        {
            control.BringToFront();
            form.mouse.GrabControl(this);
        }
        private void OnMouseUp( object sender, MouseEventArgs e )
        {
            form.mouse.ReleaseControl();
        }

        delegate void MoveToDelegate(Point point);
        public void MoveTo(Point point)
        {
            if( control.InvokeRequired ) {
                MoveToDelegate del = new MoveToDelegate( MoveTo );
                control.Invoke( del, new object[] { point } );
            } else {
                control.Location = point;
                form.Refresh();
            }
        }

        delegate void SetSizeDelegate(Point point);
        public void SetSize(Point size)
        {
            if( control.InvokeRequired ) {
                SetSizeDelegate del = new SetSizeDelegate( SetSize );
                control.Invoke( del, new object[] { size } );
            } else {
                control.Size = new Size(size);
            }
        }

        public void SetTitle(string title)
        {
            List<Control> allControls = Utility.GetAllControlsRecurs( new List<Control>(), control );
            foreach( Control ctrl in allControls ) {
                if( ctrl.Name == "titleLabel" ) {
                    ctrl.Text = title;
                }
            }
        }
        public void SetText(string text, bool append)
        {
            List<Control> allControls = Utility.GetAllControlsRecurs( new List<Control>(), control );
            foreach( Control ctrl in allControls ) {
                if( ctrl.Name == "bodyText" ) {
                    if( append ) {
                        ctrl.Text += text;
                    } else {
                        ctrl.Text = text;
                    }
                }
            }
        }

        public void Close()
        {
            form.RemovePage(this);
            form.Controls.Remove(control);
            control = null;
        }
    }
}

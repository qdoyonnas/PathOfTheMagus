using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagusPath
{
    public class OpenExit : Exit
    {
        public OpenExit( string name, Container container )
            : base(name)
        {
            containers = new Container[] { container };
            container.AddExit(this);
        }

        public override bool Transition( GameObject obj )
        {
            if( !CheckDimensions(obj) ) { return false; }

            if( obj.attachedTo == containers[1] ) {
                containers[1].Detach(obj);
                containers[1].attachedTo.Attach(obj);
            } else if( obj.attachedTo == containers[1].attachedTo ) {
                containers[1].attachedTo.Detach(obj);
                containers[1].Attach(obj);
            } else {
                return false;
            }

            return true;
        }
    }
}

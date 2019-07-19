using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagusPath
{
    public class LinkedExit : Exit
    {
        public LinkedExit( string name, Container container1, Container container2 )
            :base(name)
        {
            containers = new Container[] { container1, container2 };
            container1.AddExit(this);
            container2.AddExit(this);
        }

        public override bool Transition( GameObject obj )
        {
            if( !CheckDimensions(obj) ) { return false; }

            if( obj.attachedTo == containers[1] ) {
                containers[1].Detach(obj);
                containers[2].Attach(obj);
            } else if( obj.attachedTo == containers[2] ) {
                containers[2].Detach(obj);
                containers[1].Attach(obj);
            } else {
                return false;
            }

            return true;
        }
    }
}

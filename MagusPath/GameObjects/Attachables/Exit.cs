using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagusPath
{
    public abstract class Exit : GameObject
    {
        public Container[] containers;

        public Vector3 crossSection = Vector3.zero;

        public Exit( string name )
            :base(name) {}

        public abstract bool Transition( GameObject obj );
        public bool CheckDimensions( GameObject obj )
        {


            return true;
        }
    }
}

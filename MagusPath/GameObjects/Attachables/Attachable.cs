using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagusPath
{
    public abstract class Attachable: GameObject
    {
        public bool singleAttach = false;
        
        protected List<GameObject> attached;

        public Attachable( string name )
            : base(name)
        {
            attached = new List<GameObject>();
        }

        public override float GetTotalWeight()
        {
            float totalWeight = base.GetTotalWeight();

            foreach( GameObject obj in attached ) {
                totalWeight += obj.GetTotalWeight();
            }

            return totalWeight;
        }

        public abstract bool Attach( GameObject obj );
        public abstract bool Detach( GameObject obj );
    }
}

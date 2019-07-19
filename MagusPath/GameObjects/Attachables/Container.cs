using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaywardEngine;

namespace MagusPath
{
    public class Container : Attachable
    {
        public Vector3 innerDimensions; // XXX: Reduction in dimensions should affect attached objects (expulse, reduce?)
        public float innerVolume {
            get {
                return innerDimensions.x * innerDimensions.y * innerDimensions.z;
            }
        }
        public float containedVolume {
            get {
                float totalVolume = 0f;
                foreach( GameObject obj in attached ) {
                    totalVolume += obj.volume;
                }
                return totalVolume;
            }
        }

        List<Exit> exits;

        public Container( string name, Vector3 innerDimensions)
            :base(name)
        {
            this.innerDimensions = innerDimensions;
            dimensions.x = ( innerDimensions.x > dimensions.x ? innerDimensions.x : dimensions.x );
            dimensions.y = ( innerDimensions.y > dimensions.y ? innerDimensions.y : dimensions.y );
            dimensions.z = ( innerDimensions.z > dimensions.z ? innerDimensions.z : dimensions.z );

            exits = new List<Exit>();
        }

        public void AddExit( Exit exit )
        {
            exits.Add(exit);
        }

        public override bool Attach( GameObject obj )
        {
            if( !CheckDimensions(obj) ) { return false; }
            if( !CheckVolume(obj) ) { return false; }

            attached.Add(obj);
            obj.OnAttach(this);

            return true;
        }
        public bool CheckDimensions( GameObject obj )
        {

            return true;
        }
        public bool CheckVolume( GameObject obj )
        {
            if( obj.volume + containedVolume > innerVolume ) {
                return false;
            }

            return true;
        }

        public override bool Detach( GameObject obj )
        {

            return true;
        }

        public override string Describe( Page page, DescribeLevel level, int indent = 0 )
        {
            string description = base.Describe(page, level, indent);

            switch( level )
            {
                case DescribeLevel.data:
                    if( exits.Count > 0 ) {
                        description += $"{Utility.Indent(indent)}Openings:\r";
                        foreach( Exit exit in exits ) {
                            description += $"{Utility.Indent(indent)}{exit.Describe(page, DescribeLevel.shallowData, indent+1)}";
                        }
                        description += "\r\r";
                    }

                    if( attached.Count > 0 ) {
                        description += $"{Utility.Indent(indent)}Contains:\r";
                        foreach( GameObject obj in attached ) {
                            description += $"{Utility.Indent(indent)}{obj.Describe(page, DescribeLevel.shallowData, indent+1)}";
                        }
                        description += "\r\r";
                    }
                    description += "-----------------------------------------------\r\r";
                    break;
            }

            return description;
        }
    }
}

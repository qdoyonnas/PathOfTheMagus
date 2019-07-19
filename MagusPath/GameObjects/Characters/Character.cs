using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaywardEngine;

namespace MagusPath
{
    public class Character: GameObject
    {
        public Body body;

        public Character( string name )
            : base(name)
        {

        }

        public override string Describe( Page page, DescribeLevel level, int indent = 0 )
        {
            string description = base.Describe(page, level, indent);

            switch( level ) {
                case DescribeLevel.data:
                    if( body != null ) {
                        description += $"{Utility.Indent(indent)}Body:\r";
                        description += $"{Utility.Indent(indent)}{body.Describe(page, DescribeLevel.shallowData, indent+1)}";
                    }
                    break;
            }

            return description;
        }
    }
}

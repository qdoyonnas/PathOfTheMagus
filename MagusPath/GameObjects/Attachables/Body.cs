using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaywardEngine;

namespace MagusPath
{
    public class Body: Attachable
    {
        public List<Body> bodies;

        public Body( string name, List<Body> bodies )
            : base(name)
        {
            this.bodies = bodies;
        }

        public override bool Attach( GameObject obj )
        {
            throw new NotImplementedException();
        }

        public override bool Detach( GameObject obj )
        {
            throw new NotImplementedException();
        }

        public override string Describe( Page page, DescribeLevel level, int indent = 0 )
        {
            string description = base.Describe(page, level, indent);

            switch( level ) {
                case DescribeLevel.shallowData:
                    if( bodies.Count > 0 ) {
                        foreach( Body body in bodies ) {
                            description += $"{Utility.Indent(indent)}{body.Describe(page, DescribeLevel.shallowData, indent+1)}";
                        }
                    }
                    break;
            }

            return description;
        }
    }
}

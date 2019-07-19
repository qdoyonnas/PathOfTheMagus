using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaywardEngine;

namespace MagusPath
{
    public class GameObject
    {
        public string name;

        float weight = 0f; // Stones (1:14 pounds, 1:6.35 Kg)
        public Vector3 dimensions = Vector3.zero;
        public float volume {
            get {
                return dimensions.x * dimensions.y * dimensions.z;
            }
        }

        public List<AttachType> canAttachTo;
        public Attachable attachedTo;

        Dictionary<string, string> data;
        List<Attachable> containers;

        public GameObject( string name )
        {
            GameManager.instance.gameObjects.Add(this);

            this.name = name;

            canAttachTo = new List<AttachType>();

            data = new Dictionary<string, string>();
            containers = new List<Attachable>();
        }

        public virtual float GetTotalWeight()
        {
            float totalWeight = weight;

            foreach( Attachable container in containers ) {
                weight += container.GetTotalWeight();
            }

            return weight;
        }
        public virtual void SetWeight( float weight )
        {
            this.weight = weight;
        }

        public virtual void OnAttach( Attachable attachable )
        {
            attachedTo = attachable;
        }

        public virtual string Describe( Page page, DescribeLevel level, int indent = 0 )
        {
            string description = string.Empty;

            switch( level ) {
                case DescribeLevel.data:
                    page.AddControl(new GameObject_data());

                    page.SetText("NameText", name);
                    page.SetText("WhatText", "Object");
                    page.SetText("WeightText", weight.ToString());
                    page.SetText("DimXText", dimensions.x.ToString());
                    page.SetText("DimYText", dimensions.y.ToString());
                    page.SetText("DimZText", dimensions.z.ToString());
                    if( attachedTo != null ) { page.SetText("WhereText", attachedTo.name); }
                    break;
                case DescribeLevel.shallowData:
                    description += $"{Utility.Indent(indent)}{name}\r";
                    if( containers.Count > 0 ) {
                        foreach( Attachable container in containers ) {
                            description += $"{Utility.Indent(indent)}{container.Describe(page, DescribeLevel.shallowData, indent+1)}";
                        }
                    }
                    break;
            }

            return description;

            {
                /*
                    description += $"{Utility.Indent(indent)}Name: {name}\r\r";
                    
                    if( data.Count > 0 ) {
                        foreach( KeyValuePair<string, string> info in data ) {
                            description += $"{Utility.Indent(indent)}{info.Value}\r\r";
                        }
                        description += "-----------------------------------------------\r\r";
                    }
                    if( weight > 0 ) {
                        description += $"{Utility.Indent(indent)}Weight: {GetTotalWeight()} stones \r\r";
                    }

                    if( canAttachTo.Count > 0 ) {
                        description += $"{Utility.Indent(indent)}Can attach by: ";
                        for( int i = 0; i < canAttachTo.Count; i++ ) {
                            if( i == 0 ) {
                                description += $"{canAttachTo[i].ToString()}";
                            } else {
                                description += $", {canAttachTo[i].ToString()}";
                            }
                        }
                        description += "\r\r";
                    }

                    if( containers.Count > 0 ) {
                        description += $"{Utility.Indent(indent)}Carrying:\r";
                        foreach( Attachable container in containers ) {
                            description += $"{Utility.Indent(indent)}{container.Describe(page, DescribeLevel.shallowData, indent+1)}";
                        }
                        description += "\r\r";
                    }
                    description += "-----------------------------------------------\r\r";
             */
            }
        }
    }
}

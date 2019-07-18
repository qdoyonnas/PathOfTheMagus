using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagusPath
{
    public enum AttachType {

    }

    public class GameObject
    {
        public string name;

        public Dictionary<string, AttachType[]> contents;

        public GameObject( string name )
        {
            GameManager.instance.gameObjects.Add(this);

            this.name = name;
        }
    }
}

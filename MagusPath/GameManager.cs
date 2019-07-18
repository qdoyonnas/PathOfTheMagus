using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagusPath
{
    public class GameManager
    {
        private static GameManager _instance;
        public static GameManager instance {
            get {
                if( _instance == null ) {
                    _instance = new GameManager();
                }

                return _instance;
            }
        }

        public List<GameObject> gameObjects;

        private GameManager()
        {
            gameObjects = new List<GameObject>();
        }
    }
}

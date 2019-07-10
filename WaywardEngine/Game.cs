using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaywardEngine
{
    public abstract class Game
    {
        public Random random;
        public WaywardForm mainForm;

        public bool isRunning = false;

        public delegate void UpdateDelegate();
        public event UpdateDelegate DoUpdate;

        public void Update()
        {
            if( DoUpdate != null ) {
                DoUpdate();
            }
        }
    }
}

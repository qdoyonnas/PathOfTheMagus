using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WaywardEngine;

namespace MagusPath
{
    static class Program
    {
        public static MagusGame game;
        
        static Thread gameThread;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            game = new MagusGame();

            game.isRunning = true;
            gameThread = new Thread( new ThreadStart(() => {
                while( game.isRunning ) {
                    game.Update();

                    Thread.Sleep(0);
                }

                Application.Exit();
            }) );
            gameThread.Start();

            Application.Run(game.mainForm);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaywardEngine;

namespace MagusPath
{
    class MagusGame : Game
    {
        public GameObject playerCharacter;

        public MagusGame()
        {
            random = new Random();
            mainForm = new WaywardForm(this);

            new GameObject("Room 1");
            new GameObject("Room 2");
            playerCharacter = new GameObject("You");

            Page inputPage = new Page(mainForm, PageType.Input);
        }
    }
}
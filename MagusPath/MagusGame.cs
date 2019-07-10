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

            playerCharacter = new GameObject("You");
            Page playerPage = new Page(mainForm, PageType.Descriptive);
            playerPage.SetTitle(playerCharacter.name);
        }
    }
}

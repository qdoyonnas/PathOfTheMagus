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
        public MagusGame()
        {
            random = new Random();
            mainForm = new WaywardForm(this);

            GameManager gm = GameManager.instance;

            Container room1 = new Container("Old Room", new Vector3(20f, 20f, 20f));
            room1.SetWeight(100f);

            Container room2 = new Container("Dark Room", new Vector3(20f, 20f, 20f));
            room2.SetWeight(100f);

            new LinkedExit("Door", room1, room2);

            Container field = new Container("Field", new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity));

            field.Attach(room1);
            field.Attach(room2);

            new OpenExit("Gate", room2);

            gm.playerCharacter = new Humanoid("You");
            gm.playerCharacter.SetWeight(9.8f);
            gm.playerCharacter.dimensions = new Vector3(2f, 6f, 1f);

            room1.Attach(gm.playerCharacter);

            Page describePage = new Page(mainForm, PageType.Descriptive);
            describePage.SetText( "TitleText", room1.name, false );
            room1.Describe(describePage, DescribeLevel.data);
        }
    }
}
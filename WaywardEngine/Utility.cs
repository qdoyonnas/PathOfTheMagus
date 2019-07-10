using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaywardEngine
{
    public static class Utility
    {
        public static List<Control> GetAllControlsRecurs(List<Control> list, Control parent)
        {
            if (parent == null) {
                return list;
            } else {
                list.Add(parent);
            }

            foreach (Control child in parent.Controls) {
                GetAllControlsRecurs(list, child);
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagusPath
{
    public enum AttachType {
        Space,
        Hang,
        Grasp,
        Loop
    }

    public enum DescribeLevel {
        data,
        shallowData,
        brief,
        wordy
    }

    public static class Utility
    {
        public static string RepeatChar(char c, int times)
        {
            return String.Concat(Enumerable.Repeat(c, times));
        }

        public static string Indent(int indent)
        {
            return RepeatChar(' ', indent);
        }
    }

    public class Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3()
        {
            x = 0f;
            y = 0f;
            z = 0f;
        }
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 zero {
            get {
                return new Vector3();
            }
        }
    }
}

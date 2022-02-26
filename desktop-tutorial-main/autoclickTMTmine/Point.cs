using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoclickTMTmine
{
    [Serializable]
    class Point
    {
        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Type { get; set; }
    
        public Point(int IdInput,int TypeInput,int XInput, int YInput)
        {
            this.ID = IdInput;
            this.X = XInput;
            this.Y = YInput;
            this.Type = TypeInput;
        }
    }
}

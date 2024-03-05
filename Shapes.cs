using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_Corp
{
    public abstract class Shapes
    {
        private string TypeID {  get;  }
        public Point Center { get; set; }
        public Color Color { get; set; }
    }
}

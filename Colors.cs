using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_Corp
{
    public class Colors
    {
        public Dictionary<string, Color> colors = new()
        {
            { "Red", Color.Red },
            { "Blue", Color.Blue },
            { "Green", Color.Green },
            { "Yellow", Color.Yellow },
            { "Orange", Color.Orange },
            { "Black", Color.Black },
            { "Purple", Color.Purple }
        };
    }
}

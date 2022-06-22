using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BGE_GlobalEngineResorces;

namespace BGE_ASCII_Render
{
    public class Text_type
    {
        public ConsoleColor ColorP = ConsoleColor.White;
        public ConsoleColor BackGroundColorP = ConsoleColor.Black;

        public Text_type()
        {

        }
        public Text_type(ConsoleColor TextColor)
        {
            ColorP = TextColor;
        }
        public Text_type(ConsoleColor TextColor, ConsoleColor BackGroundColor)
        {
            ColorP = TextColor;
            BackGroundColorP = BackGroundColor;
        }
        public ConsoleColor ReturnTextColor()
        {
            return ColorP;
        }
        public ConsoleColor ReturnBackGroundColor()
        {
            return BackGroundColorP;
        }
        public ConsoleColor[] ReturnColors()
        {
            ConsoleColor[] colors = { ColorP, BackGroundColorP };
            return colors;
        }
    }
}

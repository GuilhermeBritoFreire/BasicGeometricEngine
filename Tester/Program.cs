using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=#\\

using BGE_ASCII_Render;
using BGE_GlobalEngineResorces;
using BGE_GlobalEngineResorces.vectors;

//#=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=#\\

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test test = new test();
        }
    }
//#=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=#\\
    internal class test : ASCII_text_resorces
    {
        public test()
        {
            OnGameloopedPosRender += Pos;
            OnGameloopedPreRender += Pre;

            while (true)
            {

            }
        }
        private void Pos(EventArgs e, object sender)
        {
            Console.WriteLine("  Life: 100%, Stamina: 100%");
            Console.WriteLine("         Dialogue:");
        }
        private void Pre(EventArgs e, object sender)
        {
            Console.WriteLine("     My game is amazing");
        }
    }
}

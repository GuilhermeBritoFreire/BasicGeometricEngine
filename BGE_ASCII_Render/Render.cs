using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using BGE_GlobalEngineResorces.vectors;

namespace BGE_ASCII_Render
{
    public class Render
    {
        private List<List<char>> textos_para_render = new List<List<char>>();

        public Text_type text_type = new Text_type();
        private Space2d plano = new Space2d(new Vector2d(31, 15));

        public Render()
        {
            List<char> textos = new List<char>();
            for (int i = 0; i < plano.Size.x; i++)
            {
                textos.Add('#');
            }
            for (int i = 0; i < plano.Size.y; i++)
            {
                textos_para_render.Add(textos);
            }
        }
        public void Render_Text()
        {
            //show the image in ASCCII
            for (int i = 0; i < textos_para_render.Count; i++)
            {
                for (int o = 0; o < textos_para_render[i].Count; o++)
                {
                    Console.Write(textos_para_render[i][o]);
                }
                Console.WriteLine();
            }
        }
    }
}

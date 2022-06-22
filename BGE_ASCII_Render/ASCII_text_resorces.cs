using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using BGE_GlobalEngineResorces;

namespace BGE_ASCII_Render
{
    public class ASCII_text_resorces
    {
        //pre render delegate
        public delegate void gameloopPreRender(EventArgs e, object sender);
        public event gameloopPreRender OnGameloopedPreRender;

        gameloopPreRender GamePreloop;

        //pos render delegate
        public delegate void gameloopPosRender(EventArgs e, object sender);
        public event gameloopPosRender OnGameloopedPosRender;

        gameloopPosRender GamePosloop;

        //renderizador padrão
        public Render text_render = new Render();

        private void GameLoop()
        {
            //gameloop, privado obviamente
            while (true)
            {
                //pos loop call
                GamePosloop.Invoke(EventArgs.Empty, this);

                Thread.Sleep(200);
                Console.Clear();

                //pre loop call
                GamePreloop.Invoke(EventArgs.Empty, this);

                text_render.Render_Text();
            }
        }
        private void PosRender(EventArgs e, object sender)
        {
            OnGameloopedPosRender?.Invoke(EventArgs.Empty, this);
        }
        private void PreRender(EventArgs e, object sender)
        {
            OnGameloopedPreRender?.Invoke(EventArgs.Empty, this);
        }

        public ASCII_text_resorces()
        {
            GamePosloop = PosRender;
            GamePreloop = PreRender;

            //tratamento de erro da Engine
            try
            {


                //chama o game loop, em uma nova Thread para não travar o resto
                Thread RenderT = new Thread(GameLoop);
                RenderT.Start();

                Console.Title = "Game";
            }
            catch (Exception errorExeption) //caso der erro
            {
                Console.WriteLine("An error occurred\n" +
                    "type (yes) for more information,\n" +
                    "if you type something else the program will close");
                string errorC = Console.ReadLine();
                if (errorC == "yes")
                {
                    Console.WriteLine("error: " + errorExeption);
                }
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}

// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    
    public class Game
    {
        
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Star Dream Simulation");
            Window.ClearBackground(Color.Black);

            void DrawStar(float x, float y)
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(Color.Yellow);
                //Draw.Triangle



            }

        }

        
        public void Update()
        {

        }
    }

}

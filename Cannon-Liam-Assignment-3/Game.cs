// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    
    public class Game
    {
        Soul soul = new Soul();

        public void Setup()
        {
            Window.SetSize(600, 600);
            Window.SetTitle("Soul Box Simulation");
            Window.ClearBackground(Color.Black);
            



        }

        
        public void Update()
        {
            Window.ClearBackground(Color.Black);
            soul.Update();



        }
    }

}

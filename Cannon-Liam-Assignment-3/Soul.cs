using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Soul
    {
        float soulX = 300;
        float soulY = 300;

        float inputX = 0;
        float inputY = 0;










        public void Update()
        {
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.Red);
            Draw.Circle(soulX - 20, soulY, 20);
            Draw.Circle(soulX + 10, soulY, 20);
            Draw.Triangle(soulX + 30, soulY + 5, soulX - 40, soulY + 5, soulX - 5, soulY + 55);

            if (Input.IsKeyboardKeyDown(KeyboardKey.W))
            {
                inputY -= 1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                inputY += 1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                inputX -= 1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                inputX += 1;
            }

            soulX += inputX * 10 * Time.DeltaTime;
            soulY += inputY * 10 * Time.DeltaTime;

        }

    }
}

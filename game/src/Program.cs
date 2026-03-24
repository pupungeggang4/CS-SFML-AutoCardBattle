using System;
using SFML.Window;
using SFML.Graphics;
using SFML.System;

namespace AutoCardBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode((800, 600)), "SFML.Net Example");
            window.Closed += (sender, e) => window.Close();

            CircleShape shape = new CircleShape(50.0f);
            shape.FillColor = Color.Green;
            shape.Position = new Vector2f(0, 275);

            Clock clock = new Clock();

            // 3. Game Loop
            while (window.IsOpen)
            {
                // Process Events
                window.DispatchEvents();

                // Draw
                window.Clear(Color.Black);
                window.Draw(shape);
                window.Display();
            }
        }
    }
}
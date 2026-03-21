using System;
using SFML.Window;
using SFML.Graphics;
using SFML.System;

namespace SfmlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1);

            // 1. Create the Window
            RenderWindow window = new RenderWindow(new VideoMode((800, 600)), "SFML.Net Example");
            window.Closed += (sender, e) => window.Close();

            // 2. Create a Shape
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
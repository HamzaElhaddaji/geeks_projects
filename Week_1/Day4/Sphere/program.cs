using System;
using System.Drawing;

class Program
{             // I try to add bonus but the graphics class doesn't exist in my version i put the code anyway!!!!
        static void Main(string[] args)
    {
        Sphere s1 = new Sphere(50);
        Sphere s2 = new Sphere(30);
        Sphere s3 = new Sphere(15);

        Bitmap canvas = new Bitmap(600, 400);
        Graphics g = Graphics.FromImage(canvas);
        g.Clear(Color.White);


        s1.Draw(g, 50, 100, 1f, Color.LightGreen, Color.DarkGreen);
        s2.Draw(g, 200, 150, 1f, Color.LightCoral, Color.DarkRed);
        s3.Draw(g, 350, 180, 1f, Color.LightSkyBlue, Color.DarkBlue);


        canvas.Save("spheres.png");

        g.Dispose();
        canvas.Dispose();

        Console.WriteLine("Spheres drawn! Check the file: spheres.png");
    }
}

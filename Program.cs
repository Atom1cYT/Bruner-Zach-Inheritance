    using System;

namespace Bruner_Zach_Inheritance
{
    class Program
    {
        static void Main(string[] args)
            // Puts Zombcube and CSGO into commmand script
        {
            FPS myFPS = new FPS("E", "ZombCube");
        
            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            FPS csgo = new FPS("M", "CS:GO");
            Console.WriteLine(csgo.Describe());
            csgo.PlayGame();
        }
    }
}

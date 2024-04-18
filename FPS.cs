using System;
using System.Collections.Generic;
using System.Text;

namespace Bruner_Zach_Inheritance
{
    class FPS : Game
    {
        // Sets the title and object creation
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }
        // Tells the Game and whats rated.
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }
    }
}

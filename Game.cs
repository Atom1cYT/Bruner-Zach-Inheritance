using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Bruner_Zach_Inheritance
{
    abstract class Game
    {
        public string Esrb { get; set; }

        public string Title { get; set; }

        public Game(string esrbParam, string titleParam)
            {
               Esrb = esrbParam;
               Title = titleParam;
            }

         /// <summary>
         ///  Ptints the title and says it is starting.
         /// </summary>
        
        
        public void PlayGame()
          {
           Console.WriteLine($"{Title} is Starting!");
          }

        public abstract string Describe();
    }
}

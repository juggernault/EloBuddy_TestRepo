using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;

namespace EloBuddy.TestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.OnStart += a =>
            {
                Game.PrintChat("Thank you spudgy for developing our loader!");
            };
        }
    }
}

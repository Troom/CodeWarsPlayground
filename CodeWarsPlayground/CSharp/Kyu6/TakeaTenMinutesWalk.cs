using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal class TakeaTenMinutesWalk
    {

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;


            int axisY = 0;
            int axisX = 0;
            foreach (var item in walk)
            {
                switch (item)
                {
                    case"n":
                        axisY++;
                        break;
                    case "e":
                        axisX++;
                        break;
                    case "s":
                        axisY--;
                        break;
                    case "w":
                        axisX--;
                        break;
                    default:
                        break;
                }
            }

            if (axisX == 0 && axisY == 0)
                return true;
            else
                return false;

        }
    }
}

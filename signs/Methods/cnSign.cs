using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Signs
{
    public class CNSigns
    {
        public string cnSignReturn(int year)
        {
            string zodiac = "";

            switch ((year- 4) % 12)
            {
                case 0:
                    zodiac = "Rat";
                    break;
                case 1:
                    zodiac = "Ox";
                    break;
                case 2:
                    zodiac = "Tiger";
                    break;
                case 3:
                    zodiac = "Rabbit";
                    break;
                case 4:
                    zodiac = "Dragon";
                    break;
                case 5:
                    zodiac = "Snake";
                    break;
                case 6:
                    zodiac = "Horse";
                    break;
                case 7:
                    zodiac = "Goat";
                    break;
                case 8:
                    zodiac = "Monkey";
                    break;
                case 9:
                    zodiac = "Rooster";
                    break;
                case 10:
                    zodiac = "Dog";
                    break;
                case 11:
                    zodiac = "Pig";
                    break;
                default:
                    Console.WriteLine("You have sign buddy!");
                    break;
            }

            return zodiac;
        }//end class
    }
}
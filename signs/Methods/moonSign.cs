using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Signs
{
    public class MoonSigns
    {
        public string moonSignReturn(int day, int month)
        {
            string aSign = "";
            //Birthday birthday = new Birthday();
            
            switch (month)
          {
                case 1:
                    if ( day > 20)
                    {
                        aSign = "Aquarius";
                    }
                    else
                    {
                        aSign = "Capricorn";
                    }
                    break;
                case 2:
                    if (day > 18)
                    {
                        aSign = "Pisces";
                    }
                    else
                    {
                        aSign = "Aquarius";
                    }
                    break;
                case 3:
                    if (day > 20)
                    {
                        aSign = "Aries";
                    }
                    else
                    {
                        aSign = "Pisces";
                    }
                    break;
                case 4:
                    if (day > 19)
                    {
                        aSign = "Taurus";
                    }
                    else
                    {
                        aSign = "Aries";
                    }
                    break;
                case 5:
                    if (day > 20)
                    {
                        aSign = "Gemini";
                    }
                    else
                    {
                        aSign = "Taurus";
                    }
                    break;
                case 6:
                    if (day > 20)
                    {
                        aSign = "Cancer";
                    }
                    else
                    {
                        aSign = "Gemini";
                    }
                    break;
                case 7:
                    if (day > 22)
                    {
                        aSign = "Leo";
                    }
                    else
                    {
                        aSign = "Cancer";
                    }
                    break;
                case 8:
                    if (day > 22)
                    {
                        aSign = "Virgo";
                    }
                    else
                    {
                        aSign = "Leo";
                    }
                    break;
                case 9:
                    if (day > 22)
                    {
                        aSign = "Libra";
                    }
                    else
                    {
                        aSign = "Virgo";
                    }
                    break;
                case 10:
                    if (day > 22)
                    {
                        aSign = "Scorpio";
                    }
                    else
                    {
                        aSign = "Libra";
                    }
                    break;
                case 11:
                    if (day > 21)
                    {
                        aSign = "Sagittarius";
                    }
                    else
                    {
                        aSign = "Scorpio";
                    }
                    break;
                case 12:
                    if (day > 20)
                    {
                        aSign = "Capricorn";
                    }
                    else
                    {
                        aSign = "Sagittarius";
                    }
                    break;
                default:
                    Console.WriteLine("INVALID DATE!!");
                    break;
               

             }//end switch
            return aSign;
            
    }//end class
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Signs
{
    public class MoonSigns
    {
        public void moonSignReturn(int month)
        {
            string aSign = "";
            //Birthday birthday = new Birthday();
            
            switch (month)
          {
                case 1:
                    if ( month > 20)
                    {
                        aSign = "Aquarius";
                    }
                    else
                    {
                        aSign = "Capricorn";
                    }
                    break;
                case 2:
                    if (month > 18)
                    {
                        aSign = "Pisces";
                    }
                    else
                    {
                        aSign = "Aquarius";
                    }
                    break;
                case 3:
                    if (month > 20)
                    {
                        aSign = "Aries";
                    }
                    else
                    {
                        aSign = "Pisces";
                    }
                    break;
                case 4:
                    if (month > 19)
                    {
                        aSign = "Taurus";
                    }
                    else
                    {
                        aSign = "Aries";
                    }
                    break;
                case 5:
                    if (month > 20)
                    {
                        aSign = "Gemini";
                    }
                    else
                    {
                        aSign = "Taurus";
                    }
                    break;
                case 6:
                    if (month > 20)
                    {
                        aSign = "Cancer";
                    }
                    else
                    {
                        aSign = "Gemini";
                    }
                    break;
                case 7:
                    if (month > 22)
                    {
                        aSign = "Leo";
                    }
                    else
                    {
                        aSign = "Cancer";
                    }
                    break;
                case 8:
                    if (month > 22)
                    {
                        aSign = "Virgo";
                    }
                    else
                    {
                        aSign = "Leo";
                    }
                    break;
                case 9:
                    if (month > 22)
                    {
                        aSign = "Libra";
                    }
                    else
                    {
                        aSign = "Virgo";
                    }
                    break;
                case 10:
                    if (month > 22)
                    {
                        aSign = "Scorpio";
                    }
                    else
                    {
                        aSign = "Libra";
                    }
                    break;
                case 11:
                    if (month > 21)
                    {
                        aSign = "Sagittarius";
                    }
                    else
                    {
                        aSign = "Scorpio";
                    }
                    break;
                case 12:
                    if (month > 20)
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

            Console.WriteLine("Your Astrological Sign is " + aSign);
    }//end class
    }
}
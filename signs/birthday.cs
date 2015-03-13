using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Signs
{
    public class Birthday
    {
        public int dobMonth;
        public int dobDay;
        public int dobYear;

        static void Main(string[] args)
        {
            
            Birthday birthday = new Birthday();

            DateTime today = DateTime.Today; 

            Console.Write("What year were you born in? (ex. 2000) ");
            birthday.dobYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("What month were you born in? (ex. 11) ");
            birthday.dobMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("What day were you born on? (ex. 11) ");
            birthday.dobDay = Convert.ToInt32(Console.ReadLine());

            DateTime birthdayDate = new DateTime(birthday.dobYear, birthday.dobMonth, birthday.dobDay);
            String.Format("{0:M/d/yyy}", birthday);
            Console.WriteLine("Your birthday is on: " + birthday);

            //check to see if birthday is today
            if (today == birthdayDate)
            {
                Console.WriteLine("HAPPY BIRTHDAY!!!! ");
            }

            //find age of user (years)
            TimeSpan actualAge = today - birthdayDate;
            int age = Convert.ToInt32(actualAge.TotalDays) / 365;

            //Check if age is possible, not born yet or > 120 ,output if error
            if (age <= 0)
            {
                Console.WriteLine("You are not born yet. Thank you for trying. :)");
            }else if (age > 120)
            {
                Console.WriteLine("Noone has ever lived this long. Did you make a mistake?");    
            }


            //output age
            Console.WriteLine("You are " + age + " years old!");
            
            
            //output users Astrological signs , western and chinese
            MoonSigns moonsigns = new MoonSigns();
            moonsigns.moonSignReturn(birthday.dobMonth);
          
            
           // Console.WriteLine("Your Astrological Sign is " + aSign);

            string zodiac = "";

            switch ((birthday.dobYear - 4) % 12) 
            {
                case  0: 
                    zodiac = "Rat";       
                    break;
                case  1: 
                    zodiac = "Ox";            
                    break;
                case  2: 
                    zodiac = "Tiger";     
                    break;
                case  3: 
                    zodiac = "Rabbit";    
                    break;
                case  4: 
                    zodiac = "Dragon";    
                    break;
                case  5: 
                    zodiac = "Snake";     
                    break;
                case  6: 
                    zodiac = "Horse";     
                    break;
                case  7: 
                    zodiac = "Goat";  
                    break;
                case  8: 
                    zodiac = "Monkey";    
                    break;
                case  9: 
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

            Console.WriteLine("Your Chinese Sign is " + zodiac);
        }
    }
}

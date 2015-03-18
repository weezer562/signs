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
            CNSigns cnsigns = new CNSigns();
            cnsigns.cnSignReturn(birthday.dobYear);
           
        }
    }
}

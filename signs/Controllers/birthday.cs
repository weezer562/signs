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

            birthday.getBirthday(ref birthday.dobMonth, ref birthday.dobDay, ref birthday.dobYear);

            DateTime birthdayDate = new DateTime(birthday.dobYear, birthday.dobMonth, birthday.dobDay);
            String.Format("{0:M/d/yyy}", birthday);
            //Console.WriteLine("Your birthday is on: " + birthday);

            //find age of user (years)
            TimeSpan actualAge = today - birthdayDate;
            int age = Convert.ToInt32(actualAge.TotalDays) / 365;

            birthday.checkAgeRange(age);
            birthday.checkIfBirthday(today, birthdayDate);
           

            //output age
            Console.WriteLine("You are " + age + " years old!");
            
            
            //output users Astrological signs , western and chinese
            MoonSigns moonsigns = new MoonSigns();
            moonsigns.moonSignReturn(birthday.dobMonth);
          
            
           // Console.WriteLine("Your Astrological Sign is " + aSign);
            CNSigns cnsigns = new CNSigns();
            cnsigns.cnSignReturn(birthday.dobYear);
           
        }

        private void getBirthday(ref int month, ref int day, ref int year)
        {
            Console.Write("What year were you born in? (ex. 2000) ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("What month were you born in? (ex. 11) ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("What day were you born on? (ex. 11) ");
            day = Convert.ToInt32(Console.ReadLine());

        }

        private void checkAgeRange(int age)
        {
            if (age <= 0)
            {
                Console.WriteLine("You are not born yet. Thank you for trying. :)");
                return;
            }
            else if (age > 120)
            {
                Console.WriteLine("Noone has ever lived this long. Did you make a mistake?");
                return;
            }
        }

        private void checkIfBirthday(DateTime today, DateTime birthdayDate)
        {
             if (today == birthdayDate)
            {
                Console.WriteLine("HAPPY BIRTHDAY!!!! ");
            }
        }
    }
}

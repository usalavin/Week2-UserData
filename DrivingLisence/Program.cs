using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaasta
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasuataja on vanem, kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhiluba saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis 
            //"Palju õnne! Nüüd sa saad ka juhiluba taotleda";

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2021 - YearOfBirth;

            if (userAge > 18) 
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada.");
            }

            else if (userAge < 18) 
            {
                Console.WriteLine("Oled liiga noor, et juhiluba saada.");
            }

            else 
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad ka juhiluba taotleda.");
            }

            Console.WriteLine("Ilusat päeva!");
        }

    }
}

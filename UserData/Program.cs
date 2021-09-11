using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsub kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - YearOfBirth;
            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana");

 

        }
    }
}

using System;

namespace TheNumberOfNailsAndBlowsOnThem
{
    class Program
    {
        static void Main()
        {
            int needNails;
            int needBlowOnTheNeils;

            while (true)
            {
                Console.WriteLine("Введите нужное количество гвоздей от 1 до 10");
                needNails = Convert.ToInt32(Console.ReadLine());

                if (needNails >= 1 && 10 >= needNails)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Вы ввели некорректное число, попробуйте еще раз!");
                }
            } 
            

            while (true)
            {
                Console.WriteLine("введите нужное колличество ударов по гвоздю от 1 до 5");
                needBlowOnTheNeils = Convert.ToInt32(Console.ReadLine());

                if (1 <= needBlowOnTheNeils && needBlowOnTheNeils <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число, попробуйте еще раз!");
                }
            }

            for(int hammeredNails = 0; hammeredNails < needNails; hammeredNails++) 
            {
                for(int blowsDelivered = 0; blowsDelivered < needBlowOnTheNeils; blowsDelivered++) 
                { 

                }
            }

            Console.WriteLine("Количество гвоздей: {0}, количество ударов: {1}", needNails, needBlowOnTheNeils);
           
        }
    }
}

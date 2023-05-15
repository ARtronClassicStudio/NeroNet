using System;

namespace ConsoleApp3
{
    internal class Program
    {

        static void Main()
        {
            decimal km = 100;
            decimal miles = 62.1371m;
            NeroNet neiron = new NeroNet();

            neiron.Train(km,miles);

            Console.WriteLine($"Итерация: {neiron.Iteration}\tОшибка:\t{neiron.LastError}");

            if (neiron.IsDone)
            {
                Console.WriteLine("Обучение завершено!");
            }


            Console.WriteLine($"{neiron.ProcessInputData(100)} миль в {100} км");
            Console.WriteLine($"{neiron.ProcessInputData(541)} миль в {541} км");
            Console.WriteLine($"{neiron.RestoreInputData(10)} км в {10} милях");
            Console.ReadLine();

           // neiron.SaveModel("Model.json");
        }
    }
}

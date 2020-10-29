using System;

namespace Лаораторная__1_бкит
{
    class Program
    {
        static void CommandLineArgs(string[] args)
        {
            /*
            Необходимо установить параметры командной строки (несколько слов через пробел)
            В пункте меню "Project", "название проекта Properties"
            вкладка "Debug", поле ввода"Command Line Arguments"
            */
            Console.WriteLine("\nВывод параметров командной строки 1:"); for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Параметр [{0}] = {1}", i, args[i]);
            }
        }
        static double ReadDouble(string message)
        {
            string resultString; double resultDouble; bool flag;

            do
            {
                Console.Write(message); resultString = Console.ReadLine();

                try
                {
                    resultDouble = double.Parse(resultString);
                    resultDouble = Convert.ToDouble(resultString); flag = true;
                }
                catch
                {
                    resultDouble = 0; 
                    flag = false;
                }
                if (!flag)
                {
                    Console.WriteLine("Необходимо ввести вещественное число");
                }
            }
            while (!flag);

            return resultDouble;
        }

        static void Main(string[] args)
            {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Компаниец Андрей Александрович ИУ5-31Б");
            int i;
            double[] xxxx = new double[4];
            double[] arr=new double[3];
            if (args.Length == 3)
              {
                CommandLineArgs(args);
                for (i = 0; i < 3; i++)
                {
                    arr[i] = Convert.ToDouble(args[i]);
                }
              }
            else
              {
                string str1="";
                for (int j=0; j<3; j++)
                {
                    Console.WriteLine("Необходимо ввести " + (j+1) +"- й аргумент");
                    arr[j]=ReadDouble(str1);
                    Console.WriteLine("Вы ввели число " + arr[j]);
                }
              }
            double decremenant;
            decremenant = arr[1] * arr[1] - 4 * arr[0] * arr[2];
            if (decremenant < 0) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет решений");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                xxxx[0] = Math.Sqrt(-arr[1] + Math.Sqrt(decremenant)) / (2 * arr[0]);
                xxxx[1] = -Math.Sqrt(-arr[1] + Math.Sqrt(decremenant)) / (2 * arr[0]);
                xxxx[2] = Math.Sqrt(-arr[1] - Math.Sqrt(decremenant)) / (2 * arr[0]);
                xxxx[3] = -Math.Sqrt(-arr[1] - Math.Sqrt(decremenant)) / (2 * arr[0]);
                if (xxxx[0] == xxxx[2])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения:" + "\n x1= " + xxxx[0].ToString() + "\n x2= " + xxxx[1].ToString());
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения:" + "\n x1= " + xxxx[0].ToString() + "\n x2= " + xxxx[1].ToString()+ "\n x3= " + xxxx[2].ToString() + "\n x4= " + xxxx[3].ToString());
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
          }
        }
    }

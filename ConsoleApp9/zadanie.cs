using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class zadanie
    {
        public int Nomer1()
        {
            Console.WriteLine("Задание первое:");
            Console.WriteLine("Введите 3-х значное число");
            int chislo = Convert.ToInt32(Console.ReadLine());

            int x = chislo / 100; //первая цифра
            Console.WriteLine(x);
            int z = chislo % 10; //последняя цифра
            Console.WriteLine(z);
            int y = chislo / 10 % 10; //средняя
            Console.WriteLine(y);
            int[] chisla = new int[3];
            chisla[0] = x;
            chisla[1] = y;
            chisla[2] = z;
            int temp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (chisla[i] < chisla[j])
                    {
                        temp = chisla[i];
                        chisla[i] = chisla[j];
                        chisla[j] = temp;
                    }
                }
            }
            double k = Math.Pow(chisla[0] * 100 + chisla[1] * 10 + chisla[2], 2);
            return (int)k;

        }

        public int Nomer2()
        {
            Console.WriteLine("Задание второе:");
            Console.WriteLine("Введите 4-х значное число");
            int x = Convert.ToInt32(Console.ReadLine());
            int k = x / 100 % 10 * 10 + x / 10 % 10;
            return k;
        }

        public int Nomer3()
        {
            Console.WriteLine("Задание третье:");
            Console.WriteLine("Введите 3 любых числа");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int[] chisla = { x,y,z,};
            int temp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (chisla[i] < chisla[j])
                    {
                        temp = chisla[i];
                        chisla[i] = chisla[j];
                        chisla[j] = temp;
                    }
                }
            }
            int k = chisla[1];
            Console.WriteLine("Среднее из них ");
            return k;
        }
        public int Nomer4()
        {
            Console.WriteLine("Задание четвертое:");
            Console.WriteLine("Введите любое натуральное число");
            int x = Convert.ToInt32(Console.ReadLine());
            List<int> chisla = new List<int>();
            int y = x / 10;
            int k = 0;
            while (y > 0)
            {
                y = x % 10;
                chisla.Add(y);
                x = x / 10;
                k++;
            }
            List<int> temp = new List<int>();
            var range = chisla.GetRange(1,k-1);
            int[] chislaarr = new int[k];
            chisla.Reverse();
            chisla.CopyTo(0, chislaarr, 0, k);
            for (int i = 0; i < k; i++)
            {
                if (chislaarr[i] % 2 != 0 && chislaarr[i] !=0 )
                {
                    temp.Add(chislaarr[i]);
                }
            }
            int[] konec = new int[temp.Count];
            double l = 0;
            for (int j = 0; j < temp.Count; j++)
            {
                l = l + temp[j]*Math.Pow(10, temp.Count-j);
            }
            l = l / 10;
            return (int)l;
        }

        public int Nomer5()
        {
            Console.WriteLine("Задание пятое:");
            Console.WriteLine("Введите любое натуральное число(если 5 цифр, то средняя уберется)");
            int N = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int y = N;
            while (N != 0)
            {
                N = N / 10;
                k++;
            }
            if (k != 5) 
            {
                int M = y;
                return M;
            }
            else
            {
                int M = y / 1000 * 100 + y % 100;
                return M;
            }

        }
        public int Nomer6()
        {
            Console.WriteLine("Задание шестое:");
            Console.WriteLine("Введите число элементов массива");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            int k = 0;
            while (arr[arr.Length-1] == 0)
            {
                Console.WriteLine($"Введите {k}-ый элемент массива");
                arr[k] = Convert.ToInt32(Console.ReadLine());
                k++;
            }
            int count = 0;
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine("Количество элементов массива, которые больше двух своих соседей:");
            return count;
        }
    }
}

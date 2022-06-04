using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace alterSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь

            string inputpath = "D:\\SolutionsForSpaceApp\\2003\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2003\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fs.Close();

            int amount;
            using (var reader =  new StreamReader(inputpath))
            {
                amount = Convert.ToInt32(reader.ReadLine());
            }

            string secondLine;
            using (var reader = new StreamReader(inputpath))
            {
                reader.ReadLine(); //пропуск 1 строки
                secondLine = reader.ReadLine();  // записываем в переменную
            }
            //запись из строки в массив строк с разделением
            string[] secondLineToInt = secondLine.Split(' ');

            //массив для действий над числами
            int[] A;
            A = new int[amount];

            //запись в интовый массив из массива строк
            int count = 0;
            foreach (var s in secondLineToInt)
            {
                A[count] = Convert.ToInt32(s);
                count++;
            }
            int sum = 0;
            for (int i = 0; i < amount; i++)
            {
                if(i%2 !=0)
                {
                    sum = sum - A[i];
                }
                else
                {
                    sum = sum + A[i];
                }

            }

            Console.WriteLine(sum);
            Console.ReadKey();


        }
    }
}

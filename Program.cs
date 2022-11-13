//             string str = Console.ReadLine();
//             if (str.Length < 5)
//                 Console.WriteLine("В строке меньше 5 символов");
//             else if (str.Length >= 5 && str.Length <= 15)
//                 Console.WriteLine(str.Length);
//             else if (str.Length > 15)
//                 Console.WriteLine("В строке больше 15 символов");
//             Console.ReadLine();

// //Проба подсчёта количества символов в отдельной строке

// String[] variable_name; //массив строк без указания размера


// Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray(); 
//считывает из консоли строку, разделяет её по пробелам, для каждой подстроки вызывает int.Parse и приводит полученную коллекцию к типу массива.

using System;
namespace Abcd
{
class Program
    {
        static void Main()
        {
            Console.Write("Введите количество строк, которые хотите ввести: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
            string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите строку №{0}:\r\n    ", i + 1);
                strs[i] = Console.ReadLine(); //Заполняем его
            }
            Console.WriteLine("Вы ввели следующие строки:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strs[i]);
            }
            Console.Write("Нажмите [Enter] для выхода...");
            Console.ReadLine();
        }
    }
}
//с форума

// string buf;
//             int n;
//             Console.WriteLine("Введите кол-во элементов массива (n):");
//             buf = Console.ReadLine();
//             n = Convert.ToInt32(buf);
//             int[] a = new int[n];
 
//             for (int x = 0; x < n; x++)
//             {
//                 Console.WriteLine("Введите {0} -ый элемент", (x+1));
//                 buf = Console.ReadLine();
//                 a[x] = Convert.ToInt32(buf);
//             }




// Возвращает число знаков в текущем объекте String.
public int Length { get; }


string str = "abcdefg";
Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);
Console.WriteLine("2) The length of '{0}' is {1}", "xyz", "xyz".Length);

int length = str.Length;
Console.WriteLine("3) The length of '{0}' is {1}", str, length);

// This example displays the following output:
//    1) The length of 'abcdefg' is 7
//    2) The length of 'xyz' is 3
//    3) The length of 'abcdefg' is 7


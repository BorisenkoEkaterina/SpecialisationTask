
//Написать программу которая из имеющегося массива строк формирует массив из строк длина которых меньше, либо равна трём символам

        Console.WriteLine("Введите желаемую строку для обработки: ");
        string originalString = Console.ReadLine();
        string[] enteredArray = originalString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < enteredArray.Length; i++)
            Console.Write(enteredArray[i] + " ");
            Console.WriteLine();

            //Для добавления вариантов разделения с исключением знаков препинания добавил возможность
            // замены кода предыдущей строки разделения только по пробелам:
            // char[] separators = new char[] { ' ', '.', ',', '(', ')', '-', '!', '?', ':' };
            // string[] enteredArray = originalString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < enteredArray.Length; i++)
{
if (enteredArray[i].Length <= 3)
    {
       string sortedString = System.Convert.ToString(enteredArray[i] + " ");
       string[] threeSignArray = sortedString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
       Console.Write(enteredArray[i] + " ");
    }  
}



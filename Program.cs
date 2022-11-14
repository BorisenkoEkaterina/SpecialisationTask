
//Написать программу которая из имеющегося массива строк формирует массив из строк длина которых меньше, либо равна трём символам

string[] ArrayString(string arrayFromString)   // Функция. Создание массива из строки, вводимой пользователем
{
string originalString = Console.ReadLine();
string[] arrayString = originalString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     {
//         for (int i = 0; i < arrayString.Length; i++)
//         Console.Write(arrayString[i] + " ");
//         Console.WriteLine();
// }
return arrayString;
}

void ShowArray(string[] array)                         //функция вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ShowSortedArray(string[] sorted) 
{
string originalString = Console.ReadLine();
string[] threeSignArray = originalString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < threeSignArray.Length; i++)
{
if (threeSignArray[i].Length <= 3)
    {
    Console.Write(threeSignArray[i] + " ");
    }
    Console.WriteLine();
}  
}





Console.WriteLine("Введите желаемую строку для обработки: ");
string[] arrayByUser = ArrayString(Console.ReadLine());

Console.WriteLine("Исходный массив: ");
ShowArray(arrayByUser);

// Console.WriteLine("Вывод отсортированного массива");
// ShowSortedArray(string array);


// for (int i = 0; i < arrayByUser.Length; i++)
// {
// if (arrayByUser[i].Length <= 3)
//     {
//        string sortedString1 = System.Convert.ToString(arrayByUser[i] + " ");
//        string[] threeSignArray = sortedString1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//        Console.Write(threeSignArray[i] + " ");
//        }
//     }  

// string[] sortedString(string sortedString, int N)
// {
// int count = 0;
// string[] ret = new string[count];
// int sortSize = N;
// string originalString = Console.ReadLine();
// string[] arrayString = originalString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// for (int i = 0; i < arrayString.Length; i++)
// {
//     if (arrayString[i].Length <= sortSize)
//     {
//          ret[count] = (arrayString[i]+ ' ');
//          count++;
//     }

// return ret; 
// }
// //     for (int i = 0; i < count; i++)
// //     {
// //         sorted[i] = (arrayString[i]);
// //         Console.Write(result[i]); //вывел, чтобы посмотреть массив для себя. Патался добавить условия ввода через запятую и другие нюансы
// //         Console.Write(' ');
// //     }
//         string sortString = System.Convert.ToString(arrayString[i] + " ");
//         string[] nSignArray = sortString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// }
// }


// // int[] ArrayFromString(string arrayFromString) //функция создания массива из строки
// // {

// //     string[] numbers = arrayFromString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
// //     // string[] numbersComma = arrayFromString.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries); //попытался указать несколько условий, чтобы пользователь мог вводить строку и через запятую и через точку с запятой. не получилось
// //     // string[] numbersDotComma = arrayFromString.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
// //     int[] result = new int[numbers.Length];
// //     for (int i = 0; i < result.Length; i++)
// //     {
// //         result[i] = int.Parse(numbers[i]);
// //         Console.Write(result[i]); //вывел, чтобы посмотреть массив для себя. Патался добавить условия ввода через запятую и другие нюансы
// //         Console.Write(' ');
// //     }

// //     return result;
// // }






//             //Для добавления вариантов разделения с исключением знаков препинания добавил возможность
//             // замены кода предыдущей строки разделения только по пробелам:
//             // char[] separators = new char[] { ' ', '.', ',', '(', ')', '-', '!', '?', ':' };
//             // string[] enteredArray = originalString.Split(separators, StringSplitOptions.RemoveEmptyEntries);






// // Console.WriteLine("Вывод отсортированного массива");
// // for (int i = 0; i < enteredArray.Length; i++)
// // {
// // if (enteredArray[i].Length <= 3)
// //     {
// //        string sortedString = System.Convert.ToString(enteredArray[i] + " ");
// //        string[] threeSignArray = sortedString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// //        Console.Write(threeSignArray[i] + " ");
// //        }
// //     }  






// // void ShowArray(int[] array)                         //функция вывода массива
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write(array[i] + " ");
// //     }
// //     Console.WriteLine();
// // }

// // int[] CreateRandomArray(int N, int start, int end)   //готовая функция рандом массива
// // {
// //     int[] array = new int[N];
// //     for (int i = 0; i < N; i++)
// //     {
// //         array[i] = new Random().Next(start, end + 1);
// //     }
// //     return array;
// // }

// // void ShowArray(int[] array)                         //функция вывода массива
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write(array[i] + " ");
// //     }
// //     Console.WriteLine();
// // }

// // int[] array = CreateRandomArray(10, 1, 100);

// // ShowArray(array);

// // int max = array[0];
// //     int min = array[0];
// // for (int i = 0; i < array.Length; i++)
// // {
// //     if (array[i]>max)
// //     max = array[i];
// //     if (array[i]<min)
// //     min = array[i];
// // }
// // int diff = max - min;
// // Console.WriteLine($"Difference betvene min & max elements is: {diff}"); //SORRY FOR MY ИНГЛИШ (((:

// // // Have a nice day!



// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// // int CountPositiveNumbersByReadline(int[] array) // function return count pos numbers
// // {
// //     int count = 0;
// //     foreach (var item in array)
// //     {
// //         if (item > 0)
// //             count++;
// //     }
// //     return count;

// // }

// // Console.WriteLine("Enter the numbers separated by a space: ");
// // int[] array = ArrayFromString(Console.ReadLine());
// // int count = CountPositiveNumbersByReadline(array);
// // Console.WriteLine(' ');
// // Console.WriteLine($"The count of positive nimbers in string is: {count} ");
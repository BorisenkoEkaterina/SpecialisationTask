            string str = Console.ReadLine();
            if (str.Length < 5)
                Console.WriteLine("В строке меньше 5 символов");
            else if (str.Length >= 5 && str.Length <= 15)
                Console.WriteLine(str.Length);
            else if (str.Length > 15)
                Console.WriteLine("В строке больше 15 символов");
            Console.ReadLine();

//Проба подсчёта количества символов в отдельной строке

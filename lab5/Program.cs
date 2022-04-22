using System;
using System.Text.RegularExpressions;

//Задание 1
//Написать регулярное выражение, которые проверят строки на соответствие: «a», «aaaaaa», «a aa a». 

//string input = File.ReadAllText(@"test.txt");
//Console.WriteLine(input);
//string pattern = @"[a]";


//foreach (Match m in Regex.Matches(input, pattern))
//{
//    Console.WriteLine("'{0}' найдено на {1} месте.", m.Value, m.Index);
//}


//Задание 2
//Написать регулярное выражение, заставляющее вводить не менее 5 алфавитно-цифровых символов.

//string input = File.ReadAllText(@"test.txt");
//Console.WriteLine(input);
//string pattern = @"([a-z-\d]{5,})";

//foreach (Match m in Regex.Matches(input, pattern))
//{
//    Console.WriteLine("'{0}'", m.Value, m.Index);
//}


//Задание 3
//Написать регулярное выражение, которое проверят email простого вида (например, test@test.test).

//string input = File.ReadAllText(@"test.txt");
//Console.WriteLine(input);
//string pattern = @"\w+@[a-z]+?\.[a-z]{2,}";

//foreach (Match m in Regex.Matches(input, pattern))
//{
//    Console.WriteLine("'{0}'", m.Value, m.Index);
//}


//Задание 4
//Написать регулярное выражение, выполняющее проверку адреса, записанного в формате: «ул.строка д.число/число», например, «ул.Высоцкого д. 20/3». 
//Если введенная строка удовлетворяет шаблону, вывести отдельно название улицы и номер дома, иначе вывести строку «Не найдено».

//string input = File.ReadAllText(@"test.txt");
//Console.WriteLine(input);
//Regex regex = new Regex(@"\w{2,}\. \w{2,} \w{1,}\. \w{1,}/\w{1,}");
//MatchCollection matches = regex.Matches(input);

//if (matches.Count > 0)
//{
//    foreach (Match match in matches)
//    {
//        string pattern = @"\w[0-9]/\w";
//        foreach (Match m in Regex.Matches(input, pattern))
//        {
//            Console.WriteLine(m);
//        }
//    }

//}
//else
//{
//    Console.WriteLine("Не найдено");
//}




















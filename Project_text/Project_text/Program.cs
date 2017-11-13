using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project_text;



namespace Project_text
{
    class Program
    {
        /*Задача 1. Создать программу обработки текста учебника по программированию с использованием классов: Символ, Слово, Предложение, Знак препинания и др. (состав и иерархию классов продумать самостоятельно). Во всех задачах с формированием текста заменять табуляции и последовательности пробелов одним пробелом.
Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них.
Во всех вопросительных предложениях текста найти и напечатать без повторений слова заданной длины.
Из текста удалить все слова заданной длины, начинающиеся на согласную букву.
В некотором предложении текста слова заданной длины заменить указанной подстрокой, длина которой может не совпадать с длиной слова.*/
        private static void Main(string[] args)
        {
            string line = "=============================================================";
            IFileReader r = new TextReader("input.txt");
            List<string> listSentences = new List<string>();
            IParser<Text> parser = new TextParser();
            listSentences = r.Read();
            var text = parser.Parse(listSentences);

            //1 Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них.
            foreach (var item in text.SortSentences())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(line);

            //2 Во всех вопросительных предложениях текста найти и напечатать без повторений слова заданной длины.
            text.FindWordsOfPredeterminedLenght(text, 4);
            Console.WriteLine(line);

            //3 Из текста удалить все слова заданной длины, начинающиеся на согласную букву.
            text.RemoveWords(2);
            Console.WriteLine(text);
            Console.WriteLine(line);

            //4 В некотором предложении текста слова заданной длины заменить указанной подстрокой, 
            ///длина которой может не совпадать с длиной слова.
            text.ReplaceWords(2, 2, "Test test");
            Console.WriteLine(text);
            Console.WriteLine(line);

            Console.ReadKey();
        }
    }
}
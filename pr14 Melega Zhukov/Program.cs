using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pr14_Melega
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнили студенты группы ИСП.20А");
            Console.WriteLine("Мелега Алексей и Жуков Артём");
            StreamReader sr = new StreamReader(@"Input.txt");
            string text = sr.ReadToEnd();
            Console.WriteLine(text);
            string[] textArray = text.Split(' ');
            Console.ReadKey();
            //v4
            Console.WriteLine("Вариант 4");
            int[] lengthArray = new int[textArray.Length];
            lengthArray = textArray.Select(x => x.Length).ToArray();
            Console.WriteLine(lengthArray.Min());
            int count = textArray.Count(x => DeletePunctuation(x).Length == lengthArray.Min());
            Console.WriteLine(count);
            StreamWriter sw = new StreamWriter(@"Rezult.txt", false
                , Encoding.Default);
            sw.WriteLine("Вариант 4");
            sw.WriteLine($"Количество самых коротких слов: {count}");
            Console.ReadKey();
            //v1
            Console.WriteLine("Введите необходимое слово");
           string word = Console.ReadLine();
            Console.WriteLine($"Входит ли слово в текст? {textArray.Contains(word)}");
            Console.WriteLine(textArray.Where(x => DeletePunctuation(x) == word));
            sw.WriteLine("Вариант 1");
            sw.WriteLine(textArray.Where(x => DeletePunctuation(x) == word));
            sw.WriteLine($"Входит ли слово в текст? {textArray.Contains(word)}");
            Console.ReadKey();
            //v8 
            string newtext = "";
            foreach (char c in text)
            {
                if (Char.IsUpper(c))
                    newtext += c.ToString().ToLower();
                else
                    newtext += c.ToString().ToUpper();

            }
            Console.WriteLine("Вариант 8");
            Console.WriteLine($"{newtext}");
            sw.WriteLine("Вариант 8");
            sw.WriteLine($"{newtext}");
            //v2
            Console.WriteLine("Вариант 2");
            lengthArray = textArray.Select(x => x.Length).ToArray();
            Console.WriteLine(lengthArray.Max());
            count = textArray.Count(x => x.Length == lengthArray.Max());
            Console.WriteLine(count);
            sw.WriteLine("Вариант 2");
            sw.WriteLine($"Количество самых длинных слов: {count}");
            Console.ReadKey();
            //v3
            Console.WriteLine("Вариант 3");
            sw.WriteLine("Вариант 3");
            foreach (string w in textArray.OrderBy(x => x).Distinct())
            {
                Console.WriteLine(DeletePunctuation(w));
                sw.WriteLine(DeletePunctuation(w));
            }
            Console.ReadKey();
            //v6
            sw.WriteLine("Вариант 6");
            string rusalphabit = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string englishalphabit = "ZYXWVUTSRQPONMLKJIHGFEDCBAzyxwvutsrqponmlkjihgfedcba";
            int ruscount = text.Count(x => rusalphabit.Contains(x));
            int engcount = text.Count(x => englishalphabit.Contains(x));
            Console.WriteLine("Каких букв больше? ");
            if (ruscount > engcount) Console.WriteLine("Русских букв больше");
            else
                if (ruscount < engcount) Console.WriteLine("Английских букв больше");
            else

                Console.WriteLine("Количество букв равно");
            if (ruscount > engcount) sw.WriteLine("Русских букв больше");
            else
    if (ruscount < engcount) sw.WriteLine("Английских букв больше");
            else
                sw.WriteLine("Количество букв равно");
            Console.ReadKey();
            sw.Close();
            //v



        }
        private static string DeletePunctuation(string inputword)
        {
            //удаление знаков препинания
            string outword="";
            string punctuation = ".,?!;:-\"\'()";
            foreach (char simbol in inputword)
                if (!punctuation.Contains(simbol)) outword += simbol;
            return outword;
        }
    }
}

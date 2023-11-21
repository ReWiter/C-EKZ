using System.Collections;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Text;

namespace Prog
{
    class Prog
    {
        public static void wrti(int b, Dictionary<string, string> map)
        {
            if (b == 1)
            {
                string filename = "ENG_to_RU.txt";
                bool fileExist = File.Exists(filename);
                if (fileExist)
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                        {
                            foreach (var item in map)
                            {
                                sw.WriteLine($"{item.Key}-{item.Value}");
                            }
                        }
                    }
                }
                else
                {
                    using (FileStream fs = new FileStream(filename, FileMode.CreateNew))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                        {
                            foreach (var item in map)
                            {
                                sw.WriteLine($"{item.Key}-{item.Value}");
                            }
                        }
                    }
                }
            }
            else if (b == 2)
            {
                string filename = "RU_to_ENG.txt";
                bool fileExist = File.Exists(filename);
                if (fileExist)
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            foreach (var item in map)
                            {
                                sw.WriteLine($"{item.Key}-{item.Value}");
                            }
                        }
                    }
                }
                else
                {
                    using (FileStream fs = new FileStream(filename, FileMode.CreateNew))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            foreach (var item in map)
                            {
                                sw.WriteLine($"{item.Key}-{item.Value}");
                            }
                        }
                    }
                }
            }
        }
        public static void wfs(int b, Dictionary<string, string> map, string word)
        {
            Dictionary<string, string> map2 = new Dictionary<string, string>() { };
            if (b == 1)
            {
                string filename = "ENG_to_RU.txt";
                int count = File.ReadLines(filename).Count();
                bool fileExist = File.Exists(filename);
                if (fileExist)
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string? line;
                            string[] arr = new string[count];
                            int i = 0;
                            while ((line = sr.ReadLine()) != null)
                            {
                                arr[i++] = line;
                            }
                            for (int j = 0; j < arr.Length; j++)
                            {
                                string[] temp = arr[j].Split('-');
                                map2.Add(temp[0], temp[1]);
                            }
                        }
                    }
                    if (map2.ContainsKey(word) == true)
                    {
                        map2.Remove(word);
                        Console.WriteLine("Укажите перевод");
                        string transl = Console.ReadLine();
                        map2.Add(word, transl);
                        using (FileStream fs = new FileStream(filename, FileMode.Create))
                        {
                            using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                            {
                                foreach (var item in map2)
                                {
                                    sw.WriteLine($"{item.Key}-{item.Value}");
                                }
                            }
                        }

                    }
                }
                else
                {
                    if (map.ContainsKey(word) == true)
                    {
                        map.Remove(word);
                        Console.WriteLine("Укажте перевод");
                        string transl = Console.ReadLine();
                        map.Add(word, transl);

                    }
                    else
                    {
                        Console.WriteLine("Слова неn в словаре");
                    }
                }
            }
            if (b == 2)
            {
                string filename = "RU_to_ENG.txt";
                int count = File.ReadLines(filename).Count();
                bool fileExist = File.Exists(filename);
                if (fileExist)
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string? line;
                            string[] arr = new string[count];
                            int i = 0;
                            while ((line = sr.ReadLine()) != null)
                            {
                                arr[i++] = line;
                            }
                            for (int j = 0; j < arr.Length; j++)
                            {
                                string[] temp = arr[j].Split('-');
                                map2.Add(temp[0], temp[1]);
                            }
                        }
                    }
                    if (map2.ContainsKey(word) == true)
                    {
                        map2.Remove(word);
                        Console.WriteLine("Укажите перевод");
                        string transl = Console.ReadLine();
                        map2.Add(word, transl);
                        using (FileStream fs = new FileStream(filename, FileMode.Create))
                        {
                            using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                            {
                                foreach (var item in map2)
                                {
                                    sw.WriteLine($"{item.Key}-{item.Value}");
                                }
                            }
                        }

                    }
                }
                else
                {
                    if (map.ContainsKey(word) == true)
                    {
                        map.Remove(word);
                        Console.WriteLine("Укажте перевод");
                        string transl = Console.ReadLine();
                        map.Add(word, transl);

                    }
                    else
                    {
                        Console.WriteLine("Слова неn в словаре");
                    }
                }
            }
        }
        public static void wfd(int b, Dictionary<string, string> map, string word)
        {
            Dictionary<string, string> map2 = new Dictionary<string, string>() { };
            if (b == 1)
            {
                string filename = "ENG_to_RU.txt";
                int count = File.ReadLines(filename).Count();
                bool fileExist = File.Exists(filename);
                if (fileExist)
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string? line;
                            string[] arr = new string[count];
                            int i = 0;
                            while ((line = sr.ReadLine()) != null)
                            {
                                arr[i++] = line;
                            }
                            for (int j = 0; j < arr.Length; j++)
                            {
                                string[] temp = arr[j].Split('-');
                                map2.Add(temp[0], temp[1]);
                            }
                        }
                    }
                    if (map2.ContainsKey(word) == true)
                    {
                        map2.Remove(word);
                        using (FileStream fs = new FileStream(filename, FileMode.Create))
                        {
                            using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                            {
                                foreach (var item in map2)
                                {
                                    sw.WriteLine($"{item.Key}-{item.Value}");
                                }
                            }
                        }

                    }
                }
                else
                {
                    if (map.ContainsKey(word) == true)
                    {
                        map.Remove(word);
                    }
                    else
                    {
                        Console.WriteLine("Слова нет в словаре");
                    }
                }
            }
            if (b == 2)
            {
                string filename = "RU_to_ENG.txt";
                int count = File.ReadLines(filename).Count();
                bool fileExist = File.Exists(filename);
                if (fileExist)
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string? line;
                            string[] arr = new string[count];
                            int i = 0;
                            while ((line = sr.ReadLine()) != null)
                            {
                                arr[i++] = line;
                            }
                            for (int j = 0; j < arr.Length; j++)
                            {
                                string[] temp = arr[j].Split('-');
                                map2.Add(temp[0], temp[1]);
                            }
                        }
                    }
                    if (map2.ContainsKey(word) == true)
                    {
                        map2.Remove(word);
                        using (FileStream fs = new FileStream(filename, FileMode.Create))
                        {
                            using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                            {
                                foreach (var item in map2)
                                {
                                    sw.WriteLine($"{item.Key}-{item.Value}");
                                }
                            }
                        }

                    }
                }
                else
                {
                    if (map.ContainsKey(word) == true)
                    {
                        map.Remove(word);
                    }
                    else
                    {
                        Console.WriteLine("Слова неn в словаре");
                    }
                }
            }
        }
        public static void addd(Dictionary<string, string> map)
        {
            Console.WriteLine("Укажите слово");
            string word = Console.ReadLine();
            Console.WriteLine("Укажите перевод");
            string transl = Console.ReadLine();
            map.Add(word, transl);
        }
        public static void switchh(int b, Dictionary<string, string> map)
        {
            int e = 4;
            Console.WriteLine("Укажите слово для поиска");
            string word = Console.ReadLine();
            Console.WriteLine("\n1-Заменить слово" + "\n2-Заменить перевод" + "\n3-Назад");
            e = Int32.Parse(Console.ReadLine());
            if (e == 1)
            {
                wfs(b, map, word);
            }
            else if (e == 2)
            {
                wfs(b, map, word);
            }
            else { }
        }
        public static void delll(int b, Dictionary<string, string> map)
        {
            Dictionary<string, string> map2 = new Dictionary<string, string>() { };
            int e = 4;
            Console.WriteLine("Укажите слово для поиска");
            string word = Console.ReadLine();
            Console.WriteLine("\n1-Удалить слово" + "\n2-Удалить перевод" + "\n3-Назад");
            e = Int32.Parse(Console.ReadLine());
            if (e == 1)
            {
                wfd(b, map, word);
            }
            else if (e == 2)
            {
                wfd(b, map, word);
            }
            else { }
        }
        public static void serc(int b, Dictionary<string, string> map)
        {
            Dictionary<string, string> map2 = new Dictionary<string, string>() { };
            Console.WriteLine("Укажите слово для поиска");
            string word = Console.ReadLine();
            if (b == 1)
            {
                string filename = "ENG_to_RU.txt";
                bool fileExist = File.Exists(filename);
                if (fileExist)
                {
                    int count = File.ReadLines(filename).Count();
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string? line;
                            string[] arr = new string[count];
                            int i = 0;
                            while ((line = sr.ReadLine()) != null)
                            {
                                arr[i++] = line;
                            }
                            for (int j = 0; j < arr.Length; j++)
                            {
                                string[] temp = arr[j].Split('-');
                                map2.Add(temp[0], temp[1]);
                            }
                        }
                    }
                    if (map2.ContainsKey(word) == true) { Console.WriteLine("Слово есть в словаре"); }
                    else
                    {
                        Console.WriteLine("Слова нет в словаре");
                    }
                }
                else
                {
                    if (map.ContainsKey(word) == true)
                    {
                        Console.WriteLine("Слово есть в словаре");
                        Console.WriteLine(word + " " + map[word]);
                    }
                    else { Console.WriteLine("Слово отсутствует в словаре"); }
                }
            }
            else if (b == 2)
            {
                string filename = "RU_to_ENG.txt";
                bool fileExist = File.Exists(filename);
                if (fileExist)
                {
                    int count = File.ReadLines(filename).Count();
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string? line;
                            string[] arr = new string[count];
                            int i = 0;
                            while ((line = sr.ReadLine()) != null)
                            {
                                arr[i++] = line;
                            }
                            for (int j = 0; j < arr.Length; j++)
                            {
                                string[] temp = arr[j].Split('-');
                                map2.Add(temp[0], temp[1]);
                            }
                        }
                    }
                    if (map2.ContainsKey(word) == true) { Console.WriteLine("Слово есть в словаре"); }
                    else
                    {
                        Console.WriteLine("Слова нет в словаре");
                    }
                }
                else
                {
                    if (map.ContainsKey(word) == true)
                    {
                        Console.WriteLine("Слово есть в словаре");
                        Console.WriteLine(word + " " + map[word]);
                    }
                    else { Console.WriteLine("Слово отсутствует в словаре"); }
                }
            }
            Console.ReadLine();
        }
        public static void create()
        {
            int b = 14;
            Console.Clear();
            Console.WriteLine("Выберите тип словаря"
                  + "\n1-Англо-Русский"
                  + "\n2-Русско-Английский");
            b = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Dictionary<string, string> map = new Dictionary<string, string>() { };
            int a = 14;
            while (a != 5)
            {
                Console.Clear();
                Console.WriteLine("1-Добавить слово и его перевод"
                    + "\n2-Заменить слово и его перевод"
                    + "\n3-Удалить слово или перевод"
                    + "\n4-Искать перевод слова"
                    + "\n5-Назад");
                a = Int32.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.Clear();
                    addd(map);
                }
                if (a == 2)
                {
                    Console.Clear();
                    switchh(b, map);
                }
                if (a == 3)
                {
                    Console.Clear();
                    delll(b, map);
                }
                if (a == 4)
                {
                    Console.Clear();
                    serc(b, map);
                }
                if (a == 5)
                {
                    Console.Clear();
                    wrti(b, map);
                    break;
                }
            }
        }
        public static void menu()
        {
            int a = 14;
            while (a != 0)
            {
                Console.WriteLine("Выебрите дейстиве"
                    + "\n1-Создать словарь"
                    + "\n0-Выход из программы");
                a = Int32.Parse(Console.ReadLine());
                if (a == 1) { create(); }
                if (a == 0) { break; }
            }
        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}   

using System;
using System.Linq;
using System.Text;

namespace Lesons
{
    class Program
    {
        static void Main(string[] args)
        {
            

           

        }

        static void StringBuilder()
        {
            Console.WriteLine("какое твое имя ?");
            string name = Console.ReadLine();

            Console.WriteLine("какой твой возраст?");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("какой твой рост?");
            int height = int.Parse(Console.ReadLine());

            string profile =
                $" Your rpofile is :"
                + $"Yzour name : {name}{Environment.NewLine}"
                + $"Your age: {age1}{Environment.NewLine}"
                + $"You Height {height}";
            Console.WriteLine(profile);


            string str1 = "abcde";
            string str2 = "abcde";
            bool areEquel = str1 == str2;
            Console.WriteLine(areEquel);
            areEquel = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEquel);

            Console.WriteLine("---");
            /*Console.WriteLine("Hi tell me your name");
            string name = Console.ReadLine();
            string sentence = $"You name is {name}";
            Console.WriteLine(sentence);*/

            Console.WriteLine("Tell me you age");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            string sentence = $"Your age is {age}!!!";
            //Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(sentence);
            //Console.Clear();




            Console.WriteLine("---");

            Console.Read();

            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");

            string str = sb.ToString();
            Console.WriteLine(str);
            Console.Read();
        }
        static void WorkWithString()
        {
            string nameConcat = string.Concat("My ", "name ", "Alex");
            Console.WriteLine(nameConcat);
            nameConcat = string.Join(" ", "My", "name", "Alex");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "Hi ");
            Console.WriteLine(nameConcat);

            string newName = nameConcat.Remove(1, 2);
            Console.WriteLine(newName);

            newName = nameConcat.Replace('e', 'E');
            Console.WriteLine(newName);


            Console.WriteLine(nameConcat);
            Console.WriteLine("-----------");

            string data = "11;22;33;44;55;66;77";
            string[] splitData = data.Split(';');
            string firstNumber = splitData[5];
            Console.WriteLine(firstNumber);
            Console.WriteLine(nameConcat);

            string lower = nameConcat.ToLower();
            string upper = nameConcat.ToUpper();
            Console.WriteLine(lower);
            Console.WriteLine(upper);

            string John = " My name is John ";
            Console.WriteLine(John.Trim());








            Console.WriteLine("-----------");

            Console.Read();
        }

        static void NewOne()
        {
            var a = "gffff";
            Console.WriteLine(a);
            Console.Read();
        }
    }
}

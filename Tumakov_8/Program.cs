using System;
using System.Linq;
using System.IO;

namespace Tumakov_8
{
    internal class Program
    {
        static public string Reverse_string(string input)
        {
            string output = new string(input.ToCharArray().Reverse().ToArray());
            return output;
        }
        static public void SearchMail(ref string s)
        {
            string[] words = s.Split(new char[] {'#'});
            s = words[1].Substring(1);
        }
        static void Main(string[] args)
        {
            
            //Упр. 8.1
            Bank_Account client_1 = new Bank_Account(100000, Bank_Account.Type_bank_account.Текущий);
            Bank_Account client_2 = new Bank_Account(40000, Bank_Account.Type_bank_account.Сберегательный);

            Console.WriteLine($"client_1:\n Balance - {client_1.Balance_Account}");
            Console.WriteLine($"client_2:\n Balance - {client_2.Balance_Account}");
            client_1.Transfer_money(client_2, 50000);
            Console.WriteLine("Перервод денег со счета client_1 на счет client_2... ");
            Console.WriteLine($"client_1:\n Balance - {client_1.Balance_Account}");
            Console.WriteLine($"client_2:\n Balance - {client_2.Balance_Account}");

            //Упр. 8.2
            string s = "Hello World";
            string reverse_s = Reverse_string(s);
            Console.WriteLine($"{s}\n {reverse_s}");
            
            //Упр. 8.3
            string reverse_text_file = "reverse_text_file.txt";

            Console.Write("Введите название файла без .txt: ");
            string input_file = Console.ReadLine() + ".txt";

            if (File.Exists(input_file))
            {
                string input_file_string = File.ReadAllText(input_file);
                File.WriteAllText(reverse_text_file, input_file_string.ToUpper());
            }
            else
            {
                Console.WriteLine($"Файл {input_file} не найден!");
            }
            //Дз 8.1
            string[] data_set = File.ReadAllLines("data.txt");
            for (int i = 0; i < data_set.Length; i++)
            {
                SearchMail(ref data_set[i]);
            }
            File.WriteAllLines("Email_list.txt", data_set);
        }
    }
}

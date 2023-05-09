using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Class1
    {
        void ArrTask()
        {
            Random r = new Random();
            Double[] a = new double[5];
            Double[,] b = new double[3, 4];
            for (int i = 0; i < 5; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    b[i, j] = r.NextDouble();
                    Console.WriteLine(b[i, j]);
                }
                Console.WriteLine("\n");
            }
            double max = b[0, 0];
            double min = b[0, 0];
            double sum = 0;
            double mult = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (b[i, j] < b[i, j + 1])
                        max = b[i, j + 1];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (b[i, j] < b[i, j + 1])
                        min = b[i, j + 1];
                }
            }
            for (int i = 0; i < 3; i += 2)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum = +b[i, j + 1];
                }
            }
            for (int i = 0; i < 3; i += 2)
            {
                for (int j = 0; j < 4; j++)
                {
                    mult = mult * b[i, j + 1];
                }
            }
        }
        void MultArr()
        {
            Random r = new Random();
            int[,] arr = new int[5, 5];
            int[] max_index = { 0, 0 };
            int[] min_index = { 0, 0 };
            int sum = 0;

            for (int i = 0; i < 5; i += 2)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = r.Next(-100, 100);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] < arr[i, j + 1])
                    {
                        max_index[0] = i;
                        max_index[1] = j;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] > arr[i, j + 1])
                    {
                        min_index[0] = i;
                        min_index[1] = j;
                    }
                }
            }
            for (int i = min_index[0]; i < max_index[0]; i++)
            {
                for (int j = min_index[1]; j < min_index[1]; j++)
                {
                    sum += arr[i, j];
                }
            }
        }
        void Chesr()
        {
            Console.WriteLine("Task 3");
            Console.Write("Enter a string to encrypt: ");
            string message = Console.ReadLine();
            Console.Write("Enter offset: ");
            int shift = int.Parse(Console.ReadLine());
            string encryptedMessage = "";
            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    char shiftedChar = (char)(((c + shift - 'a') % 26) + 'a');
                    encryptedMessage += shiftedChar;
                }
                else
                {
                    encryptedMessage += c;
                }
            }
            Console.WriteLine("Encrypted line: " + encryptedMessage);
            string decryptedMessage = "";
            foreach (char c in encryptedMessage)
            {
                if (char.IsLetter(c))
                {
                    char shiftedChar = (char)(((c - shift - 'a' + 26) % 26) + 'a');
                    decryptedMessage += shiftedChar;
                }
                else
                {
                    decryptedMessage += c;
                }
            }
            Console.WriteLine("Decrypted line: " + decryptedMessage);

        }
    }
}
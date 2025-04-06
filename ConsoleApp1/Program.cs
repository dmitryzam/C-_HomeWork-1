using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void WriteToFile(string path, string content)
        {
            StreamWriter sr = new StreamWriter(path, true);
            sr.Write(content);
            sr.Close();
        }
        static void Main(string[] args)
        {
            File.WriteAllText("out.txt", string.Empty);
            int num = int.Parse(args[0]);
            string result = string.Empty;
            int multy = 1;
            if(args.Length >= 1)
            {
                if (int.Parse(args[0]) > 1 && int.Parse(args[0]) < 100) 
                {
                    try
                    {
                        for (int i = 1; i < num + 1; i++)
                        {
                            if (i == 1)
                            {
                                for (int j = 1; j < num + 1; j++)
                                {
                                    if (j == 1)
                                    {
                                        result = "\t";
                                        WriteToFile("out.txt", result);
                                    }
                                    if (j > 1)
                                    {
                                        result = $"{j}\t";
                                        WriteToFile("out.txt", result);
                                    }
                                    if (j == num)
                                    {
                                        result = "\n";
                                        WriteToFile("out.txt", result);
                                    }
                                }
                            }
                            if (i > 1)
                            {
                                for (int j = 1; j < num + 1; j++)
                                {
                                    if (j == 1)
                                    {
                                        result = $"{i}\t";
                                        WriteToFile("out.txt", result);
                                    }
                                    if (j > 1)
                                    {
                                        multy = i * j;
                                        result = $"{multy}\t";
                                        WriteToFile("out.txt", result);
                                    }
                                    if (j == num)
                                    {
                                        result = "\n";
                                        WriteToFile("out.txt", result);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }                
            }
            else
            {
                Console.WriteLine("Программа работает");
            }
        }
    }
}

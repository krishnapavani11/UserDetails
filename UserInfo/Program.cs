using FileLibrary;
using System;
using System.IO;

namespace UserInfo
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileOperations fileops = new FileOperations();
            string path = "C:\\Users\\pav\\source\\repos\\UserInfo\\Users.csv";

            Console.WriteLine("Welcome To Student Details File");


            // Initialize Serial Number based on existing data
            int SNo = 0;

            int iNumber;

            string Content()
            {
                Console.WriteLine("Enter Student Name: ");
                string sName = Console.ReadLine();

                Console.WriteLine("Enter Student Age: ");
                int iAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Email: ");
                string sEmail = Console.ReadLine();

                SNo++; // increment for each student
                return $"{SNo},{sName},{iAge},{sEmail}\n";
            }

            do
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. List Of Students");
                Console.WriteLine("3. Exit");
                Console.WriteLine("------------------------------");
                Console.Write("Enter your Choice: ");
                iNumber=Convert.ToInt32(Console.ReadLine());

                switch (iNumber)
                {
                    case 1:
                        fileops.AppendContent(path, Content());
                        Console.WriteLine("\nStudent Added Successfully.\n");
                        break;

                    case 2:
                        string readContent = fileops.ReadContent(path);
                        Console.WriteLine("\nList Of Students:\n" + readContent);
                        break;

                    case 3:
                        Console.WriteLine("\nExiting Program...");
                        break;
                }
            }
            while (iNumber != 3);
        }
    }
}

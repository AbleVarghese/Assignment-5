/*Name: Able Varghese
 *Assignment: 05
 *Description: This is a program that create, input and read rows from a text file.
*/



using System;
using System.IO;

namespace File_Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

      // Object is created for FileInputAndOutput class
            FileInputAndOutput FileManipulate = new FileInputAndOutput();


      // Menu entry with exception handling
            try
            {
                while (choice != 2)
                {
                    Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("\nPlease enter your choice");
                    Console.WriteLine("1. Display Grades");
                    Console.WriteLine("2. Exit");
                    Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++\n\n");
                    choice = Convert.ToInt32(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            {
                         // Calling methods in FileInputAndOutput class
                                FileManipulate.FilePath();
                                FileManipulate.FileInput();
                                FileManipulate.FileOutput();
                                break;
                            }
                        case 2:
                            {
                                return;

                            }
                        default: Console.WriteLine("Invalid entry, please try again..\n");

                            break;
                    }
                }
            }


       //Exception output        
            catch(Exception)
                  {
                        Console.WriteLine("Please enter the integer(1 or 2) from the menu");
                         return;
                   }
        



        }

    }
}

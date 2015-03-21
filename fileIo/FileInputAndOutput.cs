using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Input_Output
{
    class FileInputAndOutput
    {
        public string fileName;
        public string fileNameInput;
        public string pathName;
        public string relativeDir;
        public string[] fileArray = new string[3];

     //Method for outputting the data from file which is created
        public void FileInput()
        {

            FileStream inFile = new FileStream(this.pathName, FileMode.Create, FileAccess.Write);

            StreamWriter writeFile = new StreamWriter(inFile);
            writeFile.Write("Jones, Bob: 1 Introduction to Computer Science, A\nJohnson, Sarah: 2 Data Structures, B+\nSmith, Sam: 3 Data Structures, C");

            writeFile.Close();
            inFile.Close();

        }

     //Method for finding and assigning the path of the file created.
        public void FilePath()
        {
            Console.Write("\nPlease enter the filename for the new file you wish to create:");
            this.fileName = Console.ReadLine();
     // getting the relative directory of the program
            this.relativeDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            this.pathName = this.relativeDir + "\\" + this.fileName + ".txt";

        }

      //Method for outputitng the data in the file to the screen
        public void FileOutput()
        {
            try
            {

                Console.Write("\n\nPlease enter the filename for the file you wanted to read\nNote: Should be same as the one you created before : ");
                this.fileNameInput = Console.ReadLine();
                Console.WriteLine("\n\n");
            
                this.pathName = this.relativeDir + "\\" + this.fileNameInput + ".txt";


                FileStream outFile = new FileStream(pathName, FileMode.Open, FileAccess.Read);

                StreamReader readFile = new StreamReader(outFile);

        //Outputting the data in file row by row
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%OUTPUT%%%%%%%%%%%%%%%%%%%%%%%\n");
                for (int row = 0; row < 3; row++)
                    {
                        string fileData = readFile.ReadLine();

                        this.fileArray[row] = fileData;

                        Console.WriteLine("{0}", fileData);
                    }
                Console.WriteLine("\n%%%%%%%%%%%%%%%%%%%%%OUTPUT%%%%%%%%%%%%%%%%%%%%%%%\n\n\n");
                readFile.Close();
                outFile.Close();
            }

    //handling the exception
            catch (Exception)
            {
                Console.WriteLine("*****ERROR: File doesn't exist please try again*****");
                Console.ReadKey();
                return;
            }

        }



    }
}

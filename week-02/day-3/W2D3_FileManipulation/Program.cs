using System;
using System.IO;
using System.Runtime.CompilerServices;

using System.Runtime.ConstrainedExecution;

namespace W2D3_FileManipulation
{
    class Program
    {
        static void WriteFile(string fileName)
        {
            File.WriteAllText(fileName, "Zsófi Kovács");
        }
        static void ReadFile(string fileName)
        {
            Console.WriteLine(File.ReadAllText(fileName));
        }
        static void Main(string[] args)
        {
            string fileName = @"path";
            WriteFile(fileName);
            ReadFile(fileName);
        }

        static void myReader()
        {
            StreamReader myReader = new StreamReader("values.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                }
                myReader.Close();
            }
        }

        static void myReaderKeyword()
        {
            string[] lines = { "This is line 1", "This is line 2", "This is line 3" };
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"path"))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        // ReadAllLines(path)
        // list of strings
        // list(ReadLines)
        // one string
        // ReadAllText

        // WriteAllLines(newfilepath, string list/array)

        // StreamReader 
        // create an object for that
        // StreamReader.ReadToEnd();
        // StreamReader.Dispose(); //close the file, because during they are opened they are read only, and other program scan't have access to them
        // using(var sr = new StreamReader(path)) 
        // { 
        // var words = sr.ReadToEnd();
        // }

        // // using(var sr = new StreamReader(path)) 
        // {
        // var text = sr.ReadLine(); // only reads one line
        // allLines.Add(line)
        // }
        // var text = srReadline();

        // StreamWriter //
        // using (var sw = new StreamWriter(path))
        // { 
        // foreach(var phrase in sentences)
        // { sw.Write(phrase); - puts everything in one line
        // OR   sw.WriteLine(phrase); - includes the new lines also
        // } 

        //// ERRORS ////
        // compile time error: problem in the syntax; appears before running the actual code
        // runtime error: 
        // semantic error: can be compiled, but running it gives an error; can be a runtime error; the logic is wrong / the result is not what I expect (using < instead of >)

        for (int i = 0; i< 6; i++) 
            {
            try 
            {}
            catch (Exeption e) 
            {Console.WriteLine("text" + e.Message)}
            }
            finally { Console.WriteLine(); } // to check which part gives the error within the loop

        // Parse //
        // amit lehet kezeljünk így, és csak nagyon végső/ritka esetben használjuk az exception handlinget

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace codetest3
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter the text to be appended: ");
            string text = Console.ReadLine();

            string filename = "append.txt";
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLine(text);
                writer.Close();
                Console.WriteLine("Text append successful");
                fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileStream);
                string fileContent = reader.ReadToEnd();
                Console.WriteLine("\nContents of file:");
                Console.WriteLine(fileContent);
                reader.Close();
            }
            catch (Exception ex)
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
                Console.WriteLine("error : " + ex.Message);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
            Console.Read();
        }
    }
}

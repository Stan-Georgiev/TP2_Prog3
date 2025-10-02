using System.Text;

namespace TP2_Prog3.Util
{
    public class FileReader
    {
        static List<string> _lines = new List<string>();
        public static List<string> ReadFile(string filePath)
        {
            try
            {
               
              
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Error: File '{filePath}' does not exist.");
                    return null;
                }
                
                _lines = File.ReadAllLines(filePath).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }

            return _lines;
        }
    }
}




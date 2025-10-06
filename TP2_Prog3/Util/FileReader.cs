using System.Text;

namespace TP2_Prog3.Util
{
    public class FileReader
    {
        private static string[] text;
        private static List<string> _lines = new List<string>();
        public static List<string> ReadFile(string filePath)
        {
            try
            {
               
              
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Error: File '{filePath}' does not exist.");
                    
                }
                
                text = File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }

            for (int i = 0; i < text.Length; i++)
            {
                _lines.Add(text[i]);
            }

           
            return _lines;
        }
    }
}




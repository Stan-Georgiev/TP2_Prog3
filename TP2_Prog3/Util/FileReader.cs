using System.Text;

namespace TP2_Prog3.Util
{
    public class FileReader
    {
        public static List<string> ReadFile(string filePath, out int width, out int height)
        {
            var lines = new List<string>();
            width = 0;
            height = 0;

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Error: File '{filePath}' does not exist.");
                    return lines;
                }

                var text = File.ReadAllLines(filePath);

                for (int i = 0; i < text.Length; i++)
                {
                    if (i == 0)
                    {
                        string[] parts = text[i].Split(';', StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length >= 2 &&
                            int.TryParse(parts[0], out int w) &&
                            int.TryParse(parts[1], out int h))
                        {
                            width = w;
                            height = h;
                        }
                        else
                        {
                            Console.WriteLine("Error: First line must contain width;height");
                        }
                    }

                    lines.Add(text[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
            lines.Remove(lines[0]);   
            
            return lines;
        }
    }
}
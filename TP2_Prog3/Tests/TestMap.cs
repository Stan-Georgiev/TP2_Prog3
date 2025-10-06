namespace TP2_Prog3.Tests;

public class TestMap
{
    public static void Afficher(Map mapping)
    {
       
        
            for (int i = 0; i < mapping.map.Count; i++)
            {
                if (mapping.map[i] != null)
                {
                    Console.WriteLine(mapping.map[i]);
                }
                else
                {
                    Console.WriteLine($"Error: File '{mapping.map}' is null");
                }
               
                
            }
        
    }
}
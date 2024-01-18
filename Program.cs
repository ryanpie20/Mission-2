// Ryan Whisenant - Section 4 
using Mission_2; 

internal class Program
{
    private static void Main(string[] args)
    { 
        // have user enter number of rolls 
        System.Console.WriteLine("Please enter the number of rolls");
        // read the code 
        int rolls = int.Parse(System.Console.ReadLine());

        Rolls rs;
        rs = new Rolls();

        rs.RollCount(rolls);

        // create array to hold rs array 
        int[] sumCounts = rs.sumCounts;

        

        // totalsum of all the rolls 
        int[] pctRolls = new int[13];

        for (int i = 0; i < sumCounts.Length; i++)
        {
            // calculate the percentage 
            pctRolls[i] = (int)((float)sumCounts[i] * 100 / rolls );
        }

        // Display the results
        for (int i = 2; i <= 12; i++)
        {

            Console.Write($"{i}. "); 

            for (int j = 0; j < pctRolls[i]; j++)
            {
                Console.Write("*");
            }
            // Move to the next line after printing all asterisks for this number
            Console.WriteLine();

        }
    }
}
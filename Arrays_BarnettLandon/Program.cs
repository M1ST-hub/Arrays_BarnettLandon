namespace Arrays_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks user to specify how many elements in the array
            Console.WriteLine("Enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            //Asks user to input values for all array elements
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            //Sum of all elements in the array
            Console.WriteLine($"The sum of the array is {sum}\n");
            
            Array.Sort(numbers);

            Console.WriteLine("Array:");
            foreach( int number in numbers ) 
            {
                Console.WriteLine(number);
            }
        }
    }
}

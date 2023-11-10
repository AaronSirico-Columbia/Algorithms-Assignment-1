namespace Algorithms_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Wayne", "Clark", "Peter", "Barry", "Tony" };
            int[] Ages = { 1, 2, 3, 4, 5 };

            //A method showing constant Big O notation.
            //Method executes at the same speed regardless of the data size within the method.
            void Constant()
            {
               
                string DogBreed = "French Bulldog\n";
                string DogName = "Charlie";
                string result = DogBreed + "Named: " + DogName;

                Console.WriteLine(result);
            }


            //A method showing linear Big O notation
            //Method exectues at the rate of how big the data entering the method is.
            void Linear(string[] _names)
            {
                Console.WriteLine("Printing names:");

                for (int i = 0; i < _names.Length; i++)
                {
                    Console.WriteLine(_names[i]);
                }
            }

           //A method showing quadratic Big O notation
           //Method executes in double the time because it is returing twice the amount of data being put in.
            void Quad(int[] _numbers)
            {
                Console.WriteLine("Printing Ages:");

                //For loops being nested to simulate quadratic notation
                for (int i = 0; i < _numbers.Length; i++)
                {
                    for (int j = 0; j < _numbers.Length; j++)
                    {
                        Console.WriteLine(_numbers[i] + ", " + _numbers[j]);
                    }
                }

            }

            //Executing all methods
            Constant();
            Linear(names);
            Quad(Ages);

        }
    }
}

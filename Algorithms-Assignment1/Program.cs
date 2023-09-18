namespace Algorithms_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Wayne", "Clark", "Peter", "Barry", "Tony" };
            int[] Ages = { 1, 2, 3, 4, 5 };

            //A Constant method regardless of the data size being inputed will always output in the same time.
            //Adding the two strings toghther takes the same amount, no matter how big the strings are.
            void Constant()
            {
               
                string DogBreed = "French Bulldog\n";
                string DogName = "Charlie";
                string result = DogBreed + "Named: " + DogName;

                Console.WriteLine(result);
            }


            //The linear method here will run for as long as the size of the method. So its runtime will be as long as the array size it is itterating through.
            void Linear(string[] _names)
            {
                Console.WriteLine("Printing names:");

                for (int i = 0; i < _names.Length; i++)
                {
                    Console.WriteLine(_names[i]);
                }
            }

            //The quadratic method is similar to the linear in which its runtime is porpotinal to the size of the data yet squared.
            //So regardless of the amount of data being entered in the method, the run time is going to be squared due to the data being squared.
            void Quad(int[] _numbers)
            {
                Console.WriteLine("Printing Ages:");

                
                for (int i = 0; i < _numbers.Length; i++)
                {
                    for (int j = 0; j < _numbers.Length; j++)
                    {
                        Console.WriteLine(_numbers[i] + ", " + _numbers[j]);
                    }
                }

            }


            Constant();
            Linear(names);
            Quad(Ages);

        }
    }
}
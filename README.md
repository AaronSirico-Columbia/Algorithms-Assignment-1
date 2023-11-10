# Algorithms-Assignment-1

1. Constant, O(1)
- A Constant method regardless of the data size being inputed will always output in the same time.
Adding the two strings toghther takes the same amount, no matter how big the strings are. The method returns the sum of the three strings added together. Since this method
returns the one string. Regardless of how big the strings are being added together the outcome is still going to be one string being returned. Therefor, regardless of data 
size the method will run at the same execution time.

2. Linear, O(n)
- The linear method here will run for as long as the size of the method. So its runtime will be as long as the array size it is itterating through. So in this case the method
is going to run as long as the 'names' array is. This is done using a for loop and the condition being as long as 'i' is less than the length of 'names'. The array size is 5 strings long, so the method will run for 5 iterations. As the data grows so does the execution time of this method, making it linear. 

3. Quadratic, O(n^2)
- The quadratic method is similar to the linear in which its runtime is reliant to the size of the data yet squared. So regardless of the amount of data being entered in 
the method, the run time is going to be squared due to the data being squared. In this method this type of Big O Notation is created by using two for loops nested within each other. In the above example we had one loop printing out one value. In this quadratic method for every one value printed another is printed. This doubles the
the output of the method, yet still has the same amount of data going in.

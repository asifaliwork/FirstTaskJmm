
using System.Diagnostics;

namespace synchronize
{
    class program
    {
       // static async Task Main(string[] args)
       static void Main(string[] args)
         {

            int[] arry = new int[] { 23, 9, 85, 34, 23, 445, 213, 432, 25, 12, 99, 34, 60, 15, 100, 1 };
            int[] arr = new int[] { 23, 9, 85, 34, 23, 445, 213, 432, 25, 12, 99, 34, 60, 15, 100, 1 };
            int i,  j, val, flag;

            int count = 0;
            var timer = new Stopwatch();
            Console.WriteLine("Simple Array");
            foreach (int item in arry)
            {
                Console.Write(item +" " );

            }
            timer.Start();

           // foreach ( i in arr)
             for ( i = 0; i <= arry.Length - 1; i++)
            {
                // foreach(int x in arr)
                for (int x = 0; x <= arry.Length - 2; x++)
                {
                    count = count + 1;

                    if (arry[x] > arry[x + 1])
                    {
                        var a = arry[x];
                        arry[x] = arry[x + 1];
                        arry[x + 1] = a;

                    }

                }

            }
            timer.Stop();



            Console.Write(" \n Bubble Sort Array ");


            foreach (int x in arry)
            {
                Console.Write(x + " ");

            }

            Console.WriteLine("\n Number Of Steps " + count);


            TimeSpan timeTaken = timer.Elapsed;
            Console.WriteLine($"{timeTaken.TotalMilliseconds} seconds");

        
            


                    
                






        




        
           // var timer = new Stopwatch();
           
            Console.WriteLine("Initial array is: ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < arr.Length; i++)
            {
                timer.Start();
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }

            }
            timer.Stop();
            Console.WriteLine("\n Sorted Array is: ");
           for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            
            Console.WriteLine("\n Time");
            Console.WriteLine($"{timeTaken.TotalMilliseconds} seconds");
        }
    }
}

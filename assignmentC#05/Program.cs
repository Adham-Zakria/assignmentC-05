using System.Text;

namespace assignmentC_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 19
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n;

            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Please enter a valid positive integer: ");
            //}

            //Console.WriteLine($"Identity Matrix of size {n}x{n}: ");


            //for (int i = 0; i < n; i++)
            //{
            //   for (int j = 0; j < n; j++)
            //   {
            //       if (i == j)
            //          Console.Write("1 ");
            //       else
            //          Console.Write("0 ");
            //   }
            //   Console.WriteLine(); 
            //}
            #endregion

            #region Q 20
            //int[] x = new int[10];
            //int sum = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < x.Length; i++)
            //{
            //    sum += x[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Q 21
            //Console.WriteLine("enter the length of the first array");
            //int n1 = int.Parse(Console.ReadLine());
            //int[] x = new int[n1];

            //Console.WriteLine("enter the elements of the first array");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("enter the length of the second array");
            //int n2 = int.Parse(Console.ReadLine());
            //int[] y = new int[n2];

            //Console.WriteLine("enter the elements of the second array");
            //for (int i = 0; i < y.Length; i++)
            //{
            //    y[i] = int.Parse(Console.ReadLine());
            //}

            //int[] z = new int[n1 + n2];

            //x.CopyTo(z, 0);
            //y.CopyTo(z, x.Length);
            //Array.Sort(z);

            //for (int i = 0; i < z.Length; i++)
            //{
            //    Console.Write(" " + z[i] + " ");
            //}
            #endregion

            #region Q 22
            //Console.WriteLine("enter the length of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] x = new int[n];

            //Console.WriteLine("enter the elements of the array");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());
            //}

            //bool[] visited = new bool[x.Length];


            //for (int i = 0; i < x.Length; i++)
            //{

            //    if (visited[i])
            //        continue;

            //    int frequency = 1;
            //    for (int j = i + 1; j < x.Length; j++)
            //    {
            //        if (x[i] == x[j])
            //        {
            //            frequency++;
            //            visited[j] = true; 
            //        }
            //    }

            //    Console.WriteLine($"The frequency of {x[i]} is {frequency} time(s)");
            //}
            #endregion

            #region Q 23
            //Console.WriteLine("enter the length of the array");
            //int n =int.Parse(Console.ReadLine());
            //int[] x=new int[n];

            //Console.WriteLine("enter the elements of the array");
            //for (int i = 0; i < x.Length ; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());
            //}

            //int max = x[0];
            //int min = x[0];

            //for (int i = 0; i < x.Length ; i++) {

            //    if (x[i] > max)
            //    {
            //        max = x[i];
            //    }
            //    else if (x[i] < min) 
            //    {
            //        min = x[i];
            //    }
            //}
            //Console.WriteLine($"the maximum element in an array is {max}");
            //Console.WriteLine($"the minimum element in an array is {min}");
            #endregion

            #region Q 24
            //Console.WriteLine("enter the length of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] x = new int[n];

            //Console.WriteLine("enter the elements of the array");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());
            //}

            //int largest = x[0];
            //int SecondLargest = x[0];

            //for (int i = 0; i < x.Length; i++)
            //{

            //    if (x[i] > largest)
            //    {
            //        SecondLargest = largest;
            //        largest = x[i];
            //    }
            //    else if (x[i] > SecondLargest && x[i] != largest)
            //    {
            //        SecondLargest = x[i];
            //    }

            //}
            //Console.WriteLine($"the second largest element in an array is {SecondLargest}");
            #endregion

            #region Q 25
            //Console.WriteLine("enter the length of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] x = new int[n];

            //Console.WriteLine("enter the elements of the array");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());
            //}


            //Dictionary<int, int> D = new Dictionary<int, int>();
            //int longestDistance = 0;

            //for (int i = 0; i < x.Length ; i++)
            //{
            //    if (D.ContainsKey(x[i]))
            //    {
            //        int distance = i - D[x[i]];
            //        if (distance > longestDistance)
            //        {
            //            longestDistance = distance;
            //        }
            //    }
            //    else
            //    {                  
            //        D[x[i]] = i;
            //    }
            //}

            //Console.WriteLine($"The longest distance between two equal cells is: {longestDistance}");
            #endregion

            #region Q 26
            //Console.WriteLine("Enter a space separated list of words:");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');

            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words));
            #endregion

            #region Q 27
            //int[,] x = new int[3, 5];
            //int[,] y = new int[3, 5];
            //Console.WriteLine("Enter the array elements");

            //for (int i = 0; i < x.GetLength(0); i++)
            //{
            //    for (int j = 0; j < x.GetLength(1); j++)
            //    {
            //        x[i,j]=int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}

            //Array.Copy(x,y,x.Length);

            //for (int i = 0; i < y.GetLength(0); i++)
            //{
            //    for (int j = 0; j < y.GetLength(1); j++)
            //    {
            //        Console.Write(" "+y[i, j]+" "); 
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q 28
            //Console.WriteLine("Enter the length of an array");
            //int n=int.Parse(Console.ReadLine());
            //string[] s =new string[n];

            //Console.WriteLine("Enter the elements of an array");
            //for (int i = 0; i < s.Length; i++)
            //{
            //    s[i] = Console.ReadLine();  
            //}

            //for (int i = s.Length-1 ; i >= 0 ; i--)
            //{
            //    Console.Write(s[i]);
            //}
            #endregion

            #region Function Q 1
            ///* passing by value occur in the function stack frame 
            //  but passing by reference occur in the main stack frame */

            //static void swip(int x, int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}

            //int num1 = 10;
            //int num2 = 20;
            //swip(num1, num2);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //static void swip2(ref int x,ref int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}
            //swip2(ref num1, ref num2);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            #endregion

            #region Function Q 2
            //static void SumOfDigits()
            //{
            //    Console.WriteLine("Enter a number");
            //    int num=int.Parse(Console.ReadLine());
            //    int sum = 0;

            //    num = Math.Abs(num);

            //    while (num > 0)
            //    {
            //        sum += num % 10; 
            //        num /= 10;       
            //    }

            //    Console.WriteLine(sum);
            //}

            //SumOfDigits();
            #endregion

            #region Function Q 3
            //static bool IsPrime(int num)
            //{
            //    if (num < 2) return false;

            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0) return false;
            //    }
            //    return true;
            //}
            #endregion

            #region Function Q 4
            //static void factorial()
            //{
            //    Console.WriteLine("enter a number");
            //    int n = int.Parse(Console.ReadLine());

            //    int fact = 1;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        fact *= i;
            //    }
            //    Console.WriteLine($"factorial {n} is {fact}");
            //}

            //factorial();
            #endregion

            #region Function Q 5
            //static void ChangeChar()
            //{
            //    Console.WriteLine("Enter the string:");
            //    StringBuilder input = new StringBuilder();
            //    input.Append(Console.ReadLine());

            //    Console.WriteLine("Enter the new character to replace with 0 based character:");
            //    char newChar = Console.ReadKey().KeyChar;
            //    Console.WriteLine();

            //    input[0]=newChar;
            //    Console.WriteLine(input);
            //}
            //ChangeChar();
            #endregion
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_9
{
    internal class Program
    {
        public static void sumNum(int num1, int num2) {
            //This method takes two integers and displays their sum


            Console.WriteLine("The sum of two numbers: ", num1+num2);
        }

        public static double avgNum(int num1, int num2, int num3, int num4, int num5) {
            //This method takes five doubles and returns their avarage
            double res;
            res = (num1 + num2 + num3+ num4 + num5) / 5;
            return res;
        }

        public static int sumRandomNum() {
            // THis method returns the sum of two randomly generated integers.
            int res;
            int num1, num2;
            System.Random random = new System.Random();
            num1 = random.Next();
            num2 = random.Next();
            Console.WriteLine("The first number: " + num1.ToString());
            Console.WriteLine("The second number: " + num2.ToString());
            res = num1 + num2;
            return res;
        }

        public static bool SumDiv3(int num1, int num2, int num3)
        {
            //This method takes three integers and returns true
            //if their sum is divisible by 3, false otherwise
            bool res = false;
            int sum = num1 + num2 + num3;
            if (sum % 3 == 0) {
                res = true;
            }
            return res;
        }

        public static string FewerChar(string s1, string s2)
        {
            //This method takes two strings and displays the string
            //that has fewer characters.
            string res = s1;
            if (s1.Length > s2.Length)
            {
                res = s2; res = s2;
            }
            return res;
        }

        public static double LargestVal(double[] arr)
        {
            //This method takes an array of doubles
            //and returns the largest value in the array.
            double res = arr.Max();

            return res;
        }

        public static int[] RandArr()
        {
            //This method generates and returns an array of fifty integer values.
            int[] res = new int[50];
            System.Random random = new System.Random();
            for (int i = 0; i < 50; i++) {
                res[i] = random.Next();
                }
            return res;
        }

        public static bool Compare(bool val1, bool val2)
        {
            //This method takes two bool variables
            //and returns true if they have the same value,
            //false otherwise
            if (val1 == val2) { 
            return true;
            }
            else return false;
        }

        public static double Product(int num1, double num2)
        {
            return num1 * num2;
        }

        public static double AvgArr(int[][] arr)
        {
            //This method takes a two-dimensional array
            //of integers and returns the average of the entries.
            double res;
            double sum = 0;
            int row = arr.Length;
            int column = arr[0].Length;
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    sum += arr[i][j];
                }
            }
            res = sum / (row * column);
            return res;


        }

        static void Main(string[] args)
        {
            sumNum(1, 2);
            Console.WriteLine(avgNum(1, 2, 3, 4, 5));

            int thirdMethod = sumRandomNum();
            Console.WriteLine(thirdMethod);
            bool fourthMethod = SumDiv3(1,2,3);
            Console.WriteLine(fourthMethod);
            Console.WriteLine(FewerChar("ab", "abcd"));
            double[] fifthMethod = { 1.3, 2.4, 5.3, 1.1, 9.0 };
            Console.WriteLine(LargestVal(fifthMethod));
            Console.WriteLine(RandArr());
            Console.WriteLine(Compare(false, false));
            Console.WriteLine(Product(1, 5.5));
            double[,] array2D = new double[,] { { 1.1, 2.2, 3.3, 4.4 }, { 1.2, 3.4, 5.1, 6.7 } };
            Console.WriteLine(array2D);
            Console.ReadLine();
        }
    }
}

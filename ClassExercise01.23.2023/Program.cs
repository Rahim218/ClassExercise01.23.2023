using System;

namespace ClassExercise01._23._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //int num = int.Parse(Console.ReadLine());

            //AddNumber(ref  num);
            //Console.WriteLine(num);

            //int num1 = int.Parse(Console.ReadLine());
            //Number(ref num1);
            //Console.WriteLine(num1);

            //int[] num = { 11, 25, 12, 44, 31, 10 };
            //EvenNumbers(ref num);
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            //int[] numbers = { 42, 15, 23, 66, 10, 1, 2, 54 };
            //int num = 5;
            //AddNumberToLastIndex( ref numbers, num);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region String metodlar
            string str = "Hello World";
            // Replace
            Console.WriteLine(str.Replace("Hello", "Bye - Bye"));

            // ToLower
            Console.WriteLine(str.ToLower());

            //ToUpper
            Console.WriteLine(str.ToUpper());

            // Clone
            var str2 = str.Clone();
            Console.WriteLine(str2);

            // ToCharArray
            var result = str.ToCharArray();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // TrimStart
            string str3 = "      Hello World";
            Console.WriteLine(str3.TrimStart());

            //TrimEnd
            string str4 = "Hello World      ";
            Console.WriteLine(str4.TrimEnd());

            // Trim 
            string str5 = "    Hello World     ";
            Console.WriteLine(str5.Trim());

            // Contains
            string str6 = "Code Academy";
            Console.WriteLine(str6.Contains("Dost"));//False
            Console.WriteLine(str6.Contains("Code")); // True

            // CompareTo
            Console.WriteLine(str6.CompareTo("Code Academy"));//0 => True  (or -1 => False)

            // StartssWith
            Console.WriteLine(str6.StartsWith("Code")); //True

            //EndsWith
            Console.WriteLine(str6.EndsWith('r')); // False

            //Subsstring
            Console.WriteLine(str6.Substring(5));//Academy
            Console.WriteLine(str6.Substring(5, 5));//Acade

            //GetHashCode
            Console.WriteLine(str6.GetHashCode());//?

            //GetType
            Console.WriteLine(str6.GetType()); // string

            //IndexOf
            Console.WriteLine(str6.IndexOf("d", 0, 3)); //2
            Console.WriteLine(str6.IndexOf('A')); //5
            Console.WriteLine(str6.IndexOf('A', 6)); // -1

            //Insert
            Console.WriteLine(str6.Insert(0, "Hello ")); // Hello Code Academy

            //LastIndexOf
            Console.WriteLine(str6.LastIndexOf('m', 11));//10
            Console.WriteLine(str6.LastIndexOf('m', 7, 2)); //-1

            //Remove

            Console.WriteLine(str6.Remove(2)); // Co
            Console.WriteLine(str6.Remove(2, 6)); //Codemy

            //Split
            var result1 = str6.Split(' ');
            for (int i = 0; i < result1.Length; i++)
            {
                Console.WriteLine(result1[i]);
            }

            #endregion
            #region Char Metod
            Console.WriteLine(char.ToLower('A')); //a
            Console.WriteLine(char.ToUpper('b')); //B
            Console.WriteLine(char.IsDigit('c')); // False
            Console.WriteLine(char.IsDigit('5')); //True
            Console.WriteLine(char.IsLetter('a')); //True
            Console.WriteLine(char.IsLetter('5')); // False
            Console.WriteLine(char.IsLetterOrDigit('5')); // True
            Console.WriteLine(char.IsLetterOrDigit('a')); // True
            Console.WriteLine(char.IsLetterOrDigit('$')); // False

            #endregion
            #region Array Metod
            int[] numbers = { 45, 12, 23, 10, 78, 51, 42, 87, 3 };
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            Array.Clear(numbers, 0, 2);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            int[] demoArr = new int[numbers.Length];
            Array.Copy(numbers, demoArr,4);
            for (int i = 0; i < demoArr.Length; i++)
            {
                Console.WriteLine(demoArr[i]);
            }
            Console.WriteLine();
            int[] number = { 4, 512, 54, 8, 45, 16, 6, 4, };
            Console.WriteLine(Array.IndexOf(number,25)); // -1
            Console.WriteLine(Array.IndexOf(number,8)); //4
            


            #endregion


        }

        static void AddNumber(ref int num)
        {
            num += 10;
        }

        static void Number(ref int num)
        {
            if (num < 0)
            {
                num = 0;
            }
            else if (num > 100)
            {
                num = 100;
            }

        }

        static void EvenNumbers(ref int[] nums)
        {
            int length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    length++;
                }
            }
            int[] evenNumbers = new int[length];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenNumbers[j] = nums[i];
                    j++;
                }
            }
            nums = evenNumbers;
        }

        static void AddNumberToLastIndex(ref int[] arr, int num)
        {
            int[] newArr = new int[arr.Length + 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[j] = arr[i];
                j++;
            }

            newArr[newArr.Length - 1] = num;
            arr = newArr;
        }
    }
}

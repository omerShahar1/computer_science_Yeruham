using System;

namespace SolutionsArrays
{
    class Program
    {
        // ------------------------------------------------------------
        // פתרונות לתשעת התרגילים במצגת המערכים, לפי הסדר.
        // כל תרגיל הוא פעולה נפרדת. הפכו להערה את מה שלא רוצים להריץ.
        // ------------------------------------------------------------
        static void Main(string[] args)
        {
            Ex1_PrintArray();
            Ex2_Reverse();
            Ex3_SumAverage();
            Ex4_MaxMin();
            Ex5_Search();
            Ex6_EvenOdd();
            Ex7_IsSorted();
            Ex8_ReverseInPlace();
            Ex9_AboveAverage();

            Console.WriteLine();
            Console.WriteLine("Done. Press Enter to exit.");
            Console.ReadLine();
        }

        // ============================ חלק א ============================

        // תרגיל 1: הדפסת מערך
        static void Ex1_PrintArray()
        {
            Console.WriteLine("--- 1 ---");

            int[] a = { 3, 7, 1, 9, 5 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        // תרגיל 2: קלט של עשרה מספרים והדפסה בסדר הפוך
        static void Ex2_Reverse()
        {
            Console.WriteLine("--- 2 ---");

            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // רצים מהאינדקס האחרון עד אפס
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // תרגיל 3: סכום וממוצע של חמישה מספרים
        static void Ex3_SumAverage()
        {
            Console.WriteLine("--- 3 ---");

            int[] a = new int[5];
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + (double)sum / a.Length);   // המרה ל-double כדי לשמור על השבר
        }

        // ============================ חלק ב ============================

        // תרגיל 4: הגדול והקטן ביותר
        static void Ex4_MaxMin()
        {
            Console.WriteLine("--- 4 ---");

            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }

            int max = a[0];
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }

        // תרגיל 5: חיפוש מספר במערך
        static void Ex5_Search()
        {
            Console.WriteLine("--- 5 ---");

            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a number to look for: ");
            int target = int.Parse(Console.ReadLine());

            int pos = -1;   // מינוס אחד: עדיין לא נמצא
            for (int i = 0; i < a.Length; i++)
            {
                if (pos == -1 && a[i] == target)
                {
                    pos = i;   // שומרים רק את המופע הראשון
                }
            }

            if (pos == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("First position (index): " + pos);
            }
        }

        // תרגיל 6: ספירת זוגיים ואי-זוגיים
        static void Ex6_EvenOdd()
        {
            Console.WriteLine("--- 6 ---");

            int[] a = new int[10];
            int evens = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] % 2 == 0)
                {
                    evens++;
                }
            }

            Console.WriteLine("Even: " + evens);
            Console.WriteLine("Odd: " + (a.Length - evens));   // כל השאר אי-זוגיים
        }

        // ============================ חלק ג ============================

        // תרגיל 7: האם המערך ממוין בסדר עולה
        static void Ex7_IsSorted()
        {
            Console.WriteLine("--- 7 ---");

            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }

            bool sorted = true;   // מניחים שממוין, ומחפשים סתירה
            for (int i = 0; i < a.Length - 1; i++)   // עד האיבר לפני האחרון, כי משווים לבא אחריו
            {
                if (a[i] > a[i + 1])
                {
                    sorted = false;
                }
            }

            if (sorted)
            {
                Console.WriteLine("The array is sorted");
            }
            else
            {
                Console.WriteLine("The array is not sorted");
            }
        }

        // תרגיל 8: היפוך מערך במקום
        static void Ex8_ReverseInPlace()
        {
            Console.WriteLine("--- 8 ---");

            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }

            // מחליפים בין האיבר ה-i לאיבר ה-i מהסוף, רק עד אמצע המערך
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        // תרגיל 9: כמה איברים גדולים מהממוצע
        static void Ex9_AboveAverage()
        {
            Console.WriteLine("--- 9 ---");

            int[] a = new int[10];
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
            }

            double average = (double)sum / a.Length;   // הממוצע חייב להיות double

            int count = 0;
            for (int i = 0; i < a.Length; i++)   // לולאה שנייה: צריך קודם לדעת את הממוצע
            {
                if (a[i] > average)
                {
                    count++;
                }
            }

            Console.WriteLine("Average: " + average);
            Console.WriteLine("Above average: " + count);
        }
    }
}

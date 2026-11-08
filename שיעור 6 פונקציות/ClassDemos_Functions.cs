using System;

namespace ClassDemosFunctions
{
    class Program
    {
        // ------------------------------------------------------------
        // איך משתמשים: כל דוגמה היא פעולה נפרדת שמסביר עליה בכיתה.
        // הפונקציות העזר של כל דוגמה כתובות מתחתיה.
        // כדי להריץ דוגמה אחת בלבד, הפכו את שאר השורות ב-Main להערה.
        // הטקסטים שמודפסים למסך באנגלית כדי שהקונסולה תציג אותם יפה.
        // ------------------------------------------------------------
        static void Main(string[] args)
        {
            Demo1_FirstFunction();
            Demo2_Parameters();
            Demo3_ReturnValue();
            Demo4_BoolAndTwoReturns();
            Demo5_Arrays();
            Demo6_ValueVsReference();
            Demo7_FunctionsCallingFunctions();

            Console.WriteLine();
            Console.WriteLine("Done. Press Enter to exit.");
            Console.ReadLine();
        }

        // ============================ דוגמה 1 ============================
        // פונקציה ראשונה: למה צריך אותן, ואיך קוראים להן

        static void PrintLine()
        {
            Console.WriteLine("----------");
        }

        static void Demo1_FirstFunction()
        {
            Console.WriteLine("--- Demo 1: first function ---");

            // בלי פונקציה היינו כותבים את אותה שורה שוב ושוב:
            // Console.WriteLine("----------");
            // Console.WriteLine("Report");
            // Console.WriteLine("----------");

            PrintLine();
            Console.WriteLine("Report");
            PrintLine();

            // שאלה לכיתה: מה יקרה אם נרצה לשנות את הקו ל-20 מקפים?
            // התשובה: מספיק לשנות במקום אחד, בתוך הפונקציה.
        }

        // ============================ דוגמה 2 ============================
        // פרמטרים

        static void PrintStars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void PrintRectangle(int rows, int cols)   // שני פרמטרים
        {
            for (int r = 0; r < rows; r++)
            {
                PrintStars(cols);                         // פונקציה שקוראת לפונקציה אחרת
            }
        }

        static void Demo2_Parameters()
        {
            Console.WriteLine("--- Demo 2: parameters ---");

            PrintStars(3);    // ***
            PrintStars(7);    // *******

            int size = 4;
            PrintStars(size); // אפשר לשלוח גם משתנה

            PrintRectangle(2, 5);   // שתי שורות של חמש כוכביות
        }

        // ============================ דוגמה 3 ============================
        // ערך מוחזר

        static int Square(int x)
        {
            return x * x;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Average(int a, int b)
        {
            return (a + b) / 2.0;    // 2.0 כדי לשמור על השבר
        }

        static void Demo3_ReturnValue()
        {
            Console.WriteLine("--- Demo 3: return value ---");

            int r = Square(4);                         // שומרים את הערך שחוזר
            Console.WriteLine(r);                      // 16
            Console.WriteLine(Square(5) + 1);          // משתמשים בו ישר בביטוי: 26
            Console.WriteLine(Add(Square(2), Square(3)));   // 4 + 9 = 13
            Console.WriteLine(Average(3, 4));          // 3.5

            // שאלה לכיתה: מה ההבדל בין Square שמחזירה ערך לבין PrintStars?
            // התשובה: PrintStars מדפיסה ולא מחזירה כלום (void), Square מחזירה ערך שאפשר להמשיך לעבוד איתו.

            // טעות נפוצה: לקרוא לפונקציה ולא לעשות עם התוצאה כלום
            // Square(4);    <- מתקמפל, אבל הערך הולך לאיבוד
        }

        // ============================ דוגמה 4 ============================
        // פונקציות בוליאניות ושני מסלולי return

        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        static bool IsPositive(int n)
        {
            return n > 0;
        }

        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;       // return מסיים את הפונקציה כאן
            }
            return b;           // מגיעים לכאן רק אם a לא גדול מ-b
        }

        static void Demo4_BoolAndTwoReturns()
        {
            Console.WriteLine("--- Demo 4: bool and two returns ---");

            if (IsEven(7))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.WriteLine(IsPositive(-3));    // False
            Console.WriteLine(Max(8, 5));         // 8
            Console.WriteLine(Max(Max(3, 9), 6)); // 9: קריאה בתוך קריאה
        }

        // ============================ דוגמה 5 ============================
        // מערכים בפונקציות

        static int Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }

        static double Average(int[] a)
        {
            return (double)Sum(a) / a.Length;    // שימוש חוזר בפונקציה קיימת
        }

        static int MaxOf(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void Demo5_Arrays()
        {
            Console.WriteLine("--- Demo 5: arrays ---");

            int[] nums = { 4, 9, 2, 7 };

            PrintArray(nums);                       // 4 9 2 7
            Console.WriteLine(Sum(nums));           // 22
            Console.WriteLine(Average(nums));       // 5.5
            Console.WriteLine(MaxOf(nums));         // 9
        }

        // ============================ דוגמה 6 ============================
        // מספר מועתק, מערך מועבר בהפניה. זה גשר חשוב לתכנות מונחה עצמים.

        static void ChangeNumber(int x)
        {
            x = 100;          // משנה רק את העותק בתוך הפונקציה
        }

        static void DoubleAll(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * 2;    // משנה את המערך המקורי
            }
        }

        static void Demo6_ValueVsReference()
        {
            Console.WriteLine("--- Demo 6: copy vs reference ---");

            int n = 5;
            ChangeNumber(n);
            Console.WriteLine(n);         // 5: המשתנה המקורי לא השתנה

            int[] a = { 1, 2, 3 };
            DoubleAll(a);
            PrintArray(a);                // 2 4 6: המערך המקורי השתנה

            // שאלה לכיתה: למה המספר לא השתנה והמערך כן?
            // התשובה: מספר נשלח כעותק. מערך נשלח כהפניה לאותו מערך בזיכרון.
            // את אותו רעיון של הפניה נפגוש שוב באובייקטים.
        }

        // ============================ דוגמה 7 ============================
        // פונקציות שקוראות לפונקציות

        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int d = 2; d < n; d++)
            {
                if (n % d == 0)
                {
                    return false;     // return בתוך לולאה עוצר את הכול מיד
                }
            }
            return true;
        }

        static void PrintPrimesUpTo(int n)
        {
            for (int p = 2; p <= n; p++)
            {
                if (IsPrime(p))        // התוכנית נקראת כמו משפט
                {
                    Console.Write(p + " ");
                }
            }
            Console.WriteLine();
        }

        static void Demo7_FunctionsCallingFunctions()
        {
            Console.WriteLine("--- Demo 7: functions calling functions ---");

            Console.WriteLine(IsPrime(7));    // True
            Console.WriteLine(IsPrime(9));    // False
            PrintPrimesUpTo(30);              // 2 3 5 7 11 13 17 19 23 29

            // שאלה לכיתה: איך נראה הקוד אילו כתבנו הכול בתוך Main בלי פונקציות?
        }
    }
}

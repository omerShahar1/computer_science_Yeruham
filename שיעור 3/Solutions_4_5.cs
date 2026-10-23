using System;

namespace Solutions45
{
    class Program
    {
        // ------------------------------------------------------------
        // פתרונות לתרגילים של מפגשים 4 ו-5, לפי הסדר במצגת.
        // כל תרגיל הוא פעולה נפרדת. הפכו להערה את מה שלא רוצים להריץ.
        // ------------------------------------------------------------
        static void Main(string[] args)
        {
            Ex4_1_Sign();
            Ex4_2_Adult();
            Ex4_3_Max();
            Ex4_4_Grade();
            Ex4_5_EvenOdd();
            Ex4_6_LeapYear();

            Ex5_1_CountAndSum();
            Ex5_2_Evens();
            Ex5_3_SumUntilZero();
            Ex5_4_Factorial();
            Ex5_5_Table();
            Ex5_6_FullTable();

            Console.WriteLine();
            Console.WriteLine("Done. Press Enter to exit.");
            Console.ReadLine();
        }

        // ============================ מפגש 4 ============================

        // תרגיל 1: חיובי, שלילי או אפס
        static void Ex4_1_Sign()
        {
            Console.WriteLine("--- 4.1 ---");
            Console.Write("Enter a number: ");
            
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (n < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        // תרגיל 2: בגיר או קטין
        static void Ex4_2_Adult()
        {
            Console.WriteLine("--- 4.2 ---");
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }
        }

        // תרגיל 3: הגדול משני מספרים
        static void Ex4_3_Max()
        {
            Console.WriteLine("--- 4.3 ---");
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Max: " + a);
            }
            else if (b > a)
            {
                Console.WriteLine("Max: " + b);
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }
        }

        // תרגיל 4: ציון עם בדיקת טווח
        static void Ex4_4_Grade()
        {
            Console.WriteLine("--- 4.4 ---");
            Console.Write("Enter a score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            // קודם בודקים את המקרה החריג: מחוץ לטווח
            if (score < 0 || score > 100)
            {
                Console.WriteLine("Error: score out of range");
            }
            else if (score >= 56)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        // תרגיל 5: זוגי או אי-זוגי
        static void Ex4_5_EvenOdd()
        {
            Console.WriteLine("--- 4.5 ---");
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)    // שארית 0 בחילוק ב-2 אומרת שהמספר זוגי
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        // תרגיל 6: שנה מעוברת
        static void Ex4_6_LeapYear()
        {
            Console.WriteLine("--- 4.6 ---");
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            // מתחלקת ב-4 אך לא ב-100, או שמתחלקת ב-400
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }

            // בדיקות מומלצות: 2024 (כן), 1900 (לא), 2000 (כן), 2026 (לא)
        }

        // ============================ מפגש 5 ============================

        // תרגיל 1: הדפסת המספרים מ-1 עד n וסכומם
        static void Ex5_1_CountAndSum()
        {
            Console.WriteLine("--- 5.1 ---");
            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("Sum: " + sum);
        }

        // תרגיל 2: המספרים הזוגיים מ-2 עד 20
        static void Ex5_2_Evens()
        {
            Console.WriteLine("--- 5.2 ---");

            for (int i = 2; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }

        // תרגיל 3: קלט עד שיוקלד אפס
        static void Ex5_3_SumUntilZero()
        {
            Console.WriteLine("--- 5.3 ---");

            int sum = 0;
            int count = 0;

            Console.Write("Enter a number (0 to stop): ");
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                sum = sum + x;
                count++;

                Console.Write("Enter a number (0 to stop): ");
                x = int.Parse(Console.ReadLine());   // הקלט הבא, בסוף הסיבוב
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Count: " + count);
        }

        // תרגיל 4: עצרת
        static void Ex5_4_Factorial()
        {
            Console.WriteLine("--- 5.4 ---");
            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());

            // long ולא int, כי העצרת גדלה מהר מאוד
            // ב-int אפשר לחשב עד 12 בלבד, וב-long עד 20
            
            
            
            long result = 1;                //1
            for (int i = 2; i <= n; i++)    //2
            {
                result = result * i;        //2.1
            }
            Console.WriteLine(n + "! = " + result); //3
        }

        // תרגיל 5: לוח הכפל של מספר
        static void Ex5_5_Table()
        {
            Console.WriteLine("--- 5.5 ---");
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + n * i);
            }
        }

        // תרגיל 6: טבלת כפל מלאה של 10 על 10
        static void Ex5_6_FullTable()
        {
            Console.WriteLine("--- 5.6 ---");

            for (int row = 1; row <= 10; row++)
            {
                string line = "";
                for (int col = 1; col <= 10; col++)
                {
                    line = line + row * col + "\t";   // טאב בין המספרים ליישור העמודות
                }
                Console.WriteLine(line);   // שורה אחת בכל סיבוב חיצוני
            }
        }
    }
}

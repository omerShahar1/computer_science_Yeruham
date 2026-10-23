using System;

namespace ClassDemos45
{
    class Program
    {
        // ------------------------------------------------------------
        // איך משתמשים: כל דוגמה היא פעולה נפרדת.
        // כדי להריץ דוגמה אחת בלבד, הפכו את שאר השורות ב-Main להערה.
        // הטקסטים שמודפסים למסך באנגלית כדי שהקונסולה תציג אותם יפה.
        // ------------------------------------------------------------
        static void Main(string[] args)
        {
            // מפגש 4 - ביצוע מותנה
            Demo1_If();
            Demo2_IfElse();
            Demo3_ElseIfChain();
            Demo4_Operators();

            // מפגש 5 - ביצוע חוזר
            Demo5_While();
            Demo6_For();
            Demo7_Table();
            Demo8_Nested();

            Console.WriteLine();
            Console.WriteLine("Done. Press Enter to exit.");
            Console.ReadLine();
        }

        // ============================ מפגש 4 ============================

        // דוגמה 1: פקודת if
        static void Demo1_If()
        {
            Console.WriteLine("--- Demo 1: if ---");

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)   // התנאי בסוגריים עגולים, בלי נקודה-פסיק בסופו
            {
                Console.WriteLine("Adult");   // מתבצע רק כשהתנאי מתקיים
            }

            Console.WriteLine("This line runs always");  // מחוץ ל-if, תמיד מתבצע

            // טעות נפוצה להדגמה: נקודה-פסיק אחרי התנאי
            // if (age >= 18);   <- זה אומר "אם גדול מ-18, אל תעשה כלום"
        }

        // דוגמה 2: פקודת if-else
        static void Demo2_IfElse()
        {
            Console.WriteLine("--- Demo 2: if-else ---");

            Console.Write("Enter a score: ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 56)
            {
                Console.WriteLine("Pass");
            }
            else   // מתבצע רק כשהתנאי לא מתקיים
            {
                Console.WriteLine("Fail");
            }

            // שאלה לכיתה: האם אפשר שיודפסו גם Pass וגם Fail? למה לא?
        }

        // דוגמה 3: שרשרת של בדיקות
        static void Demo3_ElseIfChain()
        {
            Console.WriteLine("--- Demo 3: else if ---");

            Console.Write("Enter a score: ");
            int score = int.Parse(Console.ReadLine());

            // הבדיקות נעשות לפי הסדר, ורק הראשונה שמתקיימת מתבצעת
            if (score >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (score >= 75)
            {
                Console.WriteLine("Good");
            }
            else if (score >= 56)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // שאלה לכיתה: מה יקרה אם נסדר את הבדיקות מהקטן לגדול?
        }

        // דוגמה 4: אופרטורי השוואה ואופרטורים לוגיים
        static void Demo4_Operators()
        {
            Console.WriteLine("--- Demo 4: operators ---");

            int a = 5;
            int b = 8;

            Console.WriteLine(a == b);   // False  (שווה?)
            Console.WriteLine(a != b);   // True   (שונה?)
            Console.WriteLine(a < b);    // True
            Console.WriteLine(a >= b);   // False

            // חיבור תנאים
            Console.WriteLine(a > 3 && b > 3);   // True  (שני התנאים חייבים להתקיים)
            Console.WriteLine(a > 6 || b > 6);   // True  (מספיק שאחד מתקיים)
            Console.WriteLine(!(a > b));         // True  (הופך אמת לשקר ולהפך)

            // טעות נפוצה: סימן שווה אחד הוא השמה, לא השוואה
            // if (a = b)    <- לא מתקמפל ב-C#
            // if (a == b)   <- נכון
        }

        // ============================ מפגש 5 ============================

        // דוגמה 5: לולאת while
        static void Demo5_While()
        {
            Console.WriteLine("--- Demo 5: while ---");

            int i = 1;
            while (i <= 5)          // התנאי נבדק לפני כל סיבוב
            {
                Console.WriteLine(i);
                i++;                // בלי השורה הזאת הלולאה אינסופית!
            }

            // ספירה לאחור
            int n = 5;
            while (n >= 0)
            {
                Console.WriteLine(n);
                n = n - 1;
            }
            Console.WriteLine("Go!");

            // שאלה לכיתה: מה ערכו של i אחרי הלולאה הראשונה? (6)
        }

        // דוגמה 6: לולאת for
        static void Demo6_For()
        {
            Console.WriteLine("--- Demo 6: for ---");

            // אתחול; תנאי; קידום
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // קידום בקפיצות של 2
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            // חישוב חוזר: סכום המספרים מ-1 עד 10
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum: " + sum);   // 55

            // טעות נפוצה להדגמה: ההבדל בין > ל->= בתנאי
            // for (int i = 1; i < 5; i++)   <- מדפיס 1 עד 4 בלבד
        }

        // דוגמה 7: טבלה בעזרת לולאה
        static void Demo7_Table()
        {
            Console.WriteLine("--- Demo 7: multiplication table ---");

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + n * i);
            }
        }

        // דוגמה 8: לולאה בתוך לולאה
        static void Demo8_Nested()
        {
            Console.WriteLine("--- Demo 8: nested loops ---");

            for (int row = 1; row <= 3; row++)         // לולאה חיצונית: שורות
            {
                for (int col = 1; col <= 3; col++)     // לולאה פנימית: עמודות
                {
                    Console.Write(row * col + " ");    // Write: לא יורדים שורה
                }
                Console.WriteLine();                   // יורדים שורה בסוף כל שורה בטבלה
            }

            // הפלט:
            // 1 2 3
            // 2 4 6
            // 3 6 9
            // שאלה לכיתה: כמה פעמים מתבצעת הפקודה הפנימית בסך הכול? (9)
        }
    }
}

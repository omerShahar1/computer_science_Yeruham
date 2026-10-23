using System;

namespace ClassDemosArrays
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
            Demo1_DeclareAndAccess();
            Demo2_Traverse();
            Demo3_InputSumAverage();
            Demo4_MaxMin();
            Demo5_Search();
            Demo6_Reverse();
            Demo7_StringArray();
            Demo8_Reference();

            Console.WriteLine();
            Console.WriteLine("Done. Press Enter to exit.");
            Console.ReadLine();
        }

        // דוגמה 1: הגדרה וגישה לאיברים
        static void Demo1_DeclareAndAccess()
        {
            Console.WriteLine("--- Demo 1: declare and access ---");

            int[] nums = new int[5];   // מערך של 5 מספרים שלמים, כולם מתחילים באפס
            Console.WriteLine(nums[0]);   // 0  (ערך ברירת מחדל)

            nums[0] = 10;              // השמה לפי אינדקס
            nums[1] = 20;
            Console.WriteLine(nums[0]);   // 10
            Console.WriteLine(nums[1]);   // 20

            Console.WriteLine(nums.Length);   // 5  (מספר האיברים)

            // אתחול ישיר: הגודל נקבע לפי מספר הערכים
            int[] grades = { 90, 75, 100 };
            Console.WriteLine(grades.Length);        // 3
            Console.WriteLine(grades[2]);            // 100  (האיבר האחרון)
            Console.WriteLine(grades[grades.Length - 1]);   // 100  (אותו דבר, ללא תלות בגודל)

            // שאלה לכיתה: מה יקרה בשורה הבאה?
            // Console.WriteLine(grades[3]);
            // התשובה: IndexOutOfRangeException, כי האינדקסים הם 0 עד 2
        }

        // דוגמה 2: מעבר על מערך
        static void Demo2_Traverse()
        {
            Console.WriteLine("--- Demo 2: traverse ---");

            int[] nums = { 4, 8, 15, 16 };

            // לולאת for: יש לנו אינדקס, אז אפשר גם לשנות איברים
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("nums[" + i + "] = " + nums[i]);
            }

            // לולאת foreach: מקבלים רק את הערך, בלי אינדקס
            foreach (int x in nums)
            {
                Console.WriteLine(x);
            }

            // שינוי כל האיברים: כאן חייבים for
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * 2;
            }
            Console.WriteLine(nums[0]);   // 8

            // שאלה לכיתה: מה קורה אם כותבים i <= nums.Length? (שגיאה באיטרציה האחרונה)
        }

        // דוגמה 3: קלט למערך, סכום וממוצע
        static void Demo3_InputSumAverage()
        {
            Console.WriteLine("--- Demo 3: input, sum, average ---");

            int[] a = new int[5];
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + (double)sum / a.Length);   // המרה ל-double כדי לא לאבד שבר
        }

        // דוגמה 4: האיבר הגדול והקטן ביותר
        static void Demo4_MaxMin()
        {
            Console.WriteLine("--- Demo 4: max and min ---");

            int[] a = { 7, 3, 12, 5, 9 };

            int max = a[0];   // מניחים שהאיבר הראשון הוא הגדול ביותר
            int min = a[0];

            for (int i = 1; i < a.Length; i++)   // מתחילים מהאיבר השני
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

            Console.WriteLine("Max: " + max);   // 12
            Console.WriteLine("Min: " + min);   // 3

            // שאלה לכיתה: למה לא מתחילים עם max = 0?
            // התשובה: אם כל המספרים שליליים, התוצאה תהיה שגויה.
        }

        // דוגמה 5: חיפוש איבר במערך
        static void Demo5_Search()
        {
            Console.WriteLine("--- Demo 5: search ---");

            int[] a = { 7, 3, 12, 5, 9, 3 };

            Console.Write("Enter a number to look for: ");
            int target = int.Parse(Console.ReadLine());

            int pos = -1;   // מינוס אחד אומר: עדיין לא נמצא
            for (int i = 0; i < a.Length; i++)
            {
                if (pos == -1 && a[i] == target)   // שומרים רק את המופע הראשון
                {
                    pos = i;
                }
            }

            if (pos == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("Found at index " + pos);
            }

            // שאלה לכיתה: מה יודפס אם מחפשים את 3? (1, המופע הראשון)
        }

        // דוגמה 6: היפוך מערך
        static void Demo6_Reverse()
        {
            Console.WriteLine("--- Demo 6: reverse ---");

            int[] a = { 1, 2, 3, 4, 5 };

            // הדפסה בסדר הפוך: עוברים מהסוף להתחלה
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }

            // היפוך במקום: מחליפים בין איברים מהקצוות פנימה
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];                    // שומרים ערך בצד
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");          // 5 4 3 2 1
            }
            Console.WriteLine();

            // שאלה לכיתה: למה הלולאה רצה רק עד חצי מהאורך?
            // התשובה: אם נרוץ עד הסוף, נחליף כל זוג פעמיים והמערך יחזור למצבו המקורי.
        }

        // דוגמה 7: מערך של מחרוזות
        static void Demo7_StringArray()
        {
            Console.WriteLine("--- Demo 7: string array ---");

            string[] names = { "Dan", "Noa", "Yael" };

            Console.WriteLine(names.Length);       // 3  (מספר השמות)
            Console.WriteLine(names[1]);           // Noa
            Console.WriteLine(names[2].Length);    // 4  (אורך המחרוזת Yael)
            Console.WriteLine(names[0][0]);        // D  (התו הראשון במחרוזת הראשונה)

            foreach (string name in names)
            {
                Console.WriteLine("Hello " + name);
            }
        }

        // דוגמה 8: מערך הוא אובייקט שאפשר להצביע עליו משני שמות
        static void Demo8_Reference()
        {
            Console.WriteLine("--- Demo 8: reference ---");

            int[] a = { 1, 2, 3 };
            int[] b = a;       // לא נוצר מערך חדש, b מצביע על אותו מערך
            b[0] = 99;

            Console.WriteLine(a[0]);   // 99!
            Console.WriteLine(b[0]);   // 99

            // כדי ליצור עותק אמיתי, יוצרים מערך חדש ומעתיקים איבר איבר
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            c[0] = 5;
            Console.WriteLine(a[0]);   // עדיין 99
            Console.WriteLine(c[0]);   // 5
        }
    }
}

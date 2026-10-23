using System;

namespace ClassDemos
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
            // מפגש 2
            Demo1_Types();
            Demo2_Declaration();
            Demo3_Print();
            Demo4_Input();

            // מפגש 3
            Demo5_StringBasics();
            Demo6_Substring();
            Demo7_Concat();
            Demo8_Search();
            Demo9_Combined();

            Console.WriteLine();
            Console.WriteLine("Done. Press Enter to exit.");
            Console.ReadLine();
        }

        // ============================ מפגש 2 ============================

        // דוגמה 1: שלושת הטיפוסים הבסיסיים
        static void Demo1_Types()
        {
            Console.WriteLine("--- Demo 1: types ---");

            int age = 16;          // מספר שלם
            double price = 4.5;    // מספר עשרוני
            char grade = 'A';      // תו בודד, תמיד בגרש בודד

            Console.WriteLine(age);
            Console.WriteLine(price);
            Console.WriteLine(grade);

            // שאלה לכיתה: מה יודפס בשתי השורות הבאות ולמה?
            Console.WriteLine(7 / 2);     // 3  (חילוק של שני שלמים נותן שלם)
            Console.WriteLine(7 / 2.0);   // 3.5 (אחד מהם עשרוני, ולכן התוצאה עשרונית)

            // בונוס: לכל תו יש קוד מספרי
            Console.WriteLine((int)grade);  // 65
        }

        // דוגמה 2: הצהרה, השמה ושינוי ערך
        static void Demo2_Declaration()
        {
            Console.WriteLine("--- Demo 2: declaration ---");

            int x;          // הצהרה: טיפוס ושם, עדיין בלי ערך
            x = 5;          // השמה: נותנים ערך
            int y = x + 3;  // הצהרה והשמה יחד

            Console.WriteLine(x);  // 5
            Console.WriteLine(y);  // 8

            x = 100;               // אפשר לשנות ערך של משתנה קיים
            Console.WriteLine(x);  // 100
            Console.WriteLine(y);  // עדיין 8, כי y חושב פעם אחת בלבד
        }

        // דוגמה 3: הדפסה
        static void Demo3_Print()
        {
            Console.WriteLine("--- Demo 3: print ---");

            Console.Write("Hello ");     // Write לא יורד שורה
            Console.Write("World");
            Console.WriteLine();         // WriteLine יורד שורה

            int apples = 3;
            Console.WriteLine("Apples: " + apples);        // חיבור טקסט ומשתנה
            Console.WriteLine("Total: " + (apples * 2));   // חישוב בתוך סוגריים
            Console.WriteLine("No parentheses: " + apples * 2);  // גם זה עובד, כי כפל קודם לחיבור
            Console.WriteLine("Sum text: " + 1 + 2);       // 12, לא 3! כי נוצר טקסט
            Console.WriteLine("Sum number: " + (1 + 2));   // 3
        }

        // דוגמה 4: קלט מהמשתמש
        static void Demo4_Input()
        {
            Console.WriteLine("--- Demo 4: input ---");

            Console.Write("Enter first number: ");
            string text = Console.ReadLine();   // ReadLine תמיד מחזירה מחרוזת
            int a = int.Parse(text);            // Parse ממירה מחרוזת למספר שלם

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());  // אפשר לחבר את שתי הפעולות

            Console.WriteLine("Sum: " + (a + b));
            Console.WriteLine("Average: " + (a + b) / 2.0);

            Console.Write("Enter a decimal number: ");
            double d = double.Parse(Console.ReadLine());  // לעשרוני משתמשים ב-double.Parse
            Console.WriteLine("Double of it: " + d * 2);

            // שאלה לכיתה: מה יקרה אם נקליד כאן אות במקום מספר?
            // התשובה: התוכנית תקרוס עם שגיאת FormatException.
        }

        // ============================ מפגש 3 ============================

        // דוגמה 5: מחרוזת, אורך ואינדקס
        static void Demo5_StringBasics()
        {
            Console.WriteLine("--- Demo 5: string basics ---");

            string s = "Hello";

            Console.WriteLine(s.Length);              // 5
            Console.WriteLine(s[0]);                  // H  (האינדקס הראשון הוא 0)
            Console.WriteLine(s[4]);                  // o
            Console.WriteLine(s[s.Length - 1]);       // o  (התו האחרון, תמיד אורך פחות 1)

            // מחרוזת לא משתנה: הפעולה מחזירה מחרוזת חדשה
            string upper = s.ToUpper();
            Console.WriteLine(upper);   // HELLO
            Console.WriteLine(s);       // Hello  (המקורית לא השתנתה)

            // שאלה לכיתה: למה השורה הבאה לא תתקמפל?
            // s[0] = 'J';
        }

        // דוגמה 6: חיתוך
        static void Demo6_Substring()
        {
            Console.WriteLine("--- Demo 6: substring ---");

            string s = "Hello World";

            // Substring(מאיזה אינדקס מתחילים, כמה תווים לוקחים)
            Console.WriteLine(s.Substring(0, 5));   // Hello
            Console.WriteLine(s.Substring(6, 3));   // Wor

            // עם פרמטר אחד: חותכים עד סוף המחרוזת
            Console.WriteLine(s.Substring(6));      // World
        }

        // דוגמה 7: חיבור מחרוזות
        static void Demo7_Concat()
        {
            Console.WriteLine("--- Demo 7: concatenation ---");

            string first = "Hello";
            string second = "World";

            string full = first + " " + second;   // חיבור עם +
            Console.WriteLine(full);              // Hello World

            string same = string.Concat(first, " ", second);  // אותה תוצאה
            Console.WriteLine(same);

            full = full + "!";                    // יוצרים מחרוזת חדשה ומשימים חזרה
            Console.WriteLine(full);              // Hello World!

            // הבדל חשוב בין חיבור טקסט לבין חיבור מספרים
            string n1 = "12";
            string n2 = "30";
            Console.WriteLine(n1 + n2);                          // 1230
            Console.WriteLine(int.Parse(n1) + int.Parse(n2));    // 42
        }

        // דוגמה 8: חיפוש
        static void Demo8_Search()
        {
            Console.WriteLine("--- Demo 8: search ---");

            string s = "Hello World";

            Console.WriteLine(s.IndexOf('o'));       // 4  (המופע הראשון)
            Console.WriteLine(s.LastIndexOf('o'));   // 7  (המופע האחרון)
            Console.WriteLine(s.IndexOf("World"));   // 6  (אפשר לחפש גם מחרוזת שלמה)
            Console.WriteLine(s.IndexOf('z'));       // -1 (לא נמצא)
            Console.WriteLine(s.Contains("World"));  // True
        }

        // דוגמה 9: שילוב, חיפוש וחיתוך יחד
        static void Demo9_Combined()
        {
            Console.WriteLine("--- Demo 9: combined ---");

            Console.Write("Enter full name (first and last, with a space): ");
            string fullName = Console.ReadLine();

            int space = fullName.IndexOf(' ');                       // מוצאים את הרווח
            string firstName = fullName.Substring(0, space);         // כל מה שלפני הרווח
            string lastName = fullName.Substring(space + 1);         // כל מה שאחרי הרווח

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine(lastName + ", " + firstName);
        }
    }
}
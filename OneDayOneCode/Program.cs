using System;
using System.IO;

class Program
{
    static void Main()
    {
        string baseFolder = @"C:\Users\user1\Documents\תכנות שנה ג\פרויקטים שונים\OneDayOneCode";
        Directory.CreateDirectory(baseFolder);

        Console.WriteLine("התיקיות make here  כאן: " + Path.GetFullPath(baseFolder));

        for (int day = 1; day <= 30; day++)
        {
            string dayFolder = Path.Combine(baseFolder, $"Day{day:D2}");
            Directory.CreateDirectory(dayFolder);

            string solutionFile = Path.Combine(dayFolder, "solution.cs");
            File.WriteAllText(solutionFile, $"// Day {day:D2} solution\n\nclass Solution {{ }}");

            string testFolder = Path.Combine(dayFolder, "Tests");
            Directory.CreateDirectory(testFolder);
        }

        Console.WriteLine("✨ כל התיקיות נוצרו בהצלחה!");

        // פותח את התיקייה אוטומטית בסיום
        System.Diagnostics.Process.Start("explorer.exe", baseFolder);

        Console.ReadLine();
    }
}

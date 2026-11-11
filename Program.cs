
using System.Data.SQLite;
using SQLitePCL;
namespace haiandro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (!System.IO.File.Exists("test.db"))
            {
                SQLiteConnection.CreateFile("test.db");
                Console.WriteLine("データベースを生成しました。");
            }
            else
            {
                Console.WriteLine("データベースが存在しているため、生成しませんでした");
            }

            SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3;");

            using (SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE "Battle_History" (
	"ID"	INTEGER NOT NULL,
	"point"	INTEGER NOT NULL,
	"Date"	TEXT NOT NULL,
	PRIMARY KEY("ID")
);"))
            {
                
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Title());
        }
    }
}
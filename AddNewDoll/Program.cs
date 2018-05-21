using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace NewDoll
{
    class Program
    {
        static void Main(string[] args)
        {
            string DatafilePath;
            if (args.Length == 0)
            {
                DatafilePath = ".\\data.db";
            }
            else
            {
                DatafilePath = args[0];
            }
            if (!System.IO.File.Exists(DatafilePath))
            {
                Console.WriteLine("Usage: " + Application.ExecutablePath + " {Database name}");
                return;
            }

            string strConn = "Data Source=" + DatafilePath;
            var conn = new SQLiteConnection(strConn).OpenAndReturn();
            string sql = "SELECT * FROM dolls";
            SQLiteCommand cmd;
            try
            {
                cmd = new SQLiteCommand(sql, conn);
            }
            catch(SQLiteException)
            {
                Console.WriteLine("에러: 사용할 수 없는 데이터입니다.");
                conn.Close();
                return;
            }
            Doll NewDoll = new Doll();
            try
            {
                Console.WriteLine("인형 이름:");
                NewDoll.Name = Console.ReadLine();
                Console.WriteLine("인형 등급: (2~5)");
                NewDoll.Grade = int.Parse(Console.ReadLine());
                if (NewDoll.Grade < 2 && NewDoll.Grade > 5)
                    throw new Exception();
                Console.WriteLine("제조 시간: (0:00)");
                NewDoll.Time = Console.ReadLine();
                Console.WriteLine("인형 종류: (HG/SMG/AR/RF/MG)");
                NewDoll.Type = Console.ReadLine();
                if (!new string[] { "HG", "SMG", "AR", "RF", "MG"}.Contains(NewDoll.Type))
                    throw new Exception();
                Console.WriteLine("중형제조 전용?: (Y/N)");
                NewDoll.IsHeavy = (char.ToUpper(Console.ReadLine()[0]) == 'Y') ? true : false;
            }
            catch (Exception)
            {
                Console.WriteLine("작업 취소.");
                conn.Close();
                return;
            }

            sql = "INSERT INTO dolls VALUES('" + NewDoll.Name + "', " + NewDoll.Grade + ", '" + NewDoll.Time + "', '" + NewDoll.Type + "', '" + NewDoll.IsHeavy + "')";
            Console.WriteLine(sql);
            cmd = new SQLiteCommand(sql, conn);
            int result;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("작업 완료");
            conn.Close();
        }
    }

    public class Doll
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public bool IsHeavy { get; set; }
    }
}

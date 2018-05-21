using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace ProductionDB
{
    public partial class FrmMain
    {
        private void LoadDB()
        {
            string strConn = "Data Source=" + Application.StartupPath + "\\data.db";
            if (!System.IO.File.Exists("data.db"))
            {
                MessageBox.Show("데이터베이스 파일 \"data.db\"를 찾을 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            var conn = new SQLiteConnection(strConn).OpenAndReturn();
            string sql = "SELECT * FROM dolls";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("데이터베이스 파일 \"data.db\"가 유효하지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            while (reader.Read())
            {
                DollData.Add(new Doll
                {
                    Name = (string)reader["name"],
                    Grade = (int)reader["grade"],
                    Time = (string)reader["time"],
                    Type = (string)reader["type"],
                    IsHeavy = (bool)reader["isHeavy"]
                });
            }
            reader.Close();
            sql = "SELECT * FROM equipments";
            cmd = new SQLiteCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EquipmentData.Add(new Equipment
                {
                    Name = (string)reader["name"],
                    Grade = (int)reader["grade"],
                    Time = (string)reader["time"],
                    Type = (string)reader["type"],
                });
            }
            reader.Close();
            sql = "SELECT * FROM fairies";
            cmd = new SQLiteCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FairyData.Add(new Fairy
                {
                    Name = (string)reader["name"],
                    Time = (string)reader["time"],
                    Type = (string)reader["type"],
                });
            }
            conn.Close();
        }

        private string NumToStars(int count)
        {
            return new string('★', count);
        }

        private void Find_Doll()
        {
            string time = TxtHour.Text + ":" + (TxtMinute.Text.Length == 1 ? "0" + TxtMinute.Text : TxtMinute.Text);
            var query = from Doll in DollData
                        where Doll.Time.Equals(time)
                        select Doll;
            ListResult.Items.Clear();
            foreach (var doll in query)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    doll.Type + (doll.IsHeavy?"(중형)":""), NumToStars(doll.Grade), doll.Name });
                ListResult.Items.Add(item);
            }
        }

        private void Find_Equipment()
        {
            string time = TxtHour.Text + ":" + (TxtMinute.Text.Length == 1 ? "0" + TxtMinute.Text : TxtMinute.Text);
            var query = from Eqipment in EquipmentData
                        where Eqipment.Time.Equals(time)
                        select Eqipment;
            ListResult.Items.Clear();
            foreach (var equipment in query)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    equipment.Type, NumToStars(equipment.Grade), equipment.Name });
                ListResult.Items.Add(item);
            }
        }

        private void Find_Fariy()
        {
            string time = TxtHour.Text + ":" + (TxtMinute.Text.Length == 1 ? "0" + TxtMinute.Text : TxtMinute.Text);
            var query = from Fairy in FairyData
                        where Fairy.Time.Equals(time)
                        select Fairy;
            ListResult.Items.Clear();
            foreach (var fairy in query)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    fairy.Type, "요정", fairy.Name });
                ListResult.Items.Add(item);
            }
        }
    }
}

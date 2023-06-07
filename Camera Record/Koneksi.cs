using System.Data.OleDb;
using System.Windows.Forms;

namespace Camera_Record.Kelas
{
    class Koneksi
    {
        public static string pathDB = Application.StartupPath + @"\db\";
        public static OleDbConnection conn = new OleDbConnection("provider=Microsoft.ACE.OleDB.12.0; Data Source="+ pathDB + "\\dbsiswa.mdb");

    }
}

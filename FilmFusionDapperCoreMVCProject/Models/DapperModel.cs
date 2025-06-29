using Dapper;
using System.Data.SqlClient;

namespace FilmFusionDapperCoreMVCProject.Models
{
    public class DapperModel
    {
        public static string connectionString = "Server=DESKTOP-V7IDV6Q\\SQLEXPRESS01; Initial Catalog=FilmFusion; Integrated Security=True;";



        // Ekleme silme güncelleme
        //Sadece işlem yapar ama geriye nesne ya da liste dönmez.
        public static void Operations(string procedureName, DynamicParameters parameters = null)
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                db.Execute(procedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        //DynamicParameters, used with Dapper library
        //Veri listelemek (SELECT)
        //Belirli kriterlere göre veri sorgulamak
        //Geriye bir nesne listesi(IEnumerable<T>) döndürmek
        public static IEnumerable<T> List<T>(string procedureName, DynamicParameters parameters = null)
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                return db.Query<T>(procedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }


    }
}

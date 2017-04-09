using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Ecommers.DL
{
    public class DBC
    {
        //"Data Source=SQL5032.SmarterASP.NET;Initial Catalog=DB_A1DF92_arartawil;User Id=DB_A1DF92_arartawil_admin;Password=YOUR_DB_PASSWORD;"
        //public static readonly SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Ecommers;Integrated Security=True");
        public static readonly SqlConnection conn = new SqlConnection(@"Data Source = SQL5032.SmarterASP.NET; Initial Catalog = DB_A1DF92_arartawil; User Id = DB_A1DF92_arartawil_admin; Password=sunflor1996;");
    }
}

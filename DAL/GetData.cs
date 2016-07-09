using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class GetData:DAO
    {
        DataTable dataTable = new DataTable();

        public DataTable GetPlayersFromDbForListPlayersDatagrid()
        {
            SqlCommand getPlayers = new SqlCommand("Select PlayerId,PlayerFirstName,PlayerLastName,PlayerHandicap,PlayerAdjust,PlayerJoinDate from Player", OpenDbConnection());
            SqlDataReader dataReader = getPlayers.ExecuteReader();
            dataTable.Load(dataReader);
            CloseDbConnnection();

            return dataTable;
        }
    }
}

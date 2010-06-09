using System.Data.Common;

namespace Example
{
    public class CustomerDAL
    {
        public DbConnection Database { get; set; }

        public CustomerDAL(DbConnection database)
        {
            Database = database;
        }

        public void SendReminders()
        {
            DbCommand dbCommand = Database.CreateCommand();
            dbCommand.CommandText = "Do something...";
            dbCommand.ExecuteNonQuery();
        }
    }
}

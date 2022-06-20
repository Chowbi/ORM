namespace ORM
{

    public enum DbEngine
    {
        MySql,
        MsSql,
        PSql
    }
    public class DBConnectionInfo
    {
        public string ConnectionString { get; }
        public DbEngine Engine { get; set; }
        public string? ServerName { get; set; }
        public string? InitialCatalog { get; set; }

        public DBConnectionInfo(DbEngine engine, string connectionString, string? serverName = null, string? initialCatalog = null)
        {
            ConnectionString = connectionString;
            Engine = engine;
            ServerName = serverName;
            InitialCatalog = initialCatalog;
        }
    }
}
using System.Collections.Generic;
namespace WebApi
{
    public class ConnectionInfo
    {
        public List<Connection> Connections { get; set; }
    }

    public class Connection{
        public string ConnectionName { get; set; }
        public string ConnectionString { get; set; }
    }
}
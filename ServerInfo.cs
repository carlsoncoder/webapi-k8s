using System;

namespace webapi_k8s
{
    public class ServerInfo
    {
        public ServerInfo(int id)
        {
            this.ID = id;
            this.Timestamp = DateTime.UtcNow;
            this.NodeName = Environment.GetEnvironmentVariable("NODE_NAME");
            this.PodName = Environment.GetEnvironmentVariable("POD_NAME");
        }

        public int ID
        {
            get;
            private set;
        }

        public DateTime Timestamp
        {
            get;
            private set;
        }

        public string NodeName
        {
            get;
            private set;
        }

        public string PodName
        {
            get;
            private set;
        }
    }
}

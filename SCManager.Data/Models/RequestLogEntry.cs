using System;

namespace SCManager.Data.Models
{
    public class RequestLogEntry
    {
        public int Id { get; set; }

        public string IpAddress { get; set; }

        public string Path { get; set; }

        public string QueryString { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
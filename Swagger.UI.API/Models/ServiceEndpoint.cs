using System;

namespace Swagger.UI.TecUnica.Models
{
    public class ServiceEndpoint
    {
        public String Name { get; set; }
        public Uri Url { get; set; }
        public int Timeout { get; set; }
        public Boolean Default { get; set; }
    }
}

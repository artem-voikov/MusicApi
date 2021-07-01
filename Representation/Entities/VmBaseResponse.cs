using System.Net;

namespace MusicApi.Representation.Entities
{
    public class VmBaseResponse
    {
        public HttpStatusCode HttpStatusCode {get;set;}
        public string Title {get;set;}
        public string Message {get;set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masha.Models
{
    public class AlisaRequestModel
    {
        public Meta Meta { get; set; }
        public Request Request { get; set; }
        public Session Session { get; set; }
        public string Version { get; set; }
    }

    public class Meta
    {
        public string Locale { get; set; }
        public string Timezone { get; set; }
        public string ClientId { get; set; }
    }

    public class Request
    {
        public string Command { get; set; }
        public string OriginalUtterance { get; set; }
        public string Type { get; set; }
        public Markup Markup { get; set; }
    }

    public class Markup
    {
        public bool DangerousContext { get; set; }
    }

    public class Session
    {
        public bool New { get; set; }
        public int MessageId { get; set; }
        public string SessionId { get; set; }
        public string SkillId { get; set; }
        public string UserId { get; set; }
    }
}

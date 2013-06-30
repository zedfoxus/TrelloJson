using System;
using System.Collections.Generic;

namespace TrelloJson
{
    class Attachment
    {
        public string Id { get; set; }
        public List<Preview> Previews { get; set; }
        public string Bytes { get; set; }
        public DateTime Date { get; set; }
        public string IdMember { get; set; }
        public string IsUpload { get; set; }
        public string MimeType { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}

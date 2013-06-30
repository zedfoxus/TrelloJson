using System;

namespace TrelloJson
{
    class Action
    {
        public string Id { get; set; }
        public string IdMemberCreator { get; set; }
        public Data Data { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public Member MemberCreator { get; set; }
    }
}

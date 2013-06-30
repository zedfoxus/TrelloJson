using System.Collections.Generic;

namespace TrelloJson
{
    class CheckList
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdBoard { get; set; }
        public string IdCard { get; set; }
        public string Pos { get; set; }
        public List<CheckItem> CheckItems { get; set; }
    }
}

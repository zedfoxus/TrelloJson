using System;
using System.Collections.Generic;
using System.Globalization;

namespace TrelloJson
{
    class Card
    {
        public string Id { get; set; }
        public Badge Badges { get; set; }
        public List<CheckItemState> CheckItemStates { get; set; }
        public string Closed { get; set; }
        public DateTime DateLastActivity { get; set; }
        public string Desc { get; set; }
        public string Due { get; set; }
        public string IdBoard { get; set; }
        public string[] IdCheckLists { get; set; }
        public string IdList { get; set; }
        public string[] IdMembers { get; set; }
        public string[] IdMembersVoted { get; set; }
        public string IdShort { get; set; }
        public string IdAttachmentCover { get; set; }
        public string ManualCoverAttachment { get; set; }
        public List<Label> Labels { get; set; }
        public string Name { get; set; }
        public string Pos { get; set; }
        public string ShortUrl { get; set; }
        public string Subscribed { get; set; }
        public string Url { get; set; }
        public List<Attachment> Attachments { get; set; }


        /// <summary>
        /// Format card information
        /// </summary>
        /// <returns>Formattetd string representation of card object</returns>
        public override string ToString()
        {
            // since created date is not available, it will either be calculated 
            // from the name of the card or the last activity date will be 
            // treated as creation date. My personal nomenclature is to use 
            // YYYYMMDD-ID nomenclature on certain cards to indicate when the
            // card was created. For example, some of my cards would read
            // 20120531-14. This would mean that the card is 14th for 2013-05-31
            string created;
            if (Name.StartsWith("201"))
            {
                try
                {
                    created = (Name.Length > 8) ? DateTime.Parse(string.Join("-", new[]
                    {
                        Name.Substring(0, 4),
                        Name.Substring(4, 2),
                        Name.Substring(6, 2)
                    })).ToShortDateString() : "";
                }
                catch
                {
                    created = DateLastActivity.ToShortDateString();
                }
            }
            else
            {
                created = DateLastActivity.ToShortDateString();
            }

            return string.Join("|", new[]
                {
                    Name.Replace(Environment.NewLine,""),
                    created,
                    DateLastActivity.ToString(CultureInfo.InvariantCulture),
                    Closed
                });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace TrelloJson
{
    class Trello
    {
        // if this class only had Id property, JavaScriptSerializer
        // will only populate this property. All other JSON information
        // for this node will be ingored. If Trello export has more 
        // variables than we have listed here, we can simply come
        // back to this class and add the new property.

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Closed { get; set; }
        public string IdOrganization { get; set; }
        public string Invited { get; set; }
        public string Pinned { get; set; }
        public string Url { get; set; }
        public Pref Prefs { get; set; }

        // TODO: public ... Invitations { get; set; }
        public List<Membership> Memberships { get; set; }
        public string ShortUrl { get; set; }
        public string Subscribed { get; set; }
        public LabelName LabelNames { get; set; }
        public DateTime DateLastActivity { get; set; }
        public DateTime DateLastView { get; set; }
        public List<List> Lists { get; set; }
        public List<Member> Members { get; set; }
        public List<Card> Cards { get; set; }
        public List<CheckList> CheckLists { get; set; }
        public List<Action> Actions { get; set; }


        /// <summary>
        /// Return name of the list given its ID
        /// </summary>
        /// <param name="id">ID of a list</param>
        /// <returns>Name of the list</returns>
        public string ListName(string id)
        {
            foreach (var list in Lists.Where(list => list.Id == id))
            {
                return list.Name;
            }
            return "";
        }
    }
}

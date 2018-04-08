using System.Collections.Generic;
using Olyfaunt.Abstractions;


namespace Olyfaunt.Utilities
{
    /**
     * This class is the client side class for the user. 
     * User data will be gathered from the server database and then stored in this wrapper class.
     * 
     * This class exists for organizational purposes.
     **/
    public class User : TableData
    {
        public string Username { get; set; }
        public string Bio { get; set; }
        public List<string> Needs { get; private set; }
        public List<string> Wants { get; private set; }
        public List<string> Likes { get; private set; }

        public void AddNeed(string need)
        {
            Needs.Add(need);
        }
            
        public void AddWant (string want)
        {
            Wants.Add(want);
        }

        public void AddLike(string like)
        {
            Likes.Add(like);
        }
    }
}

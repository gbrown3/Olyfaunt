using Xamarin.Forms;
using System.Collections.Generic;
using Olyfaunt.Abstractions;


namespace Olyfaunt
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
        public Image profileImage { get; set; }


        public User(string picpath)
        {
            profileImage = new Image { Source = picpath };
            Needs = new List<string>();
            Wants = new List<string>();
            Likes = new List<string>();
        }
        public User()
        {
            profileImage = new Image { Source = "default_profile_pic.png" };
            Needs = new List<string>();
            Wants = new List<string>();
            Likes = new List<string>();
        }

        public void AddNeed(string need)
        {
            Needs.Add(need);
        }

        public void AddWant(string want)
        {
            Wants.Add(want);
        }

        public void AddLike(string like)
        {
            Likes.Add(like);
        }
    }
}

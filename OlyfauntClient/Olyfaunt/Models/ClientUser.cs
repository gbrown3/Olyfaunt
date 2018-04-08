using System;
using System.Collections.Generic;
using System.Text;

namespace Olyfaunt.Utilities
{
    /**
     * This class is the client side class for the user. 
     * User data will be gathered from the server database and then stored in this wrapper class.
     * 
     * This class exists for organizational purposes.
     **/
    public class ClientUser
    {
        private string UserID;
        private string UserName;
        private string BIO;
        private List<string> Needs;
        private List<string> Wants;
        private List<string> Likes;

        /**
         * This constructor takes in a UserID and UserName and initializes all necessary variables.
         * 
         **/
        public ClientUser(string UserID, string UserName)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.BIO = "";

            this.Likes = new List<string>();
            this.Wants = new List<string>();
            this.Needs = new List<string>();
        }

        public void AddNeeds(List<string> Needs)
        {
            foreach (string Need in Needs)
                this.Needs.Add(Need);
        }

        public void AddWants(List<string> Wants)
        {
            foreach (string Want in Wants)
                this.Wants.Add(Want);
        }

        public void AddLikes(List<string> Likes)
        {
            foreach (string Like in Likes)
                this.Likes.Add(Like);
        }

        public List<string> GetNeeds() { return Needs; }
        public List<string> GetWants() { return Wants; }
        public List<string> GetLikes() { return Likes; }

        public void SetUserName(string UserName) {this.UserName = UserName;}
        public string GetUserName() {return UserName;}
        public void SetUserID(string UserID) {this.UserID = UserID;}
        public string GetUserID() {return UserID;}
        public void SetBIO(string BIO) {this.BIO = BIO;}
        public string GetBIO() {return BIO;}
    }
}

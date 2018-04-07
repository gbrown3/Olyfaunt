using System;
namespace Olyfaunt.UIElements
{
    /// <summary>
    /// UI element to use when looking at lists of users
    /// </summary>
    public class UserUIElement
    {
        private string displayName;    // internal storage of displayName
        private string username;

        public string DisplayName 
        {
            get 
            {
                return this.displayName;
            }
        }
        public string Username
        {
            get
            {
                return this.username;
            }
        }


        public UserUIElement(string username)
        {
            this.username = username;

            // Get info from server about display name

            // Get info from server about profile
        }
    }
}

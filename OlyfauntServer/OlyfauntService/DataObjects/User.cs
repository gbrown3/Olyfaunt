using Microsoft.Azure.Mobile.Server;

namespace OlyfauntService.DataObjects
{
    public class User : EntityData
    {
        public int UserID { get; set; }
        public string Username { get; set; }

    }
}
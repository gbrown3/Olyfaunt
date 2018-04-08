using Microsoft.Azure.Mobile.Server;

namespace OlyfauntService.DataObjects
{
    public class User : EntityData
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Bio { get; set; }

    }
}
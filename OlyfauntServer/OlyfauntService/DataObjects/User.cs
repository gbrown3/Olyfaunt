using Microsoft.Azure.Mobile.Server;

namespace OlyfauntService.DataObjects
{
    public class User : EntityData
    {
        public string Username { get; set; }
        public string Bio { get; set; }
	public List<string> Needs { get; set; }
	public List<string> Wants { get; set; }
	public List<string> Likes { get; set; }
    }
}
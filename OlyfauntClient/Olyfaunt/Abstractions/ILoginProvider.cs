using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Olyfaunt.Abstractions
{
    public interface ILoginProvider
    {
        Task LoginAsync(MobileServiceClient client);
    }
}

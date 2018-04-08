using System.Collections.Generic;
using System.Threading.Tasks;

namespace Olyfaunt.Abstractions
{
    public interface ICloudTable<T> where T : TableData
    {
        Task<T> CreateItemAsync(T item);
        Task<T> ReadItemAsync(string id);
        Task<T> UpdateItemAsync(T item);
        Task DestroyItemAsync(T item);

        Task<ICollection<T>> ReadAllItemsAsync();
    }
}

using NewsPaperSubscribe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPaperSubscribe.Repository.NewsPaperSubscribe
{
    public interface INewsPaperSubscribeRepository
    {
        Task AddClientAsync(ClientDetails addClient);
        Task<IEnumerable<ClientDetails>> GetAllClientsDetailAsync();
        Task<ClientDetails> GetClientByIdAsync(int id);
        Task<bool> IsClientExistsAsync(int id);
        Task EditClientAsync(ClientDetails updateClient);
        Task DeleteClientAsync(ClientDetails removeClient);
    }
}

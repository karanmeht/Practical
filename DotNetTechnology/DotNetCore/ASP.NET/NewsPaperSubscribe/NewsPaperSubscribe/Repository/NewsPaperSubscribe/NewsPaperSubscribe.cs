using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPaperSubscribe.Models;
using Microsoft.EntityFrameworkCore;

namespace NewsPaperSubscribe.Repository.NewsPaperSubscribe
{
    public class NewsPaperSubscribeRepository : INewsPaperSubscribeRepository
    {
        private readonly NewsPaperDbContext _DbContext;

        public NewsPaperSubscribeRepository(NewsPaperDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task AddClientAsync(ClientDetails addClient)
        {
            _DbContext.ClientDetails.Add(addClient);
            await _DbContext.SaveChangesAsync();
        }

        public async Task DeleteClientAsync(ClientDetails removeClient)
        {
            _DbContext.ClientDetails.Remove(removeClient);
            await _DbContext.SaveChangesAsync();
        }

        public async Task EditClientAsync(ClientDetails updateClient)
        {
            _DbContext.ClientDetails.Update(updateClient);
            await _DbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ClientDetails>> GetAllClientsDetailAsync()
        {
            return (await _DbContext.ClientDetails.ToListAsync());
        }

        public async Task<ClientDetails> GetClientByIdAsync(int id)
        {
            return (await _DbContext.ClientDetails.FirstOrDefaultAsync(x => x.Id == id));
        }

        public async Task<bool> IsClientExistsAsync(int id)
        {
            return (await _DbContext.ClientDetails.AnyAsync(x => x.Id == id));
        }
    }
}

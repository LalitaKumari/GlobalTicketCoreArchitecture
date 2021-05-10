using GlobalTicket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}

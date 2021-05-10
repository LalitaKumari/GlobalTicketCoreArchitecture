using GlobalTicket.Application.Contracts.Persistence;
using GlobalTicket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(GloboTicketDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
        {
            var allcategories = await _dbContext.Categories.Include(x => x.Events).ToListAsync();
            if(!includePassedEvents)
            {
                allcategories.ForEach(x => x.Events.ToList().RemoveAll(y => y.Date < DateTime.Today));
            }
            return allcategories;
        }
    }
}

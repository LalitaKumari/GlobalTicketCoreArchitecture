using AutoMapper;
using GlobalTicket.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQueryHandler : IRequestHandler<GetCategoriesListWithEventsQuery, List<CategoryEventListVm>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoriesListWithEventsQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public  async Task<List<CategoryEventListVm>> Handle(GetCategoriesListWithEventsQuery request, CancellationToken cancellationToken)
        {
            var list = await _categoryRepository.GetCategoriesWithEvents(request.IncludeHistory);
            return _mapper.Map<List<CategoryEventListVm>>(list);
        }
    }
}

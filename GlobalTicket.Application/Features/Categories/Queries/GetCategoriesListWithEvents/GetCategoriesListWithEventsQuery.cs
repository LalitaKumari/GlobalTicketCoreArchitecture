﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery : IRequest<List<CategoryEventListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}

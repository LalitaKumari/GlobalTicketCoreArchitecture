using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.Application.Features.Events.Queries.GetEventList
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {

    }
}

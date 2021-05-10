using AutoMapper;
using GlobalTicket.Application.Contracts.Persistence;
using GlobalTicket.Application.Exceptions;
using GlobalTicket.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;
        public DeleteEventCommandHandler(IAsyncRepository<Event> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.EventId);
            if(@event == null)
            {
                throw new NotFoundException(nameof(Event), request.EventId);
            }
            await _eventRepository.DeleteAsync(@event);

            return Unit.Value;
        }
    }
}

using AutoMapper;
using GlobalTicket.Application.Features.Categories.Commands.CreateCategory;
using GlobalTicket.Application.Features.Categories.Queries.GetCategoriesList;
using GlobalTicket.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GlobalTicket.Application.Features.Events.Commands.CreateEvent;
using GlobalTicket.Application.Features.Events.Commands.UpdateEvent;
using GlobalTicket.Application.Features.Events.Queries.GetEventDetail;
using GlobalTicket.Application.Features.Events.Queries.GetEventList;
using GlobalTicket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
        }
    }
}

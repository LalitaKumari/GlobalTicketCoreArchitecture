using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand: IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
    }
}

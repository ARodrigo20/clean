using AutoMapper;
using AutoMapper.QueryableExtensions;
using Hsec.Application.Common.Interfaces;
using Hsec.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hsec.Application.TodoItems.Queries.GetTodos
{
    public class GetTodosQuery : IRequest<TodosViewModel>
    {
        public class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, TodosViewModel>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetTodosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<TodosViewModel> Handle(GetTodosQuery request, CancellationToken cancellationToken)
            {
                var vm = new TodosViewModel();

                //vm.Lists = await _context.TodoItems
                //    .ProjectTo<TodoItemDto>(_mapper.ConfigurationProvider)
                //    .OrderBy(t => t.Title)
                //    .ToListAsync(cancellationToken);

                vm.PriorityLevels =
                    Enum.GetValues(typeof(PriorityLevel))
                        .Cast<PriorityLevel>()
                        .Select(p => new PriorityLevelDto { Value = (int)p, Name = p.ToString() })
                        .ToList();
                //var newDTO = new 
                //var asd = 
                return vm;
            }
        }
    }
}

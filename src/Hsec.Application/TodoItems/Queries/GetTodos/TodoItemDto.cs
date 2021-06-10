using AutoMapper;
using Hsec.Application.Common.Mappings;
using Hsec.Domain.Entities;
using Hsec.Domain.Enums;

namespace Hsec.Application.TodoItems.Queries.GetTodos
{
    public class ObservacionDto /*: IMapFrom<TodoItem>*/
    {
        public long Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public bool Done { get; set; }

        public int Priority { get; set; }

        public string Note { get; set; }

        public string PriorityString { get; set; }

        public PriorityLevelDto PriorityLevelDto { get; set; }

        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<TodoItem, TodoItemDto>()
        //        .ForMember(d => d.Priority, opt => opt.MapFrom(s => (int)s.Priority))
        //        .ForMember(d => d.PriorityLevelDto, opt => opt.MapFrom(s => s.Priority));
        //    // profile.CreateMap<TodoItem, TodoItemDto>().ConvertUsing(value => { new TodoItemDto() });
        //}

    }
}

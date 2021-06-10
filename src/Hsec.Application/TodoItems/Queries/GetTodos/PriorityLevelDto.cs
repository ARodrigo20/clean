using AutoMapper;
using Hsec.Application.Common.Mappings;
using Hsec.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hsec.Application.TodoItems.Queries.GetTodos
{
    public class PriorityLevelDto: IMapFrom<PriorityLevel>
    {
        public int Value { get; set; }

        public string Name { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<PriorityLevel, PriorityLevelDto>();
                //.ForMember(m => m.Name, opt => opt.MapFrom(f => f.));
        }
    }
}

using System.Collections.Generic;

namespace Hsec.Application.TodoItems.Queries.GetTodos
{
    public class TodosViewModel
    {
        public IList<PriorityLevelDto> PriorityLevels { get; set; }

        public IList<ObservacionDto> Lists { get; set; }
    }
}

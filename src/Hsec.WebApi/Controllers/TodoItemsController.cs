
using System.Threading.Tasks;
using Hsec.Application.TodoItems.Queries.GetTodos;
using Microsoft.AspNetCore.Mvc;

namespace Hsec.WebApi.Controllers
{    
    public class TodoItemsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<TodosViewModel>> Get()
        {
            return await Mediator.Send(new GetTodosQuery());
        }
    }
}

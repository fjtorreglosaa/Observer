using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Observer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class AbstractController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator
        {
            get
            {
                if (_mediator == null)
                {
                    _mediator = HttpContext.RequestServices.GetRequiredService<IMediator>();
                }
                return _mediator;
            }
        }
    }
}

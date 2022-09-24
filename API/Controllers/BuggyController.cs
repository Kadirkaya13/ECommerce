using API.Errors;
using API.Infrastructure.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {

            return NotFound(new ApiResponse(404));
        }

        [HttpGet("servererror")]
        public ActionResult GetNotServerError()
        {

            return NotFound(new ApiResponse(500));
        }
        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {

            return NotFound(new ApiResponse(400));
        }
        [HttpGet("badrequest/{id}")]
        public ActionResult GetNotFoundRequest(int id)
        {

            return NotFound(new ApiResponse(400));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace EStudy.Web.App.Responses
{
    public class ErrorApiVersioningResponse : IErrorResponseProvider
    {
        public IActionResult CreateResponse(ErrorResponseContext context)
        {
            return new BadRequestObjectResult(new { error = context.Message, desc = context.MessageDetail });
        }
    }
}

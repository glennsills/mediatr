using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System;
using System.Net;

namespace SampleWeb;

public class FeatureApiExceptionHandler: ExceptionFilterAttribute
{
    public override Task OnExceptionAsync(ExceptionContext context)
    {
        var exceptionType = context.Exception.GetType().ToString();
        if (context.Exception.GetType() == typeof(ValidationException))
        {
            var result = JsonConvert.SerializeObject(((ValidationException)context.Exception).Message);
            var details = new ProblemDetails()
            {
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                Title = "Request Validation Error.",
                Detail = JsonConvert.SerializeObject(((ValidationException)context.Exception).Message)
            };

            context.Result = new BadRequestObjectResult(details);

            context.ExceptionHandled = true;
        }
        else
        {
            var details = new ProblemDetails()
            {
                Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
                Title = "Internal Server Error"
            };
            context.Result = new ObjectResult(details) { StatusCode = 500 };
            context.ExceptionHandled = true;
        }
      return base.OnExceptionAsync(context);
    }
}

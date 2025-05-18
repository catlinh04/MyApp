using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace MyApp.Application.Exceptions
{
    // public class ValidationException : ApplicationException
    // {
    //     public List<string> Errors { get; set; } = new List<string>();

    //     public ValidationException(ValidationResult validationResult)
    //     {
    //         foreach (var error in validationResult.Errors)
    //         {
    //             Errors.Add(error.ErrorMessage);
    //         }
    //     }
    // }

    public class ValidationException : BaseException
    {
        public IDictionary<string, string[]> Errors { get; }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : base("One or more validation failures have occurred.", HttpStatusCode.BadRequest)
        {
            Errors = failures
                .GroupBy(e => e.PropertyName)
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(e => e.ErrorMessage).ToArray()
                );
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace errorhandling_problemdetails.Custom_Exceptions
{
    public class ProductNotFoundDetails : ProblemDetails
    {
        public string AdditionalInfo { get; set; }
    }
}

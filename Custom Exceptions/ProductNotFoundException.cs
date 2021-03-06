using System;

namespace errorhandling_problemdetails.Custom_Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public string AdditionalInfo { get; set; }
        public string Type { get; set; }
        public string Detail { get; set; }
        public string Title { get; set; }
        public string Instance { get; set; }

        public ProductNotFoundException(string instance)
        {
            Type = "product-not-found";
            Detail = "The product you are looking for is missing.";
            Title = "Product not found";
            AdditionalInfo = "Maybe you can buy some of our other simmilar products instead?";
            Instance = instance;
        }
    }
}





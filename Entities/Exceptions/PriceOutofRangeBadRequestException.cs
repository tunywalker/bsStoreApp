namespace Entities.Exceptions
{
	public abstract partial class BadRequestExtension
	{
		public class PriceOutofRangeBadRequestException:BadRequestExtension
        {
            public PriceOutofRangeBadRequestException():base("Maximum price should be less than 1000 and greater than 10")
            {
                
            }
        }
    }
}

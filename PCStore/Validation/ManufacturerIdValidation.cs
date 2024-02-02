using PCStore.Models.Requests;
using FluentValidation;

namespace PCStore.Validation
{
    public class ManufacturerIdValidation : AbstractValidator
        <GetAllProductsFromManufacturerRequest>
    {
        public ManufacturerIdValidation()
        {
            RuleFor(x => x.ManufacturerId)
                .NotNull()
                .GreaterThan(0).WithMessage("ManufacturerId cannot be less than 0")
                .LessThan(5).WithMessage("ManufacturerId cannot be larger than 5");

            RuleFor(x => x.DateAfter)
                .NotNull()
                .NotEmpty().WithMessage("You need to insert a date!")
                .LessThan(DateTime.Now).WithMessage("Date cannot be later than today!");
        }
    }
}

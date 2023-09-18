using FluentValidation;

namespace Observer.Application.Features.WarehouseFeatures.Commands.CreateWarehouse
{
    public class CreateWarehouseCommandValidator : AbstractValidator<CreateWarehouseCommand>
    {
        public CreateWarehouseCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Field Name is mandatory");
            RuleFor(x => x.Identifier).NotEmpty().WithMessage("Field Identifier is mandatory");
        }
    }
}

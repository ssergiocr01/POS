using FluentValidation;
using POS.Application.Dtos.Requests;

namespace POS.Application.Validators.Category
{
    public class CategoryValidation : AbstractValidator<CategoryRequestDto>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("El campo nombre no puede ser nulo")
                .NotEmpty().WithMessage("El campo nombre no puede estar vacío");
        }
    }
}

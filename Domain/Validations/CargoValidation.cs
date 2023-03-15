using Domain.ViewModel;
using FluentValidation;

namespace Domain.Validations
{
    public class CargoValidation : AbstractValidator<CargoViewModel>
    {
        public CargoValidation()
        {
            RuleFor(w => w.Descricao)
                .NotNull().NotEmpty().WithMessage("Descrição deve ser preenchida.");

            RuleFor(w => w.Descricao)
                .MinimumLength(4).WithMessage("Descrição deve ter no minimo 4 caracteres.");

            RuleFor(w => w.Descricao)
               .MaximumLength(30).WithMessage("Descrição deve ter no maximo 30 caracteres.");
        }
    }
}
using Domain.Models;
using Domain.ViewModel;
using FluentValidation;

namespace Domain.Validations
{
    public class FuncionarioValidation : AbstractValidator<FuncionarioViewModel>
    {
        public FuncionarioValidation()
        {
            RuleFor(w => w.Nome)
                .NotEmpty().NotNull().WithMessage("Nome é obrigatório.");

            RuleFor(w => w.Nome)
                .MinimumLength(3).WithMessage("Nome deve ter no minimo 3 caracteres.");

            RuleFor(w => w.Nome)
                .MaximumLength(50).WithMessage("Nome deve ter no maximo 50 caracteres.");

            RuleFor(w => w.DataNascimento)
               .NotEmpty().NotNull().WithMessage("Data de Nascimento é obrigatório.");

            RuleFor(w => w.CargoId)
               .NotEmpty().NotNull().WithMessage("Cargo é obrigatório.");
        }
    }
}
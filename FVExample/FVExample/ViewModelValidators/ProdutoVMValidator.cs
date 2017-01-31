using System;
using FluentValidation;
using FVExample.ViewModels;

namespace FVExample.ViewModelValidators
{
    public class ProdutoVMValidator : AbstractValidator<ProdutoVM>
    {
        public ProdutoVMValidator()
        {
            RuleFor(x => x.Nome)
               .NotEmpty().WithMessage("O campo nome deve ser informado")
               .Length(3, 150).WithMessage("O campo nome deve ter entre 3 e 150 caracteres");

            RuleFor(c => c.Tipo)
                .NotEmpty().WithMessage("O campo tipo deve ser informado")
                .Must(TipoNaoPodeSerTeste).WithMessage("O tipo do produto não pode ser igual a Teste");

            RuleFor(c => c.Data)
                .NotEmpty().WithMessage("O campo data deve ser informado");

        }
        private static bool TipoNaoPodeSerTeste(string tipo)
        {
            return tipo != "Teste";
        }
    }
}
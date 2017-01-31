using System;
using FluentValidation.Attributes;
using FVExample.ViewModelValidators;

namespace FVExample.ViewModels
{
    [Validator(typeof(ProdutoVMValidator))]
    public class ProdutoVM
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
    }
}
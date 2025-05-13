using Cadastro.Application.ViewModels;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Factories
{
    public static class CepFactory
    {
        public static CepViewModel CreateCepFactory(CepEntity entity)
        {
            return new CepViewModel(entity.Cep, entity.Logradouro, entity.Complemento, entity.Unidade, entity.Bairro, entity.Localidade, entity.Uf, entity.Estado, entity.Regiao, entity.Ibge, entity.Gia, entity.Ddd, entity.Siafi);
        }
    }
}

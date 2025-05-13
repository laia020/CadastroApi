using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.ViewModels
{
public record class CepViewModel(string? Cep, string? Logradouro, string? Complemento, string? Unidade, string? Bairro, string? Localidade, string? Uf, string? Estado, string? Regiao, string? Ibge, string? Gia, string? Ddd, string? Siafi);
        
}

using Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Interfaces
{
    public interface ICepAppServices
    {
        CepViewModel SearchCep(string cep);

    }
}

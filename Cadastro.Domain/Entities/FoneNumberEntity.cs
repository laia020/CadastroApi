using Cadastro.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class FoneNumberEntity: Identity<int>
    {
        public string? Ddi { get; set; }
        public string? Ddd { get; set; }
        public string? Number { get; set; }
        public int UserId { get; set; }
        public UserEntity? User { get; set; }
    }
}

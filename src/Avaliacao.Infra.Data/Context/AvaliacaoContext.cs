using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Infra.Data.Context
{
  public  class AvaliacaoContext : DbContext
    {
        public AvaliacaoContext() : base("AvaliacaoUIWebContext")
        {

        }
    }
}

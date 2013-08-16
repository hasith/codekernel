using Codekernel.Data.Core;
using Codekernel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codekernel.Data.Repos
{
    internal class ProductRepository: Repository<Product>
    {
        public ProductRepository(DbContext context) : base(context) { }

        /* override any method to provide custom behaviour */
        //public override Product Update(Product entityToUpdate) { return null; }
    }
}

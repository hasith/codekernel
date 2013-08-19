using Codekernel.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codekernel.API.ApiModel
{
    public class PublicProduct: IIdentifier
    {
        public int Id { get; set; }

        public Guid GUID { get; set; }

        public byte[] RowVersion { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public ProductDetails Details { get; set; }
    }

    public class ProductDetails {
        public string SupplierName { get; set; }
    }
}
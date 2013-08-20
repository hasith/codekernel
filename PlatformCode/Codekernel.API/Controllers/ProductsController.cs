using Codekernel.API.ApiModel;
using Codekernel.API.Core;
using Codekernel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.OData.Query;

namespace Codekernel.API.Controllers
{
    public class ProductsController : CrudController<Product, PublicProduct>
    {
        /// <summary>
        /// Navigation property to return custom attributes of a particulat product.
        /// e.g. GET /rest/Products(4)/Details
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<ProductDetail> GetDetails(int key)
        {
            return new List<ProductDetail>() {
                new ProductDetail() { Title = "Product is sole with warantee" },
                new ProductDetail() { Title = "Limited in stocks" }
            };
        }

        protected override PublicProduct ConvertToApiType(Product dbEntity)
        {
            return new PublicProduct() { 
                Id = dbEntity.Id,
                RowVersion = dbEntity.RowVersion,
                GUID = dbEntity.GUID,
                Name = dbEntity.Name,
                Price = dbEntity.Price,
            };
        }

        protected override Product ConvertToDbType(PublicProduct apiEntity)
        {
            return new Product() { 
                Id = apiEntity.Id,
                GUID = apiEntity.GUID,
                RowVersion = apiEntity.RowVersion,
                Name = apiEntity.Name,
                Price = apiEntity.Price
            };
        }

        protected override IQueryable<PublicProduct> ConvertToApiQueryable(IQueryable<Product> dbQueryable)
        {
            return dbQueryable.Select(dbEntity => new PublicProduct()
            {
                Id = dbEntity.Id,
                Name = dbEntity.Name,
                GUID = dbEntity.GUID,
                Price = dbEntity.Price,
                RowVersion = dbEntity.RowVersion,
            });
        }
    }
}
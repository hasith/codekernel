using Codekernel.Data;
using Codekernel.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.OData;

namespace Codekernel.API.Core
{
    public class UowController<ApiType> : EntitySetController<ApiType, int> where ApiType : class, IIdentifier
    {
        protected IUnitOfWork UnitOfWork { get; set; }

        public UowController()
        {
            UnitOfWork = UowFactory.Create("DefaultConnection");
        }

        protected override void Dispose(bool disposing)
        {
            UnitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}
using Codekernel.API.ApiModel;
using Codekernel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.OData.Builder;

namespace Codekernel.API
{
    public class RestApiModelBuilder : ODataConventionModelBuilder
    {

        public RestApiModelBuilder() 
        {
            EntitySet<PublicProduct>("Products");
            EntitySet<Supplier>("Suppliers");
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud.Web.Helpers
{
    public class CrudContext : CRUDEntities
    {
        public CrudContext() {
            this.Configuration.EnsureTransactionsForFunctionsAndCommands = false;
        }
    }
}
using System;
using AutoService.Data;

namespace AutoService.Core.Manager
{
    public abstract class ManagerBase
    {

        protected readonly DbContext Context;

        public ManagerBase(DbContext context) {
            Context = context;
        }

        public ManagerBase(ManagerBase manager) {
            Context = manager.Context;
        }

        
    }
}

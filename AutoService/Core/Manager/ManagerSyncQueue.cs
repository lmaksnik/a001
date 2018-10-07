using System;
using AutoService.Data;

namespace AutoService.Core.Manager
{
    public class ManagerSyncQueue : ManagerBase
    {
        public ManagerSyncQueue(DbContext context) : base(context)
        {
        }

        public ManagerSyncQueue(ManagerBase manager) : base(manager)
        {
        }

        public void AddItemInQueue(string jsonData){

        }
    }
}

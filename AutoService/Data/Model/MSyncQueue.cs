using System;
namespace AutoService.Data.Model
{
    public class MChangesSync : DbObject
    {
       
        public DateTime ChangesDateTime { get; set; }

        public string Json { get; set; }

        public string DeviceInfo { get; set; }

        public string OSInfo { get; set; }

        public string AccountId { get; set; }

        public long ChangeVersion { get; set; }

    }
}

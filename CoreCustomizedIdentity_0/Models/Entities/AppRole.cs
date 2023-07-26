using CoreCustomizedIdentity_0.Models.Enums;
using CoreCustomizedIdentity_0.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CoreCustomizedIdentity_0.Models.Entities
{
    public class AppRole : IdentityRole<int>, IEntity
    {
        public AppRole()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties
        public virtual List<AppUserRole> UserRoles { get; set; }

    }
}

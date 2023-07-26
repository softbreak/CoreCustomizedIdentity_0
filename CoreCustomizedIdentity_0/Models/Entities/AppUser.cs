using CoreCustomizedIdentity_0.Models.Enums;
using CoreCustomizedIdentity_0.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CoreCustomizedIdentity_0.Models.Entities
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser()
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
        public virtual List<Order> Orders { get; set; }
        public virtual AppUserProfile Profile { get; set; }


    }
}

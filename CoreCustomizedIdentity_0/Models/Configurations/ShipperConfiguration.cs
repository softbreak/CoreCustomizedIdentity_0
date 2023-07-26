using CoreCustomizedIdentity_0.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCustomizedIdentity_0.Models.Configurations
{
    public class ShipperConfiguration:BaseConfiguration<Shipper>
    {
        public override void Configure(EntityTypeBuilder<Shipper> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Orders).WithOne(x => x.Shipper).HasForeignKey(x => x.ShipperID);
        }
    }
}

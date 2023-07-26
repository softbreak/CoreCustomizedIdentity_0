namespace CoreCustomizedIdentity_0.Models.Entities
{
    public class Order:BaseEntity
    {
        public string? ShippingAddress { get; set; }
        public int? AppUserID { get; set; }
        public int? ShipperID { get; set; }



        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }

    }
}

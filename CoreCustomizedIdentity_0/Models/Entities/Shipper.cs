namespace CoreCustomizedIdentity_0.Models.Entities
{
    public class Shipper:BaseEntity
    {
        public string CompanyName { get; set; }

        //Relational Properties
        public virtual List<Order> Orders { get; set; }

    }
}

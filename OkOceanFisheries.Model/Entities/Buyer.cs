using System;
using System.Collections.Generic;

namespace OkOceanFisheries.Model.Entities
{
    public class Buyer
    {
        public int BuyerId { get; set; }

        public DateTime DateTimeCreated { get; set; }

        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string CompanyName { get; set; }
        public string Contact { get; set; }
        
        public string Notes { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
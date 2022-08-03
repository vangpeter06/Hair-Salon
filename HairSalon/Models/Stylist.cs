using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }

        public int StylistId { get; set; }

        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "0:MM/dd/yyyy")]

        public DateTime HireDate { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BartenderApp.Models
{
    [Table("Table")]
    public class Drink
    {
        public int DrinkId { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
    }
}
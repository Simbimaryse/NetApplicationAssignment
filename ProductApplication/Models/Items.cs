using System;
using System.ComponentModel.DataAnnotations;

namespace ProductApplication.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int Price { get; set; }
        [DataType(DataType.DateTime)]
         public DateTime ReleasedDate{ get; set; }
         public DateTime ExpiredDate { get; set; }
    }
}
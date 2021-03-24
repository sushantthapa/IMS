using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace IMSystem.Models
{
    public class Product
    {
         public int Id { get; set; }

        public string Name { get; set; }

        public int Quantities { get; set; }

       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOE { get; set; }

        public int  Price { get; set; }

        public string  Desc { get; set; }

    }
}
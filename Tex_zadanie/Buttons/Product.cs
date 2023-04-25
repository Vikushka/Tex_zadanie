using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media;
using System;

namespace Tex_zadanie.Buttons
{
    public class Product
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }

        [NotMapped] public ImageSource QRCode { get; set; }


    }
}
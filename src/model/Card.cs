using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtgCollectionCore.model
{
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Blue { get; set; }
        public bool Red { get; set; }
        public bool White { get; set; }
        public bool Black { get; set; }
        public bool Green { get; set; }
        public bool Colorless { get; set; }
        public float? Cmc { get; set; }
        public string? IdCard { get; set; }
        public string? ImageUrl { get; set; }
        public string? ManaCost { get; set; }
        public string? Name { get; set; }
        public string? OriginalText { get; set; }
        public string? OriginalType { get; set; }
        public string? Rarity { get; set; }
        public string? Text { get; set; }
        public int Quantity { get; set; }
        public bool Foil { get; set; }
    }
}

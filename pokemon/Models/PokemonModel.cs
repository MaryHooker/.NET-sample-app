using System;
using System.ComponentModel.DataAnnotations;

namespace pokemon.Models
{
    public class PokemonModel
    {
        // data annotations- gives the model a specific set of directions
        [Key]
        public int id {get; set;}

        [Required]
        [Display(Name = "Pokemon Name")]

        public string name {get; set;}

         [Required]
        [Display(Name = "Pokemon Type")]

        public string type {get; set;}

         
 [         Display(Name = "Time of Appearance")]

        public DateTime timeOfDay {get; set;}

    }
}  
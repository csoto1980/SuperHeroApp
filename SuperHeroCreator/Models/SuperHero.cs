using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroCreator.Models
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Superhero Name")]
        public string Name { get; set; }

        [Display(Name = "Alter Ego Name")]
        public string AlterEgoName { get; set; }

        [Display(Name = "Primary Superhero Ability")]
        public string PrimaryAbility { get; set; }

        [Display(Name = "Secondary Superhero Ability")]
        public string SecondaryAbility { get; set; }

        public string Catchphrase { get; set; }
    }
}

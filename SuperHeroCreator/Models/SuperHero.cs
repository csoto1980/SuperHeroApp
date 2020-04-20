﻿using System;
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
        public string Name { get; set; }

        [Display(Name = "Alter Ego")]
        public string AlterEgoName { get; set; }

        [Display(Name = "Primary Ability")]
        public string PrimaryAbility { get; set; }

        [Display(Name = "Secondary Ability")]
        public string SecondaryAbility { get; set; }

        public string Catchphrase { get; set; }
    }
}

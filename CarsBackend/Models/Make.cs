﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarsBackend.Models
{
    [Table("Makes")]
    public class Make
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }

        public Make()
        {
            this.Models = new Collection<Model>();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Models
{
    public class AdModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Address { get; set; }
        public string Bonus { get; set; }
        public string Picture { get; set; }
        [Column("idUser")]
        public string IdUser { get; set; }
    }
}

using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FiendXWebsite.Models
{
    public class Gig
    {

        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(250)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }

    }
}
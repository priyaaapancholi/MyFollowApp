﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace MyFollowOwin.Models
{
    public class ProductUpdate
    {
        [Key]
        [Required]
        public int ProductUpdateId { get; set; }

        [Required]
        [MaxLength(1100)]
        public string Detail { get; set; }

        public string Media { get; set; }

        [Required]
        [MaxLength(140)]
        public string Introduction { get; set; }

        //refers relation between product and product updates(Details)..
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

    }
}
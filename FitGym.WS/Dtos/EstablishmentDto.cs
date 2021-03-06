﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitGym.WS.Dtos
{
    public class EstablishmentDto
    {
        public int EstablishmentId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(Double.MinValue, Double.MaxValue)]
        public decimal LocationX { get; set; }

        [Required]
        [Range(Double.MinValue, Double.MaxValue)]
        public decimal LocationY { get; set; }

        public string Status { get; set; }

        [Required]
        [Range(1, Int32.MaxValue)]
        public int GymCompanyId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
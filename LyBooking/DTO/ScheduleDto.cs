﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

#nullable disable

namespace IRS.DTO
{
    public partial class ScheduleDto
    {
        public int Id { get; set; }
        public string ShoesGuid { get; set; }
        public string PartGuid { get; set; }
        public string ColorGuid { get; set; }
        public string TreatmentWayGuid { get; set; }
        public string TreatmentGuid { get; set; }
        public string ProcessGuid { get; set; }
        public string Guid { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? UpdateBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public decimal? DeleteBy { get; set; }
        public decimal? Status { get; set; }

        public double? Consumption { get; set; }
    }
}

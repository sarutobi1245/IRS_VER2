﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace IRS.Models
{
    public partial class Chemical2
    {
        public Chemical2()
        {
            this.CreatedDate = DateTime.Now;
        }
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string MaterialNO { get; set; }
        public int ProcessID { get; set; }
        public double Unit { get; set; }
        public int SupplierID { get; set; }
        public bool Modify { get; set; }
        public Supplier Supplier { get; set; }
        public Process Processes { get; set; }
        public string VOC { get; set; }
        public int CreatedBy { get; set; }
        public int ExpiredTime { get; set; }
        public int DaysToExpiration { get; set; }
        public bool isShow { get; set; }
        public int ModifiedBy { get; set; }
        public string Guid { get; set; }
        public double Percentage { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
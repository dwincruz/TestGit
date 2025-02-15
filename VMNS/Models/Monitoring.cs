﻿using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Monitoring
    {
        [Key]
        public int Id { get; set; }

        public Guid? MaintenanceId { get; set; }

        public int? ReplacementId { get; set; }

        
        
        [Display(Name = "Lifespan in Days")]
        public int? LifeSpan { get; set; }
        [Display(Name = "Distance Limit")]
        public int? DistanceLimit { get; set; }
        [Display(Name = "Current Kilometer")]
        public int? CurrentKM { get; set; }


        //Additional
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date Acquired")]
        public DateTime DateAcquired { get; set; }



        //Foreign Key
        public virtual Replacement? Replacement { get; set; }
        public virtual Maintenance? Maintenance { get; set; }


        public DateTime? EndDate
        {
            get
            {
                if (LifeSpan.HasValue)
                {
                    return DateAcquired.AddDays(LifeSpan.Value);
                }
                return null; 
            }
        }
    }
}

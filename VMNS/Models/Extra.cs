using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Extra
    {
        [Key]
        public int Id { get; set; }

        public Guid? VehicleId { get; set; }

        public string Tools { get; set; }
        public string Remarks { get; set; }
        public string Manuals { get; set; }
        [Display(Name = "Spare tires")]
        public string SpareTires { get; set; }

        //For Tracking
        public Guid CreatorId { get; set; }
        public Guid? ModifierId { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Date Modified")]
        public DateTime DateModified { get; set; }


        //Foreign Key
        public virtual Vehicle? Vehicle { get; set; }
    }
}

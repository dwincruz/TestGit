using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class VehicleHistory
    {
        [Key]
        public int Id { get; set; }

        public Guid? VehicleId { get; set; }

        public string Description { get; set; }
        public string Remarks { get; set; }
        [Display(Name = "Action Date")]
        public string ActionDate { get; set; }
        public Guid CreatorId { get; set; }

        //look up
        public virtual Vehicle? Vehicle { get; set; }
    }
}

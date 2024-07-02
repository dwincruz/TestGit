using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Upload
    {
        [Key]
        public int Id { get; set; }

        public string ConcernId { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string FileName { get; set; }

        [MaxLength(512)]
        [Column(TypeName = "varchar(512)")]
        [Display(Name = "File path")]
        public string FilePath { get; set; }

        [Display(Name = "Date upload")]
        public DateTime UploadDate { get; set; }
    }
}

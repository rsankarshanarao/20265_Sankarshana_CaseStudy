using Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Job
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Job ID")]
        public int ID { get; set; }

        [Required]
        public User creator { get; set; }
        
        public User owner { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Task")]
        public string name { get; set; }

        [MaxLength(100)]
        public string description { get; set; }

        [Required]
        public status status { get; set; }

        public priority? priority { get; set; }

        public string? notes { get; set; }

        public string? bookmark { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created On")]
        public DateTime createdOn { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Status Changed On")]
        public DateTime statusChangedOn { get; set; }

    }
}

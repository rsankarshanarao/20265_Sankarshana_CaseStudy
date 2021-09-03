using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace JobTracking.Models
{
    public class Task
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "ID")]
        public int TaskID { get; set; }

        [Required]
        public User Owner { get; set; }

        [Required]
        public User Creator { get; set; }

        [Required, StringLength(20)]
        public string Taskname { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(15)]
        public string Status { get; set; }

        [StringLength(15)]
        public string Priority { get; set; }

        public string Notes { get; set; }

        public string Bookmark  { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime StatusChangedOn { get; set; }
    }
}

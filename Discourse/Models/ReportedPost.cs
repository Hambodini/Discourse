using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Discourse.Models
{
    public class ReportedPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string ReporterUserId { get; set; }
        public string Reason { get; set; }
        [Required]
        public DateTime DateReported { get; set; }
        [Required]
        public string ReportedUserId { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
    }
}
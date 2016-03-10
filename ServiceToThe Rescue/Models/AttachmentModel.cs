using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiceToTheRescue.Models
{
    public class AttachmentModel
    {
        [Key]
        public long AttachmentID { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }

    }
}
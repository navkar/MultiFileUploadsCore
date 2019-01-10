using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelUploads.Models
{
    public class AdModel
    {
        public IFormFileCollection AdImages { get; set; }
        public string AdId { get; set; }
        public string AdCaption { get; set; }
    }
}

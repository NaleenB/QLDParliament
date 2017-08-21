using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace QLDParliament.Models
{
    public class Channel
    {
        public DateTime Date { get; set; }

        public string ID { get; set; }

        public string Programme { get; set; }

        public string Category { get; set; }
    }
}

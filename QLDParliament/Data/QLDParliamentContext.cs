using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QLDParliament.Models
{
    public class QLDParliamentContext
    {
        public List<QLDParliament.Models.Channel> Channel { get; set; }

        public QLDParliamentContext()
        {
            Channel = new List<Models.Channel>()
            {
                new Models.Channel()
                {
                    Category = "Current Affairs",
                    Date = DateTime.Now,
                    ID = "Channel 9",
                    Programme = "Public housing at crisis point."
                }
            };
        }
    }
}

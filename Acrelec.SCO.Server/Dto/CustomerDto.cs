using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Acrelec.SCO.Server.Dto
{
    public class CustomerDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Address { get; set; }
    }
}

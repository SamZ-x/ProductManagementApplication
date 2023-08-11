using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementApp.DataUtility
{
    public class BaseDTO
    {
        public Guid CreatedBy { get; set; }

        // #TODO: use default value or set to 'required' 
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;

        public Guid UpdatedBy { get; set; }

        // #TODO: use default value or set to 'required' 
        public DateTimeOffset UpdatedDate { get; set; } = DateTimeOffset.UtcNow;
    }
}

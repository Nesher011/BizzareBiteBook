using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBiteBook.Domain.Entities;

public class Step : BaseAuditableEntity
{
    public string? Description { get; set; }
    public int Index { get; set; }
}

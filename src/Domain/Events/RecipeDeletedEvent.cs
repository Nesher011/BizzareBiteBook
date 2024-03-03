using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBiteBook.Domain.Events;

public class RecipeDeletedEvent(Recipe recipe) : BaseEvent
{
    public Recipe Recipe { get; set; } = recipe;
}

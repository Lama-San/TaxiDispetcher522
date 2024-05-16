using System;
using System.Collections.Generic;

namespace TaxiDispetcher5;

public partial class Role
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual Login IdNavigation { get; set; } = null!;
}

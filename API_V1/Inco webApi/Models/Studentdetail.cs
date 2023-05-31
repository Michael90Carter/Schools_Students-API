using System;
using System.Collections.Generic;

namespace Inco_webApi.Models;

public partial class Studentdetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? Dob { get; set; }

    public DateTime? Doj { get; set; }

    public string? Gender { get; set; }

    public string? Country { get; set; }
}

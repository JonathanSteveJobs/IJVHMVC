using System;
using System.Collections.Generic;

namespace IJVHMVC.Models;

public partial class Veterinarium
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Edad { get; set; }

    public string? NombreDueño { get; set; }

    public string? MotivoConsulta { get; set; }
}

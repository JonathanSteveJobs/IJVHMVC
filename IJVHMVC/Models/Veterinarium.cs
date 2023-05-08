using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;


namespace IJVHMVC.Models;

public partial class Veterinarium
{
    public int Id { get; set; }
    [Required]
    
    
    public string? Nombre { get; set; }

    public int? Edad { get; set; }

    public string? NombreDueño { get; set; }

    public string? MotivoConsulta { get; set; }
}

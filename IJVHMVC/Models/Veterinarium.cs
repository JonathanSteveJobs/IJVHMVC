using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;


namespace IJVHMVC.Models;

public partial class Veterinarium
{
    public int Id { get; set; }


    [System.ComponentModel.DataAnnotations.Required] public string? Nombre { get; set; }

    [System.ComponentModel.DataAnnotations.Required] public int? Edad { get; set; }

    [System.ComponentModel.DataAnnotations.Required] public string? NombreDueño { get; set; }
    [System.ComponentModel.DataAnnotations.Required] public string? MotivoConsulta { get; set; }
   
}

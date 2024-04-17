using System;
using System.Collections.Generic;

namespace MVCCRUD.Models;

public partial class Alumno
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }
}

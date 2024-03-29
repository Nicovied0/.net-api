﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Models;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string? Description { get; set; }

    [JsonIgnore]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}

﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace CNProjetos.Client.Models
{
    public partial class regiao
    {
        public regiao()
        {
            cliente = new HashSet<cliente>();
        }

        public int regiaoId { get; set; }
        public string regiaoNome { get; set; }

        public virtual ICollection<cliente> cliente { get; set; }
    }
}
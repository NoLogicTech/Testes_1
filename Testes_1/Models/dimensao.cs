// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace CNProjetos.Client.Models
{
    public partial class dimensao
    {
        public dimensao()
        {
            cliente = new HashSet<cliente>();
        }

        public int dimensaoId { get; set; }
        public string dimensaoNome { get; set; }

        public virtual ICollection<cliente> cliente { get; set; }
    }
}
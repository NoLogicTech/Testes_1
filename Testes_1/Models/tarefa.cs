// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace CNProjetos.Client.Models
{
    public partial class tarefa
    {
        public int tarefaId { get; set; }
        public int tarefaParentid { get; set; }
        public int projeto_Id { get; set; }
        public string tarefaNome { get; set; }
        public DateTime tarefaDatahoraregisto { get; set; }
        public DateTime? tarefaDatalimite { get; set; }
        public int utilizador_Id { get; set; }
        public bool tarefaEstado { get; set; }
        public bool tarefaTemfilho { get; set; }
        public int tarefaPosicao { get; set; }
    }
}
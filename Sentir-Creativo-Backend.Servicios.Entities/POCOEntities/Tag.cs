﻿namespace Sentir_Creativo_Backend.Servicios.Entities.POCOEntities
{
    public class Tag : BaseEntity<int>
    {
        public string Nombre { get; set; }
        public string? Color { get; set; }
        public int Prioridad { get; set; }
        public bool Activo { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}

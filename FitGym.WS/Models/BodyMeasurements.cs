//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitGym.WS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BodyMeasurements
    {
        public int BodyMeasurementsId { get; set; }
        public decimal Arms { get; set; }
        public decimal Legs { get; set; }
        public decimal Abs { get; set; }
        public decimal Back { get; set; }
        public decimal Chest { get; set; }
        public decimal Weight { get; set; }
        public int EvaluationId { get; set; }
        public int ClientId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Evaluation Evaluation { get; set; }
    }
}

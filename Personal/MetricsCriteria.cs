//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Personal
{
    using System;
    using System.Collections.Generic;
    
    public partial class MetricsCriteria
    {
        public int id_met_cr { get; set; }
        public int id_criterion { get; set; }
        public int id_metrics { get; set; }
    
        public virtual Criteria Criteria { get; set; }
        public virtual MetricsTable MetricsTable { get; set; }
    }
}

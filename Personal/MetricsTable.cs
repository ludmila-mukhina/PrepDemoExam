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
    
    public partial class MetricsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MetricsTable()
        {
            this.EmployeeMetrics = new HashSet<EmployeeMetrics>();
            this.MetricsCriteria = new HashSet<MetricsCriteria>();
        }
    
        public int id_metrics { get; set; }
        public string metrics { get; set; }
        public double weight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeMetrics> EmployeeMetrics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MetricsCriteria> MetricsCriteria { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersonalEntities : DbContext
    {
        public PersonalEntities()
            : base("name=PersonalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Criteria> Criteria { get; set; }
        public virtual DbSet<EmployeeMetrics> EmployeeMetrics { get; set; }
        public virtual DbSet<EmployeeTable> EmployeeTable { get; set; }
        public virtual DbSet<MetricsCriteria> MetricsCriteria { get; set; }
        public virtual DbSet<MetricsTable> MetricsTable { get; set; }
        public virtual DbSet<PositionTable> PositionTable { get; set; }
        public virtual DbSet<RoleTable> RoleTable { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}

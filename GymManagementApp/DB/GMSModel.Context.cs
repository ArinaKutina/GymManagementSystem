﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GymManagementApp.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GymManagementSystemEntities : DbContext
    {
        public GymManagementSystemEntities()
            : base("name=GymManagementSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AbonementState> AbonementState { get; set; }
        public virtual DbSet<Apparatus> Apparatus { get; set; }
        public virtual DbSet<Attendence> Attendence { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Specializations> Specializations { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Trainers> Trainers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}

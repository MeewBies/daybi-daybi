﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace daybi2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class uchetstudEntities : DbContext
    {
        public uchetstudEntities()
            : base("name=uchetstudEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Группа> Группа { get; set; }
        public virtual DbSet<Курсовая> Курсовая { get; set; }
        public virtual DbSet<Оценки> Оценки { get; set; }
        public virtual DbSet<Предмет> Предмет { get; set; }
        public virtual DbSet<Преподователь> Преподователь { get; set; }
        public virtual DbSet<Специальность> Специальность { get; set; }
        public virtual DbSet<Студенты> Студенты { get; set; }
        public virtual DbSet<Предмет_преподователь> Предмет_преподователь { get; set; }
    }
}

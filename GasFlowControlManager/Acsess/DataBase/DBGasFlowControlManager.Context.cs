﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GasFlowControlManager.Acsess.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBGasFlowControlManagerEntities2 : DbContext
    {

        public static DBGasFlowControlManagerEntities2 _context;
        public static DBGasFlowControlManagerEntities2 GetContext()
        {
            if (_context == null)
                _context = new DBGasFlowControlManagerEntities2();
            return _context;
        }

        public DBGasFlowControlManagerEntities2()
            : base("name=DBGasFlowControlManagerEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GasCompressors> GasCompressors { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<ParametersLogs> ParametersLogs { get; set; }
        public virtual DbSet<StatesLogs> StatesLogs { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}

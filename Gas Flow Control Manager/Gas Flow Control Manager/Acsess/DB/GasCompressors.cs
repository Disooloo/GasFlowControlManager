//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gas_Flow_Control_Manager.Acsess.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class GasCompressors
    {
        public GasCompressors()
        {
            this.Parameters = new HashSet<Parameters>();
            this.States = new HashSet<States>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public Nullable<decimal> MaxPressure { get; set; }
        public Nullable<decimal> MaxFlowRate { get; set; }
        public Nullable<decimal> Efficiency { get; set; }
        public Nullable<System.DateTime> InstallationDate { get; set; }
    
        public virtual ICollection<Parameters> Parameters { get; set; }
        public virtual ICollection<States> States { get; set; }
    }
}
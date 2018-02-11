//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectricData.BL
{
    using System;
    using System.Collections.Generic;
    
    public partial class regist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public regist()
        {
            this.orders = new HashSet<order>();
        }
    
        public int id { get; set; }
        public string PCAM { get; set; }
        public int id_circuits { get; set; }
        public int id_counters { get; set; }
        public int id_inputs { get; set; }
        public int id_ammeters { get; set; }
        public int id_bloks { get; set; }
        public int id_converters_i { get; set; }
        public int id_converters_u { get; set; }
        public int id_krm { get; set; }
        public int id_voltmeters { get; set; }
        public int id_country { get; set; }
        public string link { get; set; }
        public string note { get; set; }
    
        public virtual ammeter ammeter { get; set; }
        public virtual blok blok { get; set; }
        public virtual circuit circuit { get; set; }
        public virtual converters_i converters_i { get; set; }
        public virtual converters_u converters_u { get; set; }
        public virtual counter counter { get; set; }
        public virtual country country { get; set; }
        public virtual input input { get; set; }
        public virtual krm krm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
        public virtual voltmeter voltmeter { get; set; }
    }
}

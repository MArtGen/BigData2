//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectricData
{
    using System;
    using System.Collections.Generic;
    
    public partial class orders
    {
        public int id { get; set; }
        public int id_PCAM { get; set; }
        public int orders_name { get; set; }
    
        public virtual regist regist { get; set; }
    }
}

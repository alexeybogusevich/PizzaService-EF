//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaServiceDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRANSACTIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANSACTIONS()
        {
            this.HISTORY_HEADERS = new HashSet<HISTORY_HEADERS>();
        }
    
        public int T_ID { get; set; }
        public decimal T_RRN { get; set; }
        public System.DateTime T_DATE { get; set; }
        public System.DateTime T_EXPIRE_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORY_HEADERS> HISTORY_HEADERS { get; set; }
    }
}

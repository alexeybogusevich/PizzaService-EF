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
    
    public partial class HISTORY_LINES
    {
        public int HL_ID { get; set; }
        public int HL_ORDER_HEADER { get; set; }
        public int HL_ITEM { get; set; }
        public int HL_QUANTITY { get; set; }
    
        public virtual HISTORY_HEADERS HISTORY_HEADERS { get; set; }
        public virtual ITEMS ITEMS { get; set; }
    }
}

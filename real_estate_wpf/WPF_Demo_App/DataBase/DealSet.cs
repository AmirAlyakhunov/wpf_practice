//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_Demo_App.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class DealSet
    {
        public int Id { get; set; }
        public int Demand_Id { get; set; }
        public int Supply_Id { get; set; }
    
        public virtual DemandSet DemandSet { get; set; }
        public virtual SupplySet SupplySet { get; set; }
    }
}

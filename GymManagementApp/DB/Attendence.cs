//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Attendence
    {
        public int idAttendence { get; set; }
        public int idClient { get; set; }
        public Nullable<int> countTrainings { get; set; }
    
        public virtual Clients Clients { get; set; }
    }
}
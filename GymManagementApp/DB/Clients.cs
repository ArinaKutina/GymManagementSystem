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
    
    public partial class Clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clients()
        {
            this.Attendence = new HashSet<Attendence>();
        }
    
        public int idClient { get; set; }
        public string surnameClient { get; set; }
        public string nameClient { get; set; }
        public string patronimicClients { get; set; }
        public Nullable<int> stateAbonement { get; set; }
        public Nullable<int> idTrainer { get; set; }
        public Nullable<long> telephoneNum { get; set; }
    
        public virtual AbonementState AbonementState { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendence> Attendence { get; set; }
        public virtual Trainers Trainers { get; set; }
    }
}
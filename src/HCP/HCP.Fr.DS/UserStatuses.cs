//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HCP.Fr.DS
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserStatuses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserStatuses()
        {
            this.Users = new HashSet<Users>();
        }
    
        public System.Guid Id { get; set; }
        public string description { get; set; }
        public string Statut { get; set; }
        public string ajouter_au { get; set; }
        public string ajouter_par { get; set; }
        public string modifier_au { get; set; }
        public string modifier_par { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users { get; set; }
    }
}

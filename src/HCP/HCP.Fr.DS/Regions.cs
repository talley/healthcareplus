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
    
    public partial class Regions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Regions()
        {
            this.Villes = new HashSet<Villes>();
        }
    
        public int Id { get; set; }
        public int pays_id { get; set; }
        public string région { get; set; }
        public bool status { get; set; }
        public string ajouter_au { get; set; }
        public string ajouter_par { get; set; }
        public string modifier_au { get; set; }
        public string modifier_par { get; set; }
    
        public virtual Pays Pays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Villes> Villes { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Recklama
{
    using System;
    using System.Collections.Generic;
    
    public partial class Newspaper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Newspaper()
        {
            this.Recklama = new HashSet<Recklama>();
        }
    
        public int id { get; set; }
        public string NameNewspaper { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Nullable<long> Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recklama> Recklama { get; set; }
    }
}

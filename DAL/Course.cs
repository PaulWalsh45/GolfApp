//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.TBL_COMPETITION = new HashSet<Competition>();
        }
    
        public int COURSE_ID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public int PAR_1 { get; set; }
        public int PAR_2 { get; set; }
        public int PAR_3 { get; set; }
        public int PAR_4 { get; set; }
        public int PAR_5 { get; set; }
        public int PAR_6 { get; set; }
        public int PAR_7 { get; set; }
        public int PAR_8 { get; set; }
        public int PAR_9 { get; set; }
        public int PAR_10 { get; set; }
        public int PAR_11 { get; set; }
        public int PAR_12 { get; set; }
        public int PAR_13 { get; set; }
        public int PAR_14 { get; set; }
        public int PAR_15 { get; set; }
        public int PAR_16 { get; set; }
        public int PAR_17 { get; set; }
        public int PAR_18 { get; set; }
        public int INDEX_1 { get; set; }
        public int INDEX_2 { get; set; }
        public int INDEX_3 { get; set; }
        public int INDEX_4 { get; set; }
        public int INDEX_5 { get; set; }
        public int INDEX_6 { get; set; }
        public int INDEX_7 { get; set; }
        public int INDEX_8 { get; set; }
        public int INDEX_9 { get; set; }
        public int INDEX_10 { get; set; }
        public int INDEX_11 { get; set; }
        public int INDEX_12 { get; set; }
        public int INDEX_13 { get; set; }
        public int INDEX_14 { get; set; }
        public int INDEX_15 { get; set; }
        public int INDEX_16 { get; set; }
        public int INDEX_17 { get; set; }
        public int INDEX_18 { get; set; }
        public Nullable<int> PAR_IN { get; set; }
        public Nullable<int> PAR_OUT { get; set; }
        public Nullable<int> PAR_TOTAL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competition> TBL_COMPETITION { get; set; }
    }
}

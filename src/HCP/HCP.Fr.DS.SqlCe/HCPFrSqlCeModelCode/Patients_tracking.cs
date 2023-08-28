using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace HCP.Fr.DS.SqlCe.ABIBOUPC
{

    public partial class Patients_tracking
    {
        public Patients_tracking(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

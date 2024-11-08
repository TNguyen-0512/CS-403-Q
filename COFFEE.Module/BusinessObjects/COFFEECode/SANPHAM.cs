using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace COFFEE.Module.BusinessObjects.COFFEE
{

    public partial class SANPHAM
    {
        public SANPHAM(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

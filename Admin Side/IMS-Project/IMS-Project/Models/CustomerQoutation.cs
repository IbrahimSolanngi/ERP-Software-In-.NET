
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace IMS_Project.Models
{

using System;
    using System.Collections.Generic;
    
public partial class CustomerQoutation
{

    public int CustomerQoutationID { get; set; }

    public Nullable<int> ReqQoutationID { get; set; }

    public string Product { get; set; }

    public string Customer { get; set; }

    public Nullable<int> QuantityNeeded { get; set; }

    public Nullable<int> SupplierQuantity { get; set; }

    public Nullable<int> UnitPrice { get; set; }

    public Nullable<int> TotalPrice { get; set; }

    public Nullable<System.DateTime> Date { get; set; }

    public string SaveQuantity { get; set; }

    public string Tax { get; set; }

    public Nullable<int> PaymentTerm { get; set; }

    public string ConUnit { get; set; }

}

}

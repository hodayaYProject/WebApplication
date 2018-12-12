﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Category
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Category()
    {
        this.Resources = new HashSet<Resource>();
    }

    public int categoryCode { get; set; }
    public string categoryName { get; set; }
    public Nullable<int> parentCategory { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Resource> Resources { get; set; }
}

public partial class Permission
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Permission()
    {
        this.Users = new HashSet<User>();
    }

    public int permissionsCode { get; set; }
    public string permissionsType { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<User> Users { get; set; }
}

public partial class Resource
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Resource()
    {
        this.Categories = new HashSet<Category>();
    }

    public int resourceCode { get; set; }
    public string resourceName { get; set; }
    public string filePath { get; set; }
    public string version { get; set; }
    public string authorName { get; set; }
    public Nullable<System.DateTime> date { get; set; }
    public Nullable<int> resourcePermission { get; set; }

    public virtual ResourcePermission ResourcePermission1 { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Category> Categories { get; set; }
}

public partial class ResourcePermission
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ResourcePermission()
    {
        this.Resources = new HashSet<Resource>();
    }

    public int ResourcePermisCode { get; set; }
    public string ResourcePermisType { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Resource> Resources { get; set; }
}

public partial class sysdiagram
{
    public string name { get; set; }
    public int principal_id { get; set; }
    public int diagram_id { get; set; }
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class User
{
    public int userCode { get; set; }
    public string userName { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public Nullable<int> permissionCode { get; set; }

    public virtual Permission Permission { get; set; }
}

public partial class sp_helpdiagramdefinition_Result
{
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class sp_helpdiagrams_Result
{
    public string Database { get; set; }
    public string Name { get; set; }
    public int ID { get; set; }
    public string Owner { get; set; }
    public int OwnerID { get; set; }
}
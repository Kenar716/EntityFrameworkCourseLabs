﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbFirstOracle
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PlutoDbContext : DbContext
    {
        public PlutoDbContext()
            : base("name=PlutoDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSection> CourseSections { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
    
        public virtual ObjectResult<Course> GetAuthorCourses(Nullable<decimal> aAUTHORID)
        {
            var aAUTHORIDParameter = aAUTHORID.HasValue ?
                new ObjectParameter("AAUTHORID", aAUTHORID) :
                new ObjectParameter("AAUTHORID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetAuthorCourses", aAUTHORIDParameter);
        }
    
        public virtual ObjectResult<Course> GetAuthorCourses(Nullable<decimal> aAUTHORID, MergeOption mergeOption)
        {
            var aAUTHORIDParameter = aAUTHORID.HasValue ?
                new ObjectParameter("AAUTHORID", aAUTHORID) :
                new ObjectParameter("AAUTHORID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetAuthorCourses", mergeOption, aAUTHORIDParameter);
        }
    
        public virtual int DeleteCourse(Nullable<decimal> aCOURSEID)
        {
            var aCOURSEIDParameter = aCOURSEID.HasValue ?
                new ObjectParameter("ACOURSEID", aCOURSEID) :
                new ObjectParameter("ACOURSEID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCourse", aCOURSEIDParameter);
        }
    
        public virtual ObjectResult<Course> GetCourses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetCourses");
        }
    
        public virtual ObjectResult<Course> GetCourses(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetCourses", mergeOption);
        }
    
        public virtual int InsertCourse(Nullable<decimal> aAUTHORID, string aTITLE, string aDESC, Nullable<decimal> aPRICE, string aLEVELSTRING, Nullable<decimal> aLEVEL)
        {
            var aAUTHORIDParameter = aAUTHORID.HasValue ?
                new ObjectParameter("AAUTHORID", aAUTHORID) :
                new ObjectParameter("AAUTHORID", typeof(decimal));
    
            var aTITLEParameter = aTITLE != null ?
                new ObjectParameter("ATITLE", aTITLE) :
                new ObjectParameter("ATITLE", typeof(string));
    
            var aDESCParameter = aDESC != null ?
                new ObjectParameter("ADESC", aDESC) :
                new ObjectParameter("ADESC", typeof(string));
    
            var aPRICEParameter = aPRICE.HasValue ?
                new ObjectParameter("APRICE", aPRICE) :
                new ObjectParameter("APRICE", typeof(decimal));
    
            var aLEVELSTRINGParameter = aLEVELSTRING != null ?
                new ObjectParameter("ALEVELSTRING", aLEVELSTRING) :
                new ObjectParameter("ALEVELSTRING", typeof(string));
    
            var aLEVELParameter = aLEVEL.HasValue ?
                new ObjectParameter("ALEVEL", aLEVEL) :
                new ObjectParameter("ALEVEL", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCourse", aAUTHORIDParameter, aTITLEParameter, aDESCParameter, aPRICEParameter, aLEVELSTRINGParameter, aLEVELParameter);
        }
    
        public virtual int UpdateCourse(Nullable<decimal> aCOURSEID, string aTITLE, string aDESC, string aLEVELSTRING, Nullable<decimal> aLEVEL)
        {
            var aCOURSEIDParameter = aCOURSEID.HasValue ?
                new ObjectParameter("ACOURSEID", aCOURSEID) :
                new ObjectParameter("ACOURSEID", typeof(decimal));
    
            var aTITLEParameter = aTITLE != null ?
                new ObjectParameter("ATITLE", aTITLE) :
                new ObjectParameter("ATITLE", typeof(string));
    
            var aDESCParameter = aDESC != null ?
                new ObjectParameter("ADESC", aDESC) :
                new ObjectParameter("ADESC", typeof(string));
    
            var aLEVELSTRINGParameter = aLEVELSTRING != null ?
                new ObjectParameter("ALEVELSTRING", aLEVELSTRING) :
                new ObjectParameter("ALEVELSTRING", typeof(string));
    
            var aLEVELParameter = aLEVEL.HasValue ?
                new ObjectParameter("ALEVEL", aLEVEL) :
                new ObjectParameter("ALEVEL", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCourse", aCOURSEIDParameter, aTITLEParameter, aDESCParameter, aLEVELSTRINGParameter, aLEVELParameter);
        }
    }
}

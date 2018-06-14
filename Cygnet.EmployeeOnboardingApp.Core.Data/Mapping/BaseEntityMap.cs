using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cygnet.EmployeeOnboardingApp.Core.Data.Mapping
{
    /// <summary>
    /// A base configuration map for all instances of BaseEntity,
    /// which initialises all of the common/shared entity properties
    /// between them.
    /// </summary>
    /// <type param name="T">the type of BaseEntity being initialised</typeparam>
    public abstract class BaseEntityMap<T> : EntityTypeConfiguration<T>
        where T : BaseEntity
    {
        protected BaseEntityMap()
        {
            // Table & Column Mappings
            Property(t => t.RowVersion).HasColumnName("RowVersion");
            Property(t => t.Created).HasColumnName("Created");
            Property(t => t.Modified).HasColumnName("Modified");

            // Concurrency Fields
            Property(t => t.RowVersion).IsRowVersion();
        }
    }
}
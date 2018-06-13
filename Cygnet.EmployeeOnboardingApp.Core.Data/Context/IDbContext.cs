using System;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;

namespace Cygnet.EmployeeOnboardingApp.Core.Data.Context
{
    public interface IDbContext : IDisposable
    {
        int SaveChanges();

        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Set", Justification = "EF convention")]
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
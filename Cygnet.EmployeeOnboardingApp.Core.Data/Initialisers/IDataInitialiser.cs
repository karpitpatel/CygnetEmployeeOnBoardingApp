﻿using System.Data.Entity;

namespace Cygnet.EmployeeOnboardingApp.Core.Data.Initialisers
{
    /// <summary>
    /// A tagging interface that identifies instances of IDatabaseInitializer
    /// that are specifically targetted at populating data. Use of this contract
    /// implies that no structural initialisation is performed by the implementer -
    /// only data creation.
    /// </summary>
    /// <typeparam name="TContext">the type of DbContext to operate on</typeparam>
    public interface IDataInitialiser<in TContext> : IDatabaseInitializer<TContext>
           where TContext : DbContext
    {
    }
}
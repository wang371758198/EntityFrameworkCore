// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Update;

namespace Microsoft.EntityFrameworkCore.TestUtilities
{
    public class FakeStateManager : IStateManager
    {
        public IEnumerable<InternalEntityEntry> InternalEntries { get; set; }
        public bool SaveChangesCalled { get; set; }
        public bool SaveChangesAsyncCalled { get; set; }

        public IEntityFinder CreateEntityFinder(IEntityType entityType)
        {
            throw new NotImplementedException();
        }

        public TrackingQueryMode GetTrackingQueryMode(IEntityType entityType) => TrackingQueryMode.Multiple;

        public void EndSingleQueryMode()
        {
        }

        public void ResetState()
        {
        }

        public void Unsubscribe()
        {
        }

        public void UpdateIdentityMap(InternalEntityEntry entry, IKey principalKey)
        {
            throw new NotImplementedException();
        }

        public void UpdateDependentMap(InternalEntityEntry entry, IForeignKey foreignKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InternalEntityEntry> GetDependents(InternalEntityEntry principalEntry, IForeignKey foreignKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InternalEntityEntry> GetDependentsUsingRelationshipSnapshot(InternalEntityEntry principalEntry, IForeignKey foreignKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InternalEntityEntry> GetDependentsFromNavigation(InternalEntityEntry principalEntry, IForeignKey foreignKey)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<IUpdateEntry> GetEntriesToSave() => Enumerable.Empty<IUpdateEntry>().ToList();

        public int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            SaveChangesCalled = true;
            return 1;
        }

        public Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
        {
            SaveChangesAsyncCalled = true;
            return Task.FromResult(1);
        }

        public virtual void AcceptAllChanges()
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry GetOrCreateEntry(object entity)
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry GetOrCreateEntry(object entity, IEntityType entityType)
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry GetOrCreateEntry(IDictionary<string, object> values, IEntityType entityType)
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry StartTrackingFromQuery(
            IEntityType baseEntityType,
            object entity,
            ValueBuffer valueBuffer,
            ISet<IForeignKey> handledForeignKeys)
        {
            throw new NotImplementedException();
        }

        public void BeginTrackingQuery()
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry TryGetEntry(IKey key, object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry TryGetEntry(IKey key, ValueBuffer valueBuffer, bool throwOnNullKey)
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry TryGetEntry(object entity)
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry TryGetEntry(object entity, IEntityType type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InternalEntityEntry> Entries => Entries ?? Enumerable.Empty<InternalEntityEntry>();

        public int ChangedCount { get; set; }

        public IInternalEntityEntryNotifier InternalEntityEntryNotifier => throw new NotImplementedException();

        public IValueGenerationManager ValueGenerationManager => throw new NotImplementedException();

        public IEntityMaterializerSource EntityMaterializerSource { get; }

        public InternalEntityEntry StartTracking(InternalEntityEntry entry)
        {
            throw new NotImplementedException();
        }

        public void StopTracking(InternalEntityEntry entry)
        {
            throw new NotImplementedException();
        }

        public void RecordReferencedUntrackedEntity(object referencedEntity, INavigation navigation, InternalEntityEntry referencedFromEntry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<INavigation, InternalEntityEntry>> GetRecordedReferers(object referencedEntity, bool clear)
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry GetPrincipal(InternalEntityEntry entityEntry, IForeignKey foreignKey)
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry GetPrincipalUsingPreStoreGeneratedValues(InternalEntityEntry entityEntry, IForeignKey foreignKey)
        {
            throw new NotImplementedException();
        }

        public InternalEntityEntry GetPrincipalUsingRelationshipSnapshot(InternalEntityEntry entityEntry, IForeignKey foreignKey)
        {
            throw new NotImplementedException();
        }

        public DbContext Context
        {
            get { throw new NotImplementedException(); }
        }
    }
}

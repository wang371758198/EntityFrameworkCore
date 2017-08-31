// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.TestUtilities.Xunit;
using Microsoft.EntityFrameworkCore.Utilities;
using System;

namespace Microsoft.EntityFrameworkCore
{
    [SqlServerCondition(SqlServerCondition.SupportsSequences)]
    public class GraphUpdatesWithSequenceSqlServerTest : GraphUpdatesSqlServerTestBase<GraphUpdatesWithSequenceSqlServerTest.GraphUpdatesWithSequenceSqlServerFixture>
    {
        public GraphUpdatesWithSequenceSqlServerTest(GraphUpdatesWithSequenceSqlServerFixture fixture)
            : base(fixture)
        {
        }


        [ConditionalFact]
        public void Reparent_to_different_one_to_many_Foo()
        {
            base.Reparent_to_different_one_to_many(GraphUpdatesTestBase<SqlServerTestStore, GraphUpdatesWithSequenceSqlServerFixture>.ChangeMechanism.Dependent, false);
        }

        public class GraphUpdatesWithSequenceSqlServerFixture : GraphUpdatesSqlServerFixtureBase
        {
            protected override string DatabaseName => "GraphSequenceUpdatesTest";

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ForSqlServerUseSequenceHiLo(); // ensure model uses sequences
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}

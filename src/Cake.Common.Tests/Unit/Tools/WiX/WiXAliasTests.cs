﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using Cake.Common.Tests.Fixtures.Tools.WiX;
using Cake.Common.Tools.WiX;
using Cake.Core;
using NSubstitute;
using Xunit;

namespace Cake.Common.Tests.Unit.Tools.WiX
{
    public sealed class WiXAliasTests
    {
        public sealed class TheWiXHeatMethod
        {
            [Fact]
            public void Should_Throw_If_Context_Is_Null()
            {
                // Given
                var fixture = new HeatFixture();

                // When
                var result = Record.Exception(() => WiXAliases.WiXHeat(null, fixture.DirectoryPath, fixture.OutputFile));

                // Then
                Assert.IsArgumentNullException(result, "context");
            }

            [Fact]
            public void Should_Throw_If_Directory_Path_Is_Null()
            {
                // Given
                var fixture = new HeatFixture();
                var context = Substitute.For<ICakeContext>();

                // When
                var result = Record.Exception(() => WiXAliases.WiXHeat(context, null, fixture.OutputFile));

                // Then
                Assert.IsArgumentNullException(result, "directoryPath");
            }
        }
    }
}
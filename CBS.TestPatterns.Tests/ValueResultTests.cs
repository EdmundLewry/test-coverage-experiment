using CBS.TestPatterns.Production;
using System;
using Xunit;

namespace CBS.TestPatterns.Tests
{
    public class ValueResultTests
    {
        [Fact]
        public void Add_WhenCalled_ReturnsExpected() 
            => Assert.Equal(9, ValueResults.Add(4,5));
    }
}

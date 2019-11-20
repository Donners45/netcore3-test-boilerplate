using System;
using domain;
using FluentAssertions;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Instantiate_SomeObject_NotNull()
        {
            var @object = new SomeClass();
            @object.Should().NotBeNull();
        }
    }
}

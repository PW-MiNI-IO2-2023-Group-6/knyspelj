using FluentAssertions;
using IoLabUnitTests;
using Xunit;

namespace IoLabUnitTestsTests;

public sealed class StringCalculatorTests
{
    [Fact]
    public void ShouldWorkForInt()
    {
        IsZeroChecker.IsZero(0).Should().BeTrue();
    }

    [Fact]
    public void ShouldNotAcceptOne()
    {
        IsZeroChecker.IsZero(1).Should().BeFalse();
    }
}
using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="UIntArgs"/>.
/// </summary>
[TestFixture]
public class UIntArgsTests
{
    /// <summary>
    /// Ensures that <see cref="UIntArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            uint.MinValue,
            uint.MaxValue,
            default,
            SondorTestConstants.DefaultUIntValue
        };

        // act
        var actual = new UIntArgs().Cast<uint>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="DecimalArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable_with_value()
    {
        // arrange
        const uint value = 10;
        var expected = new[]
        {
            uint.MinValue,
            uint.MaxValue,
            default,
            value
        };

        // act
        var actual = new UIntArgs(value).Cast<uint>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
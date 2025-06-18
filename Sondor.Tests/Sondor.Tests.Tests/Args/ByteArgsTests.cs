using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="ByteArgs"/>.
/// </summary>
[TestFixture]
public class ByteArgsTests
{
    /// <summary>
    /// Ensures that <see cref="ByteArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            byte.MinValue,
            byte.MaxValue,
            default,
            SondorTestConstants.DefaultByteValue
        };

        // act
        var actual = new ByteArgs().Cast<byte>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="ByteArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable_with_value()
    {
        // arrange
        const byte value = 10;
        var expected = new[]
        {
            byte.MinValue,
            byte.MaxValue,
            default,
            value
        };

        // act
        var actual = new ByteArgs(value).Cast<byte>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
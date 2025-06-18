using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="UShortArgs"/>.
/// </summary>
[TestFixture]
public class UShortArgsTests
{
    /// <summary>
    /// Ensures that <see cref="UShortArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            ushort.MinValue,
            ushort.MaxValue,
            default,
            SondorTestConstants.DefaultUShortValue
        };

        // act
        var actual = new UShortArgs().Cast<ushort>().ToArray();

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
        const ushort value = 10;
        var expected = new[]
        {
            ushort.MinValue,
            ushort.MaxValue,
            default,
            value
        };

        // act
        var actual = new UShortArgs(value).Cast<ushort>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
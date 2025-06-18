using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="ShortArgs"/>.
/// </summary>
[TestFixture]
public class ShortArgsTests
{
    /// <summary>
    /// Ensures that <see cref="ShortArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            short.MinValue,
            short.MaxValue,
            default,
            SondorTestConstants.DefaultShortValue
        };

        // act
        var actual = new ShortArgs().Cast<short>().ToArray();

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
        const short value = 10;
        var expected = new[]
        {
            short.MinValue,
            short.MaxValue,
            default,
            value
        };

        // act
        var actual = new ShortArgs(value).Cast<short>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="LongArgs"/>.
/// </summary>
[TestFixture]
public class LongArgTests
{
    /// <summary>
    /// Ensures that <see cref="LongArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            long.MinValue,
            long.MaxValue,
            default,
            SondorTestConstants.DefaultLongValue
        };

        // act
        var actual = new LongArgs().Cast<long>().ToArray();

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
        const long value = 10;
        var expected = new[]
        {
            long.MinValue,
            long.MaxValue,
            default,
            value
        };

        // act
        var actual = new LongArgs(value).Cast<long>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="DecimalArgsTests"/>.
/// </summary>
[TestFixture]
public class DecimalArgsTests
{
    /// <summary>
    /// Ensures that <see cref="DecimalArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            decimal.MinValue,
            decimal.MaxValue,
            default,
            SondorTestConstants.DefaultDecimalValue
        };

        // act
        var actual = new DecimalArgs().Cast<decimal>().ToArray();

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
        const decimal value = 10;
        var expected = new[]
        {
            decimal.MinValue,
            decimal.MaxValue,
            default,
            value
        };

        // act
        var actual = new DecimalArgs(value).Cast<decimal>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
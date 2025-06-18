using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="DoubleArgs"/>.
/// </summary>
[TestFixture]
public class DoubleArgsTests
{
    /// <summary>
    /// Ensures that <see cref="DoubleArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            double.MinValue,
            double.MaxValue,
            default,
            SondorTestConstants.DefaultDoubleValue
        };

        // act
        var actual = new DoubleArgs().Cast<double>().ToArray();

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
        const double value = 10;
        var expected = new[]
        {
            double.MinValue,
            double.MaxValue,
            default,
            value
        };

        // act
        var actual = new DoubleArgs(value).Cast<double>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
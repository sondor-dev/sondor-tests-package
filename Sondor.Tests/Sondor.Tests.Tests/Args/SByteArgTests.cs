using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="SByteArgs"/>.
/// </summary>
[TestFixture]
public class SByteArgTests
{
    /// <summary>
    /// Ensures that <see cref="SByteArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            sbyte.MinValue,
            sbyte.MaxValue,
            default,
            SondorTestConstants.DefaultSbyteValue
        };

        // act
        var actual = new SByteArgs().Cast<sbyte>().ToArray();

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
        const sbyte value = 10;
        var expected = new[]
        {
            sbyte.MinValue,
            sbyte.MaxValue,
            default,
            value
        };

        // act
        var actual = new SByteArgs(value).Cast<sbyte>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
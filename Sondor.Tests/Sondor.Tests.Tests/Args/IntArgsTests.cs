using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="IntArgs"/>.
/// </summary>
[TestFixture]
public class IntArgsTests
{
    /// <summary>
    /// Ensures that <see cref="IntArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            int.MinValue,
            int.MaxValue,
            default,
            SondorTestConstants.DefaultIntValue
        };

        // act
        var actual = new IntArgs().Cast<int>().ToArray();

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
        const int value = 10;
        var expected = new[]
        {
            int.MinValue,
            int.MaxValue,
            default,
            value
        };

        // act
        var actual = new IntArgs(value).Cast<int>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
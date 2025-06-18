using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="TimeSpanArgs"/>.
/// </summary>
[TestFixture]
public class TimeSpanArgsTests
{
    /// <summary>
    /// Ensures that <see cref="TimeSpanArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            TimeSpan.Zero,
            TimeSpan.MinValue, 
            TimeSpan.MaxValue, 
            SondorTestConstants.DefaultTimeSpan,
        };

        // act
        var actual = new TimeSpanArgs().Cast<TimeSpan>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="TimeSpanArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable_with_value()
    {
        // arrange
        var value = TimeSpan.FromSeconds(10);
        var expected = new[]
        {
            TimeSpan.Zero,
            TimeSpan.MinValue,
            TimeSpan.MaxValue,
            value
        };

        // act
        var actual = new TimeSpanArgs(value).Cast<TimeSpan>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
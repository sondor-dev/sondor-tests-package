using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="DateTimeOffsetArgs"/>.
/// </summary>
[TestFixture]
public class DateTimeOffsetArgsTests
{
    /// <summary>
    /// Ensures that <see cref="DateTimeOffsetArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            DateTime.MinValue,
            DateTime.MaxValue,
            default,
            SondorTestConstants.DefaultDateTimeOffsetValue
        };

        // act
        var actual = new DateTimeOffsetArgs().Cast<DateTimeOffset>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="DateTimeOffsetArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable_with_value()
    {
        // arrange
        var value = DateTimeOffset.UtcNow;
        var expected = new[]
        {
            DateTime.MinValue,
            DateTime.MaxValue,
            default,
            value
        };

        // act
        var actual = new DateTimeOffsetArgs(value).Cast<DateTimeOffset>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="DateTimeArgs"/>.
/// </summary>
[TestFixture]
public class DateTimeArgsTests
{
    /// <summary>
    /// Ensures that <see cref="DateTimeArgs"/> returns the correct values.
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
            SondorTestConstants.DefaultDateTimeValue
        };

        // act
        var actual = new DateTimeArgs().Cast<DateTime>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="DateTimeArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable_with_value()
    {
        // arrange
        var value = DateTime.UtcNow;
        var expected = new[]
        {
            DateTime.MinValue,
            DateTime.MaxValue,
            default,
            value
        };

        // act
        var actual = new DateTimeArgs(value).Cast<DateTime>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
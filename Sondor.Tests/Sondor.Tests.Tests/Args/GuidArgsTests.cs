using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="GuidArgs"/>.
/// </summary>
[TestFixture]
public class GuidArgsTests
{
    /// <summary>
    /// Ensures that <see cref="GuidArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            Guid.Empty,
            SondorTestConstants.DefaultGuidValue
        };

        // act
        var actual = new GuidArgs().Cast<Guid>().ToArray();

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
        var value = Guid.NewGuid();
        var expected = new[]
        {
            Guid.Empty,
            value
        };

        // act
        var actual = new GuidArgs(value).Cast<Guid>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
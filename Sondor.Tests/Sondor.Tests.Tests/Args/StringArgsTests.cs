using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="StringArgs"/>.
/// </summary>
[TestFixture]
public class StringArgsTests
{
    /// <summary>
    /// Ensures that <see cref="StringArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            null,
            string.Empty,
            SondorTestConstants.WhitespaceString,
            SondorTestConstants.DefaultStringValue
        };

        // act
        var actual = new StringArgs().Cast<string>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="StringArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable_with_value()
    {
        // arrange
        const string value = "10";
        var expected = new[]
        {
            null,
            string.Empty,
            SondorTestConstants.WhitespaceString,
            value
        };

        // act
        var actual = new StringArgs(value).Cast<string>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
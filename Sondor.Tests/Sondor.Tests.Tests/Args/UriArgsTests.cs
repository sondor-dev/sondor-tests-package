using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="UriArgs"/>.
/// </summary>
[TestFixture]
public class UriArgsTests
{
    /// <summary>
    /// Ensures that <see cref="ULongArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            null,
            new Uri(SondorTestConstants.DefaultRelativeUriValue, UriKind.Relative),
            new Uri(SondorTestConstants.DefaultAbsoluteUriValue, UriKind.Absolute)
        };

        // act
        var actual = new UriArgs().Cast<Uri?>().ToArray();

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
        const string relative = "/test/relative/path";
        const string absolute = "https://admin.sondor-technology.co.uk";

        var expected = new[]
        {
            null,
            new Uri(relative, UriKind.Relative),
            new Uri(absolute, UriKind.Absolute)
        };

        // act
        var actual = new UriArgs(relative, absolute).Cast<Uri?>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
using Sondor.Tests.Args;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Collection of tests for <see cref="BoolArgs"/>.
/// </summary>
[TestFixture]
public class BoolArgsTests
{
    /// <summary>
    /// Ensures that <see cref="BoolArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[] { false, true };

        // act
        var actual = new BoolArgs().Cast<bool>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
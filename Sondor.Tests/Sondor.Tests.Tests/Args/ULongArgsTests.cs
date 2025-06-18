using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="ULongArgs"/>.
/// </summary>
[TestFixture]
public class ULongArgsTests
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
            ulong.MinValue,
            ulong.MaxValue,
            default,
            SondorTestConstants.DefaultULongValue
        };

        // act
        var actual = new ULongArgs().Cast<ulong>().ToArray();

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
        const ulong value = 10;
        var expected = new[]
        {
            ulong.MinValue,
            ulong.MaxValue,
            default,
            value
        };

        // act
        var actual = new ULongArgs(value).Cast<ulong>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
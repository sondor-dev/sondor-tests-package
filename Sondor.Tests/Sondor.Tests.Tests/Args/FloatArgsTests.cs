using Sondor.Tests.Args;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="FloatArgs"/>.
/// </summary>
[TestFixture]
public class FloatArgsTests
{
    /// <summary>
    /// Ensures that <see cref="FloatArgs"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            float.MinValue,
            float.MaxValue,
            default,
            SondorTestConstants.DefaultFloatValue
        };

        // act
        var actual = new FloatArgs().Cast<float>().ToArray();

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
        const float value = 10;
        var expected = new[]
        {
            float.MinValue,
            float.MaxValue,
            default,
            value
        };

        // act
        var actual = new FloatArgs(value).Cast<float>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
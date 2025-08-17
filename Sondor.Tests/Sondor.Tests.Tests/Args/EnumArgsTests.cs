using Sondor.Tests.Args;

namespace Sondor.Tests.Tests.Args;

/// <summary>
/// Tests for <see cref="EnumArgs{TEnum}"/>.
/// </summary>
[TestFixture]
public class EnumArgsTests
{
    /// <summary>
    /// Ensures that <see cref="EnumArgs{TEnum}"/> returns the correct values.
    /// </summary>
    [Test]
    public void IEnumerable()
    {
        // arrange
        var expected = new[]
        {
            TestEnum.Unknown,
            TestEnum.Value1,
            TestEnum.Value2
        };

        // act
        var actual = new EnumArgs<TestEnum>().Cast<TestEnum>().ToArray();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
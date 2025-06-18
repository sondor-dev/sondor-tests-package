using System.Collections;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="long"/> arguments for testing purposes.
/// </summary>
public class LongArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly long Value;

    /// <summary>
    /// Creates a new instance of <see cref="LongArgs"/>.
    /// </summary>
    public LongArgs()
    {
        Value = SondorTestConstants.DefaultLongValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="LongArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public LongArgs(long value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        yield return long.MinValue;
        yield return long.MaxValue;
        yield return default(long);
        yield return Value;
    }
}
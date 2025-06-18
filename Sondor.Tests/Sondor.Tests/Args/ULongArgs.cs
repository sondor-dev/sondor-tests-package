using System.Collections;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="ulong"/> arguments for testing purposes.
/// </summary>
public class ULongArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly ulong Value;

    /// <summary>
    /// Creates a new instance of <see cref="ULongArgs"/>.
    /// </summary>
    public ULongArgs()
    {
        Value = SondorTestConstants.DefaultULongValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="ULongArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public ULongArgs(ulong value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        yield return ulong.MinValue;
        yield return ulong.MaxValue;
        yield return default(ulong);
        yield return Value;
    }
}
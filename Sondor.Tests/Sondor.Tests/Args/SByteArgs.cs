using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="sbyte"/> arguments for testing purposes.
/// </summary>
public class SByteArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly sbyte Value;

    /// <summary>
    /// Creates a new instance of <see cref="SByteArgs"/>.
    /// </summary>
    public SByteArgs()
    {
        Value = SondorTestConstants.DefaultSbyteValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="SByteArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public SByteArgs(sbyte value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        yield return sbyte.MinValue;
        yield return sbyte.MaxValue;
        yield return default(sbyte);
        yield return Value;
    }
}

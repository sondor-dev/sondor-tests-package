using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="byte"/> arguments for testing purposes.
/// </summary>
public class ByteArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly byte Value;

    /// <summary>
    /// Creates a new instance of <see cref="ByteArgs"/>.
    /// </summary>
    public ByteArgs()
    {
        Value = SondorTestConstants.DefaultByteValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="ByteArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public ByteArgs(byte value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        yield return byte.MinValue;
        yield return byte.MaxValue;
        yield return default(byte);
        yield return Value;
    }
}

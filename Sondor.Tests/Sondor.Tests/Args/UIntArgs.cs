using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="uint"/> test arguments.
/// </summary>
public class UIntArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly uint Value;

    /// <summary>
    /// Creates a new instance of <see cref="UIntArgs"/>.
    /// </summary>
    public UIntArgs()
    {
        Value = SondorTestConstants.DefaultUIntValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="UIntArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public UIntArgs(uint value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return uint.MinValue;
        yield return uint.MaxValue;
        yield return default(uint);
        yield return Value;
    }
}

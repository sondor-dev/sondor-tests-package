using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="int"/> test arguments.
/// </summary>
public class IntArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly int Value;

    /// <summary>
    /// Creates a new instance of <see cref="IntArgs"/>.
    /// </summary>
    public IntArgs()
    {
        Value = SondorTestConstants.DefaultIntValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="IntArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public IntArgs(int value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return int.MinValue;
        yield return int.MaxValue;
        yield return default(int);
        yield return Value;
    }
}

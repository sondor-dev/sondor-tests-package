using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="double"/> test arguments.
/// </summary>
public class DoubleArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly double Value;

    /// <summary>
    /// Creates a new instance of <see cref="DoubleArgs"/>.
    /// </summary>
    public DoubleArgs()
    {
        Value = SondorTestConstants.DefaultDoubleValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="DoubleArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public DoubleArgs(double value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return double.MinValue;
        yield return double.MaxValue;
        yield return default(double);
        yield return Value;
    }
}

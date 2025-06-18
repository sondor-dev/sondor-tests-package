using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="float"/> test arguments.
/// </summary>
public class FloatArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly float Value;

    /// <summary>
    /// Creates a new instance of <see cref="FloatArgs"/>.
    /// </summary>
    public FloatArgs()
    {
        Value = SondorTestConstants.DefaultFloatValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="FloatArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public FloatArgs(float value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return float.MinValue;
        yield return float.MaxValue;
        yield return default(float);
        yield return Value;
    }
}

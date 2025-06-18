using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="decimal"/> test arguments.
/// </summary>
public class DecimalArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly decimal Value;

    /// <summary>
    /// Creates a new instance of <see cref="DecimalArgs"/>.
    /// </summary>
    public DecimalArgs()
    {
        Value = SondorTestConstants.DefaultDecimalValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="DecimalArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public DecimalArgs(decimal value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return decimal.MinValue;
        yield return decimal.MaxValue;
        yield return default(decimal);
        yield return Value;
    }
}

using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="short"/> test arguments.
/// </summary>
public class ShortArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly short Value;

    /// <summary>
    /// Creates a new instance of <see cref="ShortArgs"/>.
    /// </summary>
    public ShortArgs()
    {
        Value = SondorTestConstants.DefaultShortValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="ShortArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public ShortArgs(short value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        yield return short.MinValue;
        yield return short.MaxValue;
        yield return default(short);
        yield return Value;
    }
}

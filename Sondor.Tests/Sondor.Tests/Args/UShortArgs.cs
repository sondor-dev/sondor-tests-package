using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="ushort"/> test arguments.
/// </summary>
public class UShortArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly ushort Value;

    /// <summary>
    /// Creates a new instance of <see cref="UShortArgs"/>.
    /// </summary>
    public UShortArgs()
    {
        Value = SondorTestConstants.DefaultUShortValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="UShortArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public UShortArgs(ushort value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        yield return ushort.MinValue;
        yield return ushort.MaxValue;
        yield return default(ushort);
        yield return Value;
    }
}

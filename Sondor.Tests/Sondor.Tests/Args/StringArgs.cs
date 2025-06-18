using Sondor.Tests.Constants;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="string"/> test arguments.
/// </summary>
public class StringArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly string Value;

    /// <summary>
    /// Creates a new instance of <see cref="StringArgs"/>.
    /// </summary>
    public StringArgs()
    {
        Value = SondorTestConstants.DefaultStringValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="StringArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public StringArgs(string value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return null;
        yield return string.Empty;
        yield return SondorTestConstants.WhitespaceString;
        yield return Value;
    }
}
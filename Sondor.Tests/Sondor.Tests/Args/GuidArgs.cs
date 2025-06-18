using Sondor.Tests.Constants;
using System;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="Guid"/> test arguments.
/// </summary>
public class GuidArgs : IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly Guid Value;

    /// <summary>
    /// Creates a new instance of <see cref="GuidArgs"/>.
    /// </summary>
    public GuidArgs()
    {
        Value = SondorTestConstants.DefaultGuidValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="GuidArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public GuidArgs(Guid value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return Guid.Empty;
        yield return Value;
    }
}

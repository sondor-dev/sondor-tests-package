using Sondor.Tests.Constants;
using System;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="TimeSpan"/> test arguments.
/// </summary>
public class TimeSpanArgs : IEnumerable
{
    /// <summary>
    /// The time span.
    /// </summary>
    protected readonly TimeSpan Value;

    /// <summary>
    /// Creates a new instance of <see cref="TimeSpan"/>.
    /// </summary>
    public TimeSpanArgs()
    {
        Value = SondorTestConstants.DefaultTimeSpan;
    }

    /// <summary>
    /// Creates a new instance of <see cref="TimeSpanArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public TimeSpanArgs(TimeSpan value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        yield return TimeSpan.Zero;
        yield return TimeSpan.MinValue;
        yield return TimeSpan.MaxValue;
        yield return Value;
    }
}

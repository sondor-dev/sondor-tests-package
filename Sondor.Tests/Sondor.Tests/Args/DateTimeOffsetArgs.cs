using Sondor.Tests.Constants;
using System;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="DateTimeOffset"/> test arguments.
/// </summary>
public class DateTimeOffsetArgs : IEnumerable
{
    /// <summary>
    /// The date time offset value.
    /// </summary>
    protected readonly DateTimeOffset Value;

    /// <summary>
    /// Creates a new instance of <see cref="DateTimeOffsetArgs"/>.
    /// </summary>
    public DateTimeOffsetArgs()
    {
        Value = SondorTestConstants.DefaultDateTimeOffsetValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="DateTimeOffsetArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public DateTimeOffsetArgs(DateTimeOffset value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return DateTimeOffset.MinValue;
        yield return DateTimeOffset.MaxValue;
        yield return default(DateTimeOffset);
        yield return Value;
    }
}
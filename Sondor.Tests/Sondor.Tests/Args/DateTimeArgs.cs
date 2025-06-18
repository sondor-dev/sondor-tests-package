using Sondor.Tests.Constants;
using System;
using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="DateTime"/> test arguments.
/// </summary>
public class DateTimeArgs : IEnumerable
{
    /// <summary>
    /// The date time value.
    /// </summary>
    protected readonly DateTime Value;

    /// <summary>
    /// Creates a new instance of <see cref="DateTimeArgs"/>.
    /// </summary>
    public DateTimeArgs()
    {
        Value = SondorTestConstants.DefaultDateTimeValue;
    }

    /// <summary>
    /// Creates a new instance of <see cref="DateTimeArgs"/>.
    /// </summary>
    /// <param name="value">The value.</param>
    public DateTimeArgs(DateTime value)
    {
        Value = value;
    }

    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return DateTime.MinValue;
        yield return DateTime.MaxValue;
        yield return default(DateTime);
        yield return Value;
    }
}

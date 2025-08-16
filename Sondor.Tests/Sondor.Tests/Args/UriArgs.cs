using System;
using System.Collections;
using Sondor.Tests.Constants;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="Uri"/> test arguments.
/// </summary>
public class UriArgs :
    IEnumerable
{
    /// <summary>
    /// The value.
    /// </summary>
    protected readonly Uri AbsoluteValue;

    /// <summary>
    /// The relative value.
    /// </summary>
    protected readonly Uri RelativeValue;

    /// <summary>
    /// Creates a new instance of <see cref="UriArgs"/>.
    /// </summary>
    public UriArgs()
    {
        AbsoluteValue = new Uri(SondorTestConstants.DefaultAbsoluteUriValue, UriKind.Absolute);
        RelativeValue = new Uri(SondorTestConstants.DefaultRelativeUriValue, UriKind.Relative);
    }

    /// <summary>
    /// Creates a new instance of <see cref="UriArgs"/>.
    /// </summary>
    /// <param name="absoluteValue">The absolute value.</param>
    /// <param name="relativeValue">The relative value.</param>
    public UriArgs(string? relativeValue = null, string ? absoluteValue = null)
    {
        var absolute = string.IsNullOrWhiteSpace(absoluteValue)
            ? SondorTestConstants.DefaultAbsoluteUriValue
            : absoluteValue;
        var relative = string.IsNullOrWhiteSpace(relativeValue)
            ? SondorTestConstants.DefaultRelativeUriValue
            : relativeValue;

        AbsoluteValue = new Uri(absolute, UriKind.Absolute);
        RelativeValue = new Uri(relative, UriKind.Relative);
    }

    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        yield return null;
        yield return RelativeValue;
        yield return AbsoluteValue;
    }
}
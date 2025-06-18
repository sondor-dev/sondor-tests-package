using System;

namespace Sondor.Tests.Constants;

/// <summary>
/// Collection of Test constants.
/// </summary>
public static class SondorTestConstants
{
    /// <summary>
    /// The default <see cref="sbyte"/> value.
    /// </summary>
    public const sbyte DefaultSbyteValue = 1;

    /// <summary>
    /// The default <see cref="byte"/> value.
    /// </summary>
    public const byte DefaultByteValue = 1;

    /// <summary>
    /// The default <see cref="short"/> value.
    /// </summary>
    public const short DefaultShortValue = 1;

    /// <summary>
    /// The default <see cref="ushort"/> value.
    /// </summary>
    public const ushort DefaultUShortValue = 1;

    /// <summary>
    /// The default <see cref="uint"/> value.
    /// </summary>
    public const uint DefaultUIntValue = 1;

    /// <summary>
    /// The default <see cref="int"/> value.
    /// </summary>
    public const int DefaultIntValue = 1;

    /// <summary>
    /// The default <see cref="ulong"/> value.
    /// </summary>
    public const ulong DefaultULongValue = 1;

    /// <summary>
    /// The default <see cref="long"/> value.
    /// </summary>
    public const long DefaultLongValue = 1L;

    /// <summary>
    /// The default <see cref="float"/> value.
    /// </summary>
    public const float DefaultFloatValue = 1.0f;
    
    /// <summary>
    /// The default <see cref="double"/> value.
    /// </summary>
    public const double DefaultDoubleValue = 1.0;

    /// <summary>
    /// The default <see cref="decimal"/> value.
    /// </summary>
    public const decimal DefaultDecimalValue = 1.0m;

    /// <summary>
    /// The default <see cref="char"/> value.
    /// </summary>
    public const char DefaultCharValue = 'a';

    /// <summary>
    /// The whitespace string constant.
    /// </summary>
    public const string WhitespaceString = " ";

    /// <summary>
    /// The default <see cref="Guid"/> value.
    /// </summary>
    public static readonly Guid DefaultGuidValue =
        Guid.Parse("8aa4d0b1-7ef2-461f-ae74-1f2ecf92d10c");

    /// <summary>
    /// The default date time value.
    /// </summary>
    public static readonly DateTime DefaultDateTimeValue =
        new (2025, 06, 18);

    /// <summary>
    /// The default date time offset value.
    /// </summary>
    public static readonly DateTimeOffset DefaultDateTimeOffsetValue =
        DateTimeOffset.UtcNow;

    /// <summary>
    /// The default time span.
    /// </summary>
    public static readonly TimeSpan DefaultTimeSpan =
        TimeSpan.FromDays(1);

    /// <summary>
    /// The default string value.
    /// </summary>
    public const string DefaultStringValue =
        "value";
}
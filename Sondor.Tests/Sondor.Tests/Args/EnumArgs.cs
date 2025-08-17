using System;
using System.Collections;
using System.Linq;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <typeparamref name="TEnum"/> test arguments.
/// </summary>
/// <typeparam name="TEnum">The enum type.</typeparam>
public class EnumArgs<TEnum> :
    IEnumerable
{
    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        return Enum.GetValues(typeof(TEnum)).Cast<object>().GetEnumerator();
    }
}
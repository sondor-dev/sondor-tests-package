using System.Collections;

namespace Sondor.Tests.Args;

/// <summary>
/// Collection of <see cref="bool"/> test arguments.
/// </summary>
public class BoolArgs : IEnumerable
{
    /// <inheritdoc />
    public virtual IEnumerator GetEnumerator()
    {
        yield return false;
        yield return true;
    }
}

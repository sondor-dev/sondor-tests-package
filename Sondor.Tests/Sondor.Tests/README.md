# Sondor Tests
Sondor Tests is a library of classes and methods to help you write tests for your code.
It provides a set of utilities to make it easier to write unit tests, integration tests,
and functional tests.

## Content
1. [Test arguments](#test-arguments)
2. [NUnit](#nunit)

### Test arguments
| Name | Type | Description |
|------|------|-------------|
| Boolean | `BoolArgs` | An extendable `IEnumerable` providing the range of values availables for `bool` type. |
| Byte | `ByteArgs` | An extendable `IEnumerable` providing the range of values availables for `byte` type. |
| DateTime | `DateTimeArgs` | An extendable `IEnumerable` providing the range of values availables for `DateTime` type. |
| DateTimeOffset | `DateTimeOffsetArgs` | An extendable `IEnumerable` providing the range of values availables for `DateTimeOffset` type. |
| Decimal | `DecimalArgs` | An extendable `IEnumerable` providing the range of values availables for `decimal` type. |
| Double | `DoubleArgs` | An extendable `IEnumerable` providing the range of values availables for `double` type. |
| Float | `FloatArgs` | An extendable `IEnumerable` providing the range of values availables for `float` type. |
| Guid | `GuidArgs` | An extendable `IEnumerable` providing the range of values availables for `Guid` type. |
| Int | `IntArgs` | An extendable `IEnumerable` providing the range of values availables for `int` type. |
| Long | `LongArgs` | An extendable `IEnumerable` providing the range of values availables for `long` type. |
| SByte | `SByteArgs` | An extendable `IEnumerable` providing the range of values availables for `sbyte` type. |
| Short | `ShortArgs` | An extendable `IEnumerable` providing the range of values availables for `short` type. |
| String | `StringArgs` | An extendable `IEnumerable` providing the range of values availables for `string` type. |
| TimeSpan | `TimeSpanArgs` | An extendable `IEnumerable` providing the range of values availables for `TimeSpan` type. |
| UInt | `UIntArgs` | An extendable `IEnumerable` providing the range of values availables for `uint` type. |
| ULong | `ULongArgs` | An extendable `IEnumerable` providing the range of values availables for `ulong` type. |
| UShort | `UShortArgs` | An extendable `IEnumerable` providing the range of values availables for `ushort` type. |

### NUnit
The library supported data driven tests, which allows you to run
the same test with different inputs. Ensuring to cover all possible
scenarios.

```csharp
[TestFixture]
public class MyTests
{
    [TestCaseSource(typeof(IntArgs))]
    public void TestWithInt(int value)
    {
        // Arrange
        var expected = value * 2;
        // Act
        var result = MyMethod(value);
        // Assert
        Assert.AreEqual(expected, result);
    }
}
```
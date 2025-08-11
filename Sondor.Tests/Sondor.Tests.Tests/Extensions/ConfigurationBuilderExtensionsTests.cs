using Microsoft.Extensions.Configuration;
using Sondor.Tests.Extensions;

namespace Sondor.Tests.Tests.Extensions;

/// <summary>
/// Tests for <see cref="ConfigurationBuilderExtensions"/>.
/// </summary>
[TestFixture]
public class ConfigurationBuilderExtensionsTests
{
    /// <summary>
    /// Ensures that <see cref="ConfigurationBuilderExtensions.AddOptions{TOptions}"/> adds the options to configuration correctly.
    /// </summary>
    [Test]
    public void AddOptions()
    {
        // arrange
        const string name = "name";
        string[] items = ["item-1", "item-2"];
        var options = new TestOptions
        {
            Name = name,
            Items = items
        };

        // act
        var configuration = new ConfigurationBuilder()
            .AddOptions(options)
            .Build();

        // assert
        using (Assert.EnterMultipleScope())
        {
            Assert.That(configuration[nameof(TestOptions.Name)], Is.EqualTo(name));

            for (var a = 0; a < items.Length; a++)
            {
                var path = $"{nameof(options.Items)}:{a}";

                Assert.That(configuration[path], Is.EqualTo(items[a]));
            }
        }
    }
}
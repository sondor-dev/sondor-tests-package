using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Sondor.Tests.Extensions;

/// <summary>
/// Collection of configuration builder extensions.
/// </summary>
public static class ConfigurationBuilderExtensions
{
    /// <summary>
    /// Adds <typeparamref name="TOptions"/> to the configuration builder.
    /// </summary>
    /// <typeparam name="TOptions">The options type.</typeparam>
    /// <param name="builder">The builder.</param>
    /// <param name="options">The options.</param>
    /// <param name="sectionName">The section name.</param>
    /// <returns>Returns the builder.</returns>
    public static ConfigurationBuilder AddOptions<TOptions>(this ConfigurationBuilder builder,
        TOptions options,
        string? sectionName = null)
        where TOptions : class
    {
        var values = new List<KeyValuePair<string, string?>>();
        var properties = typeof(TOptions).GetProperties();

        foreach (var property in properties)
        {
            var key = string.IsNullOrWhiteSpace(sectionName) ?
                property.Name :
                $"{sectionName}:{property.Name}";

            var value = property.GetValue(options);

            if (value is Array array)
            {
                var index = 0;

                foreach (var item in array)
                {
                    values.Add(new KeyValuePair<string, string?>($"{key}:{index}", item?.ToString()));

                    index++;
                }

                continue;
            }

            values.Add(new KeyValuePair<string, string?>(key, value?.ToString()));
        }

        builder.AddInMemoryCollection(values);

        return builder;
    }
}

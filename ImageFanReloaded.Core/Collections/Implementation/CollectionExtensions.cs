using System;
using System.Collections.Generic;

namespace ImageFanReloaded.Core.Collections.Implementation;

public static class CollectionExtensions
{
    public static bool IsIndexWithinBounds<T>(this IReadOnlyCollection<T> collection, int index)
    {
        if (collection is null)
            throw new ArgumentNullException(nameof(collection));

        return index >= 0 && index < collection.Count;
    }
}
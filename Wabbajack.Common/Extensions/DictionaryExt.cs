﻿using System;
using System.Collections.Generic;

namespace Wabbajack
{
    public static class DictionaryExt
    {
        public static V TryCreate<K, V>(this IDictionary<K, V> dict, K key)
            where V : new()
        {
            return dict.TryCreate(key, () => new V());
        }

        public static V TryCreate<K, V>(this IDictionary<K, V> dict, K key, Func<V> create)
        {
            if (dict.TryGetValue(key, out var val)) return val;
            var ret = create();
            dict[key] = ret;
            return ret;
        }
    }
}

﻿namespace FeatureLib.Features.DataValues.DataAccess
{
    public class DataContainer
    {
        private static Dictionary<string, string> _values = new Dictionary<string, string>
        {
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" }
        };

        public static Task<List<KeyValuePair<string, string>>> GetAllData()
        {
            return Task.FromResult(_values.ToList());
        }

        internal static Task Add(string key, string value)
        {
            _values.Add(key, value);
            return Task.CompletedTask;
        }

        internal static Task<bool> ContainsKey(string key)
        {
            return Task.FromResult(_values.ContainsKey(key));
        }

        internal static Task<string> GetValueByKey(string key)
        {
            return Task.FromResult(_values[key]);
        }
    }
}
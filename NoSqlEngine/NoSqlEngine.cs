using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NoSqlEngine
{
    public  class NoSqlProcessor
    {
        private const string DBPath = @"D:\TeamProject\TeamProject\NoSqlEngine\Data.json";

        private static async Task<DataEntry[]> ReadDB()
        {
            using (var sourceStream = new StreamReader(DBPath))
            {
                var dataText = await sourceStream.ReadToEndAsync();
                return JsonConvert.DeserializeObject<DataEntry[]>(dataText);
            }
        }

        private static async Task SaveDB(DataEntry[] data)
        {
            using (var sourceStream = new StreamWriter(DBPath, false))
            {
                await sourceStream.WriteAsync(JsonConvert.SerializeObject(data));
            }
        }

        public static async Task<List<T>> GetData<T>()
        {
            var data = await ReadDB();
            return data.Where(x => x.Name == typeof(T).Name).First().PayLoad.Cast<T>().ToList();
        }

        public static async Task ClearData()
        {
            using (var sourceStream = new StreamWriter(DBPath, false))
            {
                await sourceStream.WriteAsync(JsonConvert.SerializeObject(new DataEntry[0]));
            }
        }

        public static async Task CreateEntry<T>(T entry)
        {
            var data = await ReadDB();
            var dataList = data.ToList();
            var entryFile = dataList.Where(x => x.Name == typeof(T).Name).FirstOrDefault();
            if (entryFile == null)
            {
                entryFile = new DataEntry() { Name = typeof(T).Name };
                dataList.Add(entryFile);
            }
            entryFile.PayLoad.Add(entry);
            await SaveDB(dataList.ToArray());
        }
    }

    public class DataEntry
    {
        public string Name { get; set; }
        public List<object> PayLoad { get; set; } = new List<object>();
    }
}

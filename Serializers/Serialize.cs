
using System.Text.Json;
using Avro.IO;
using Avro.Reflect;
using Avro.Specific;

internal class Serialize
{
    public static async Task<Stream> ToJsonAsync(object o, CancellationToken cancelToken)
    {
        var stream = new MemoryStream();
        var jsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        await JsonSerializer.SerializeAsync(stream, o, jsonSerializerOptions, cancelToken);

        stream.Seek(0, SeekOrigin.Begin);
        return stream;
    }

    public static async Task<Stream> ToAvroAsync<T>(T obj, CancellationToken cancelToken) where T : ISpecificRecord
    {
        var stream = new MemoryStream();
        var schema = obj.Schema;
        var serializer = new ReflectWriter<T>(schema);
        var encoder = new BinaryEncoder(stream);

        await Task.Run(() => serializer.Write(obj, encoder), cancelToken);

        stream.Seek(0, SeekOrigin.Begin);
        return stream;
    }
}
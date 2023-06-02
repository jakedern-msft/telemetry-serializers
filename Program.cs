// See https://aka.ms/new-console-template for more information
using Models;
using Serializers;

var model1 = ActiveSessionsDatarow.Generate();
var model2 = PerformanceCountersCommonDatarow.Generate();

var jsonStream = await Serialize.ToJsonAsync(model1, CancellationToken.None);
var avroStream = await Serialize.ToAvroAsync(model1, CancellationToken.None);

var jsonStream2 = await Serialize.ToJsonAsync(model2, CancellationToken.None);
var avroStream2 = await Serialize.ToAvroAsync(model2, CancellationToken.None);

Console.WriteLine($"jsonStream: {jsonStream.Length}");
Console.WriteLine($"avroStream: {avroStream.Length}");

Console.WriteLine($"jsonStream2: {jsonStream2.Length}");
Console.WriteLine($"avroStream2: {avroStream2.Length}");
    
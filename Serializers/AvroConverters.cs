// -----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------------------------

using Avro;
using Avro.Reflect;

namespace Serializers;

internal class Int16ToInt32Converter : TypedFieldConverter<int, short>
{
    public override short From(int o, Schema s) => Convert.ToInt16(o);

    public override int To(short o, Schema s) => Convert.ToInt32(o);
}

internal class ByteToInt32Converter : TypedFieldConverter<int, Byte>
{
    public override Byte From(int o, Schema s) => Convert.ToByte(o);

    public override int To(Byte o, Schema s) => Convert.ToInt32(o);
}

internal class DecimalToAvroDecimalConverter : TypedFieldConverter<AvroDecimal, decimal>
{
    public override decimal From(AvroDecimal o, Schema s) => throw new NotImplementedException();

    public override AvroDecimal To(decimal o, Schema s) => new AvroDecimal(o);
}

internal class DoubleToFloatConverter : TypedFieldConverter<float, double>
{
    public override double From(float o, Schema s) => Convert.ToDouble(o);

    public override float To(double o, Schema s) => Convert.ToSingle(o);
}

internal class GuidToStringConverter : TypedFieldConverter<string, Guid>
{
    public override Guid From(string o, Schema s) => Guid.Parse(o);

    public override string To(Guid o, Schema s) => o.ToString();
}

internal class SingleToDoubleConverter : TypedFieldConverter<double, float>
{
    public override float From(double o, Schema s) => Convert.ToSingle(o);

    public override double To(float o, Schema s) => Convert.ToDouble(o);
}

internal class DateTimeOffsetToLongConverter : TypedFieldConverter<long, DateTimeOffset>
{
    public override DateTimeOffset From(long o, Schema s) => DateTimeOffset.FromUnixTimeMilliseconds(o);

    public override long To(DateTimeOffset o, Schema s) => o.ToUnixTimeMilliseconds();
}

internal class DateTimeOffsetToDateTimeConverter : TypedFieldConverter<DateTime, DateTimeOffset>
{
    public override DateTimeOffset From(DateTime o, Schema s) => new(o);

    public override DateTime To(DateTimeOffset o, Schema s) => o.UtcDateTime;
}

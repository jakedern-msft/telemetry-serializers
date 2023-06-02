using System.Text.Json.Serialization;
using Avro;
using Avro.Reflect;
using Serializers;

namespace Models;

/// <summary>
/// The dataset for the sqlmi performance counters common monitoring target.
/// </summary>
internal sealed class PerformanceCountersCommonDatarow: Avro.Specific.ISpecificRecord
{
#nullable enable // Justification = System.String? needs to be nullable; i.e. parity with db results.

    /// <summary>
    /// Gets the sample time utc.
    /// </summary>
    [AvroField("sample_time_utc")]
    [JsonPropertyName("sample_time_utc")]
    public System.DateTime? SampleTimeUtc { get; }

    /// <summary>
    /// Gets the managed instance name.
    /// </summary>
    [AvroField("managed_instance_name")]
    [JsonPropertyName("managed_instance_name")]
    public System.String? ManagedInstanceName { get; }

    /// <summary>
    /// Gets the replica type.
    /// </summary>
    [AvroField("replica_type")]
    [JsonPropertyName("replica_type")]
    public System.String? ReplicaType { get; }

    /// <summary>
    /// Gets the object name.
    /// </summary>
    [AvroField("object_name")]
    [JsonPropertyName("object_name")]
    public System.String? ObjectName { get; }

    /// <summary>
    /// Gets the counter name.
    /// </summary>
    [AvroField("counter_name")]
    [JsonPropertyName("counter_name")]
    public System.String? CounterName { get; }

    /// <summary>
    /// Gets the instance name.
    /// </summary>
    [AvroField("instance_name")]
    [JsonPropertyName("instance_name")]
    public System.String? InstanceName { get; }

    /// <summary>
    /// Gets the database id.
    /// </summary>
    [AvroField("database_id")]
    [JsonPropertyName("database_id")]
    public System.Int32? DatabaseID { get; }

    /// <summary>
    /// Gets the database name.
    /// </summary>
    [AvroField("database_name")]
    [JsonPropertyName("database_name")]
    public System.String? DatabaseName { get; }

    /// <summary>
    /// Gets the cntr value.
    /// </summary>
    [AvroField("cntr_value", typeof(DoubleToFloatConverter))]
    [JsonPropertyName("cntr_value")]
    public System.Double? CntrValue { get; }

    /// <summary>
    /// Gets the cntr type.
    /// </summary>
    [AvroField("cntr_type")]
    [JsonPropertyName("cntr_type")]
    public System.Int32? CntrType { get; }

#nullable restore // Justification = System.String? needs to be nullable; i.e. parity with db results.

   /// <summary>
   /// JSON String representation of the avro schema for this data row.
   /// <summary>
   [JsonIgnore]
   internal const string AvroSchemaString = @"
   {
       ""type"": ""record"",
       ""name"": ""PerformanceCountersCommonDatarow"",
       ""namespace"": ""Microsoft.Database.Insights"",
       ""fields"": [
           {
               ""name"": ""sample_time_utc"",
               ""type"": [
                   ""null"",
                   {
                       ""type"": ""long"",
                       ""logicalType"": ""timestamp-millis""
                   }
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""managed_instance_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""replica_type"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""object_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""counter_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""instance_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""database_id"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""database_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""cntr_value"",
               ""type"": [
                   ""null"",
                   ""float""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""cntr_type"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
       ]
   }";

   /// <summary>
   /// Parsed schema object for this data row.
   /// <summary>
   [JsonIgnore]
   private static readonly Schema _schema = Schema.Parse(PerformanceCountersCommonDatarow.AvroSchemaString);

   /// <summary>
   /// Public schema object.
   /// <summary>
   [JsonIgnore]
   public Schema Schema => PerformanceCountersCommonDatarow._schema;

    /// <summary>
    /// Initializes a new instance of the <see cref="PerformanceCountersCommonDatarow"/> class.
    /// </summary>
    /// <param name="sampleTimeUtc">The sample time utc.</param>
    /// <param name="managedInstanceName">The managed instance name.</param>
    /// <param name="replicaType">The replica type.</param>
    /// <param name="objectName">The object name.</param>
    /// <param name="counterName">The counter name.</param>
    /// <param name="instanceName">The instance name.</param>
    /// <param name="databaseID">The database id.</param>
    /// <param name="databaseName">The database name.</param>
    /// <param name="cntrValue">The cntr value.</param>
    /// <param name="cntrType">The cntr type.</param>
    public PerformanceCountersCommonDatarow(
        System.DateTime? sampleTimeUtc,
        System.String? managedInstanceName,
        System.String? replicaType,
        System.String? objectName,
        System.String? counterName,
        System.String? instanceName,
        System.Int32? databaseID,
        System.String? databaseName,
        System.Double? cntrValue,
        System.Int32? cntrType)
    {
        this.SampleTimeUtc = sampleTimeUtc;
        this.ManagedInstanceName = managedInstanceName;
        this.ReplicaType = replicaType;
        this.ObjectName = objectName;
        this.CounterName = counterName;
        this.InstanceName = instanceName;
        this.DatabaseID = databaseID;
        this.DatabaseName = databaseName;
        this.CntrValue = cntrValue;
        this.CntrType = cntrType;
    }
   /// <inheritdoc />
   public object Get(int fieldPos)
   {
#pragma warning disable CS8603 // Justification = Fields on this class are nullable and we do not control this interface
       return fieldPos switch
       {
           0 => this.SampleTimeUtc,
           1 => this.ManagedInstanceName,
           2 => this.ReplicaType,
           3 => this.ObjectName,
           4 => this.CounterName,
           5 => this.InstanceName,
           6 => this.DatabaseID,
           7 => this.DatabaseName,
           8 => this.CntrValue,
           9 => this.CntrType,
           _ => throw new AvroRuntimeException("Bad index " + fieldPos)
       };
#pragma warning restore CS8603 // Justification = Fields on this class are nullable and we do not control this interface
   }

   /// <inheritdoc />
   public void Put(int fieldPos, object fieldValue)
   {
       // This method is only required for de-serializing avro messages. Since
       // this application is purely a data producer, we have no need.
       throw new NotImplementedException();
   }
}

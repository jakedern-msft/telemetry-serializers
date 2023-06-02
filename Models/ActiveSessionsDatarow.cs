using System.Text.Json.Serialization;
using Avro;
using Avro.Reflect;
using Serializers;

namespace Models;

/// <summary>
/// The dataset for the sqlmi active sessions monitoring target.
/// </summary>
internal sealed class ActiveSessionsDatarow: Avro.Specific.ISpecificRecord
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
    /// Gets the database id.
    /// </summary>
    [AvroField("database_id", typeof(Int16ToInt32Converter))]
    [JsonPropertyName("database_id")]
    public System.Int16? DatabaseID { get; }

    /// <summary>
    /// Gets the database name.
    /// </summary>
    [AvroField("database_name")]
    [JsonPropertyName("database_name")]
    public System.String? DatabaseName { get; }

    /// <summary>
    /// Gets the session id.
    /// </summary>
    [AvroField("session_id", typeof(Int16ToInt32Converter))]
    [JsonPropertyName("session_id")]
    public System.Int16? SessionID { get; }

    /// <summary>
    /// Gets the session status.
    /// </summary>
    [AvroField("session_status")]
    [JsonPropertyName("session_status")]
    public System.String? SessionStatus { get; }

    /// <summary>
    /// Gets the login time.
    /// </summary>
    [AvroField("login_time")]
    [JsonPropertyName("login_time")]
    public System.DateTime? LoginTime { get; }

    /// <summary>
    /// Gets the login name.
    /// </summary>
    [AvroField("login_name")]
    [JsonPropertyName("login_name")]
    public System.String? LoginName { get; }

    /// <summary>
    /// Gets the host name.
    /// </summary>
    [AvroField("host_name")]
    [JsonPropertyName("host_name")]
    public System.String? HostName { get; }

    /// <summary>
    /// Gets the program name.
    /// </summary>
    [AvroField("program_name")]
    [JsonPropertyName("program_name")]
    public System.String? ProgramName { get; }

    /// <summary>
    /// Gets the workload group id.
    /// </summary>
    [AvroField("workload_group_id")]
    [JsonPropertyName("workload_group_id")]
    public System.Int32? WorkloadGroupID { get; }

    /// <summary>
    /// Gets the workload group name.
    /// </summary>
    [AvroField("workload_group_name")]
    [JsonPropertyName("workload_group_name")]
    public System.String? WorkloadGroupName { get; }

    /// <summary>
    /// Gets the client net address.
    /// </summary>
    [AvroField("client_net_address")]
    [JsonPropertyName("client_net_address")]
    public System.String? ClientNetAddress { get; }

    /// <summary>
    /// Gets the client tcp port.
    /// </summary>
    [AvroField("client_tcp_port")]
    [JsonPropertyName("client_tcp_port")]
    public System.Int32? ClientTcpPort { get; }

    /// <summary>
    /// Gets the local net address.
    /// </summary>
    [AvroField("local_net_address")]
    [JsonPropertyName("local_net_address")]
    public System.String? LocalNetAddress { get; }

    /// <summary>
    /// Gets the local tcp port.
    /// </summary>
    [AvroField("local_tcp_port")]
    [JsonPropertyName("local_tcp_port")]
    public System.Int32? LocalTcpPort { get; }

    /// <summary>
    /// Gets the connection id.
    /// </summary>
    [AvroField("connection_id", typeof(GuidToStringConverter))]
    [JsonPropertyName("connection_id")]
    public System.Guid? ConnectionID { get; }

    /// <summary>
    /// Gets the auth scheme.
    /// </summary>
    [AvroField("auth_scheme")]
    [JsonPropertyName("auth_scheme")]
    public System.String? AuthScheme { get; }

    /// <summary>
    /// Gets the encrypt option.
    /// </summary>
    [AvroField("encrypt_option")]
    [JsonPropertyName("encrypt_option")]
    public System.String? EncryptOption { get; }

    /// <summary>
    /// Gets the session cpu time ms.
    /// </summary>
    [AvroField("session_cpu_time_ms")]
    [JsonPropertyName("session_cpu_time_ms")]
    public System.Int32? SessionCpuTimeMS { get; }

    /// <summary>
    /// Gets the session total elapsed time ms.
    /// </summary>
    [AvroField("session_total_elapsed_time_ms")]
    [JsonPropertyName("session_total_elapsed_time_ms")]
    public System.Int32? SessionTotalElapsedTimeMS { get; }

    /// <summary>
    /// Gets the session logical reads.
    /// </summary>
    [AvroField("session_logical_reads")]
    [JsonPropertyName("session_logical_reads")]
    public System.Int64? SessionLogicalReads { get; }

    /// <summary>
    /// Gets the session writes.
    /// </summary>
    [AvroField("session_writes")]
    [JsonPropertyName("session_writes")]
    public System.Int64? SessionWrites { get; }

    /// <summary>
    /// Gets the session row count.
    /// </summary>
    [AvroField("session_row_count")]
    [JsonPropertyName("session_row_count")]
    public System.Int64? SessionRowCount { get; }

    /// <summary>
    /// Gets the tempdb allocations kb.
    /// </summary>
    [AvroField("tempdb_allocations_kb")]
    [JsonPropertyName("tempdb_allocations_kb")]
    public System.Int64? TempdbAllocationsKB { get; }

    /// <summary>
    /// Gets the tempdb current kb.
    /// </summary>
    [AvroField("tempdb_current_kb")]
    [JsonPropertyName("tempdb_current_kb")]
    public System.Int64? TempdbCurrentKB { get; }

    /// <summary>
    /// Gets the input buffer text.
    /// </summary>
    [AvroField("input_buffer_text")]
    [JsonPropertyName("input_buffer_text")]
    public System.String? InputBufferText { get; }

    /// <summary>
    /// Gets the request id.
    /// </summary>
    [AvroField("request_id")]
    [JsonPropertyName("request_id")]
    public System.Int32? RequestID { get; }

    /// <summary>
    /// Gets the request start time.
    /// </summary>
    [AvroField("request_start_time")]
    [JsonPropertyName("request_start_time")]
    public System.DateTime? RequestStartTime { get; }

    /// <summary>
    /// Gets the request status.
    /// </summary>
    [AvroField("request_status")]
    [JsonPropertyName("request_status")]
    public System.String? RequestStatus { get; }

    /// <summary>
    /// Gets the command.
    /// </summary>
    [AvroField("command")]
    [JsonPropertyName("command")]
    public System.String? Command { get; }

    /// <summary>
    /// Gets the statement text.
    /// </summary>
    [AvroField("statement_text")]
    [JsonPropertyName("statement_text")]
    public System.String? StatementText { get; }

    /// <summary>
    /// Gets the sql module object id.
    /// </summary>
    [AvroField("sql_module_object_id")]
    [JsonPropertyName("sql_module_object_id")]
    public System.Int32? SqlModuleObjectID { get; }

    /// <summary>
    /// Gets the sql module name.
    /// </summary>
    [AvroField("sql_module_name")]
    [JsonPropertyName("sql_module_name")]
    public System.String? SqlModuleName { get; }

    /// <summary>
    /// Gets the wait type.
    /// </summary>
    [AvroField("wait_type")]
    [JsonPropertyName("wait_type")]
    public System.String? WaitType { get; }

    /// <summary>
    /// Gets the wait time ms.
    /// </summary>
    [AvroField("wait_time_ms")]
    [JsonPropertyName("wait_time_ms")]
    public System.Int32? WaitTimeMS { get; }

    /// <summary>
    /// Gets the wait resource.
    /// </summary>
    [AvroField("wait_resource")]
    [JsonPropertyName("wait_resource")]
    public System.String? WaitResource { get; }

    /// <summary>
    /// Gets the blocking session id.
    /// </summary>
    [AvroField("blocking_session_id", typeof(Int16ToInt32Converter))]
    [JsonPropertyName("blocking_session_id")]
    public System.Int16? BlockingSessionID { get; }

    /// <summary>
    /// Gets the open transaction count.
    /// </summary>
    [AvroField("open_transaction_count")]
    [JsonPropertyName("open_transaction_count")]
    public System.Int32? OpenTransactionCount { get; }

    /// <summary>
    /// Gets the transaction isolation level.
    /// </summary>
    [AvroField("transaction_isolation_level")]
    [JsonPropertyName("transaction_isolation_level")]
    public System.String? TransactionIsolationLevel { get; }

    /// <summary>
    /// Gets the request cpu time ms.
    /// </summary>
    [AvroField("request_cpu_time_ms")]
    [JsonPropertyName("request_cpu_time_ms")]
    public System.Int32? RequestCpuTimeMS { get; }

    /// <summary>
    /// Gets the request total elapsed time ms.
    /// </summary>
    [AvroField("request_total_elapsed_time_ms")]
    [JsonPropertyName("request_total_elapsed_time_ms")]
    public System.Int32? RequestTotalElapsedTimeMS { get; }

    /// <summary>
    /// Gets the request logical reads.
    /// </summary>
    [AvroField("request_logical_reads")]
    [JsonPropertyName("request_logical_reads")]
    public System.Int64? RequestLogicalReads { get; }

    /// <summary>
    /// Gets the request writes.
    /// </summary>
    [AvroField("request_writes")]
    [JsonPropertyName("request_writes")]
    public System.Int64? RequestWrites { get; }

    /// <summary>
    /// Gets the request row count.
    /// </summary>
    [AvroField("request_row_count")]
    [JsonPropertyName("request_row_count")]
    public System.Int64? RequestRowCount { get; }

    /// <summary>
    /// Gets the percent complete.
    /// </summary>
    [AvroField("percent_complete")]
    [JsonPropertyName("percent_complete")]
    public System.Single? PercentComplete { get; }

    /// <summary>
    /// Gets the query hash.
    /// </summary>
    [AvroField("query_hash")]
    [JsonPropertyName("query_hash")]
    public System.String? QueryHash { get; }

    /// <summary>
    /// Gets the query plan hash.
    /// </summary>
    [AvroField("query_plan_hash")]
    [JsonPropertyName("query_plan_hash")]
    public System.String? QueryPlanHash { get; }

    /// <summary>
    /// Gets the memory grant kb.
    /// </summary>
    [AvroField("memory_grant_kb")]
    [JsonPropertyName("memory_grant_kb")]
    public System.Int32? MemoryGrantKB { get; }

    /// <summary>
    /// Gets the requested memory kb.
    /// </summary>
    [AvroField("requested_memory_kb")]
    [JsonPropertyName("requested_memory_kb")]
    public System.Int64? RequestedMemoryKB { get; }

    /// <summary>
    /// Gets the max used memory kb.
    /// </summary>
    [AvroField("max_used_memory_kb")]
    [JsonPropertyName("max_used_memory_kb")]
    public System.Int64? MaxUsedMemoryKB { get; }

    /// <summary>
    /// Gets the ideal memory kb.
    /// </summary>
    [AvroField("ideal_memory_kb")]
    [JsonPropertyName("ideal_memory_kb")]
    public System.Int64? IdealMemoryKB { get; }

    /// <summary>
    /// Gets the dop.
    /// </summary>
    [AvroField("dop")]
    [JsonPropertyName("dop")]
    public System.Int32? Dop { get; }

    /// <summary>
    /// Gets the parallel worker count.
    /// </summary>
    [AvroField("parallel_worker_count")]
    [JsonPropertyName("parallel_worker_count")]
    public System.Int32? ParallelWorkerCount { get; }

    /// <summary>
    /// Gets the pending task count.
    /// </summary>
    [AvroField("pending_task_count")]
    [JsonPropertyName("pending_task_count")]
    public System.Int32? PendingTaskCount { get; }

    /// <summary>
    /// Gets the runnable task count.
    /// </summary>
    [AvroField("runnable_task_count")]
    [JsonPropertyName("runnable_task_count")]
    public System.Int32? RunnableTaskCount { get; }

    /// <summary>
    /// Gets the running task count.
    /// </summary>
    [AvroField("running_task_count")]
    [JsonPropertyName("running_task_count")]
    public System.Int32? RunningTaskCount { get; }

    /// <summary>
    /// Gets the suspended task count.
    /// </summary>
    [AvroField("suspended_task_count")]
    [JsonPropertyName("suspended_task_count")]
    public System.Int32? SuspendedTaskCount { get; }

    /// <summary>
    /// Gets the done task count.
    /// </summary>
    [AvroField("done_task_count")]
    [JsonPropertyName("done_task_count")]
    public System.Int32? DoneTaskCount { get; }

    /// <summary>
    /// Gets the spinloop task count.
    /// </summary>
    [AvroField("spinloop_task_count")]
    [JsonPropertyName("spinloop_task_count")]
    public System.Int32? SpinloopTaskCount { get; }

    /// <summary>
    /// Gets the session wait stats.
    /// </summary>
    [AvroField("session_wait_stats")]
    [JsonPropertyName("session_wait_stats")]
    public System.String? SessionWaitStats { get; }

#nullable restore // Justification = System.String? needs to be nullable; i.e. parity with db results.

   /// <summary>
   /// JSON String representation of the avro schema for this data row.
   /// <summary>
   [JsonIgnore]
   internal const string AvroSchemaString = @"
   {
       ""type"": ""record"",
       ""name"": ""ActiveSessionsDatarow"",
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
               ""name"": ""session_id"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""session_status"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""login_time"",
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
               ""name"": ""login_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""host_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""program_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""workload_group_id"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""workload_group_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""client_net_address"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""client_tcp_port"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""local_net_address"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""local_tcp_port"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""connection_id"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""auth_scheme"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""encrypt_option"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""session_cpu_time_ms"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""session_total_elapsed_time_ms"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""session_logical_reads"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""session_writes"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""session_row_count"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""tempdb_allocations_kb"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""tempdb_current_kb"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""input_buffer_text"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""request_id"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""request_start_time"",
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
               ""name"": ""request_status"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""command"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""statement_text"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""sql_module_object_id"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""sql_module_name"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""wait_type"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""wait_time_ms"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""wait_resource"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""blocking_session_id"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""open_transaction_count"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""transaction_isolation_level"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""request_cpu_time_ms"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""request_total_elapsed_time_ms"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""request_logical_reads"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""request_writes"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""request_row_count"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""percent_complete"",
               ""type"": [
                   ""null"",
                   ""float""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""query_hash"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""query_plan_hash"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""memory_grant_kb"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""requested_memory_kb"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""max_used_memory_kb"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""ideal_memory_kb"",
               ""type"": [
                   ""null"",
                   ""long""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""dop"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""parallel_worker_count"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""pending_task_count"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""runnable_task_count"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""running_task_count"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""suspended_task_count"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""done_task_count"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""spinloop_task_count"",
               ""type"": [
                   ""null"",
                   ""int""
               ],
               ""default"": ""null""
           },
           {
               ""name"": ""session_wait_stats"",
               ""type"": [
                   ""null"",
                   ""string""
               ],
               ""default"": ""null""
           },
       ]
   }";

   /// <summary>
   /// Parsed schema object for this data row.
   /// <summary>
   [JsonIgnore]
   private static readonly Schema _schema = Schema.Parse(ActiveSessionsDatarow.AvroSchemaString);

   /// <summary>
   /// Public schema object.
   /// <summary>
   [JsonIgnore]
   public Schema Schema => ActiveSessionsDatarow._schema;

    /// <summary>
    /// Initializes a new instance of the <see cref="ActiveSessionsDatarow"/> class.
    /// </summary>
    /// <param name="sampleTimeUtc">The sample time utc.</param>
    /// <param name="managedInstanceName">The managed instance name.</param>
    /// <param name="replicaType">The replica type.</param>
    /// <param name="databaseID">The database id.</param>
    /// <param name="databaseName">The database name.</param>
    /// <param name="sessionID">The session id.</param>
    /// <param name="sessionStatus">The session status.</param>
    /// <param name="loginTime">The login time.</param>
    /// <param name="loginName">The login name.</param>
    /// <param name="hostName">The host name.</param>
    /// <param name="programName">The program name.</param>
    /// <param name="workloadGroupID">The workload group id.</param>
    /// <param name="workloadGroupName">The workload group name.</param>
    /// <param name="clientNetAddress">The client net address.</param>
    /// <param name="clientTcpPort">The client tcp port.</param>
    /// <param name="localNetAddress">The local net address.</param>
    /// <param name="localTcpPort">The local tcp port.</param>
    /// <param name="connectionID">The connection id.</param>
    /// <param name="authScheme">The auth scheme.</param>
    /// <param name="encryptOption">The encrypt option.</param>
    /// <param name="sessionCpuTimeMS">The session cpu time ms.</param>
    /// <param name="sessionTotalElapsedTimeMS">The session total elapsed time ms.</param>
    /// <param name="sessionLogicalReads">The session logical reads.</param>
    /// <param name="sessionWrites">The session writes.</param>
    /// <param name="sessionRowCount">The session row count.</param>
    /// <param name="tempdbAllocationsKB">The tempdb allocations kb.</param>
    /// <param name="tempdbCurrentKB">The tempdb current kb.</param>
    /// <param name="inputBufferText">The input buffer text.</param>
    /// <param name="requestID">The request id.</param>
    /// <param name="requestStartTime">The request start time.</param>
    /// <param name="requestStatus">The request status.</param>
    /// <param name="command">The command.</param>
    /// <param name="statementText">The statement text.</param>
    /// <param name="sqlModuleObjectID">The sql module object id.</param>
    /// <param name="sqlModuleName">The sql module name.</param>
    /// <param name="waitType">The wait type.</param>
    /// <param name="waitTimeMS">The wait time ms.</param>
    /// <param name="waitResource">The wait resource.</param>
    /// <param name="blockingSessionID">The blocking session id.</param>
    /// <param name="openTransactionCount">The open transaction count.</param>
    /// <param name="transactionIsolationLevel">The transaction isolation level.</param>
    /// <param name="requestCpuTimeMS">The request cpu time ms.</param>
    /// <param name="requestTotalElapsedTimeMS">The request total elapsed time ms.</param>
    /// <param name="requestLogicalReads">The request logical reads.</param>
    /// <param name="requestWrites">The request writes.</param>
    /// <param name="requestRowCount">The request row count.</param>
    /// <param name="percentComplete">The percent complete.</param>
    /// <param name="queryHash">The query hash.</param>
    /// <param name="queryPlanHash">The query plan hash.</param>
    /// <param name="memoryGrantKB">The memory grant kb.</param>
    /// <param name="requestedMemoryKB">The requested memory kb.</param>
    /// <param name="maxUsedMemoryKB">The max used memory kb.</param>
    /// <param name="idealMemoryKB">The ideal memory kb.</param>
    /// <param name="dop">The dop.</param>
    /// <param name="parallelWorkerCount">The parallel worker count.</param>
    /// <param name="pendingTaskCount">The pending task count.</param>
    /// <param name="runnableTaskCount">The runnable task count.</param>
    /// <param name="runningTaskCount">The running task count.</param>
    /// <param name="suspendedTaskCount">The suspended task count.</param>
    /// <param name="doneTaskCount">The done task count.</param>
    /// <param name="spinloopTaskCount">The spinloop task count.</param>
    /// <param name="sessionWaitStats">The session wait stats.</param>
    public ActiveSessionsDatarow(
        System.DateTime? sampleTimeUtc,
        System.String? managedInstanceName,
        System.String? replicaType,
        System.Int16? databaseID,
        System.String? databaseName,
        System.Int16? sessionID,
        System.String? sessionStatus,
        System.DateTime? loginTime,
        System.String? loginName,
        System.String? hostName,
        System.String? programName,
        System.Int32? workloadGroupID,
        System.String? workloadGroupName,
        System.String? clientNetAddress,
        System.Int32? clientTcpPort,
        System.String? localNetAddress,
        System.Int32? localTcpPort,
        System.Guid? connectionID,
        System.String? authScheme,
        System.String? encryptOption,
        System.Int32? sessionCpuTimeMS,
        System.Int32? sessionTotalElapsedTimeMS,
        System.Int64? sessionLogicalReads,
        System.Int64? sessionWrites,
        System.Int64? sessionRowCount,
        System.Int64? tempdbAllocationsKB,
        System.Int64? tempdbCurrentKB,
        System.String? inputBufferText,
        System.Int32? requestID,
        System.DateTime? requestStartTime,
        System.String? requestStatus,
        System.String? command,
        System.String? statementText,
        System.Int32? sqlModuleObjectID,
        System.String? sqlModuleName,
        System.String? waitType,
        System.Int32? waitTimeMS,
        System.String? waitResource,
        System.Int16? blockingSessionID,
        System.Int32? openTransactionCount,
        System.String? transactionIsolationLevel,
        System.Int32? requestCpuTimeMS,
        System.Int32? requestTotalElapsedTimeMS,
        System.Int64? requestLogicalReads,
        System.Int64? requestWrites,
        System.Int64? requestRowCount,
        System.Single? percentComplete,
        System.String? queryHash,
        System.String? queryPlanHash,
        System.Int32? memoryGrantKB,
        System.Int64? requestedMemoryKB,
        System.Int64? maxUsedMemoryKB,
        System.Int64? idealMemoryKB,
        System.Int32? dop,
        System.Int32? parallelWorkerCount,
        System.Int32? pendingTaskCount,
        System.Int32? runnableTaskCount,
        System.Int32? runningTaskCount,
        System.Int32? suspendedTaskCount,
        System.Int32? doneTaskCount,
        System.Int32? spinloopTaskCount,
        System.String? sessionWaitStats)
    {
        this.SampleTimeUtc = sampleTimeUtc;
        this.ManagedInstanceName = managedInstanceName;
        this.ReplicaType = replicaType;
        this.DatabaseID = databaseID;
        this.DatabaseName = databaseName;
        this.SessionID = sessionID;
        this.SessionStatus = sessionStatus;
        this.LoginTime = loginTime;
        this.LoginName = loginName;
        this.HostName = hostName;
        this.ProgramName = programName;
        this.WorkloadGroupID = workloadGroupID;
        this.WorkloadGroupName = workloadGroupName;
        this.ClientNetAddress = clientNetAddress;
        this.ClientTcpPort = clientTcpPort;
        this.LocalNetAddress = localNetAddress;
        this.LocalTcpPort = localTcpPort;
        this.ConnectionID = connectionID;
        this.AuthScheme = authScheme;
        this.EncryptOption = encryptOption;
        this.SessionCpuTimeMS = sessionCpuTimeMS;
        this.SessionTotalElapsedTimeMS = sessionTotalElapsedTimeMS;
        this.SessionLogicalReads = sessionLogicalReads;
        this.SessionWrites = sessionWrites;
        this.SessionRowCount = sessionRowCount;
        this.TempdbAllocationsKB = tempdbAllocationsKB;
        this.TempdbCurrentKB = tempdbCurrentKB;
        this.InputBufferText = inputBufferText;
        this.RequestID = requestID;
        this.RequestStartTime = requestStartTime;
        this.RequestStatus = requestStatus;
        this.Command = command;
        this.StatementText = statementText;
        this.SqlModuleObjectID = sqlModuleObjectID;
        this.SqlModuleName = sqlModuleName;
        this.WaitType = waitType;
        this.WaitTimeMS = waitTimeMS;
        this.WaitResource = waitResource;
        this.BlockingSessionID = blockingSessionID;
        this.OpenTransactionCount = openTransactionCount;
        this.TransactionIsolationLevel = transactionIsolationLevel;
        this.RequestCpuTimeMS = requestCpuTimeMS;
        this.RequestTotalElapsedTimeMS = requestTotalElapsedTimeMS;
        this.RequestLogicalReads = requestLogicalReads;
        this.RequestWrites = requestWrites;
        this.RequestRowCount = requestRowCount;
        this.PercentComplete = percentComplete;
        this.QueryHash = queryHash;
        this.QueryPlanHash = queryPlanHash;
        this.MemoryGrantKB = memoryGrantKB;
        this.RequestedMemoryKB = requestedMemoryKB;
        this.MaxUsedMemoryKB = maxUsedMemoryKB;
        this.IdealMemoryKB = idealMemoryKB;
        this.Dop = dop;
        this.ParallelWorkerCount = parallelWorkerCount;
        this.PendingTaskCount = pendingTaskCount;
        this.RunnableTaskCount = runnableTaskCount;
        this.RunningTaskCount = runningTaskCount;
        this.SuspendedTaskCount = suspendedTaskCount;
        this.DoneTaskCount = doneTaskCount;
        this.SpinloopTaskCount = spinloopTaskCount;
        this.SessionWaitStats = sessionWaitStats;
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
           3 => this.DatabaseID,
           4 => this.DatabaseName,
           5 => this.SessionID,
           6 => this.SessionStatus,
           7 => this.LoginTime,
           8 => this.LoginName,
           9 => this.HostName,
           10 => this.ProgramName,
           11 => this.WorkloadGroupID,
           12 => this.WorkloadGroupName,
           13 => this.ClientNetAddress,
           14 => this.ClientTcpPort,
           15 => this.LocalNetAddress,
           16 => this.LocalTcpPort,
           17 => this.ConnectionID,
           18 => this.AuthScheme,
           19 => this.EncryptOption,
           20 => this.SessionCpuTimeMS,
           21 => this.SessionTotalElapsedTimeMS,
           22 => this.SessionLogicalReads,
           23 => this.SessionWrites,
           24 => this.SessionRowCount,
           25 => this.TempdbAllocationsKB,
           26 => this.TempdbCurrentKB,
           27 => this.InputBufferText,
           28 => this.RequestID,
           29 => this.RequestStartTime,
           30 => this.RequestStatus,
           31 => this.Command,
           32 => this.StatementText,
           33 => this.SqlModuleObjectID,
           34 => this.SqlModuleName,
           35 => this.WaitType,
           36 => this.WaitTimeMS,
           37 => this.WaitResource,
           38 => this.BlockingSessionID,
           39 => this.OpenTransactionCount,
           40 => this.TransactionIsolationLevel,
           41 => this.RequestCpuTimeMS,
           42 => this.RequestTotalElapsedTimeMS,
           43 => this.RequestLogicalReads,
           44 => this.RequestWrites,
           45 => this.RequestRowCount,
           46 => this.PercentComplete,
           47 => this.QueryHash,
           48 => this.QueryPlanHash,
           49 => this.MemoryGrantKB,
           50 => this.RequestedMemoryKB,
           51 => this.MaxUsedMemoryKB,
           52 => this.IdealMemoryKB,
           53 => this.Dop,
           54 => this.ParallelWorkerCount,
           55 => this.PendingTaskCount,
           56 => this.RunnableTaskCount,
           57 => this.RunningTaskCount,
           58 => this.SuspendedTaskCount,
           59 => this.DoneTaskCount,
           60 => this.SpinloopTaskCount,
           61 => this.SessionWaitStats,
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
 
    public ActiveSessionsDatarow Generate()
    {
        return new ActiveSessionsDatarow
        (
            sampleTimeUtc: System.DateTime.UtcNow,
            managedInstanceName: "ManagedInstanceName",
            replicaType: "ReplicaType",
            databaseID: 1,
            databaseName: "DatabaseName",
            sessionID: 1,
            sessionStatus: "SessionStatus",
            loginTime: System.DateTime.UtcNow,
            loginName: "LoginName",
            hostName: "HostName",
            programName: "ProgramName",
            workloadGroupID: 1,
            workloadGroupName: "WorkloadGroupName",
            clientNetAddress: "ClientNetAddress",
            clientTcpPort: 1,
            localNetAddress: "LocalNetAddress",
            localTcpPort: 1,
            connectionID: System.Guid.NewGuid(),
            authScheme: "AuthScheme",
            encryptOption: "EncryptOption",
            sessionCpuTimeMS: 1,
            sessionTotalElapsedTimeMS: 1,
            sessionLogicalReads: 1,
            sessionWrites: 1,
            sessionRowCount: 1,
            tempdbAllocationsKB: 1,
            tempdbCurrentKB: 1,
            inputBufferText: "InputBufferText",
            requestID: 1,
            requestStartTime: System.DateTime.UtcNow,
            requestStatus: "RequestStatus",
            command: "Command",
            statementText: "StatementText",
            sqlModuleObjectID: 1,
            sqlModuleName: "SqlModuleName",
            waitType: "WaitType",
            waitTimeMS: 1,
            waitResource: "WaitResource",
            blockingSessionID: 1,
            openTransactionCount: 1,
            transactionIsolationLevel: "TransactionIsolationLevel",
            requestCpuTimeMS: 1,
            requestTotalElapsedTimeMS: 1,
            requestLogicalReads: 1,
            requestWrites: 1,
            requestRowCount: 1,
            percentComplete: 1,
            queryHash: "QueryHash",
            queryPlanHash: "QueryPlanHash",
            memoryGrantKB: 1,
            requestedMemoryKB: 1,
            maxUsedMemoryKB: 1,
            idealMemoryKB: 1,
            dop: 1,
            parallelWorkerCount: 1,
            pendingTaskCount: 1,
            runnableTaskCount: 1,
            runningTaskCount: 1,
            suspendedTaskCount: 1,
            doneTaskCount: 1,
            spinloopTaskCount: 1,
            sessionWaitStats: "SessionWaitStats"
        );
    }
}
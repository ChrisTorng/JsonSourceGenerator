using System.Diagnostics;
using System.Text.Json.Serialization;
using NetStandard20;

namespace Net60Tests;

[JsonSerializable(typeof(Person))]
[DebuggerNonUserCode]
public partial class Net60JsonContext : JsonSerializerContext
{
}

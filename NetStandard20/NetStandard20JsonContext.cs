using System.Diagnostics;
using System.Text.Json.Serialization;

namespace NetStandard20;

[JsonSerializable(typeof(Person))]
[DebuggerNonUserCode]
public partial class NetStandard20JsonContext : JsonSerializerContext
{
}

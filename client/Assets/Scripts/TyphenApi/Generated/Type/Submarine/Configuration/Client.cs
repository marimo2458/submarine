// This file was generated by typhen-api

using System.Collections.Generic;

namespace TyphenApi.Type.Submarine.Configuration
{
    [MessagePack.MessagePackObject]
    [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public partial class Client : TyphenApi.TypeBase<Client>
    {
        [TyphenApi.QueryStringProperty("version", false)]
        [MessagePack.Key("version")]
        [Newtonsoft.Json.JsonProperty("version")]
        [Newtonsoft.Json.JsonRequired]
        public string Version { get; set; }
        [TyphenApi.QueryStringProperty("api_server_base_uri", false)]
        [MessagePack.Key("api_server_base_uri")]
        [Newtonsoft.Json.JsonProperty("api_server_base_uri")]
        [Newtonsoft.Json.JsonRequired]
        public string ApiServerBaseUri { get; set; }
    }
}

// This file was generated by typhen-api

using System.Collections.Generic;

namespace TyphenApi.Type.Submarine.Battle
{
    [MessagePack.MessagePackObject]
    [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public partial class Equipment : TyphenApi.TypeBase<Equipment>
    {
        [TyphenApi.QueryStringProperty("actor_id", false)]
        [MessagePack.Key("actor_id")]
        [Newtonsoft.Json.JsonProperty("actor_id")]
        [Newtonsoft.Json.JsonRequired]
        public long ActorId { get; set; }
        [TyphenApi.QueryStringProperty("torpedos", false)]
        [MessagePack.Key("torpedos")]
        [Newtonsoft.Json.JsonProperty("torpedos")]
        [Newtonsoft.Json.JsonRequired]
        public List<TyphenApi.Type.Submarine.Battle.EquipmentItem> Torpedos { get; set; }
        [TyphenApi.QueryStringProperty("pinger", false)]
        [MessagePack.Key("pinger")]
        [Newtonsoft.Json.JsonProperty("pinger")]
        [Newtonsoft.Json.JsonRequired]
        public TyphenApi.Type.Submarine.Battle.EquipmentItem Pinger { get; set; }
        [TyphenApi.QueryStringProperty("watcher", false)]
        [MessagePack.Key("watcher")]
        [Newtonsoft.Json.JsonProperty("watcher")]
        [Newtonsoft.Json.JsonRequired]
        public TyphenApi.Type.Submarine.Battle.EquipmentItem Watcher { get; set; }
    }
}

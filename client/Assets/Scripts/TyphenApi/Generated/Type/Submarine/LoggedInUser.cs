// This file was generated by typhen-api

using System.Collections.Generic;

namespace TyphenApi.Type.Submarine
{
    [MessagePack.MessagePackObject]
    [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public partial class LoggedInUser : TyphenApi.Type.Submarine.User
    {
        [TyphenApi.QueryStringProperty("joined_room", true)]
        [MessagePack.Key("joined_room")]
        [Newtonsoft.Json.JsonProperty("joined_room")]
        public TyphenApi.Type.Submarine.JoinedRoom JoinedRoom { get; set; }
    }
}

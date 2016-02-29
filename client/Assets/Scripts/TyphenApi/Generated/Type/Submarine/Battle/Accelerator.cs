// This file was generated by typhen-api

using System.Collections.Generic;

namespace TyphenApi.Type.Submarine.Battle
{
    public partial class Accelerator : TyphenApi.TypeBase<Accelerator>
    {
        protected static readonly SerializationInfo<Accelerator, double> maxSpeed = new SerializationInfo<Accelerator, double>("max_speed", false, (x) => x.MaxSpeed, (x, v) => x.MaxSpeed = v);
        public double MaxSpeed { get; set; }
        protected static readonly SerializationInfo<Accelerator, long> duration = new SerializationInfo<Accelerator, long>("duration", false, (x) => x.Duration, (x, v) => x.Duration = v);
        public long Duration { get; set; }
        protected static readonly SerializationInfo<Accelerator, double> startRate = new SerializationInfo<Accelerator, double>("start_rate", false, (x) => x.StartRate, (x, v) => x.StartRate = v);
        public double StartRate { get; set; }
        protected static readonly SerializationInfo<Accelerator, bool> isAccelerating = new SerializationInfo<Accelerator, bool>("is_accelerating", false, (x) => x.IsAccelerating, (x, v) => x.IsAccelerating = v);
        public bool IsAccelerating { get; set; }
        protected static readonly SerializationInfo<Accelerator, long> changedAt = new SerializationInfo<Accelerator, long>("changed_at", false, (x) => x.ChangedAt, (x, v) => x.ChangedAt = v);
        public long ChangedAt { get; set; }
    }
}

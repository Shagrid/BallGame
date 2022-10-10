using UnityEngine;

namespace BallGame
{
    public sealed class UnityTimeService : Service
    {
        public float DeltaTime() => Time.deltaTime;
    }
}
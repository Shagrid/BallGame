using System;
using UnityEngine;

namespace BallGame
{
    [Serializable]
    public sealed class LevelData
    {
        public LevelType LevelType;
        public GameObject LocationPrefab;
    }
}
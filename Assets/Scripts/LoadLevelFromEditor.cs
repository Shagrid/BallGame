using BallGame;
using UnityEngine;

namespace Editor
{
    public sealed class LoadLevelFromEditor : MonoBehaviour
    {
        [SerializeField] private LevelType _levelType;
        [SerializeField] private CharacterType _characterType;

        public void Load()
        {
            if (Application.isPlaying)
                Services.Instance.LoadLevelService.LoadLevel(_levelType, _characterType);
        }
    }
}
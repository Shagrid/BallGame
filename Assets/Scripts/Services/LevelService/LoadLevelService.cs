using UnityEngine;

namespace BallGame
{
    public class LoadLevelService
    {
        private GameObject _currentLevel;
        private LevelType _levelType;
        private CharacterType _characterType;

        public void LoadLevel(LevelType levelType, CharacterType characterType)
        {
            DestroyLevel();
            _levelType = levelType;
            _characterType = characterType;
            var lvl = Data.Instance.LevelsData.GetPrefabLevel(levelType);
            _currentLevel = GameObject.Instantiate(lvl);
            var characterPosition = GameObject.FindWithTag(TagManager.GetTag(TagType.CharacterPosition)).transform;
            Data.Instance.Character.Initialization(_characterType, characterPosition);
        }

        private void DestroyLevel()
        {
            if (_currentLevel == null) return;
            GameObject.Destroy(_currentLevel);
        }

        public bool IsLvlLoaded()
        {
            return _currentLevel != null;
        }
    }
}
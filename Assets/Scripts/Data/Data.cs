using System;
using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;

namespace BallGame
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {
        public static Data Instance => _instance.Value;
        
        [SerializeField] private string _levelsDataPath;
        [SerializeField] private string _characterDataPath;
        
        private static LevelsData _levelsData;
        private static CharacterData _characterData;
        
        private static readonly Lazy<Data> _instance = new Lazy<Data>(() => Load<Data>("Data/" + typeof(Data).Name));
        
        
        public LevelsData LevelsData
        {
            get
            {
                if (_levelsData == null)
                {
                    _levelsData = Load<LevelsData>("Data/" + Instance._levelsDataPath);
                }

                return _levelsData;
            }
        }
        
        public CharacterData Character
        {
            get
            {
                if (_characterData == null)
                {
                    _characterData = Load<CharacterData>("Data/" + Instance._characterDataPath);
                }

                return _characterData;
            }
        }
        
        private static T Load<T>(string resourcesPath) where T : Object =>
            CustomResources.Load<T>(Path.ChangeExtension(resourcesPath, null));

    }
}
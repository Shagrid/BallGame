using UnityEngine;

namespace BallGame
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Data/Character/CharacterData")]
    public class CharacterData : ScriptableObject
    {
        [SerializeField] private float _speed = 50f;
        private CharacterBehaviour _characterBehaviour;
        
        [HideInInspector] public CharacterBehaviour CharacterBehaviour;
        
        private UnityTimeService _unityTimeService;
        
        public void Initialization(CharacterType characterType, Transform point)
        {
            var characterBehaviour = CustomResources.Load<CharacterBehaviour>
                (AssetsPathCharactersGameObjects.CharacterGameObject[characterType]);
            CharacterBehaviour = Instantiate(characterBehaviour, point.position, point.rotation);
            _unityTimeService = Services.Instance.UnityTimeService;
        }
        
        public float GetSpeed()
        {
            return _speed * _unityTimeService.DeltaTime();
        }
    }
}
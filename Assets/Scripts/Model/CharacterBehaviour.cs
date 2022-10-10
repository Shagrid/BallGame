using UnityEngine;

namespace BallGame
{
    public class CharacterBehaviour : MonoBehaviour
    {
        private CharacterData _characterData;
        private Rigidbody _rb;
        
        
        private void Awake()
        {
            _characterData = Data.Instance.Character;
            _rb = GetComponentInChildren<Rigidbody>();
        }

        public void Move(Vector3 vector)
        {
            _rb.AddForce(vector * _characterData.GetSpeed());
        }
    }
}
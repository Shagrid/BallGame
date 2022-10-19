using UnityEngine;

namespace BallGame
{
    public class CharacterBehaviour : MonoBehaviour
    {
        private CharacterData _characterData;
        private Rigidbody _rb;
        [SerializeField]private Camera playerCamera;
        [SerializeField]private Transform ball;
        
        private void Awake()
        {
            _characterData = Data.Instance.Character;
            _rb = GetComponentInChildren<Rigidbody>();
            Services.Instance.CameraServices.ChangeCamera(playerCamera);
        }

        public void Move(Vector3 vector)
        {
            _rb.AddForce(vector * _characterData.GetSpeed());
        }

        public Transform GetPlayerTransform()
        {
            return ball;
        }
    }
}
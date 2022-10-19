using UnityEngine;

namespace BallGame
{
    public class CameraBehaviour : MonoBehaviour
    {
        [SerializeField]private Vector3 offset = new Vector3(0, 10, 0);
        
        public void MoveCamera(Transform target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position + offset,
                Services.Instance.UnityTimeService.DeltaTime());
            
        }
    }
}
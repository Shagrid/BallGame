using UnityEngine;

namespace BallGame
{
    public class CameraController : IExecute
    {
        private CameraBehaviour _cameraBehaviour;
        private readonly CharacterData _character;
        private readonly CameraServices _cameraServices;
        
        public CameraController()
        {
            _cameraServices = Services.Instance.CameraServices;
            _cameraBehaviour = _cameraServices.CameraMain.GetComponent<CameraBehaviour>();
            _character = Data.Instance.Character;
            _cameraServices.ChangeCamera += OnChangeCamera;
        }
        public void Execute()
        {
            _cameraBehaviour.MoveCamera(_character.CharacterBehaviour.GetPlayerTransform());
        }

        private void OnChangeCamera(Camera camera)
        {
            _cameraBehaviour = camera.GetComponent<CameraBehaviour>();
        }
    }
}
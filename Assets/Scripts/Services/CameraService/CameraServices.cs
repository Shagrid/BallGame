using System;
using UnityEngine;

namespace BallGame
{
    public class CameraServices : Service
    {
        
        public Camera CameraMain { get; private set; }
        public delegate void ChangeCameraEvent(Camera camera);

        public ChangeCameraEvent ChangeCamera;
        
        public CameraServices()
        {
            CameraMain = Camera.main;
            ChangeCamera += SetCamera;
        }

        
        public void SetCamera(Camera camera)
        {
            CameraMain.gameObject.SetActive(false);
            CameraMain = camera;
            CameraMain.gameObject.SetActive(true);
        }
        
        
    }
}
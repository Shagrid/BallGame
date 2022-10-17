using UnityEngine;

namespace BallGame
{
    public sealed class GameController : MonoBehaviour
    {
        
        private Controllers _controllers;
        // Start is called before the first frame update
        private void Start()
        {
            _controllers = new Controllers();
            Initialization();
            
        }

        // Update is called once per frame
        private void Update()
        {
            for (var i = 0; i < _controllers.Length; i++)
            {
                _controllers[i].Execute();
            }
        }
        
        
        
        public void Initialization()
        {
            _controllers.Init();
        }
    }
}

namespace BallGame
{
    public sealed class Controllers : IInitialization
    {
        private readonly IExecute[] _executeControllers;
        private readonly IInitialization[] _initializations;
        
        public int Length => _executeControllers.Length;

        public IExecute this[int index] => _executeControllers[index];
        
        public Controllers()
        {
            _initializations = new IInitialization[1];
            _initializations[0] = new LoadLevelController();
            _executeControllers = new IExecute[2];
            _executeControllers[0] = new InputController();
            _executeControllers[1] = new CameraController();
        }
        
        public void Init()
        {
            for (var i = 0; i < _initializations.Length; i++)
            {
                var initialization = _initializations[i];
                initialization.Init();
            }
            
            for (var i = 0; i < _executeControllers.Length; i++)
            {
                var execute = _executeControllers[i];
                if (execute is IInitialization initialization)
                {
                    initialization.Init();
                }
            }
        }
    }
}
using System;

namespace BallGame
{
    public class Services
    {
        private static readonly Lazy<Services> _instance = new Lazy<Services>();
        public static Services Instance => _instance.Value;
        public LoadLevelService LoadLevelService { get; private set; }
        public UnityTimeService UnityTimeService { get; private set; }
        
        public Services()
        {
            Initialize();
        }

        private void Initialize()
        {
            LoadLevelService = new LoadLevelService();
            UnityTimeService = new UnityTimeService();
        }
    }
}
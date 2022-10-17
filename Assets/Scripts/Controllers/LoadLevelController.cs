namespace BallGame
{
    public sealed class LoadLevelController : IInitialization
    {
        public void Init()
        {
            Services.Instance.LoadLevelService.LoadLevel(LevelType.FirstLevel, CharacterType.Player1);
        }
    }
}
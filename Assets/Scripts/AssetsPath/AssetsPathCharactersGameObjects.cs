using System.Collections.Generic;

namespace BallGame
{
    public sealed class AssetsPathCharactersGameObjects
    {
        public static readonly Dictionary<CharacterType, string> CharacterGameObject = new Dictionary<CharacterType, string>
        {
            {
                CharacterType.Player1, "Prefabs/Players/Player"
            }

        };
    }
}
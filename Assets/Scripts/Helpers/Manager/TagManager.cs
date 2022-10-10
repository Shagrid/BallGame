using System.Collections.Generic;

namespace BallGame
{
    public static class TagManager
    {
        private static readonly Dictionary<TagType, string> _tags;

        static TagManager()
        {
            _tags = new Dictionary<TagType, string>
            {
                {TagType.CharacterPosition, "CharacterPosition"},
            };
        }

        public static string GetTag(TagType tagType)
        {
            return _tags[tagType];
        }
    }
}
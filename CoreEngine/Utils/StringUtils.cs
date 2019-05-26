using System.Linq;

namespace CoreEngine.Utils
{
    internal class StringUtils
    {
        public static string GetCardNameFromId(string id)
        {
            var strings = id.Split('-');
            var firstLetterUpperStrings = strings.Select(str => char.ToUpper(str[0]) + str.Substring(1));
            var cardName = string.Join("", firstLetterUpperStrings);

            return string.Concat(cardName, "Card");
        }
    }
}

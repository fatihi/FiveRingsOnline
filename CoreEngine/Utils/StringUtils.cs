using System.Collections.Generic;
using System.Linq;

namespace CoreEngine.Utils
{
    public class StringUtils
    {
        public static string GetCardNameFromCardId(string cardId)
        {
            var splitId = cardId.Split('-');
            var firstLetterUpperStrings = CapitalizeFirstLetters(splitId);
            var cardName = string.Join("", firstLetterUpperStrings);

            return string.Concat(cardName, "Card");
        }

        private static IEnumerable<string> CapitalizeFirstLetters(IEnumerable<string> splitId)
        {
            return splitId.Select(str => char.ToUpper(str[0]) + str.Substring(1));
        }
    }
}

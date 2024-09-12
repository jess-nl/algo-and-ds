namespace Practice.Grind75.Easy
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            // SET alphanum
            var alphanum = "abcdefghijklmnopqrstuvwxyz0123456789";
            // SET cleanup
            var cleanup = "";
            // FOREACH c lowercase in s
            foreach (var c in s)
            {
                // SET c to lowercase
                var cToLower = char.ToLower(c);
                // IF c in alphanum
                if (alphanum.Contains(cToLower))
                {
                    // ADD to cleanup
                    cleanup += cToLower;
                }
            }
            // SET reversedAsArr that reverses cleanup
            var reversedAsArr = cleanup.Reverse();
            // SET reversed as reversedAsArr to string
            var reversed = string.Join("", reversedAsArr);
            // RETURN the check on cleanup is equivalent to reversed
            return cleanup == reversed;
        }
    }
}

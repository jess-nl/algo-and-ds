namespace Practice.Grind75.Easy
{
    public class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            // IF the length of s is not equal to t
            if (s.Length != t.Length)
            {
                // RETURN false
                return false;
            }
            // SET dict 1 for s
            var dictS = new Dictionary<char, int>() { };
            // SET dict 2 for t
            var dictT = new Dictionary<char, int>() { };
            // FOR each c in s and t
            for (var i = 0; i < s.Length; i++)
            {
                if (dictS.ContainsKey(s[i]))
                {
                    dictS[s[i]] += 1;
                }
                else
                {
                    dictS[s[i]] = 1;
                }
                if (dictT.ContainsKey(t[i]))
                {
                    dictT[t[i]] += 1;
                }
                else
                {
                    dictT[t[i]] = 1;
                }
            }

            // FOREACH c in dictS
            foreach (var el in dictS)
            {
                // IF row presented as key or value;
                // ATTN: If dictT does not contain kvp.Key, then the second condition (dictT[kvp.Key] != kvp.Value) is irrelevant because you cannot access dictT[kvp.Key]. In this case, !dictT.ContainsKey(kvp.Key) is true, which should be sufficient to indicate a mismatch.
                if (!dictT.ContainsKey(el.Key) || dictT[el.Key] != el.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

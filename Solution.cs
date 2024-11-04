public class Solution {
    public string Convert(string s, int numRows) {
        var sarr = s.ToCharArray();
        var rows = new Dictionary<int, List<char>>();
        for (int i = 0; i < numRows; i++) {
            rows[i] = new List<char>();
        }
        int row = 0;
        bool dirPlus = true;
        for (int i = 0; i < s.Length; i++) {
            rows[row].Add(sarr[i]);
            if (row == numRows - 1)
                dirPlus = false;
            else if (row == 0)
                dirPlus = true;

            if (numRows > 1) {
                if (dirPlus)
                    row++;
                else
                    row--;
            }
        }
        string rtn = "";
        foreach (var chars in rows) {
            rtn += new string(chars.Value.ToArray());
        }
        return rtn;
    }
}
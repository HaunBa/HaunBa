public class Solution {
    public bool IsValid(string s) {
        bool valid = false;

        int countOpenP1 = 0;
        int countOpenP2 = 0;
        int countOpenP3 = 0;
        int countClosedP1 = 0;
        int countClosedp2 = 0;
        int countClosedP3 = 0;

        foreach (var item in s)
        {
            switch (item)
            {
                case '(':
                countOpenP1++;
                break;
                case ')':
                countClosedp1++;
                break;
                case '{':
                countOpenP2++;
                break;
                case '}':
                countClosedp2++;
                break;
                case '[':
                countOpenP3++;
                break;
                case ']':
                countClosedP3++;
                break;
                default:
                break;
            }
        }

        return (countOpenP1 == countClosedP1) && (countOpenP2 == countClosedp2) && (countOpenP3 == countClosedP3);
    }
}
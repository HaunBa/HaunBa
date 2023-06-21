string folderPath = @"C:\Users\Haunschmied.Bastian\Documents\GitHub\HaunBa\Coding Contest\HoneyComb\Level1\Level1_";

for (int i = 1; i < 6; i++)
{
    string filePath = $"{folderPath}{i}.in";
    string text = File.ReadAllText(filePath);

    Dictionary<char, int> letterCounts = new Dictionary<char, int>();
    foreach (char c in text)
    {
        if (c == 'O')
        {
            if (letterCounts.ContainsKey(c))
            {
                letterCounts[c]++;
            }
            else
            {
                letterCounts.Add(c, 1);
            }
        }
    }

    using (StreamWriter countFile = File.CreateText(folderPath+i+".out"))
    {
        foreach (KeyValuePair<char, int> kvp in letterCounts)
        {
            countFile.WriteLine("{0}", kvp.Value);
        }
    }
}
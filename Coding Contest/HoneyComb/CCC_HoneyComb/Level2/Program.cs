string folderPath = @"C:\Users\Haunschmied.Bastian\Documents\GitHub\HaunBa\Coding Contest\HoneyComb\Level2\Level2_";
List<int> combsSurrounding = new List<int>();
int CombsAmount = 0;
for (int i = 1; i < 6; i++)
{
    string filePath = $"{folderPath}{i}.in";
    int combCount = 0;
    List<List<char>> combs = new List<List<char>>();
    using (StreamReader reader = new StreamReader(filePath))
    {
        int lineIndex = 0;
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            if (lineIndex == 0)
            {
                CombsAmount = int.Parse(line);
            }
            else if(line == "")
            {
                if (combs.Count != 0)
                {
                    int xIndex = 0;
                    int yIndex = 0;
                    // calculate surrounding indexes of W
                    for (int x = 0; x < combs.Count; x++)
                    {
                        if (combs[x].Contains('W'))
                        {
                            xIndex = x;
                            yIndex = combs[x].IndexOf('W');
                        }

                        if (combs[xIndex - 1][yIndex - 1])
                        {

                        }
                    }
                }
                combs = new List<List<char>>();
            }
            else
            {
                List<char> comb = new ();
                line.Replace("-", "");
                foreach (char c in line)
                {
                    comb.Add(c);
                }
                combs.Add(comb);
            }
            lineIndex++;
        }
    }


}
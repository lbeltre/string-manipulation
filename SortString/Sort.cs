using System.Text;

namespace SortString
{
    public class Sort
    {
        public IEnumerable<string> SortingOperations(IEnumerable<string> inputs)
        {
            var result = new List<string>();
            var builder = new StringBuilder();

            foreach (var item in inputs)
            {
                var frecuencyCharacters = GetFrecuencyCharacter(item);

                foreach(var frecuency in frecuencyCharacters.Select(s => s.Value).Distinct().OrderByDescending(o => o))
                {
                    var sortByFrecuency = frecuencyCharacters.Where(w => w.Value == frecuency).Select(s => s.Key).ToArray();
                    Array.Sort(sortByFrecuency);

                    foreach (var character in sortByFrecuency)
                    {
                        builder.Append(character, frecuency);
                    }
                }
                             
                result.Add(builder.ToString());
                builder.Clear();
            }

            return result;
        }

        static Dictionary<char, int> GetFrecuencyCharacter(string input)
        {
            var result = new Dictionary<char, int>();

            for (int idx = 0; idx < input.Length; idx++)
            {
                if (!result.ContainsKey(input[idx]))
                    result.Add(input[idx], 1);
                else
                    result[input[idx]]++;
            }

            return result;
        }
    }
}

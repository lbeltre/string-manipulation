namespace SortString.Test
{
    public static class TestCaseData
    {
        public static IEnumerable<string> InputFirstScenario()
        {
            yield return "abaccadcc";
            yield return "xyzxy";
        }

        public static IEnumerable<string> OutputFirstScenario()
        {
            yield return "ccccaaabd";
            yield return "xxyyz";
        }

        public static IEnumerable<string> InputInputScenarioSecond()
        {
            yield return "";
            yield return "";
        }

        public static IEnumerable<string> InputScenario1Third()
        {
            yield return "";
            yield return "";
        }

        public static IEnumerable<string> InputScenarioFourth()
        {
            yield return "";
            yield return "";
        }

        public static IEnumerable<string> InputScenarioFifth()
        {
            yield return "";
            yield return "";
        }

        public static IEnumerable<string> InputScenarioSixth()
        {
            yield return "";
            yield return "";
        }

    }
}

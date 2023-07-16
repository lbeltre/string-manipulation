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

        public static IEnumerable<string> InputSecondScenario()
        {
            yield return "dulgvgzwqg";
            yield return "gxtjtmtywr";
            yield return "hnlnxiupgt";
            yield return "gzjotckivp";
            yield return "dpwwsdptae";
            yield return "pcscpilknb";
            yield return "btvyhhmflf";
            yield return "artrtnqxcr";
            yield return "nrtcmcoadn";
            yield return "fkdsgnekft";
        }

        public static IEnumerable<string> OutputSecondScenario()
        {
            yield return "gggdlquvwz";
            yield return "tttgjmrwxy";
            yield return "nnghilptux";
            yield return "cgijkoptvz";
            yield return "ddppwwaest";
            yield return "ccppbiklns";
            yield return "ffhhblmtvy";
            yield return "rrrttacnqx";
            yield return "ccnnadmort";
            yield return "ffkkdegnst";
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

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

        public static IEnumerable<string> InputThirdScenario()
        {
            yield return "wzenwebuau";
            yield return "vokfxzynwl";
            yield return "neldfeyrxk";
            yield return "wqadfiodgs";
            yield return "ykiuvzfcbc";
        }

        public static IEnumerable<string> OutputThirdScenario()
        {
            yield return "eeuuwwabnz";
            yield return "fklnovwxyz";
            yield return "eedfklnrxy";
            yield return "ddafgioqsw";
            yield return "ccbfikuvyz";
        }

        public static IEnumerable<string> InputFourthScenario()
        {
            yield return "qakmc";
            yield return "rrtbk";
            yield return "vaixn";
            yield return "wmpnj";
            yield return "uproi";
            yield return "btska";
            yield return "ejqwr";
            yield return "elwlg";
            yield return "oaoiy";
            yield return "hrqkn";
        }

        public static IEnumerable<string> OutputFourthScenario()
        {
            yield return "ackmq";
            yield return "rrbkt";
            yield return "ainvx";
            yield return "jmnpw";
            yield return "iopru";
            yield return "abkst";
            yield return "ejqrw";
            yield return "llegw";
            yield return "ooaiy";
            yield return "hknqr";
        }

        public static IEnumerable<string> InputFifthScenario()
        {
            yield return "pzjim";
            yield return "njnfq";
            yield return "xyohs";
        }

        public static IEnumerable<string> OutputFifthScenario()
        {
            yield return "ijmpz";
            yield return "nnfjq";
            yield return "hosxy";
        }

        public static IEnumerable<string> InputSixthScenario()
        {
            yield return "xqycs";
            yield return "beoax";
            yield return "afkso";
            yield return "bldit";
            yield return "gwrys";
        }

        public static IEnumerable<string> OutputSixthScenario()
        {
            yield return "cqsxy";
            yield return "abeox";
            yield return "afkos";
            yield return "bdilt";
            yield return "grswy";
        }
    }
}

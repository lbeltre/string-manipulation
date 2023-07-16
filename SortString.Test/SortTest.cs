namespace SortString.Test
{
    public class SortTest
    {
        [Fact]
        public void FirstScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputFirstScenario());

            Assert.Equal(TestCaseData.OutputFirstScenario(), sorted);
        }

        [Fact]
        public void SecondScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputSecondScenario());

            Assert.Equal(TestCaseData.OutputSecondScenario(), sorted);
        }

        [Fact]
        public void ThirdScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputThirdScenario());

            Assert.Equal(TestCaseData.OutputThirdScenario(), sorted);
        }

        [Fact]
        public void FourthScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputFourthScenario());

            Assert.Equal(TestCaseData.OutputFourthScenario(), sorted);
        }

        [Fact]
        public void FifthScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputFifthScenario());

            Assert.Equal(TestCaseData.OutputFifthScenario(), sorted);
        }

        [Fact]
        public void SixthScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputSixthScenario());

            Assert.Equal(TestCaseData.OutputSixthScenario(), sorted);
        }
    }
}
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
    }
}
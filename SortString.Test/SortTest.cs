using System.Globalization;
using Xunit.Abstractions;

namespace SortString.Test
{
    public class SortTest
    {
        private readonly ITestOutputHelper testOutputHelper;

        public SortTest(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void FirstScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputFirstScenario());

            Assert.Equal(TestCaseData.OutputFirstScenario(), sorted);

            WriteOutput("Input", string.Join(Environment.NewLine, TestCaseData.InputFirstScenario()), Environment.NewLine, "Output", string.Join(Environment.NewLine, sorted));
        }

        [Fact]
        public void SecondScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputSecondScenario());

            Assert.Equal(TestCaseData.OutputSecondScenario(), sorted);

            WriteOutput("Input", string.Join(Environment.NewLine, TestCaseData.InputSecondScenario()), Environment.NewLine, "Output", string.Join(Environment.NewLine, sorted));
        }

        [Fact]
        public void ThirdScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputThirdScenario());

            Assert.Equal(TestCaseData.OutputThirdScenario(), sorted);
            WriteOutput("Input", string.Join(Environment.NewLine, TestCaseData.InputThirdScenario()), Environment.NewLine, "Output", string.Join(Environment.NewLine, sorted));
        }

        [Fact]
        public void FourthScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputFourthScenario());

            Assert.Equal(TestCaseData.OutputFourthScenario(), sorted);
            WriteOutput("Input", string.Join(Environment.NewLine, TestCaseData.InputFourthScenario()), Environment.NewLine, "Output", string.Join(Environment.NewLine, sorted));
        }

        [Fact]
        public void FifthScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputFifthScenario());

            Assert.Equal(TestCaseData.OutputFifthScenario(), sorted);
            WriteOutput("Input", string.Join(Environment.NewLine, TestCaseData.InputFifthScenario()), Environment.NewLine, "Output", string.Join(Environment.NewLine, sorted));
        }

        [Fact]
        public void SixthScenario_Sort_String_ReturnStrigSorted()
        {
            var sort = new Sort();

            var sorted = sort.SortingOperations(TestCaseData.InputSixthScenario());

            Assert.Equal(TestCaseData.OutputSixthScenario(), sorted);
            WriteOutput("Input", string.Join(Environment.NewLine, TestCaseData.InputSixthScenario()), Environment.NewLine, "Output", string.Join(Environment.NewLine, sorted));
        }

        void WriteOutput(params string[] data)
        {
            foreach (var item in data)
                testOutputHelper.WriteLine(item);
        }
    }
}
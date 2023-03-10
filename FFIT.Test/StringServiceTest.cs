using FFIT.Service.String;

namespace FFIT.Test
{
    public class StringServiceTest
    {
        private IStringService stringService;

        public StringServiceTest()
        {
            stringService = new StringService();
        }


        [Theory]
        [InlineData("test","es")]
        [InlineData("testing", "t")]
        [InlineData("middle", "dd")]
        [InlineData("A", "A")]
        [InlineData("", "")]
        public void GetMiddle_Test(string input, string expected)
        {
            var result = stringService.GetMiddle(input);
            Assert.Equal(expected, result);
        }
    }
}
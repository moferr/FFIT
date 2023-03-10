using FFIT.Service.MarkdownParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFIT.Test
{
    public class MarkdownParserTest
    {
        private IMarkdownParser markdownParser;

        public MarkdownParserTest()
        {
            markdownParser = new MarkdownParser();
        }

        [Theory]
        [InlineData("aaa### Header", "aaa### Header")] // Invalid 
        [InlineData("###   Header", "###   Header")]// Invalid 
        [InlineData("####### Header", "####### Header")]// Invalid 
        [InlineData(" Header ", " Header ")]// Invalid 
        [InlineData("### Header", "<h3>Header</h3>")]
        [InlineData("  ### Header   ", "<h3>  Header   </h3>")]
        [InlineData("   ### Header", "<h3>   Header</h3>")]
        public void ParseHeader_Test(string input, string expected)
        {
            var result = markdownParser.ParseHeader(input);

            Assert.Equal(expected, result);
        }
    }
}

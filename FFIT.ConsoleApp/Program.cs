
using FFIT.Service.FormatValidator;
using FFIT.Service.MarkdownParser;
using FFIT.Service.String;

var stringService = new StringService();

Console.WriteLine($"Middle of \"test\" is: {stringService.GetMiddle("test")}");

var parser = new MarkdownParser();

Console.WriteLine($"Parsed value of \"###### hellow world!\" is: {parser.ParseHeader("###### hellow world!")}");


var formatValidator = new FormatValidator();

Console.WriteLine($"Is \"12345\" parsable as a number? {formatValidator.IsFormat("12345","number")}");


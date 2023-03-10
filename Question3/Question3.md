## Question 3 

The `IsFormat` function takes two string parameters and checks if the `f` parameter is the allowed format and then returns a boolean value that indicates if the `str` parameter is parsable to the `f` format.

There is a problem with the loop. It ignores the last item of the `allowedDict`.  I changed it as below:

```cs
for (var i = 0; i < allowedDict.Count; i++)
{
    if (f == allowedDict.Keys.ToArray()[i])
    {
        isNotAllowed |= 1 << (i + 1);
        break;
    }
}
```

Another issue is about checking `isNotAllowed` variable.  `isNotAllowed > 0` means the format was found in the `allowedDict` so the code should change as below:

```cs
if (isNotAllowed == 0)
    throw new Exception("Format not allowed.");
```

In a more general view, there is no need to loop here when we have a dictionary. We can just check if the dictionary contains the `f` key:

```cs
if (!allowedDict.ContainsKey(f.ToLower()))
{
    throw new Exception("Format not allowed.");
}
```

To engage the `allowedDict` values:

```cs
if (!allowedDict.ContainsKey(f.ToLower()) || allowedDict[f.ToLower()] == false)
{
    throw new Exception("Format not allowed.");
}
```

To try to parse the timespan format should use `TimeSpan.TryParse(str, out var _)`

Final changed class:

```cs
public class FormatValidator
{

    Dictionary<string, bool> allowedDict = new Dictionary<string, bool>()
    {
        { "number",true},
        { "date",true},
        { "timespan",true}
    };

    public bool IsFormat(string str, string f)
    {
         if (!allowedDict.ContainsKey(f.ToLower()) || allowedDict[f.ToLower()] == false)
         {
             throw new Exception("Format not allowed.");
         }

         if (f.ToLower() == "number")
             return Int32.TryParse(str, out var _);
         else if (f.ToLower() == "date")
             return DateTime.TryParse(str, out var _);
         else if (f.ToLower() == "timespan")
             return TimeSpan.TryParse(str, out var _);

         throw new Exception("Unknown format.");
    }

}
```
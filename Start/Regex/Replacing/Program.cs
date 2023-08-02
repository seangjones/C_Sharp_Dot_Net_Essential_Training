// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for Replacing content with Regexes 
using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";

Regex CapWords = new Regex(@"[A-Z]\w+");

// TODO: Regular expressions can be used to replace content in strings
// in addition to just searching for content

// string result = CapWords.Replace(teststr1, "***");
// Console.WriteLine(teststr1);
// Console.WriteLine(result);

// TODO: Replacement text can be generated on the fly using MatchEvaluator
// This is a delegate that computes the new value of the replacement

// Create a function that modifies a string. We will use this function 
// as a delegate, passed in to the Replace() function.

string MakeUpper(Match m){
    // Convert Match to a string
    string s = m.ToString();

    // Do not upper case matches at the start of the string
    if (m.Index == 0){
        return s;
    }
    // return upper case version of the string
    return s.ToUpper();
}

string upperstr = CapWords.Replace(teststr1, new MatchEvaluator(MakeUpper));
Console.WriteLine(teststr1);
Console.WriteLine(upperstr);

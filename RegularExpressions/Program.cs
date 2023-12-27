// See https://aka.ms/new-console-template for more information
using System.Security.Authentication;
using System.Text.RegularExpressions;

string teststr1="The quick brown fox jumps over the lazy Dog";
string teststr2="The quick brown fox jumps over the lazy dog";

// The ismatch function is used to determine if the content of a string
// results in a match with the given regex
Regex CapWords=new Regex(@"[A-Z]\w+");
Regex NoCase=new Regex(@"fox",RegexOptions.IgnoreCase);
Console.WriteLine(NoCase.IsMatch(teststr1));

// to get more info about the match use Match and Matches methods to get information about
// specific regex matches for a given pattern.
// The match method returns a single match at a time.
Match m=CapWords.Match(teststr1);

while(m.Success)
{
    Console.WriteLine($"{m.Value} found at position {m.Index}");
    m=m.NextMatch();
}

// The matches method returns a collection of match objects

// Match ms=CapWords.Matches(teststr1);
// Console.WriteLine($"Found {ms.Count} matches:");

// foreach(Match match in ms)
// {
//     Console.WriteLine($"{match.Value} found at position {match.Index}");
// }
// Simple replace in regex
// where ever we have got uppercase the teststr is replaced with "***".
string result=CapWords.Replace(teststr1,"***");
Console.WriteLine(teststr1);
Console.WriteLine(result);


// replacement text can be generated on the fly using MatchEvaluator.
// This is a delegate that computes the new value of the replacement.

string MakeUpper(Match m)
{
    string s=m.ToString();
    if(m.Index==0)
    {
        return s; // apart from the first instance convert all the matches to uppercase.
    }
    return s.ToUpper(); 


}

string upperstr=CapWords.Replace(teststr1,new MatchEvaluator(MakeUpper));
/*
When to Use Each Approach:

Use the basic Replace method when you want a simple, fixed replacement for each match. This is suitable when you have a clear, constant replacement text for all matches.

Use the MatchEvaluator approach when you need dynamic or conditional replacement based on the characteristics of each match. In your example, the MakeUpper method allows you to customize the replacement behavior based on the index of the match.

In summary, choose the appropriate approach based on your specific use case. If you need a uniform replacement for all matches, use the basic Replace method. If you need more dynamic or conditional replacement logic, use the MatchEvaluator with a custom method.


*/ 

// Regex Timeouts!

// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// TODO: Length of a string 

// System.Console.WriteLine($"{str1}");
// System.Console.WriteLine(str1.Length);


// TODO: Access individual characters


// TODO: Iterate over a string like any other sequence of values
// foreach (char ch in str1){
//     Console.Write(ch);
//     if (ch == 'b'){
//         Console.WriteLine();
//         break;
//     }
// }



// TODO: String Concatenation         
// Console.WriteLine(String.Concat("one","two"));
// Console.WriteLine(String.Concat(strs));




// TODO: Joining strings together with Join
// string outstr;
// outstr = String.Join('+',strs);
// Console.WriteLine(outstr);


// TODO: String Comparison

// Equals just returns a regular Boolean
// bool isEqual = str2.Equals(str3);
// Console.WriteLine(isEqual);

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
// int result = String.Compare(str2, "This is a string");
// Console.WriteLine(result);

// TODO: Replacing content
string outstr = str1.Replace("fox","cat");
Console.WriteLine(outstr);
foreach (string s in outstr.Split(" ")){
    Console.WriteLine(s);
}
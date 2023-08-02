// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

bool done = false;
int i = 0;
string instr = "";
bool parseresult = false;

DateTime indate;
DateOnly dateOnly;

Regex DateValue = new Regex(@"[0-9]+");


do{
    Console.WriteLine($"Enter a date (ex: 1/3/2018 or 03/02/2020):");
    instr = Console.ReadLine();

    if (instr.Equals("exit")){
        done = true;
    }
    else{
        // Try and parse out a date from this string
        parseresult = DateTime.TryParse(instr, out indate);

        if (!parseresult){
            Console.WriteLine($"'{instr}' is not a valid date");
        }
        else {
            Console.WriteLine($"Recognized date: {indate:d}");
            // We know we have a valid date.

            // Now pull the 3 values out
            Match m = DateValue.Match(instr);
            string monthVal = m.Value;
            m = m.NextMatch();
            string dayVal = m.Value;
            m = m.NextMatch();
            string yearVal = m.Value;

            // Console.WriteLine($"Month: {monthVal}");
            // Console.WriteLine($"Day: {dayVal}");
            // Console.WriteLine($"Year: {yearVal}");

            Console.WriteLine($"The reversed format is {yearVal}-{monthVal}-{dayVal}");

        }
    }
}
while (!done);


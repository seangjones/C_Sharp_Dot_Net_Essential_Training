// See https://aka.ms/new-console-template for more information

string inStr = "";
DateTime inDate = DateTime.Now;
DateTime now = DateTime.Now;
bool parseResult = false;
TimeSpan ts;

while (true){
    Console.WriteLine("Enter a date (or 'exit)");
    inStr = Console.ReadLine();

    if (inStr.Equals("exit")){
        // exit loop
        break;
    }

    // Try to parse out a date
    parseResult = DateTime.TryParse(inStr, out inDate);

    if (parseResult){
        // We have a valid date

        // Compute timespan in days
        ts = now - inDate;

        if ((ts.Days == 0) && (now.Day == inDate.Day)){
            // Input day is today
            Console.WriteLine($"{inDate:d} is today!");
        }
        else if (now < inDate){
            // Input date is in the future
            Console.WriteLine($"{inDate:d} is {-ts.Days+1} day" + (((-ts.Days+1)>1)?"s":"") + " in the future");
        }
        else{
            // Input date is in the past
            Console.WriteLine($"{inDate:d} is {ts.Days} day" + (((ts.Days)>1)?"s":"") + " in the past");
        }
    }
    else {
        // Could not parse out a date
        Console.WriteLine($"{inStr} is not a valid date\n");
    }
}
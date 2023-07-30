// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
// Console.WriteLine($"It is now {now}");

// // TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today;
// Console.WriteLine(today);

// // TODO: DateOnly and TimeOnly represent just dates and times
// DateOnly dt = DateOnly.FromDateTime(DateTime.Today);
// Console.WriteLine($"Today's date is {dt}");

// TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now);
// Console.WriteLine($"The time is {tm}");

// // TODO: Dates have properties that can be inspected
// Console.WriteLine($"It is {today.DayOfWeek}");
// Console.WriteLine($"It is the {today.DayOfYear} day of the year so far");


// // TODO: Dates also have methods to change their values
// now = now.AddDays(5);
// Console.WriteLine($"In 5 days, it will be {now}");

// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);
TimeSpan ts = AprilFools - NewYears;
Console.WriteLine($"The time between New Years and April Fools day is {ts}");


// TODO: Dates can be compared using regular operators
Console.WriteLine($"{AprilFools < NewYears}");
Console.WriteLine($"{AprilFools > NewYears}");

DateOnly dateO = DateOnly.FromDateTime(DateTime.Now);
TimeOnly to1 = TimeOnly.FromDateTime(DateTime.Now);
TimeOnly to2 = to1.AddHours(2);

Console.WriteLine($"{to1 < to2}");


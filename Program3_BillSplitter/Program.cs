
int totalBill = 250;
int friends = 4;

// Calculate the whole-peso share
int wholeShare = totalBill / friends;

// Calculate the remaining pesos
int leftover = totalBill % friends;

// Calculate the exact share
double exactShare = (double)totalBill / friends;

Console.WriteLine($"Total bill: PHP {totalBill}");
Console.WriteLine($"Number of friends: {friends}");
Console.WriteLine($"Each pays (integer division): PHP {wholeShare}");
Console.WriteLine($"Leftover pesos: PHP {leftover}");
Console.WriteLine($"Each pays (exact): PHP {exactShare:F2}");

bool beach = true;
bool hiking = false;
bool city = true;
bool yourNeeds = beach && city;
bool friendNeeds = beach || hiking;
bool tripDecision = yourNeeds && friendNeeds;
Console.WriteLine(tripDecision);
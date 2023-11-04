string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string[] corporateEmail = new string[corporate.GetLength(0)];
string[] externalEmail = new string[external.GetLength(0)];


for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    string corporateDomain = "contoso.com";
    corporateEmail[i] = $"{corporate[i, 0].Substring(0, 2).ToLower()}{corporate[i, 1].ToLower()}@{corporateDomain}";
    Console.WriteLine($"CorporateEmail: {corporateEmail[i]}");

    string first = corporate[i, 0].Substring(0, 2).ToLower();
    string last = corporate[i, 1].ToLower();
    DisplayEmail(first: first, last: last, domain: corporateDomain);

}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    string externalDomain = "hayworth.com";                                                                                                                                                                 
    externalEmail[i] = $"{external[i, 0].Substring(0,2).ToLower()}{external[i, 1].ToLower()}@{externalDomain}";
    Console.WriteLine($"ExternalEmail: {externalEmail[i]}");

    string first = external[i, 0].Substring(0, 2).ToLower();
    string last = external[i, 1].ToLower();
    DisplayEmail(first: first, last: last, domain: externalDomain);
}


void DisplayEmail(string first, string last, string domain = "contoso.com")
    {
        string email = $"{first}{last}@{domain}";
        Console.WriteLine($"{email}");
    }

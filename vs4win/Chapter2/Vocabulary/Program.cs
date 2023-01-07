using System.Reflection;

// declare some unused variables using types
// in additional assemblies
System.Data.DataSet ds;
HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();
if (myApp == null) return; // quit the app
// loop through the assemblies that my app references
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // load the assembly so we can read its details
    Assembly a = Assembly.Load(name);
    // declare a variable to count the number of methods
    int methodCount = 0;
    // loop through all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up the counts of methods
        methodCount += t.GetMethods().Count();
    }
    // output the count of types and their methods
    Console.WriteLine(
    "{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount,
    arg2: name.Name);
}

// let the heightInMetres variable become equal to the value 1.88
double heightInMetres = 1.88;
Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");

char letter = 'A'; // assigning literal characters
char digit = '1';
char symbol = '$';
char userChoice = GetSomeKeystroke(); // assigning from a fictitious function

char GetSomeKeystroke()
{
    return 'C';
}

string firstName = "Bob"; // assigning literal strings
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";
// assigning a string returned from the string class constructor
string horizontalLine = new('-', count: 74); // 74 hyphens
// assigning a string returned from a fictitious function
string address = GetAddressFromDatabase(id: 563);

// assigning an emoji by converting from Unicode
string grinningEmoji = char.ConvertFromUtf32(0x1F600);

Console.OutputEncoding = System.Text.Encoding.UTF8;
grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);

string GetAddressFromDatabase(int id)
{
    if (id == 563)
    {
        return "Street 222";

    }
    else
    {
        return "Another Street 230";
    }
}

string fullNameWithTabSeparator = "Bob\tSmith";

//string filePathError = "C:\televisions\sony\bravia.txt"; //Cause errors because the \t

string filePath = @"C:\televisions\sony\bravia.txt";

string xml = """
 <person age="50">
 <first_name>Mark</first_name>
 </person>
 """;

var person = new { FirstName = "Alice", Age = 56 };
string json = $$"""
 {
 "first_name": "{{person.FirstName}}",
 "age": {{person.Age}},
 "calculation", "{{{1 + 2}}}"
 }
 """;
Console.WriteLine(json);
int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

int counter = 0;
string? password;
do
{
    Write("Enter your password: ");
    password = ReadLine();
    counter++;
    if (counter > 3)
    {
        WriteLine("Password Blocked!");
        break;
    }
}
while (password != "Pa$$w0rd");
if (counter < 3)
{
    WriteLine("Correct!");
}

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}
// Declare variables using an explicit type
string string1 = "i'm string 1";
int one = 1;
double testdec = 2.2;
bool isFact = true;

// Declare a variable using var
var string2 = "i'm string 2";
var two = 2;
var test3 = 3.1;
var isNotFact = false;

// Display the values of your variables
Console.WriteLine($"{string1}|i'm int {one}|i'm a decimal {testdec}|{string2}|i'm int {two}|i'm a decimal {test3}|i'm {isFact} but i'm not {isNotFact}");

// Reassign a variable to a new value
string2 = "now string 2 is different";
isFact = false;
Console.WriteLine($"{string1}|i'm int {one}|i'm a decimal {testdec}|{string2}|i'm int {two}|i'm a decimal {test3}|i'm {isFact} but i'm not {isNotFact}");

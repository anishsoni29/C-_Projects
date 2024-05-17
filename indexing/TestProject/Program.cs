//extract replace and remove data

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

//extract the quantity -5000
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;

quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

//Set output to input, replacing the trademark symbol with the reg symbol.

const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

//Remove the opening div tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

//Remove the closing div tag
const string closeDiv = "</div>";
int divEnd = output.IndexOf(closeDiv);
output = output.Remove(divEnd, closeDiv.Length);

//Add an output to the beginning
output = "Output: " + output;





Console.WriteLine(quantity);
Console.WriteLine(output);
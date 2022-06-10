using ConsoleApp1;
using ConsoleApp1.Tons;

string I = null;
string IIb = null;
string II = null;
string IIIb = null;
string III = null;
string IV = null;
string Vb = null;     
string V = null;
string VIb = null;
string VI = null;
string VIIb = null;
string VII = null;



string tom = Console.ReadLine();


var sol = new TomG();
var fa = new TomF();
var c = new TomC();

if (tom == "F")
{
     I = fa.I;
    IIb = fa.IIb;
    II = fa.II;
    IIIb = fa.IIIb;
    III = fa.III;  
    IV = fa.IV;
    Vb = fa.Vb;
    V = fa.V;
    VIb = fa.VI;
    VI = fa.VIb;
    VIIb = fa.VIIb;
    VII = fa.VII;

    
}

if (tom == "G")
{
    I = sol.I; 
    II = sol.II;
    IIb = sol.IIb;
    IIIb = sol.IIIb;
    III = sol.IIIb;
    IV = sol.IV; 
    Vb = sol.Vb;  
    V = sol.V;
    VIb = sol.VIb;        
    VI = sol.VIb;
    VIIb = sol.VIIb;
    VII = sol.VII;
}


if (tom == "C")
{
    I = c.I;
    II = c.II;
    IIb = c.IIb;
    IIIb = c.IIIb;
    III = c.IIIb;
    IV = c.IV;
    Vb = c.Vb;
    V = c.V;
    VIb = c.VIb;
    VI = c.VIb;
    VIIb = c.VIIb;
    VII = c.VII;
}


string musicb = (" | " +I+"7+(9)/"+III + " | " + I +" | " + III+"m"+" | " + II+"m" + " | " + "\n"+ " | " + I + " " +  II + "m" + " | " + I + " | " + III + "m" + " | " + II + "m" + " | " );

string musicc = (" Int - | Em | C | \n Ver - | Em | C | D | G | \n Pre - | C | D | Em | C | Am | \n ref - | Em | C | G | D | ");

string musicd = (" Int - | IIIm | I |\n Ver - | IIIm | I | II | V | \n Pre - | I | II | IIIm | I | VIm |\n ref - | IIIm | I | V | II |");

string subI  = musicc.Replace("C", "I");
string subIIb = subI.Replace("Db", "IIb");
string subII = subIIb.Replace("D", "II");
string subIIx = subII.Replace("D#", "IIx");
string subIIIb = subIIx.Replace("Eb", "IIIb");
string subIII = subIIIb.Replace("E", "III");
string subIV = subIII.Replace("F", "IV");
string subIVx = subIV.Replace("F#", "IVx");
string subVb = subIVx.Replace("Gb", "IV");
string subV = subVb.Replace("G", "V");
string subVx = subV.Replace("G#", "Vx");
string subVIb = subVx.Replace("Ab", "VIb");
string subVI = subVIb.Replace("A", "VI");
string subVIx = subVI.Replace("A#", "VIx");
string subVIIb = subVIx.Replace("Bb", "VIIb");
string subVII= subVIIb.Replace("B", "VII");




string fim = subVII ;



// var n = musicb.Replace(" II ", II ) ;





Console.WriteLine(musicb);
Console.WriteLine("---------------");

Console.WriteLine(musicd);
Console.WriteLine("---------------");

Console.WriteLine("---------------");
Console.WriteLine("Sub");
Console.WriteLine(fim);

Console.WriteLine("---------------");
Console.WriteLine(musicc);






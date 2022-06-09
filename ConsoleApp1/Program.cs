using ConsoleApp1;




string I = null;
string IIb = null;
string II = null;
string IIIb = null;
string III = null;
string IV = null;



string tom = Console.ReadLine();


var sol = new TomG();
var fa = new TomF();
var C = new TomC();

if (tom == "F")
{
     I = fa.I;
    II = fa.II;
    III = fa.III;   

}

if (tom == "G")
{
    I = sol.I;
    II = sol.II;
    III = sol.III;

}


if (tom == "C")
{
    I = C.I;
    II = C.II;
    III = C.III;

}


string musicb = (" | " +I+"7+(9)/"+III + " | " + I +" | " + III+"m"+" | " + II+"m" + " | " + "\n"+ " | " + I + " " +  II + "m" + " | " + I + " | " + III + "m" + " | " + II + "m" + " | " );

// var n = musicb.Replace(" II ", II ) ;







Console.WriteLine(musicb);



public class TomF
{
    public string T = "F";
    public string I = "F";
    public string IIb = "Gb";
    public string II = "G";
    public string IIIb = "Ab";
    public string III = "A";

    public void AplicaTom()
    {
        var fa = new TomF();

          I = fa.I;
    II = fa.II;
    III = fa.III;  

    }

    
}



public class TomG
{
    public string T = "G";
    public string I = "G";
    public string IIb = "Ab";
    public string II = "A";
    public string IIIb = "Bb";
    public string III = "B";
}


public class TomC
{
    public string T = "C";
    public string I = "C";
    public string IIb = "Db";
    public string II = "D";
    public string IIIb = "Eb";
    public string III = "E";
}





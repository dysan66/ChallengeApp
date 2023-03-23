int nember = 45663777;
string nemberString = nember.ToString();
char[] letters = nemberString.ToArray();
Console.WriteLine("Zadana liczba: " + nember);
int meter0 = 0;
int meter1 = 0;
int meter2 = 0;
int meter3 = 0;
int meter4 = 0;
int meter5 = 0;
int meter6 = 0;
int meter7 = 0;
int meter8 = 0;
int meter9 = 0;
foreach (char i in letters)
{
    if (i == '0')
    {
        meter0++;
    }
    else if (i == '1')
    {
        meter1++;
    }
    else if (i == '2')
    {
        meter2++;
    }
    else if (i == '3')
    {
        meter3++;
    }
    else if (i == '4')
    {
        meter4++;
    }
    else if (i == '5')
    {
        meter5++;
    }
    else if (i == '6')
    {
        meter6++;
    }
    else if (i == '7')
    {
        meter7++;
    }
    else if (i == '8')
    {
        meter8++;
    }
    else if (i == '9')
    {
        meter9++;
    }
}
Console.WriteLine("Cyfra 0 wystepuje " + meter0);
Console.WriteLine("Cyfra 1 wystepuje " + meter1);
Console.WriteLine("Cyfra 2 wystepuje " + meter2);
Console.WriteLine("Cyfra 3 wystepuje " + meter3);
Console.WriteLine("Cyfra 4 wystepuje " + meter4);
Console.WriteLine("Cyfra 5 wystepuje " + meter5);
Console.WriteLine("Cyfra 6 wystepuje " + meter6);
Console.WriteLine("Cyfra 7 wystepuje " + meter7);
Console.WriteLine("Cyfra 8 wystepuje " + meter8);
Console.WriteLine("Cyfra 9 wystepuje " + meter9);





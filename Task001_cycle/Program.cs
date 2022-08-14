string Metod4(int count, string c)
{
    string result = "";
    for(int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Metod4(10, "coc");
Console.WriteLine(res);
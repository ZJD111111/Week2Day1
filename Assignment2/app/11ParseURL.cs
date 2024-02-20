namespace app1;

class ParseURL
{
    public void ParseURLMethod(string url)
    {
        string[] urlParts = url.Split(new char[] { '/', ':' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("[protocol] = {0}", urlParts[0]);
        Console.WriteLine("[server] = {0}", urlParts[1]);
        Console.WriteLine("[resource] = {0}", string.Join("/", urlParts.Skip(2)));
    }
}
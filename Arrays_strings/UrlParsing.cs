namespace Arrays_Strings;

// Write a program that parses an URL given in the following format:
// [protocol]://[server]/[resource]
// The parsing extracts its parts: protocol, server and resource.
//     The [server] part is mandatory.
//     The [protocol] and [resource] parts are optional.
//     https://www.apple.com/iphone
// [protocol] = "https"
//     [server] = "www.apple.com"
//     [resource] = "iphone"

public class UrlParsing
{
    public void Parsing(string url)
    {
        if (url.Contains("://"))
        {
            string[] parts = url.Split("://");
            string[] serverAndResource = parts[1].Split('/');

            Console.WriteLine("[protocol] = \"" + parts[0] + "\"");
            Console.WriteLine("[server] = \"" + serverAndResource[0] + "\"");
            if (serverAndResource.Length > 1)
            {
                Console.WriteLine("[resource]= \"" + serverAndResource[1] + "\"");
            }
            else
            {
                Console.WriteLine("[resource] = \"\"");
            }

        }
        else
        {
            string[] serverAndResource = url.Split('/');
            Console.WriteLine("[protocol] = \"\"");
            Console.WriteLine("[server] = \"" + serverAndResource[0] + "\"");
            if (serverAndResource.Length > 1)
            {
                Console.WriteLine("[resource] = \"" + serverAndResource[1] + "\"");
            }
            else
            {
                Console.WriteLine("[resource] = \"\"");
            }

        }

    }
}
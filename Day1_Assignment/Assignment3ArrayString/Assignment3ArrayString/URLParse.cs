//Write a program that parses an URL given in the following format:
//[protocol]://[server]/[resource]
//The parsing extracts its parts: protocol, server and resource.
//The [server] part is mandatory.
//The[protocol] and [resource] parts are optional.
using System;
namespace Assignment3ArrayString
{
    public class URLParse
    {
        public static void Parse(string URL)
        {
            string protocol;
            string server;
            string resource;

            if (!URL.Contains(":")) {
                if (!URL.Contains("/")) {
                    protocol = "";
                    server = URL;
                    resource = "";
                }
                else
                {
                    char sp = Convert.ToChar("/");
                    string[] parts = URL.Split(sp);
                    protocol = "";
                    server = parts[0];
                    resource = parts[1];
                }
            }
            else
            {
                if (URL.Contains("com/"))
                {
                    char sp1 = Convert.ToChar("://");
                    char sp2 = Convert.ToChar("/");
                    string[] parts = URL.Split(sp1, sp2);
                    protocol = parts[0];
                    server = parts[1];
                    resource = parts[2];

                }
                else
                {
                    char sp = Convert.ToChar("://");
                    string[] parts = URL.Split(sp);
                    protocol = parts[0];
                    server = parts[1];
                    resource = "";
                }

            }
            Console.WriteLine($"[protocol]: {protocol}\n[server]: {server}\n[resource]: { resource }");
        } 
    }
}


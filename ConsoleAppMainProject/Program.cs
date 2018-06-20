using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using static ConsoleAppMainProject.Json;

namespace AzureCosmosProj { 

    class Program
    {

        static void Main(String [] args)
        {
            LoginAndDeserailizeJson();

            continueLoopItteration();
        }

        private static void continueLoopItteration()
        {

        }

        static void LoginAndDeserailizeJson()
        {
            using (var client = new WebClientEx())
            {
                var values = new NameValueCollection
                {
                    { "j_username", "" },
                    { "j_password", "" },
                };
                Console.WriteLine("Trying to validate username and password.....\n");

                client.UploadValues("https://tie.interpreterintelligence.com/j_spring_security_check", values);

                Console.WriteLine("Successfully logged in to ii.....\n");

                var recordCount = 10213;
                var count = 1;

                for (var i = 0; i < recordCount; i++)
                {
                    try
                    {
                        var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/contact/" + count);
                        count++;

                        Console.WriteLine("Download string from Interpreter Intelligence : " + json);

                        dynamic rootjson = JsonConvert.DeserializeObject(json);

                        //var rootjson = JsonConvert.DeserializeObject<dynamic>(json);

                        Console.WriteLine("Root object : " + rootjson);

                        //File.WriteAllText(@"C:\json\test.json", JsonConvert.SerializeObject(rootjson));
                        File.AppendAllText(@"C:\json\test.json", JsonConvert.SerializeObject(rootjson));

                        Console.WriteLine("Contents successfully writing to file.....Record: " + count);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(count + " : Record not found.....");
                        count++;
                    }
                }
            }
        }
    }
}

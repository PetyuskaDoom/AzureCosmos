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

            //continueLoopItteration();

            //CreateDocumentsAsync();
        }

    //static void CreateDocumentsAsync()
    //{
    //    string fileName = "/myjson.json";

    //    // Obtain AAD token for ADLS 
    //    var creds = new ClientCredential(applicationId, clientSecret);
    //    var clientCreds = ApplicationTokenProvider.LoginSilentAsync(tenantId, creds).GetAwaiter().GetResult();

    //    // Create ADLS client object
    //    AdlsClient client = AdlsClient.CreateClient(adlsAccountFQDN, clientCreds);

    //    String json = "";

    //    //Read file contents
    //    using (var readStream = new StreamReader(client.GetReadStream(fileName)))
    //    {
    //        string line;
    //        while ((line = readStream.ReadLine()) != null)
    //        {
    //            Console.WriteLine("Read file Line: " + line);
    //            json += line;
    //        }
    //    }

    //    //Read file to json
    //    JsonTextReader reader = new JsonTextReader(new StringReader(json));

    //    //Storing json to CosmosDB
    //    Uri collectionUri = UriFactory.CreateDocumentCollectionUri(databaseName, collectionName);

    //    using (DocumentClient DocumentDBclient2 = new DocumentClient(new Uri(endpointUrl), authorizationKey))
    //    {
    //        Document doc = await DocumentDBclient2.CreateDocumentAsync(collectionUri, reader);

    //    }
    //}

    

    //private static void continueLoopItteration(){}

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

                var recordCount = 10300;
                var count = 0;


                var path = @"C:\json\test";
                var fileNumber = 1;
                var extension = ".json";

                var fullPath = path + fileNumber + extension;

                var recSkipped = false;

                for (var i = 0; i < recordCount; i++)
                {
                    try
                    {
                        if(count < 280) {

                            if (!File.Exists(fullPath))
                            {
                                File.Create(fullPath).Dispose();
                                File.AppendAllText(fullPath, "[");
                            }

                            if (recSkipped == true)
                            {
                                recSkipped = false;
                            }
                            else
                            {
                                count++;
                            }

                            var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/contact/" + count);


                            //Console.WriteLine("Download string from Interpreter Intelligence : " + json);

                            dynamic rootjson = JsonConvert.DeserializeObject(json);

                            //var rootjson = JsonConvert.DeserializeObject<dynamic>(json);

                            //Console.WriteLine("Root object : " + rootjson);

                            //File.WriteAllText(@"C:\json\test.json", JsonConvert.SerializeObject(rootjson));
                            File.AppendAllText(fullPath, JsonConvert.SerializeObject(rootjson));
                            File.AppendAllText(fullPath, ",");
                            File.AppendAllText(fullPath, Environment.NewLine);


                            Console.WriteLine("Contents successfully writing to file.....Record: " + count);
                        }


                        //else if (count != 5001)
                        //{
                        //    var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/contact/" + count);
                        //    count++;

                        //    //Console.WriteLine("Download string from Interpreter Intelligence : " + json);

                        //    dynamic rootjson = JsonConvert.DeserializeObject(json);

                        //    //var rootjson = JsonConvert.DeserializeObject<dynamic>(json);

                        //    //Console.WriteLine("Root object : " + rootjson);

                        //    //File.WriteAllText(@"C:\json\test.json", JsonConvert.SerializeObject(rootjson));
                        //    File.AppendAllText(@"C:\json\test2.json", JsonConvert.SerializeObject(rootjson));

                        //    Console.WriteLine("Contents successfully writing to file.....Record: " + count);
                        //}
                        //else if (count != 7501)
                        //{
                        //    var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/contact/" + count);
                        //    count++;

                        //    //Console.WriteLine("Download string from Interpreter Intelligence : " + json);

                        //    dynamic rootjson = JsonConvert.DeserializeObject(json);

                        //    //var rootjson = JsonConvert.DeserializeObject<dynamic>(json);

                        //    //Console.WriteLine("Root object : " + rootjson);

                        //    //File.WriteAllText(@"C:\json\test.json", JsonConvert.SerializeObject(rootjson));
                        //    File.AppendAllText(@"C:\json\test3.json", JsonConvert.SerializeObject(rootjson));

                        //    Console.WriteLine("Contents successfully writing to file.....Record: " + count);
                        //}

                        //else if (count != 10300)
                        //{
                        //    var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/contact/" + count);
                        //    count++;

                        //    //Console.WriteLine("Download string from Interpreter Intelligence : " + json);

                        //    dynamic rootjson = JsonConvert.DeserializeObject(json);

                        //    //var rootjson = JsonConvert.DeserializeObject<dynamic>(json);

                        //    //Console.WriteLine("Root object : " + rootjson);

                        //    //File.WriteAllText(@"C:\json\test.json", JsonConvert.SerializeObject(rootjson));
                        //    File.AppendAllText(@"C:\json\test4.json", JsonConvert.SerializeObject(rootjson));

                        //    Console.WriteLine("Contents successfully writing to file.....Record: " + count);
                        //}
                        //else
                        //{
                        //    File.AppendAllText(fullPath, "]");
                        //    Console.WriteLine("If statement finished...");

                        //    //Console.ReadLine();
                        //}
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(count + " : Record not found.....");
                        count++;

                        recSkipped = true;
                    }
                }
                File.AppendAllText(fullPath, "]");
            }
        }
    }

    // When the file is created, connect to cosmos db and upload the file.

}

using NuGet.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml;


Venda v1 = new(1, "X-Tudo", 25.20M);


string json = JsonConvert.SerializeObject(v1, Formatting.Indented);

Console.WriteLine(json);

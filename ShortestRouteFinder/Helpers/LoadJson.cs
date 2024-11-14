using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShortestRouteFinder.Model;

namespace ShortestRouteFinder.Helpers
{
    public class LoadJson(string filePath)
    {
        public string? FilePath {get;}

        public List<Route> LoadRoutes(){
            try {
                var Data = File.ReadAllText(FilePath);

                return JsonConvert.DeserializeObject<List<Route>>(Data);
            } catch (Exception e){
                Console.WriteLine($"Error occured while reading JSON file: {e.Message}");
                return [];
            }
        }
    }
}
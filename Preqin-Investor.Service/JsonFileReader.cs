using Newtonsoft.Json;
using Preqin_Investor.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preqin_Investor.Service
{
    public class JsonFileReader : IJsonFileReader
    {
        public List<T> ReadJsonFile<T>(string filePath)
        {
            try
            {
                var jsonData = File.ReadAllText(filePath);
                var investors = JsonConvert.DeserializeObject<List<T>>(jsonData);
                return investors;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

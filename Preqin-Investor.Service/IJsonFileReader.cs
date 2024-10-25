using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preqin_Investor.Service
{
    public interface IJsonFileReader
    {
        List<T> ReadJsonFile<T>(string filePath);
    }
}

using Library.Models;
using System.Security.Cryptography;
using System.Text.Json;

namespace Library
{
    public interface IBackend
    {
        List<Condition> GetConditions();
    }

    public class Backend : IBackend
    {
        public List<Condition> GetConditions()
        {
            var conditonsFile = File.ReadAllText("conditions.json");

            var conditions = JsonSerializer.Deserialize<ConditionsJSON>(conditonsFile);

            return conditions.Conditions;
        }
    }
}

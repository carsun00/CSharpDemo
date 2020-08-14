using Dependability.Interface;

namespace DependabilityTests.Entity
{
    class StubAccountDao : IAccountDao
    {
        public string GetPassword(string id)
        {
            return "PASS";
        }
    }
}

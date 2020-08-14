using Dependability.Interface;

namespace DependabilityTests.Entity
{
    class StubHash : IHash
    {
        public string GetHashResult(string password)
        {
            return "PASS";
        }
    }
}

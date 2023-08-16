using Gym.Shared.Abstraction.Domain;

namespace Gym.Domain.Entities
{
    public class Gym : BaseEntity
    {
        public string Name { get; private set; }
        public Gym(string name)
        {
            Name = name;
        }
    }
}

using Unity.Mathematics;

namespace Pickgliss.Helper
{
    public static class RandomHelper
    {
        public static Random Rng = new Random();
        public static void Setup(uint state)
        {
            Rng.InitState(state);
        }
    }
}
using rougelike_lib.Interfaces;
using rougelike_lib.Internal;

namespace rougelike_lib
{
    public static class Engine
    {
        public static IGame Initialize()
        {
            return new Game();
        }
    }
}

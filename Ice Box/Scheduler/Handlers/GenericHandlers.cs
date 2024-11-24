using ECommons.Throttlers;

namespace Ice_Box.Scheduler.Handlers
{
    internal class GenericHandlers
    {
        internal static bool? Throttle(int ms)
        {
            return EzThrottler.Throttle("Ice Box Wait", ms);
        }

        internal static bool? WaitFor(int ms)
        {
            return EzThrottler.Check("Ice Box Wait");
        }
    }
}

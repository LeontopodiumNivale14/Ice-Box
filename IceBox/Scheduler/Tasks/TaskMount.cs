using IceBox.Scheduler.Handlers;

namespace IceBox.Scheduler.Tasks;

public class TaskMount
{
    internal static void Enqueue()
    {
        TaskManagerIce.Enqueue(PlayerHandlers.PlayerMounted);
    }
}

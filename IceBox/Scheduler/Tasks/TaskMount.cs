using IceBox.Scheduler.Handlers;

namespace IceBox.Scheduler.Tasks;

public class TaskMount
{
    internal static void Enqueue()
    {
        P.TaskManager.Enqueue(PlayerHandlers.PlayerMounted);
    }
}

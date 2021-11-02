using LetMeDo.Models;

namespace LetMeDo;

public static class AppState
{
    public static List<TodoList> Lists { get; set; } = new();
    public static event EventHandler<EventArgs> OnChanged;

    public static void NotifyChanges(object? sender, EventArgs args)
    {
        OnChanged.Invoke(sender, args);
    }
}

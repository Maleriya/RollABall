
namespace Assets.Scripts
{
    public interface IInteractable : IAction
    {
        bool IsInteractable { get; }
    }
}

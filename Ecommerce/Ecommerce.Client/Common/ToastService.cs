public class ToastService
{
    public event Func<string, ToastLevel, Task> OnShow;
    public event Func<Task> OnHide;

    public async Task ShowToast(string message, ToastLevel level = ToastLevel.Info)
    {
        if (OnShow != null)
        {
            await OnShow.Invoke(message, level);
        }
    }

    public async Task HideToast()
    {
        if (OnHide != null)
        {
            await OnHide.Invoke();
        }
    }

    public enum ToastLevel
    {
        Info,
        Success,
        Warning,
        Error
    }
}

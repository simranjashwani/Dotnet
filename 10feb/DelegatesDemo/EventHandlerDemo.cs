public class Button
{
    public delegate void OnclickHandler();

    public event OnclickHandler OnClick;

    // informing subscribers that button was clicked

    public void Click()
    {
        OnClick?.Invoke();
    }
}
public class EventDemo
{
    public static void Run()
    {
        Button button = new Button();
        // Subscriber Dool bell
        button.OnClick += () => Console.WriteLine("Bell Rings!");

        // Subscriber Electricity Board
        button.OnClick += () => Console.WriteLine("Charge for electricity");
        button.OnClick += () => Console.WriteLine("3rd for electricity");
        button.OnClick += () => Console.WriteLine("4th for electricity");
        button.Click();
    }
}

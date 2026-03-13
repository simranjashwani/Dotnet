ICommand createCustomerCommand = new CreateCustomerCommand();
createCustomerCommand.Execute();






//solid 
CreateCustomer();
void CreateCustomer()
{
    Console.WriteLine("creating customer directly");
}

public interface ICommand
{
    void Execute();
}
public class CreateCustomerCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("create customer ");
    }
}
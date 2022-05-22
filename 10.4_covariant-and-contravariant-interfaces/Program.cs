
/*  
    //КОВАРИАЦИЯ
    IMessenger<Phone> viberInPhone = new Viber<Phone>();
    IMessenger<IPhone> viberInIPhone = new Viber<IPhone>();
    IMessenger<Phone> viberInIphone = new Viber<IPhone>(); // ковариация - Объект интерфейса более универсального типа Phone мы можем привести к объекту интерфейса более конкретного типа IPhone

    viberInPhone.DeviceInfo();
    viberInIPhone.DeviceInfo();
    viberInIphone.DeviceInfo();

    Console.Read();

    public interface IMessenger<out T>
    {
        T DeviceInfo();
    }
*/
/*
    //КОНТРАВАРИАЦИЯ
    IMessenger<Phone> viberInPhone = new Viber<Phone>();
    viberInPhone.GetDeviceInfo(new Phone());

    IMessenger<IPhone> viberInIphone = new Viber<IPhone>();
    viberInIphone.GetDeviceInfo(new IPhone());

    IMessenger<IPhone> viberInIPhone = new Viber<Phone>(); // контравариация - Данной строкой мы выполняем приведение объекта интерфейса более универсального типа Phone к объекту интерфейса более конкретного типа IPhone

    Console.Read();
    public interface IMessenger<in T>
    {
        void GetDeviceInfo (T device);
    }
    public class Viber <T>: IMessenger<T> where T : Phone, new()
    {
        void IMessenger<T>.GetDeviceInfo(T device)
        {
            Console.WriteLine(device);
        }
    }

    public class Phone { }
    public class IPhone : Phone { }
*/
//Задание 10.4.4
//Определены два класса:

var user = new User();
var account = new Account();
IUpdater<Account> updater = new UserService();

public class User {}
public class Account : User {}
//Определён обобщённый интерфейс:
public interface IUpdater<in T>
{
    void Update(T entity);
}
//Реализуйте данный интерфейс в классе UserService, и продемонстрируйте контравариацию интерфейса в базовом классе Program.
public class UserService : IUpdater<User>
{
    public void Update(User entity)
    {
        throw new NotImplementedException();
    }
}

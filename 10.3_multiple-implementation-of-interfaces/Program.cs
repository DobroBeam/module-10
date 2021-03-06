//Задание 10.3.1
//Создайте класс FileManager и выполните в нём множественную реализацию интерфейсов, указанных в примере


public interface IWriter
{
    void Write();
}

public interface IReader
{
    void Read();
}

public interface IMailer
{
    void SendEmail();
}
public class FileManager : IWriter, IReader, IMailer
{
    public void Read()
    {
        throw new NotImplementedException();
    }

    public void SendEmail()
    {
        throw new NotImplementedException();
    }

    public void Write()
    {
        throw new NotImplementedException();
    }
}

//Задание 10.3.2
//Даны три интерфейса:
//Создайте класс Entity и выполните в нём множественную неявную реализацию данных интерфейсов.
public interface ICreatable
{
    void Create();
}

public interface IDeletable
{
    void Delete();
}

public interface IUpdatable
{
    void Update();
}
public class Entity : ICreatable, IDeletable, IUpdatable
{
    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}

//Задание 10.3.3
//Даны два интерфейса:
//Создайте класс ElectronicBook и выполните в нём множественную явную реализацию данных интерфейсов.
public interface IBook
{
    void Read();
}

public interface IDevice
{
    void TurnOn();
    void TurnOff();
}
public class ElectronicBook : IBook, IDevice
{
    void IBook.Read()
    {
        throw new NotImplementedException();
    }

    void IDevice.TurnOff()
    {
        throw new NotImplementedException();
    }

    void IDevice.TurnOn()
    {
        throw new NotImplementedException();
    }
}

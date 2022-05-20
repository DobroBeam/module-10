//Задание 10.2.2
//Используя теоретический материал из данного юнита, постарайтесь самостоятельно реализовать явную реализацию следующего интерфейса:

Writer writer = new Writer();
((IWriter)writer).Write();

//Задание 10.2.3
//Реализуйте неявно следующий интерфейс:

Worker worker = new Worker();
worker.Build();

//Задание 10.2.4
//Реализуйте явно следующий интерфейс и вызовите его метод в классе Program.

((IWorker)worker).Build();

public interface IWriter
{
    void Write();
}
public class Writer : IWriter
{
    public void Write()
    {
        throw new NotImplementedException();
    }
}



public class Worker : IWorker
{
    public void Build()
    {

    }
}
public interface IWorker
{
    public void Build();
}
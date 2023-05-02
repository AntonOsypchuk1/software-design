namespace ChainOfResponsibilities.LevelHandlers;

abstract class Handler
{
    protected Handler nextHandler;

    public Handler SetNext(Handler handler)
    {
        nextHandler = handler;
        return handler;
    }

    public Handler GetNext()
    {
        return nextHandler;
    }

    public abstract bool Handle(string input);
}
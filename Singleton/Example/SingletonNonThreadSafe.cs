namespace Singleton.Example;

public class SingletonNonThreadSafe
{
    private static SingletonNonThreadSafe _instance;

    private SingletonNonThreadSafe()
    {
    }

    public static SingletonNonThreadSafe GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SingletonNonThreadSafe();
        }

        return _instance;
    }
}
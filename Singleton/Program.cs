using Singleton.Example;


SingletonNonThreadSafe s1 = SingletonNonThreadSafe.GetInstance();
SingletonNonThreadSafe s2 = SingletonNonThreadSafe.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}

Console.WriteLine("\n----------------------------------------------------------------");

Console.WriteLine(
    "\n{0}\n{1}\n\n{2}\n",
    "If you see the same value, then singleton was reused (yay!)",
    "If you see different values, then 2 singletons were created (booo!!)",
    "RESULT:"
);

Thread process1 = new Thread(() =>
{
    SingletonThreadSafe instance = SingletonThreadSafe.GetInstance("FOO");
    Console.WriteLine(instance.Value);
});
Thread process2 = new Thread(() =>
{
    SingletonThreadSafe instance = SingletonThreadSafe.GetInstance("BAR");
    Console.WriteLine(instance.Value);
});
            
process1.Start();
process2.Start();
            
process1.Join();
process2.Join();
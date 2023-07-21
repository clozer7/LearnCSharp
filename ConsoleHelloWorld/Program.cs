
namespace ConsoleHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用自定义的打印输出
            ConsoleHelloWorld.Console.WriteLine("Hello World!");
            System.Console.Read();
        }
    }

    class Console
    {

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="str"></param>
        internal static void WriteLine(string message)
        {

            System.Console.WriteLine("start HelloWorld.Console.WriteLine...");
            System.Console.WriteLine(message);
            System.Console.WriteLine("end HelloWorld.Console.WriteLine.....");
        }
    }
}

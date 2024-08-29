using System.Windows.Forms;

namespace ConsoleHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用自定义的打印输出
            ConsoleHelloWorld.Console.WriteLine("Hello World!");

            // 弹窗
            //Form form = new Form();
            //form.ShowDialog();

            // 错误示例
            //System.Windows.Window window = new System.Windows.Window();
            //window.ShowDialog();

            // 引入项目依赖
            double v = Tools.Calculate.Add(1.5, 2.5);
            System.Console.WriteLine(v);

            // 获取数据类型
            var num = 3;
            Console.WriteLine(num.GetType().Name);

            // 汉诺塔
            Console.Solve(3, 'A', 'C', 'B');

            // 弱类型
            dynamic s = 12;
            System.Console.WriteLine(s);
            s = "hello world";
            System.Console.WriteLine(s);

            // 反射
            System.Type myType = typeof(Form);
            // 打印全称
            System.Console.WriteLine(myType.FullName);
            // 获取所有属性并打印
            foreach (var item in myType.GetProperties())
            {
                System.Console.WriteLine(item.Name);
            }
            // 获取所有方法并打印
            foreach (var item in myType.GetMethods())
            {
                System.Console.WriteLine(item.Name);
            }
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

        /// <summary>
        /// 汉诺塔算法
        /// </summary>
        /// <param name="n">圆环数</param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="aux"></param>
        public static void Solve(int n, char source, char destination, char aux)
        {
            if (n == 1)
            {
                System.Console.WriteLine($"Move disk from {source} to {destination}");
            }
            else
            {
                Solve(n - 1, source, aux, destination);
                System.Console.WriteLine($"Move disk from {source} to {destination}");
                Solve(n - 1, aux, destination, source);
            }
        }
    }
}

using System.Text;

namespace FileTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tools.Calculate.Add(1.5, 2.5);
            // 指定要读取的txt文件的路径
            string filePath = "你当前文本的路径";

            // 检查文件是否存在
            if (!File.Exists(filePath))
            {
                Console.WriteLine("文件不存在，请检查路径是否正确。");
                return;
            }

            // 注册CodePagesEncodingProvider
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // 使用StreamReader并指定GBK编码
            using (StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("GBK")))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
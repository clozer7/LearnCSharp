初识类与名称空间

1.名称空间 namespace
	描述: 方便项目管理,解决类名重复等问题
	使用: using System; 声明使用的名称空间
		  System.Console.WriteLine("Hello World!"); 也可以在使用时指定名称空间

2.依赖引用
	白盒引用-项目引用: 右键"引用" -> 添加引用 -> 项目 -> 选择需要的项目
	黑盒引用-DLL引用: 右键"引用" -> 添加引用 -> 程序集 -> 选择需要的DLL

注意: .NET Core项目与 .NET Framework项目不一样, .NET Core项目引用时没有程序集!

.NET Core项目结构为: 
    HelloWorld
        |-依赖项
        |   |-分析器
        |   |-框架
        |-Program.cs


.NET Framework项目结构为: 
    HelloWorld
        |-Properties
        |   |-AssemblyInfo.cs
        |-引用
        |   |-分析器
        |   |-...各种依赖程序集等
        |-App.config
        |-Program.cs
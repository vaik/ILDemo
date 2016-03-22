# IL相关知识梳理与学习的Demo
=
测试一下副标题
-
##一  什么是IL
		单行文本前面两个Tab

		
##二 IL基础知识点和查看工具
		多行编辑
		每行前面两个Tab
		多行编辑
		每行前面两个Tab
		部分高亮就是使用``包围起来。注意不是单引号，而是Tab键上方，数字1左边的按键
`郁闷`

##三 IL代码分析

~~~C#
static void Main(string[] args)
        {
            int num = 1;
            string str = "string";
            List<string> list = new List<string>() { "first", "second" };
            int id = 1;
            One one = new One();
            one.ID = id;
            Two two = new Two();
            Console.WriteLine(two.SayHello());
        }
~~~

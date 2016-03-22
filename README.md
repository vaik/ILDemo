# IL相关知识梳理与学习的Demo
=
测试一下副标题
-
一  什么是IL

		
二 IL基础知识点和查看工具


三 IL代码分析

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

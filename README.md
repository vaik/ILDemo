# 学习和练习使用MarkDwon来写README.MD
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

#插入符号 圆点符<br/>
* 给你我的手
	* 娃哈哈
		* 你是陪我到老的女人
* 一起摇摆
* 大姐太牛了

#缩进
>数据结构
>>树
>>>二叉树
>>>>平衡二叉树
>>>>>满二叉树

#插入图片
[![排队网]](http://www.paidui.com)
[排队网]:http://www.paidui.com/Content/Images/PDW/2016/3/15/17/12d6079c-d8a1-4ca3-a74c-8d05b4603eb0.jpg?1.0 "排队网移动POS"



[文字加超链接](http://www.baidu.com "百度")

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

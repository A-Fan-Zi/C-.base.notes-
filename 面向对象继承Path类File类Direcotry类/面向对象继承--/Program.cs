using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace 面向对象继承__
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Path类

            //string s=@"C:\Users\Administrator\Desktop\高天之下.txt";
            ////获得文件名
            //Console.WriteLine(Path.GetFileName(s));
            ////获得文件名但不包括扩展名
            //Console.WriteLine(Path.GetFileNameWithoutExtension(s));
            ////获得文件的扩展名
            //Console.WriteLine(Path.GetExtension(s));
            ////获得文件所在文件夹的名称
            //Console.WriteLine(Path.GetDirectoryName(s));
            ////获得文件的全路径
            //Console.WriteLine(Path.GetFullPath(s));
            ////连接两个字符串作为路径
            //Console.WriteLine(Path.Combine(@"C:\Users\Administrator\Desktop\","天空.txt"));
            ////以上述路径字符串来创建文档文件
            //File.Create(Path.Combine(@"C:\Users\Administrator\Desktop\", "天空.txt")); 
            #endregion
            #region File类
            //File类
            //创建文本文件
            //File.Create(@"C:\Users\Administrator\Desktop\大地之上.txt");
            ////删除文本文件
            //File.Delete(@"C:\Users\Administrator\Desktop\大地之上.txt");
            //复制文本文件
            //File.Copy(@"C:\Users\Administrator\Desktop\大地之上.txt", @"C:\Users\Administrator\Desktop\高天之下.txt");
            //Console.WriteLine("复制成功");
            //移动文本文件，剪切并粘贴到所想的位置
            //File.Move(@"C:\Users\Administrator\Desktop\高天之下.txt", @"C:\Users\Administrator\高天之下.txt");
            //判断文件是否存在
            //bool torf=File.Exists(@"C:\Users\Administrator\高天之下.txt");
            //Console.WriteLine(torf);
            //读取文件中的内容转成二进制字节数组
            //byte[] s=File.ReadAllBytes(@"C:\Users\Administrator\高天之下.txt");
            ////将字节数组中的每一个元素都要按照我们指定的编码格式解码成字符串
            ////GB2312简体中文  GBK简繁体中文 ASCII大多可以通用    UNICODE UTF-8
            ////得采用特定的编码格式打开
            //string str =Encoding.Unicode.GetString(s);
            //Console.WriteLine(str);

            //没有这个文件的话，会创建这个文件,有的话会覆盖
            //string st = "心胜于物，超凡入胜";
            //byte[] buffer= Encoding.Default.GetBytes(st);
            //File.WriteAllBytes(@"C:\Users\Administrator\Desktop\高天之上.txt", buffer);
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //对于文本、图片、影像都可以用的是ReadAllBytes

            //针对于文本文件的用ReadAllLines,或ReadAllTexts

            //将文件途径及编码格式输入File.ReadAllLines后，返回字符串数组
            //string[] strs=File.ReadAllLines(@"C:\Users\Administrator\高天之下.txt",Encoding.Default);
            //foreach (string item in strs)
            //{
            //    Console.WriteLine(item);
            //}
            //如果需要对文本中每一行进行操作，那么要用ReadAllLines

            //将文件途径及编码格式输入File.ReadAllLines后，返回字符串
            //string tr =File.ReadAllText(@"C:\Users\Administrator\高天之下.txt",Encoding.Default);
            //Console.WriteLine(tr);
            //Console.ReadKey();

            //输入途径与字符串数组，如果没有该文件则创建文件，有的话会将文件内的内容覆盖
            //File.WriteAllLines(@"C:\Users\Administrator\牢人与海.txt", new string[] { "格温","格海皇","夺心魔","格子姐"});
            //Console.WriteLine("写入成功");
            //向已有文件追加写入数据
            //File.AppendAllText(@"C:\Users\Administrator\牢人与海.txt","格子猫最可爱了",Encoding.Default); 
            #endregion
            #region Directory类
            //对文件夹进行操作的用Directory
            //创建文件夹
            //Directory.CreateDirectory(@"C:\Users\Administrator\罗素");
            //删除文件夹
            //Directory.Delete(@"C:\Users\Administrator\罗素",true);
            //for (int i = 0; i < 5; i++)
            //{
            //    Directory.CreateDirectory(@"C:\Users\Administrator\高天之上\" + i);
            //}
            //Console.WriteLine("创建成功");
            //剪切文件夹
            //Directory.Move(@"C:\Users\Administrator\高天之上\0", @"C:\Users\Administrator\高天之上\5");
            //Console.WriteLine("剪切成功");

            //获得文件夹内的文件的路径
            //string[] ss = Directory.GetFiles(@"F:\笔记", "*.txt");//后面"*.txt"代表的是搜索文件的格式
            //for (int i = 0; i < ss.Length; i++)
            //{
            //    Console.WriteLine(ss[i]);
            //}
            ////截取上面所搜索到的文件的文件名
            //for (int i = 0; i < ss.Length; i++)
            //{
            //    string s = Path.GetFileNameWithoutExtension(ss[i]);
            //    Console.WriteLine(s);
            //}

            //获得文件夹内的文件夹的路径
            //string[] strs=Directory.GetDirectories(@"F:\C#\c#");
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    Console.WriteLine(strs[i]);
            //} 
            #endregion


            Console.ReadKey();
        }
    }
}

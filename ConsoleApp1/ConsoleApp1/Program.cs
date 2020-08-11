using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            myClass.Message("myClass");
            myTest.function1();
            myClass.newMethod();
            //myClass.oldMethod();

            //测试委托
            ChangeNumber _comHandler;
            ChangeNumber _AddNumHandler = new ChangeNumber(testDelegate.AddNum);
            ChangeNumber _MulNumHandler = new ChangeNumber(testDelegate.MulNum);
            //Console.WriteLine(_AddNumHandler(8));
            //Console.WriteLine(_MulNumHandler(4));
            _comHandler = _MulNumHandler;
            _comHandler += _AddNumHandler;
            Console.WriteLine(_comHandler(7));

            PrintToScreen ps = new PrintToScreen(testDelegate.print);
            //调用已委托为参数的方法
            testDelegate.sendToScreen(ps,"2222");

            //实例化两个类
            testEvent te = new testEvent();
            testEventPrint tep = new testEventPrint();
            //实例化事件中的托管
            testEvent.EventDelegate teEventDelegate = new testEvent.EventDelegate(tep.PrintToScreen);
            //将托换注册到事件中
            te.eventChangeSend += teEventDelegate;
            // 触发事件
            te.onEventChange("xiaomi");

            Console.ReadLine();
        }
        // 自定义类
        class myClass{
            [Conditional("DEBUG")] //Attribute修饰，仅在调试模式下可调用改方法
            public static void Message(string str) {
                Console.WriteLine(str+" Message");
            }
            public static void newMethod() {
                Console.WriteLine("newMethod");
            }
            [Obsolete("this is a obsolete method!use anthor method instead",true)]
            public static void oldMethod()
            {
                Console.WriteLine("oldMethod");
            }
        }
        class myTest {
            public static void function1(){
                Console.WriteLine("function1");
            }
        }

        delegate int ChangeNumber(int n);
        delegate void PrintToScreen(string str);
        class testDelegate {
            private static int _value = 1;
            public static int AddNum(int n) {
                _value += n;
                return _value;
            }
            public static int MulNum(int n) {
                _value *= n;
                return _value;
            }
            public static void print(string str) {
                Console.WriteLine("你需要打印的是：" + str);
            }
            // 已委托为参数打印
            public static void sendToScreen(PrintToScreen ps,string str) {
                ps(str);
            }
        }


        class testEvent {
            public delegate void EventDelegate(string str);
            public event EventDelegate eventChangeSend;
            public void onEventChange(string str) {
                if (eventChangeSend != null) {
                    Console.WriteLine("事件分发");
                    eventChangeSend(str);
                }
            }
        }

        class testEventPrint {
            public void PrintToScreen(string str) {
                Console.WriteLine("事件触发打印："+str);
            }
        }
    }
}

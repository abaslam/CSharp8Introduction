using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Introduction.Lessons
{
    public class DefaultInterfaceImplementation
    {
        public static void Run()
        {
            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLogger();           

            consoleLogger.CommonMethod();

            Console.WriteLine($"Console Logger: {consoleLogger.LoggerName}");
            Console.WriteLine($"File Logger: {fileLogger.LoggerName}");
        }
    }


    public interface ILogger
    {
        public string LoggerName => this.GetType().Name;
        public string CommonMethod()
        {
            return "I am common";
        }

        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public string LoggerName => this.GetType().Name;

        public void Log(string message)
        {
            Console.WriteLine("I am logging in Console");
        }
    }

    public class FileLogger : ILogger
    {
        public string CommonMethod()
        {
            return "I am from File Logger";
        }
        public void Log(string message)
        {
            Console.WriteLine("I am logging in File");
        }
    }
}

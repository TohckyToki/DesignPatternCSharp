using System;
using ObserverPattern;

namespace DesignPatternCSharp {
    class ObserverPattern {
        public static bool IsCancel;
        public static void Run() {
            Console.CancelKeyPress += Console_CancelKeyPress;
            IsCancel = false;
            var messagechanged = false;
            var center = new MessageCenter();
            var programer = new Programer();
            var manager = new Manager();
            center.RegisterService(manager);
            center.RegisterService(programer);
            center.MessageChanged += new MessageChangedHandle(() => {
                messagechanged = true;
            });
            int i = 0;
            while (!IsCancel) {
                if (i > 10) {
                    center.UnregisterService(programer);
                }
                if (i > 20) {
                    center.UnregisterService(manager);
                    center.RegisterService(programer);
                }
                if (i > 30) {
                    center.RegisterService(manager);
                }
                if (i % 3 == 0) {
                    center.Message = i.ToString();
                }
                if (messagechanged) {
                    messagechanged = false;
                    Console.Clear();
                    Console.Write(programer.Message + "    " + manager.Message);
                }
                i++;
                System.Threading.Thread.Sleep(500);
            }
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e) {
            IsCancel = true;
        }
    }
}

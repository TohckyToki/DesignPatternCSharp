using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern {
    public class Manager : MessageService {
        public string Message { get; set; }
        public MessageCenter MessageCenter { get; set; }
        ~Manager() {
            this.MessageCenter?.UnregisterService(this);
        }
        public void UpdateMsg(string msg) {
            this.Message = $"{this.GetType().FullName}: {msg}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern {
    public class Programer : MessageService {
        public string Message { get; set; }
        public MessageCenter MessageCenter { get; set; }
        ~Programer() {
            this.MessageCenter?.UnregisterService(this);
        }
        public void UpdateMsg(string msg) {
            this.Message = $"{this.GetType().FullName}: {msg}";
        }
    }
}

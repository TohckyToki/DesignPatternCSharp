using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern {
    public delegate void MessageChangedHandle();

    public class MessageCenter {
        private string _message;
        private List<MessageService> _messageServices;
        public MessageChangedHandle MessageChanged;

        public string Message {
            set {
                this._message = value;
                this.MessageChanged();
            }
        }

        public MessageCenter() {
            this._messageServices = new List<MessageService>();
            this.MessageChanged += DefaultMessageChanged;
        }

        private void DefaultMessageChanged() {
            foreach (var item in this._messageServices) {
                item?.UpdateMsg(this._message);
            }
            this._message = string.Empty;
        }

        public void RegisterService(MessageService service) {
            this._messageServices.Add(service);
            service.MessageCenter = this;
        }

        public void UnregisterService(MessageService service) {
            this._messageServices.Remove(service);
            service.MessageCenter = null;
        }

    }
}

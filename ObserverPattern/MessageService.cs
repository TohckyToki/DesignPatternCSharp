using System;

namespace ObserverPattern {
    public interface MessageService {
        public MessageCenter MessageCenter { get; set; }
        public void UpdateMsg(string msg);

        //There is usually another way to notify the observer that the
        //subject has changed but dose not pass any specific information,
        //but rather allows the observer to extract the desired information
        //from the subject.
    }
}

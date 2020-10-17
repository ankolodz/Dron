using System.Collections.Generic;
using System.Linq;

namespace DronApp
{
    public enum SenderId
    {
        ALERT,
        PARAMETER,
        MESSAGE
    }

    public class MessageScheduler: SendMessageService
    {
        private static byte [] DEFAULT_PARAMETER_MESSAGE = { 128, 0, 40, 40, 0, 208 };
        private byte[] alertMessage;
        private byte[] parameterMessage;
        private Queue<byte[]> messageQueue;
        private bool lastParameterMessage;
        private object m_SyncObject;

        public MessageScheduler()
        {
            parameterMessage = DEFAULT_PARAMETER_MESSAGE;
            messageQueue = new Queue<byte[]>();
            lastParameterMessage = true;
            m_SyncObject = new object();
        }

        public void newMessage(byte[] message, SenderId senderId)
        {
            lock (m_SyncObject)
            {            
                switch (senderId)
                {
                    case SenderId.ALERT:
                        alertMessage = message;
                        break;
                    case SenderId.PARAMETER:
                        parameterMessage = message;
                        break;
                    case SenderId.MESSAGE:
                        messageQueue.Enqueue(message);
                        break;
                }
            }            
        }

        public byte[] getNextMessage()
        {
            lock (m_SyncObject)
            {
                if (alertMessage != null)
                    return getAlertMessage();
                else if (lastParameterMessage && messageQueue.Count() > 0)
                    return getMessage();
            
                return parameterMessage;
            }
        }

        private byte[] getAlertMessage()
        {
            byte[] message = alertMessage;
            alertMessage = null;
            lastParameterMessage = false;
            return message;
        }

        private byte[] getMessage()
        {
            byte[] message = messageQueue.Dequeue();
            lastParameterMessage = false;
            return message;
        }

        private byte[] getParameterMessage()
        {
            lastParameterMessage = true;
            return parameterMessage;
        }
    }
}

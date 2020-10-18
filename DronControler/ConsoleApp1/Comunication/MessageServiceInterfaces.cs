namespace DronApp
{
    public interface SendMessageService
    {
        void newMessage(byte[] message, SenderId senderId);
    }

    public interface ServiceState
    {
        void setON();
        void setOFF();
        State getState();
    }

    public interface Addressee
    {
        void reciveMessage(byte[] message);
    }
}

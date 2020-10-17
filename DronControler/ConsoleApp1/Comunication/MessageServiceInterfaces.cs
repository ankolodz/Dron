namespace DronApp
{
    public interface SendMessageService
    {
        void newMessage(byte[] message, SenderId senderId);
    }

    public interface Addressee
    {
        void reciveMessage(byte[] message);
    }
}

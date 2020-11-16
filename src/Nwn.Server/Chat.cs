using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwn.Server
{
  public class Chat : Plugin
  {
    #region Channel Class
    public class Channel
    {
      public Chat Chat { get; }
      internal int ID { get; set; }
      public float HearingDistance
      {
        get => Chat.CallFloat("GetChatHearingDistance", ID, NwnReference.INVALID);
        set => Chat.Call("SetChatHearingDistance", ID, NwnReference.INVALID, value);
      }

      internal Channel(Chat chat, int id)
      {
        Chat = chat;
        ID = id;
      }

      public void SetHearingDistance(NwnReference listener, float distance) => Chat.Call("SetChatHearingDistance", ID, listener, distance);
      public float GetHearingDistance(NwnReference listener) => Chat.CallFloat("GetChatHearingDistance", ID, listener);

      public void SendMessage(string message, NwnReference? sender = null, NwnReference? target = null) =>
        Chat.Call("SendMessage", ID, message, sender ?? NwnReference.INVALID, target ?? NwnReference.INVALID);
    }
    #endregion

    #region Chat Script Class
    private class ChatScript : Script
    {
      public Chat Chat { get; }
      public ChatScript(Chat chat) : base(chat.Server) => Chat = chat;
      public override string Name => "__csharp__chat";
      public override void Execute()
      {
        var e = Chat.OnMessageArrived(
          new Channel(Chat,Chat.CallInt32("GetChannel")),
          Chat.CallString("GetMessage"),
          Chat.CallObj("GetSender"),
          Chat.CallObj("GetTarget")
        );

        if (e.Suppress)
          Chat.Call("SkipMessage");
      }
    }
    #endregion

    #region Channels
    public Channel PlayerTalk => new Channel(this, 1);
    public Channel PlayerShout => new Channel(this, 2);
    public Channel PlayerWhisper => new Channel(this, 3);
    public Channel PlayerTell => new Channel(this, 4);
    public Channel ServerChannel => new Channel(this, 5);
    public Channel PlayerParty => new Channel(this, 6);
    public Channel PlayerToDM => new Channel(this, 14);
    public Channel DMTalk => new Channel(this, 17);
    public Channel DMShout => new Channel(this, 18);
    public Channel DMWhisper => new Channel(this, 19);
    public Channel DMTell => new Channel(this, 20);
    public Channel DMParty => new Channel(this, 22);
    public Channel DMToDM => new Channel(this, 30);
    #endregion

    private ChatScript _script;

    internal Chat(NwnServer server) : base(server)
    {
      _script = new ChatScript(this);
      Call("RegisterChatScript", _script.Name);
    }

    #region Events

    #region MessageArrivedEventArgs Subclass
    public class MessageArrivedEventArgs : EventArgs
    {
      public Channel Channel { get; private set; }
      public string Message { get; private set; }
      public NwnReference Sender { get; private set; }
      public NwnReference Target { get; private set; }
      public bool Suppress { get; set; }

      internal MessageArrivedEventArgs(Channel channel, string message, NwnReference sender, NwnReference target)
      {
        Channel = channel;
        Message = message;
        Sender = sender;
        Target = target;
      }
    }
    #endregion

    public event global::System.EventHandler<MessageArrivedEventArgs> MessageArrived;
    protected MessageArrivedEventArgs OnMessageArrived(Channel channel, string message, NwnReference sender, NwnReference target)
    {
      var e = new MessageArrivedEventArgs(channel, message, sender, target);
      OnMessageArrived(e);
      return e;
    }
    protected virtual void OnMessageArrived(MessageArrivedEventArgs e) => MessageArrived?.Invoke(this, e);
    #endregion
  }
}

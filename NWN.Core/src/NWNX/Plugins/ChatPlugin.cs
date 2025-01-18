using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Chat)]
  public class ChatPlugin
  {
    public const string NWNX_Chat = "NWNX_Chat";

    ///&lt; @private
    /// @name Chat Channels
    /// @anchor chat_channels
    ///
    /// Constants defining the various chat channels.
    /// @{
    public const int NWNX_CHAT_CHANNEL_PLAYER_TALK = 1;
    public const int NWNX_CHAT_CHANNEL_PLAYER_SHOUT = 2;
    public const int NWNX_CHAT_CHANNEL_PLAYER_WHISPER = 3;
    public const int NWNX_CHAT_CHANNEL_PLAYER_TELL = 4;
    public const int NWNX_CHAT_CHANNEL_SERVER_MSG = 5;
    public const int NWNX_CHAT_CHANNEL_PLAYER_PARTY = 6;
    public const int NWNX_CHAT_CHANNEL_PLAYER_DM = 14;
    public const int NWNX_CHAT_CHANNEL_DM_TALK = 17;
    public const int NWNX_CHAT_CHANNEL_DM_SHOUT = 18;
    public const int NWNX_CHAT_CHANNEL_DM_WHISPER = 19;
    public const int NWNX_CHAT_CHANNEL_DM_TELL = 20;
    public const int NWNX_CHAT_CHANNEL_DM_PARTY = 22;
    public const int NWNX_CHAT_CHANNEL_DM_DM = 30;

    // @}
    /// Sends a chat message.
    /// @remark If no target is provided, then it broadcasts to all eligible targets.
    /// <param name="channel">The @ref chat_channels &quot;channel&quot; to send the message.</param>
    /// <param name="message">The message to send.</param>
    /// <param name="sender">The sender of the message.</param>
    /// <param name="target">The receiver of the message.</param>
    /// <returns>TRUE if successful, FALSE otherwise.</returns>
    public static int SendMessage(int channel, string message, uint sender = OBJECT_INVALID, uint target = OBJECT_INVALID)
    {
      const string sFunc = "SendMessage";
      VM.NWNX.SetFunction(NWNX_Chat, sFunc);
      VM.NWNX.StackPush(target);
      VM.NWNX.StackPush(sender);
      VM.NWNX.StackPush(message);
      VM.NWNX.StackPush(channel);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Registers the script which receives all chat messages.
    /// @note If a script was previously registered, this one will take over.
    /// <param name="script">The script name to handle the chat events.</param>
    public static void RegisterChatScript(string script)
    {
      const string sFunc = "RegisterChatScript";
      VM.NWNX.SetFunction(NWNX_Chat, sFunc);
      VM.NWNX.StackPush(script);
      VM.NWNX.Call();
    }

    /// Skips a chat message
    /// @note Must be called from a chat or system script handler.
    public static void SkipMessage()
    {
      const string sFunc = "SkipMessage";
      VM.NWNX.SetFunction(NWNX_Chat, sFunc);
      VM.NWNX.Call();
    }

    /// Gets the chat @ref chat_channels &quot;channel&quot;.
    /// @note Must be called from a chat or system script handler.
    /// <returns>The @ref chat_channels &quot;channel&quot; the message is sent.</returns>
    public static int GetChannel()
    {
      const string sFunc = "GetChannel";
      VM.NWNX.SetFunction(NWNX_Chat, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the message.
    /// @note Must be called from a chat or system script handler.
    /// <returns>The message sent.</returns>
    public static string GetMessage()
    {
      const string sFunc = "GetMessage";
      VM.NWNX.SetFunction(NWNX_Chat, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Gets the sender of the message.
    /// @note Must be called from a chat or system script handler.
    /// <returns>The object sending the message.</returns>
    public static uint GetSender()
    {
      const string sFunc = "GetSender";
      VM.NWNX.SetFunction(NWNX_Chat, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Gets the target of the message.
    /// @note Must be called from an chat or system script handler.
    /// <returns>The target of the message or OBJECT_INVALID if no target.</returns>
    public static uint GetTarget()
    {
      const string sFunc = "GetTarget";
      VM.NWNX.SetFunction(NWNX_Chat, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Sets the distance with which the player hears talks or whispers.
    /// @remark Per player settings override server wide.
    /// <param name="distance">The distance in meters.</param>
    /// <param name="listener">The listener, if OBJECT_INVALID then it will be set server wide.</param>
    /// <param name="channel">The @ref chat_channels &quot;channel&quot; to modify the distance heard. Only applicable for talk and whisper.</param>
    public static void SetChatHearingDistance(float distance, uint listener = OBJECT_INVALID, int channel = NWNX_CHAT_CHANNEL_PLAYER_TALK)
    {
      const string sFunc = "SetChatHearingDistance";
      VM.NWNX.SetFunction(NWNX_Chat, sFunc);
      VM.NWNX.StackPush(channel);
      VM.NWNX.StackPush(listener);
      VM.NWNX.StackPush(distance);
      VM.NWNX.Call();
    }

    /// Gets the distance with which the player hears talks or whisper
    /// <param name="listener">The listener, if OBJECT_INVALID then will return server wide setting.</param>
    /// <param name="channel">The @ref chat_channels &quot;channel&quot;. Only applicable for talk and whisper.</param>
    public static float GetChatHearingDistance(uint listener = OBJECT_INVALID, int channel = NWNX_CHAT_CHANNEL_PLAYER_TALK)
    {
      const string sFunc = "GetChatHearingDistance";
      VM.NWNX.SetFunction(NWNX_Chat, sFunc);
      VM.NWNX.StackPush(channel);
      VM.NWNX.StackPush(listener);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    // @}
  }
}

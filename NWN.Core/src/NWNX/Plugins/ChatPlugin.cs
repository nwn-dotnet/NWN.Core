using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Chat)]
  public class ChatPlugin
  {
    /// @addtogroup chat Chat
    /// Functions related to chat.
    /// @{
    /// @file nwnx_chat.nss
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
      NWNXPushObject(target);
      NWNXPushObject(sender);
      NWNXPushString(message);
      NWNXPushInt(channel);
      NWNXCall(NWNX_Chat, "SendMessage");
      return NWNXPopInt();
    }

    /// Registers the script which receives all chat messages.
    /// @note If a script was previously registered, this one will take over.
    /// <param name="script">The script name to handle the chat events.</param>
    public static void RegisterChatScript(string script)
    {
      NWNXPushString(script);
      NWNXCall(NWNX_Chat, "RegisterChatScript");
    }

    /// Skips a chat message
    /// @note Must be called from a chat or system script handler.
    public static void SkipMessage()
    {
      NWNXCall(NWNX_Chat, "SkipMessage");
    }

    /// Gets the chat @ref chat_channels &quot;channel&quot;.
    /// @note Must be called from a chat or system script handler.
    /// <returns>The @ref chat_channels &quot;channel&quot; the message is sent.</returns>
    public static int GetChannel()
    {
      NWNXCall(NWNX_Chat, "GetChannel");
      return NWNXPopInt();
    }

    /// Gets the message.
    /// @note Must be called from a chat or system script handler.
    /// <returns>The message sent.</returns>
    public static string GetMessage()
    {
      NWNXCall(NWNX_Chat, "GetMessage");
      return NWNXPopString();
    }

    /// Gets the sender of the message.
    /// @note Must be called from a chat or system script handler.
    /// <returns>The object sending the message.</returns>
    public static uint GetSender()
    {
      NWNXCall(NWNX_Chat, "GetSender");
      return NWNXPopObject();
    }

    /// Gets the target of the message.
    /// @note Must be called from an chat or system script handler.
    /// <returns>The target of the message or OBJECT_INVALID if no target.</returns>
    public static uint GetTarget()
    {
      NWNXCall(NWNX_Chat, "GetTarget");
      return NWNXPopObject();
    }

    /// Sets the distance with which the player hears talks or whispers.
    /// @remark Per player settings override server wide.
    /// <param name="distance">The distance in meters.</param>
    /// <param name="listener">The listener, if OBJECT_INVALID then it will be set server wide.</param>
    /// <param name="channel">The @ref chat_channels &quot;channel&quot; to modify the distance heard. Only applicable for talk and whisper.</param>
    public static void SetChatHearingDistance(float distance, uint listener = OBJECT_INVALID, int channel = NWNX_CHAT_CHANNEL_PLAYER_TALK)
    {
      NWNXPushInt(channel);
      NWNXPushObject(listener);
      NWNXPushFloat(distance);
      NWNXCall(NWNX_Chat, "SetChatHearingDistance");
    }

    /// Gets the distance with which the player hears talks or whisper
    /// <param name="listener">The listener, if OBJECT_INVALID then will return server wide setting.</param>
    /// <param name="channel">The @ref chat_channels &quot;channel&quot;. Only applicable for talk and whisper.</param>
    public static float GetChatHearingDistance(uint listener = OBJECT_INVALID, int channel = NWNX_CHAT_CHANNEL_PLAYER_TALK)
    {
      NWNXPushInt(channel);
      NWNXPushObject(listener);
      NWNXCall(NWNX_Chat, "GetChatHearingDistance");
      return NWNXPopFloat();
    }

    // @}
  }
}

using NWN;

namespace NWNX
{
    [NWNXPlugin(NWNX_Chat)]
    public class ChatPlugin
    {
        public const string NWNX_Chat = "NWNX_Chat";

        // /< @private
        // / @name Chat Channels
        // / @anchor chat_channels
        // /
        // / Constants defining the various chat channels.
        // / @{
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

        // / @}
        // / @brief Sends a chat message.
        // / @remark If no target is provided, then it broadcasts to all eligible targets.
        // / @param channel The @ref chat_channels "channel" to send the message.
        // / @param message The message to send.
        // / @param sender The sender of the message.
        // / @param target The receiver of the message.
        // / @return TRUE if successful, FALSE otherwise.
        public static int SendMessage(int channel, string message, uint sender = NWScript.OBJECT_INVALID, uint target = NWScript.OBJECT_INVALID)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Chat, "SendMessage");
            Internal.NativeFunctions.nwnxPushObject(target);
            Internal.NativeFunctions.nwnxPushObject(sender);
            Internal.NativeFunctions.nwnxPushString(message);
            Internal.NativeFunctions.nwnxPushInt(channel);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Registers the script which receives all chat messages.
        // / @note If a script was previously registered, this one will take over.
        // / @param script The script name to handle the chat events.
        public static void RegisterChatScript(string script)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Chat, "RegisterChatScript");
            Internal.NativeFunctions.nwnxPushString(script);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Skips a chat message
        // / @note Must be called from a chat or system script handler.
        public static void SkipMessage()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Chat, "SkipMessage");
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the chat @ref chat_channels "channel".
        // / @note Must be called from a chat or system script handler.
        // / @return The @ref chat_channels "channel" the message is sent.
        public static int GetChannel()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Chat, "GetChannel");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets the message.
        // / @note Must be called from a chat or system script handler.
        // / @return The message sent.
        public static string GetMessage()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Chat, "GetMessage");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Gets the sender of the message.
        // / @note Must be called from a chat or system script handler.
        // / @return The object sending the message.
        public static uint GetSender()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Chat, "GetSender");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopObject();
        }

        // / @brief Gets the target of the message.
        // / @note Must be called from an chat or system script handler.
        // / @return The target of the message or OBJECT_INVALID if no target.
        public static uint GetTarget()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Chat, "GetTarget");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopObject();
        }

        // / @brief Sets the distance with which the player hears talks or whispers.
        // / @remark Per player settings override server wide.
        // / @param distance The distance in meters.
        // / @param listener The listener, if OBJECT_INVALID then it will be set server wide.
        // / @param channel The @ref chat_channels "channel" to modify the distance heard. Only applicable for talk and whisper.
        public static void SetChatHearingDistance(float distance, uint listener = NWScript.OBJECT_INVALID, int channel = NWNX_CHAT_CHANNEL_PLAYER_TALK)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Chat, "SetChatHearingDistance");
            Internal.NativeFunctions.nwnxPushInt(channel);
            Internal.NativeFunctions.nwnxPushObject(listener);
            Internal.NativeFunctions.nwnxPushFloat(distance);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the distance with which the player hears talks or whisper
        // / @param listener The listener, if OBJECT_INVALID then will return server wide setting.
        // / @param channel The @ref chat_channels "channel". Only applicable for talk and whisper.
        public static float GetChatHearingDistance(uint listener = NWScript.OBJECT_INVALID, int channel = NWNX_CHAT_CHANNEL_PLAYER_TALK)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Chat, "GetChatHearingDistance");
            Internal.NativeFunctions.nwnxPushInt(channel);
            Internal.NativeFunctions.nwnxPushObject(listener);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopFloat();
        }

        // / @}
    }
}

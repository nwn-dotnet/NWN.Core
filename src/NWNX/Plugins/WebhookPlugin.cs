namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_WebHook)]
    public class WebhookPlugin
    {
        public const string NWNX_WebHook = "NWNX_WebHook";

        ///< @private
        /// Send a slack compatible webhook.
        /// <param name="host">The web server to send the hook.</param>
        /// <param name="path">The path to the hook.</param>
        /// <param name="message">The message to dispatch.</param>
        /// <param name="username">The username to display as the originator of the hook.</param>
        /// <param name="mrkdwn">Set to false if you do not wish your message's markdown be parsed.</param>
        public static void SendWebHookHTTPS(string host, string path, string message, string username = "", int mrkdwn = 1)
        {
            VM.NWNX.SetFunction(NWNX_WebHook, "SendWebHookHTTPS");
            VM.NWNX.StackPush(mrkdwn);
            VM.NWNX.StackPush(username);
            VM.NWNX.StackPush(message);
            VM.NWNX.StackPush(path);
            VM.NWNX.StackPush(host);
            VM.NWNX.Call();
        }

        /// Resends a webhook message after a defined delay.
        ///
        /// Handy when a submission is rate limited, since the message that the event sends in NWNX_Events_GetEventData
        /// is already constructed. So it just resends the WebHook with an optional delay.
        /// <param name="host">The web server to send the hook.</param>
        /// <param name="path">The path to the hook.</param>
        /// <param name="sMessage">The message to dispatch.</param>
        /// <param name="delay">The delay in seconds to send the message again.</param>
        public static void ResendWebHookHTTPS(string host, string path, string sMessage, float delay = 0.0f)
        {
            NWScript.DelayCommand(delay, () => SendWebHookHTTPS(host, path, sMessage));
        }

        /// @}
    }
}
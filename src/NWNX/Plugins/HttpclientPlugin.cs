using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_HTTPClient)]
  public class HttpclientPlugin
  {
    public const string NWNX_HTTPClient = "NWNX_HTTPClient";

    ///&lt; @private
    /// @name Request Types
    /// @anchor request_types
    ///
    /// @{
    public const int NWNX_HTTPCLIENT_REQUEST_METHOD_GET = 0;
    public const int NWNX_HTTPCLIENT_REQUEST_METHOD_POST = 1;
    public const int NWNX_HTTPCLIENT_REQUEST_METHOD_DELETE = 2;
    public const int NWNX_HTTPCLIENT_REQUEST_METHOD_PATCH = 3;
    public const int NWNX_HTTPCLIENT_REQUEST_METHOD_PUT = 4;
    public const int NWNX_HTTPCLIENT_REQUEST_METHOD_OPTION = 5;
    public const int NWNX_HTTPCLIENT_REQUEST_METHOD_HEAD = 6;

    ///@}
    /// @name Content Types
    /// @anchor content_types
    ///
    /// @{
    public const int NWNX_HTTPCLIENT_CONTENT_TYPE_HTML = 0;
    public const int NWNX_HTTPCLIENT_CONTENT_TYPE_PLAINTEXT = 1;
    public const int NWNX_HTTPCLIENT_CONTENT_TYPE_JSON = 2;
    public const int NWNX_HTTPCLIENT_CONTENT_TYPE_FORM_URLENCODED = 3;
    public const int NWNX_HTTPCLIENT_CONTENT_TYPE_XML = 4;

    ///@}
    /// @name HTTP Authentication Types
    /// @anchor auth_types
    ///
    /// @{
    public const int NWNX_HTTPCLIENT_AUTH_TYPE_NONE = 0;
    public const int NWNX_HTTPCLIENT_AUTH_TYPE_BASIC = 1;
    public const int NWNX_HTTPCLIENT_AUTH_TYPE_DIGEST = 2;
    public const int NWNX_HTTPCLIENT_AUTH_TYPE_BEARER_TOKEN = 3;

    ///@}
    /// A structure for an HTTP Client Request
    /// Sends an http method to the given host.
    /// <param name="s">The structured NWNX_HTTPClient_Request information.</param>
    /// <returns>A unique identifier for the request for later access in the REQUEST_ID event data.</returns>
    public static int SendRequest(Request s)
    {
      const string sFunc = "SendRequest";
      VM.NWNX.SetFunction(NWNX_HTTPClient, sFunc);
      VM.NWNX.StackPush(s.sHeaders);
      VM.NWNX.StackPush(s.nPort);
      VM.NWNX.StackPush(s.sAuthPassword);
      VM.NWNX.StackPush(s.sAuthUserOrToken);
      VM.NWNX.StackPush(s.nAuthType);
      VM.NWNX.StackPush(s.sData);
      VM.NWNX.StackPush(s.nContentType);
      VM.NWNX.StackPush(s.sPath);
      VM.NWNX.StackPush(s.sHost);
      VM.NWNX.StackPush(s.nRequestMethod);
      VM.NWNX.StackPush(s.sTag);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns an NWNX_HTTP_Client_Request structure
    /// <param name="nRequestId">The request id returned from NWNX_HTTPClient_SendRequest()</param>
    /// <returns>The structured NWNX_HTTPClient_Request information</returns>
    public static Request GetRequest(int nRequestId)
    {
      const string sFunc = "GetRequest";
      VM.NWNX.SetFunction(NWNX_HTTPClient, sFunc);
      VM.NWNX.StackPush(nRequestId);
      VM.NWNX.Call();
      Request s = default;
      s.sTag = VM.NWNX.StackPopString();
      s.nRequestMethod = VM.NWNX.StackPopInt();
      s.sHost = VM.NWNX.StackPopString();
      s.sPath = VM.NWNX.StackPopString();
      s.nContentType = VM.NWNX.StackPopInt();
      s.sData = VM.NWNX.StackPopString();
      s.nAuthType = VM.NWNX.StackPopInt();
      s.sAuthUserOrToken = VM.NWNX.StackPopString();
      s.sAuthPassword = VM.NWNX.StackPopString();
      s.nPort = VM.NWNX.StackPopInt();
      s.sHeaders = VM.NWNX.StackPopString();
      return s;
    }

    // @}
  }

  public struct Request
  {
    public int nRequestMethod;
    public string sTag;
    public string sHost;
    public string sPath;
    public string sData;
    public int nContentType;
    public int nAuthType;
    public string sAuthUserOrToken;
    public string sAuthPassword;
    public int nPort;
    public string sHeaders;
  }
}
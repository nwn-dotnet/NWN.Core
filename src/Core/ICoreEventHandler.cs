namespace NWN.Core
{
  public interface ICoreEventHandler
  {
    /// <summary>
    /// Called once every server update (loop).
    /// </summary>
    void OnMainLoop(ulong frame);

    /// <summary>
    /// Called every time the virtual machine will execute a script.
    /// </summary>
    /// <param name="script">The script invoked from the VM.</param>
    /// <param name="oidSelf">The current object.</param>
    /// <returns>-1: Not handled. If the script resource (ncs) is defined in the module, it will now be executed.<br/>
    /// 0: FALSE/Handled - For conditional scripts, sets the result to FALSE. If the script resource (ncs) is defined in the module, it will not be executed.<br/>
    /// 1: TRUE - For conditional scripts, sets the result to TRUE. If the script resource (ncs) is defined in the module, it will not be executed.</returns>
    int OnRunScript(string script, uint oidSelf);

    /// <summary>
    /// Called during processing of closure based commands and other actions that happen at a later time.
    /// </summary>
    /// <param name="eid">The closure's unique event ID.</param>
    /// <param name="oidSelf">The current object.</param>
    void OnClosure(ulong eid, uint oidSelf);

    /// <summary>
    /// Called when a significant server event occurs (Startup/Shutdown).
    /// </summary>
    /// <param name="signal">"ON_MODULE_LOAD_FINISH" - Called just before the OnModuleLoad event. Perform any init requiring NWScript usage here.<br/>
    /// "ON_DESTROY_SERVER" - Called just before the server will be shutdown. Perform any cleanup/flushing here.</param>
    void OnSignal(string signal);

    /// <summary>
    /// Called when a assertion failure occurs in native code.
    /// </summary>
    /// <param name="message">The failure message.</param>
    /// <param name="stackTrace">The native stack trace when this assertion failure occurred.</param>
    void OnAssertFail(string message, string stackTrace);

    /// <summary>
    /// Called when the server has entered an undefined state and is about to crash.
    /// </summary>
    /// <remarks>The implementation of this method should only attempt to log additional information, and NEVER attempt to save/modify existing state.<br/>
    /// Anything invoked by this function is considered undefined behaviour.</remarks>
    /// <param name="signal">The termination signal that was sent.</param>
    /// <param name="stackTrace">The backtrace of the current call stack.</param>
    void CrashHandler(int signal, string stackTrace);
  }
}

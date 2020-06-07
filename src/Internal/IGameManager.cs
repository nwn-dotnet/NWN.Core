namespace NWN
{
  public interface IGameManager
  {
    uint ObjectSelf { get; }

    void OnMainLoop(ulong frame);
    int OnRunScript(string script, uint oidSelf);
    void OnClosure(ulong eid, uint oidSelf);

    void ClosureAssignCommand(uint obj, ActionDelegate func);
    void ClosureDelayCommand(uint obj, float duration, ActionDelegate func);
    void ClosureActionDoCommand(uint obj, ActionDelegate func);
  }
}
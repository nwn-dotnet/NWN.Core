namespace NWN.Core
{
  public interface ICoreFunctionHandler
  {
    uint ObjectSelf { get; }

    void ClosureAssignCommand(uint obj, ActionDelegate func);
    void ClosureDelayCommand(uint obj, float duration, ActionDelegate func);
    void ClosureActionDoCommand(uint obj, ActionDelegate func);
  }
}

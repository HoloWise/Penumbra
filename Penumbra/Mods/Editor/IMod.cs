using OtterGui.Classes;
using Penumbra.Mods.Subclasses;

namespace Penumbra.Mods.Editor;

public interface IMod
{
    LowerString Name { get; }

    public int      Index    { get; }
    public ModPriority Priority { get; }

    public ISubMod                  Default { get; }
    public IReadOnlyList<IModGroup> Groups  { get; }

    public IEnumerable<SubMod> AllSubMods { get; }

    // Cache
    public int TotalManipulations { get; }
}

using Reloaded.Hooks.Definitions;
using static p3ppc.deDuplicator.Utils;
using IReloadedHooks = Reloaded.Hooks.ReloadedII.Interfaces.IReloadedHooks;

namespace p3ppc.deDuplicator.Component;

/// <summary>
/// Removes the use of the bst bustup bin files which contain duplicates of the loose bustup bins
/// </summary>
public class BustupBin
{

    private IAsmHook? _loadBstBinHook;

    public BustupBin(IReloadedHooks hooks)
    {
        SigScan(
            "48 81 EC B8 00 00 00 48 8B 05 ?? ?? ?? ?? 48 31 E0 48 89 84 24 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ??",
            "LoadBstBin",
            address =>
            {
                string[] function =
                {
                    "use64",
                    "ret", // Just don't try to load the bin :)
                };

                _loadBstBinHook = hooks.CreateAsmHook(function, address).Activate();
            });
    }
    
}
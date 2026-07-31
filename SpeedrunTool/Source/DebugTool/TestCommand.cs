#if DEBUG


using Celeste.Mod.SpeedrunTool.SaveLoad;

namespace Celeste.Mod.SpeedrunTool.DebugTool;
internal static class TestCommand {

    [Command("test_srt", "SpeedrunTool debug test")]
    public static void Test() {
        // do anything you want to test here
        StateManager.Instance.GcCollect(force: true);
    }

    [Command("test2_srt", "SpeedrunTool debug test")]
    public static void Test2() {
        // do anything you want to test here
        StateManager.Instance.ClearStateImpl(hasGc: true);
    }
}
#endif
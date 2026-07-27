#if DEBUG
namespace Celeste.Mod.SpeedrunTool.DebugTool;

internal static class MemoryTracker {

    private static long lastMark = 0;

    private static string lastTag = "init";

    public static void Mark(string tag) {
        if (!MemoryTracker_Profiling) {
            return;
        }

        long current = GC.GetTotalMemory(false);
        long diff = current - lastMark;

        // 格式化输出，方便查看（单位：MB）
        string diffStr = diff > 0 ? $"+{diff / 1024 / 1024} MB" : $"{diff / 1024 / 1024} MB";
        Logger.Debug("SpeedrunTool/MemoryTracker", $"[{tag}]: {current / 1024 / 1024} MB // Change vs [{lastTag}]: {diffStr}");

        lastMark = current;
        lastTag = tag;
    }
}
#endif
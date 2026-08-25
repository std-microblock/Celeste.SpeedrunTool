#if DEBUG
namespace Celeste.Mod.SpeedrunTool.DebugTool;

internal static class MemoryTracker {

    public static void Mark(string tag) {
        if (!MemoryTracker_Profiling) {
            return;
        }

        GCMemoryInfo info = GC.GetGCMemoryInfo();

        // 获取关键指标
        long totalHeapSize = info.HeapSizeBytes;        // GC 堆总大小
        long fragmentedBytes = info.FragmentedBytes;    // 碎片化总字节数

        // 计算碎片率（百分比）
        double fragmentationRatio = 0;
        if (totalHeapSize > 0) {
            fragmentationRatio = (double)fragmentedBytes / totalHeapSize * 100;
        }

        // 输出结果（转换为 MB）
        Logger.Debug("SpeedrunTool/MemoryTracker", $"[{tag}] Total GC Heap Size: {totalHeapSize / 1024.0 / 1024.0:F2} MB, Fragmented Ratio: {fragmentationRatio:F2}%");
    }
}
#endif
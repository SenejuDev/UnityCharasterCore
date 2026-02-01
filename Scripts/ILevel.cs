using UnityEngine;

namespace UnityCharacterCore.Level
{
    public interface ILevel
    {
        int level { get; }
        int maxLevel { get; }
        int minLevel { get; }
        int Exp {  get; }
        int MaxExp { get; }
        int MinExp { get; }

        void OnLevelChange();
        void OnLevelInfo();
        void GetExp();
        void GetMaxExp();
    }
}
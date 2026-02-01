using UnityEngine;

namespace UnityCharacterCore.Rank
{
    public interface IRank
    {
        int rank { get; }
        int maxRank { get; }
        int minRank { get; }
        int Exp {  get; }
        int maxExp { get; }
        int minExp { get; }

        void GetCurrentRank();
        void GetMaxRank();
        void GetCurrentExp();
        void GetExpToNextRank();
    }
}


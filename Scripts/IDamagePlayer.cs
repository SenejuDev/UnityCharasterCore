using UnityEngine;

namespace UnityCharacterCore.DamagePlayer
{
    public interface IDamagePlayer
    {
        float damagePlayer { get; }

        void DamagePlayer();
    }
}

using UnityEngine;

namespace UnityCharacterCore.Name
{
    public interface INameable
    {
        string NamePlayer { get; }

        void NamePlayerInfo();
    }
}

using UnityEngine;

namespace UnityCharacterCore.EnemyCharasters
{
    public interface IEnemyCharasters
    {
        string NameEnemy {  get;}
        float HealthEnemy { get;}
        float damageEnemy { get; }
        void InfoEnemyHealth();
        void DamageEnemy();
    }
}

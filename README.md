# UnityCharasterCore
Библиотека UnityCharacterCore

Базовая библиотека для модульной разработки в Unity 6+. Предоставляет набор интерфейсов для создания гибких систем (урон, инвентарь, локализация), которые легко расширять.



🚀 Установка

Просто скопируйте папку UnityCharacterCore в директорию Assets вашего Unity-проекта.



💡 Философия использования

Библиотека разработана с упором на чистый код и модульность, используя современный синтаксис C# (версии 8.0+), доступный в Unity 6.




🛠️ Примеры структур и использования



1\. Система урона: IDamagePlayer

Этот интерфейс определяет базовое поведение для любого объекта, способного получать урон.

Код интерфейса:



```csharp

using UnityEngine;

namespace UnityCharacterCore.DamagePlayer
{
    public interface IDamagePlayer
    {
        float damagePlayer { get; }

        void DamagePlayer();
    }
}
```



Пример реализации:



```csharp

using UnityEngine;

using UnityCharacterCore.DamagePlayer;

public class EnemyHealth : MonoBehaviour, IDamagePlayer
{
   public float damagePlayer => 10f; 

   public void DamagePlayer()
   {
       Debug.Log($"Получен урон: {damagePlayer}");
   }

   void Start()
   {
       IDamagePlayer entity = this; 
       entity.DamagePlayer(); 
   }
}

```





2\. Типы сущностей: EnemyType (Enum)

Это простое перечисление, которое можно использовать для категоризации ваших игровых объектов.

Код перечисления:



```csharp
using UnityEngine;

namespace UnityCharacterCore.Enemy
{
    public enum EnemyType
    {
        Normal,
        Elite,
        Boss
    }
}
```



3\. Характеристики врагов: IEnemyCharasters

Интерфейс для определения базовых характеристик врагов (здоровье, урон, имя).

Код интерфейса:



```csharp
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
```





4\. Здоровье игрока: IHealthPlayer

Интерфейс для управления здоровьем главного персонажа.

Код интерфейса:


```csharp
using UnityEngine;

namespace UnityCharacterCore.HealthPlayer
{
    public interface IHealthPlayer
    {
        float HealthPlayer { get; }

         void InfoHealthPlayer();
    }
}
```





5\. Система уровней: ILevel

Интерфейс для управления уровнями, опытом и их изменениями.

Код интерфейса:

```csharp
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
```





6\. Система имен: INameable

Интерфейс для объектов, которым требуется имя (Игрока).

Код интерфейса:

```csharp
using UnityEngine;

namespace UnityCharacterCore.Name
{
    public interface INameable
    {
        string NamePlayer { get; }

        void NamePlayerInfo();
    }
}

```







7\. Система рангов: IRank

Интерфейс для управления детальными рангами, опытом и прогрессией.

Код интерфейса:

```csharp

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

```


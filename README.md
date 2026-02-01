# UnityCharasterCore
Библиотека UnityCharacterCore

Базовая библиотека для модульной разработки в Unity 6+. Предоставляет набор интерфейсов для создания гибких систем (урон, инвентарь, локализация), которые легко расширять.



🚀 Установка

Просто скопируйте папку UnityCharacterCore в директорию Assets вашего Unity-проекта.



💡 Философия использования

Библиотека разработана с упором на чистый код и модульность, используя современный синтаксис C# (версии 8.0+), доступный в Unity 6.

Ключевой подход: работа с интерфейсами через переменные, чтобы код выглядел лаконично и красиво (без постоянных приведений типов ((Interface)this)).



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

&nbsp;   public float damagePlayer => 10f; 



&nbsp;   public void DamagePlayer()

&nbsp;   {

&nbsp;       Debug.Log($"Получен урон: {damagePlayer}");

&nbsp;   }



&nbsp;   void Start()

&nbsp;   {

&nbsp;       IDamagePlayer entity = this; 

&nbsp;       entity.DamagePlayer(); 

&nbsp;   }

}

```





2\. Типы сущностей: EnemyType (Enum)

Это простое перечисление, которое можно использовать для категоризации ваших игровых объектов.

Код перечисления:



```csharp

using UnityEngine;



namespace UnityCharacterCore.Enemy

{

&nbsp;   public enum EnemyType

&nbsp;   {

&nbsp;       Normal,

&nbsp;       Elite,

&nbsp;       Boss

&nbsp;   }

}

```



3\. Характеристики врагов: IEnemyCharasters

Интерфейс для определения базовых характеристик врагов (здоровье, урон, имя).

Код интерфейса:



```csharp

namespace UnityCharacterCore.EnemyCharasters

{

&nbsp;   public interface IEnemyCharasters

&nbsp;   {

&nbsp;       string NameEnemy { get;}

&nbsp;       float HealthEnemy { get;}

&nbsp;       float damageEnemy { get; }

&nbsp;       void InfoEnemyHealth();

&nbsp;       void DamageEnemy();

&nbsp;   }

}

```





4\. Здоровье игрока: IHealthPlayer

Интерфейс для управления здоровьем главного персонажа.

Код интерфейса:



```csharp

using UnityEngine;



namespace UnityCharacterCore.HealthPlayer

{

&nbsp;   public interface IHealthPlayer

&nbsp;   {

&nbsp;       float HealthPlayer { get; }

&nbsp;       void InfoHealthPlayer();

&nbsp;   }

}

```





5\. Система уровней: ILevel

Интерфейс для управления уровнями, опытом и их изменениями.

Код интерфейса:



```csharp

using UnityEngine;



namespace UnityCharacterCore.Level

{

&nbsp;   public interface ILevel

&nbsp;   {

&nbsp;       int level { get; }

&nbsp;       int maxLevel { get; }

&nbsp;       int minLevel { get; }

&nbsp;       int Exp { get; }

&nbsp;       int MaxExp { get; }

&nbsp;       int MinExp { get; }

&nbsp;       void OnLevelChange();

&nbsp;       void OnLevelInfo();

&nbsp;       void GetExp();

&nbsp;       void GetMaxExp();

&nbsp;   }

}

```





6\. Система имен: INameable

Интерфейс для объектов, которым требуется имя (например, игрок, NPC, предмет).

Код интерфейса:



```csharp

using UnityEngine;



namespace UnityCharacterCore.Name

{

&nbsp;   public interface INameable

&nbsp;   {

&nbsp;       string NamePlayer { get; }

&nbsp;       void NamePlayerInfo();

&nbsp;   }

}
```







7\. Система рангов: IRank

Интерфейс для управления детальными рангами, опытом и прогрессией.

Код интерфейса:



```csharp

using UnityEngine;



namespace UnityCharacterCore.Rank

{

&nbsp;   public interface IRank

&nbsp;   {

&nbsp;       int rank { get; }

&nbsp;       int maxRank { get; }

&nbsp;       int minRank { get; }

&nbsp;       int Exp { get; }

&nbsp;       int maxExp { get; }

&nbsp;       int minExp { get; }

&nbsp;       void GetCurrentRank();

&nbsp;       void GetMaxRank();

&nbsp;       void GetCurrentExp();

&nbsp;       void GetExpToNextRank();

&nbsp;   }

}

```


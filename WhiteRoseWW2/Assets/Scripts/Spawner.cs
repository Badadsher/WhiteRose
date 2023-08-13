using UnityEngine;

public class Spawner : MonoBehaviour
{
    [System.Serializable] //добавляем атрибут чтоб можно было сериализовать в инспекторе (Ползунок итд)
    public struct SpawnableObject //создаем публичную структуру для идентификации объекта и шанса появления
    {
        public GameObject prefab; //создаем для префабов
        [Range(0f, 1f)] //рандомный шанс появления между 0 и 1(будем контролировать в инспекторе)
        public float spawnChance;
    }

    public SpawnableObject[] objects; //создаем массив объектов

    public float minSpawnRate = 1f; //объект будет появляться в промежутке от одной до двух секунд
    public float maxSpawnRate = 2f;

    private void OnEnable()  //при включении скрипта вызывается функция спавна и время между рандомном временем мин и макс
    {
        Invoke(nameof(Spawn), Random.Range(minSpawnRate, maxSpawnRate));
    }
        
    private void OnDisable() //прекращаем цикл при проигрыше
    {
        CancelInvoke();
    }

    private void Spawn() //функция спавна которую мы вызвали выше
    {
        float spawnChance = Random.value;  //шанс рандомный

        foreach (var obj in objects) //создаем цикл
        {
            if (spawnChance < obj.spawnChance) //если вероятность появления меньше чем вероятность появления объекта-создаем экземпляр объекта
            {
                GameObject obstacle = Instantiate(obj.prefab); //в переменную определяем префабы препятствий
                obstacle.transform.position += transform.position; //новый объект будет появляться там-где объект с этим скриптом(спавнер)
                break; //заканчиваем цикл
            }

            spawnChance -= obj.spawnChance; //уменьшаем шанс 
        }

        Invoke(nameof(Spawn), Random.Range(minSpawnRate, maxSpawnRate));  //снова вызываем функцию спавна с новым рандомным объектом и новым рандомном минимума и максимума
    }

}

using UnityEngine;

public class DayNightSwitcher : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_speed * Time.deltaTime, 0, 0);
    }
}

//Сделать меню старта игры
//Еда при спауне должа падать с неба

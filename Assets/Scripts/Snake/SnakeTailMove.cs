using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTailMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Snake _target;
    
    public int Index { get; private set;}

    private void Update()
    {
        transform.LookAt(_target.transform);
        transform.position = Vector3.Lerp(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }
    public void Init(Snake target, int index)
    {
        _target = target;
        Index = index;
    }

}
//Найти 3D модель яблока. Добавить его в игру. Сделать для него материал
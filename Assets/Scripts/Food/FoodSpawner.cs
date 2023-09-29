using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : Pool
{
    [SerializeField] private Food _template;
    [SerializeField] private float _xSizeMin;
    [SerializeField] private float _xSizeMax;
    [SerializeField] private float _zSizeMin;
    [SerializeField] private float _zSizeMax;
    [SerializeField] private float _delay;

    private float _elepsedTime;

    private void Start()
    {
        Init(_template);
    }

    private void Update()
    {
        _elepsedTime += Time.deltaTime;
        if( _elepsedTime >= _delay)
        {
            _elepsedTime = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        Food food = GetFreeElement();
        food.gameObject.SetActive(true);
        food.transform.position = new Vector3(Random.Range(_xSizeMin, _xSizeMax), 12f, Random.Range(_zSizeMin, _zSizeMax));
    }
}

//—делать возможность поедани€ €блок с последующим добавлени€ очков.
//ќчки отображать на интерфейсе
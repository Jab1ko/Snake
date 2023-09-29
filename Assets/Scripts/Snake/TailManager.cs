using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailManager : MonoBehaviour
{
    [SerializeField] private Snake _tailTemplate;
    [SerializeField] private SnakeScore _snakeScore;
    [SerializeField] private Snake _currentLastTail;

    private List<SnakeTailMove> _moveList = new List<SnakeTailMove>();

    private void OnEnable()
    {
        _snakeScore.Eated += AddATail;
    }

    private void OnDisable()
    {
        _snakeScore.Eated -= AddATail;
    }

    private void AddATail()
    {
        Vector3 newTailPosition = _currentLastTail.transform.position;
        Snake newTail = Instantiate(_tailTemplate, newTailPosition, Quaternion.identity);

        if(newTail.TryGetComponent(out SnakeTailMove tail))
        {
            _moveList.Add(tail);
            tail.Init(_currentLastTail, _moveList.Count - 1);
            _currentLastTail = newTail;
        }
    }
}

//Сделать так, чтобы когда голова змеи касается стены, вылетало окно поражения
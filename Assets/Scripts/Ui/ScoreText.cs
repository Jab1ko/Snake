using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private SnakeScore _snakeScore;
    [SerializeField] private TMP_Text _scoreText;

    private void OnEnable()
    {
        _snakeScore.Eated += OnEated;
        _scoreText.text = "Score: 0";
    }

    private void OnDisable()
    {
        _snakeScore.Eated -= OnEated;
    }

    private void OnEated()
    {
        _scoreText.text = $"Score: {_snakeScore.Score}";
    }
}

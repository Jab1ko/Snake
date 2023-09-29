using UnityEngine;

public class DayNightSwitcher : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_speed * Time.deltaTime, 0, 0);
    }
}

//������� ���� ������ ����
//��� ��� ������ ����� ������ � ����

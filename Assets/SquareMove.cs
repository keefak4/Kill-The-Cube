using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMove : MonoBehaviour
{
    [Header("�������� ����")]
    [SerializeField] private float speedSquare;
    [Header("���������� �������� ����� ������")]
    [SerializeField] private float speedRec;
    [Header("���������� ������� ����� ������")]
    [SerializeField] private float scaleRec;
    [Header("����� ������ ����")]
    [SerializeField] private int healthCube;
    [Header("��������� ��� ��� ���")]
    [SerializeField] private bool isEnemy;
    [Space]
    private Animator animator;
    [Space]
    private Vector3 targetPos;
    private void Start()
    {
        targetPos = GetRandomPos();
        if (isEnemy == false)
        {
            
        }
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speedSquare * Time.deltaTime);
        if(targetPos == transform.position)
        {
            targetPos = GetRandomPos();
        }    
    }
    private void OnMouseDown()
    {
        if(isEnemy)
        {

        }
        else
        {
            PointLogic();
        }
    }
    private void PointLogic()
    {
        healthCube--;
        if (healthCube == 0)
        {
            Destroy(gameObject);
        }
        else
        {
            speedSquare += speedRec;
            transform.localScale = new Vector3(scaleRec, scaleRec, scaleRec);
            transform.position = GetRandomPos();
        }
    }
    private Vector3 GetRandomPos()
    {
        Vector3 randomVector = new Vector3();
        randomVector.x = Random.Range(-8, 8);
        randomVector.y = Random.Range(-4, 4);
        randomVector.z = transform.position.z;
        return randomVector;
    }    
}

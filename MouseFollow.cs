using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    [Header("Parameters: ")]
    [SerializeField] public float Speed = 1;

    Rigidbody rigidBody;

    Vector3 LookPosition;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Ray Ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit HitInfo;

        if (Physics.Raycast(Ray, out HitInfo, 100000000))
        {
            LookPosition = HitInfo.point;
        }

        Vector3 LookDirection = LookPosition - transform.position;
        LookDirection.y = 0;

        transform.LookAt(transform.position + LookDirection, Vector3.up); //смотрим в сторону курсора мыши

        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.AddForce((LookDirection * Speed).normalized / Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidBody.AddForce((LookDirection * -Speed).normalized / Time.deltaTime); //"двигаемся"
        }
    }
}
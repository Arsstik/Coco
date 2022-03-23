using UnityEngine;
using System.Collections;

public class CameraRing : MonoBehaviour
{

    public GameObject Player; // тут объект игрока
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
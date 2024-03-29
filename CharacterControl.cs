using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterControl : MonoBehaviour
{
    public float movementSpeed;
    public GameObject camera;



    void Update()
    {
        Plane PlayerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        if(PlayerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            targetRotation.x = 0;
            targetRotation.z = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 7f * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
    }

}






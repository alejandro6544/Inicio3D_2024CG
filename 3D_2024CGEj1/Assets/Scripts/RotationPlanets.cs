using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RotationPlanets : MonoBehaviour
{
    public float angle;
    public GameObject sun;
    private Vector3 posSun;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        posSun= sun.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        angle = Time.deltaTime*5;
        transform.Rotate(0, angle, 0);

        transform.RotateAround(posSun, Vector3.up, speed * Time.deltaTime);
    }
}

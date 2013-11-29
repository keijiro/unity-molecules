using UnityEngine;
using System.Collections;

public class WavyMove : MonoBehaviour
{
    public Vector3 range;
    public float speed;
    Vector3 initialPosition;
    Vector3 seed1;
    Vector3 seed2;
    Vector3 seed3;

    void Start ()
    {
        initialPosition = transform.position;
        seed1 = Random.onUnitSphere;
        seed2 = Random.onUnitSphere;
        seed3 = Random.onUnitSphere;
    }
    
    void Update ()
    {
        var dx = Perlin.Fbm (seed1 * Time.time * speed, 3) * range.x;
        var dy = Perlin.Fbm (seed2 * Time.time * speed, 3) * range.y;
        var dz = Perlin.Fbm (seed3 * Time.time * speed, 3) * range.z;
        transform.position = initialPosition + new Vector3 (dx, dy, dz);
    }
}

using UnityEngine;

public class Billiard : MonoBehaviour
{
    public Rigidbody redSphere;
    public float forceRange = 500f;
    public void StartGame()
    {
        redSphere.AddForce(-Vector3.forward * forceRange);
    }
}

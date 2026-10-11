using UnityEngine;

public class Boom : MonoBehaviour
{
    public float force = 1000f;
    public float timeForBoom = 5f;
    public Rigidbody[] rigidbodies;
    public ParticleSystem boomParticleSystem;
    private float currectTime;
    private void Update()
    {
        currectTime += Time.deltaTime;
        if (currectTime >= timeForBoom)
        {
            currectTime = 0f;
            Kaboom();
        }
    }
    private void Kaboom()
    {
        boomParticleSystem.Play();
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.AddExplosionForce(force, transform.position, 5f);
        }
    }
}

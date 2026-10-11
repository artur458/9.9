using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 from;
    public Vector3 to;
    private bool isLeft = true;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, isLeft ? from : to, Time.deltaTime * speed);

        if (transform.position == from)
        {
            isLeft = false;
        }
        else if (transform.position == to)
        {
            isLeft = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}

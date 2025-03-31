using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float speed = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

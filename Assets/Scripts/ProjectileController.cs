using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 direction;
    private Vector3 uniDirection;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        uniDirection = direction.normalized;

        gameObject.transform.Translate(uniDirection * speed * Time.deltaTime);

        if (gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostControl : MonoBehaviour
{
    private Vector3 goUp = Vector3.up;
    private Vector3 goDown = Vector3.down;
    private Vector3 go;

    private AudioSource ghostAS;

    public float moveSpeed;
    public float knockback;

    // Start is called before the first frame update
    void Start()
    {
        ghostAS = GetComponent<AudioSource>();

        go = goUp;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(go * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Top"))
        {
            go = goDown;
        }

        if (other.gameObject.CompareTag("Bottom"))
        {
            go = goUp;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * knockback, ForceMode.Impulse);

            ghostAS.Play();

        }
    }

}

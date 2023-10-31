using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinControl : MonoBehaviour
{
    public GameObject lid;
    public GameObject skeleton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lid.SetActive(false);
            StartCoroutine(SkeletonGuy());
        }

    }

    IEnumerator SkeletonGuy()
    {
        yield return new WaitForSeconds(2);
        skeleton.SetActive(true);
    }

}

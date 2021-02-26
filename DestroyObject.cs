using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField]
    private GameObject effectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shell"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            Destroy(effect, 2.0f);
        }
    }
}

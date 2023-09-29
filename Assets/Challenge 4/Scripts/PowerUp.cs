using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float time = 5f;
    void Start()
    {
        StartCoroutine(KillGameObject(time));
    }

    IEnumerator KillGameObject(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
}

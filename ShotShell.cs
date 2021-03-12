using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotShell : MonoBehaviour
{
    public float shotSpeed;

    [SerializeField]
    private GameObject shellPrefab = null;

    [SerializeField]
    private AudioClip shotSound = null;

    private float timeBetweenShot = 0.75f;
    private float timer;

    public int shotCount;

    [SerializeField]
    private Text shellLabel;

    public int shotMaxCount = 20;

    void Start()
    {
        shotCount = shotMaxCount;

        shellLabel.text = "砲弾：" + shotCount;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && timer > timeBetweenShot && shotCount > 0)
        {
            shotCount -= 1;

            shellLabel.text = "砲弾：" + shotCount;

            timer = 0.0f;

            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);

            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            shellRb.AddForce(transform.forward * shotSpeed);

            Destroy(shell, 3.0f);

            AudioSource.PlayClipAtPoint(shotSound, transform.position);
        }
    }

    public void AddShell(int amount)
    {
        shotCount += amount;

        if (shotCount > shotMaxCount)
        {
            shotCount = shotMaxCount;
        }

        shellLabel.text = "砲弾：" + shotCount;
    }
}

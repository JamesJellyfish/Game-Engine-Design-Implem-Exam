//https://www.youtube.com/watch?v=-on5HRW8v1A Galaga Tutorial
// James Pham 100741773 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform projectileSpawn;

    public GameObject projectile;

    public float nextFire = 1.0f;
    public float currentTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        projectileSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    public void shoot()
    {
        currentTime += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && currentTime > nextFire)
        {
            nextFire += currentTime;
            Instantiate(projectile, projectileSpawn.position, Quaternion.identity);

            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}

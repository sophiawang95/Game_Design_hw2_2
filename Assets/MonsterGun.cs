using UnityEngine;
using System.Collections;
using DG.Tweening;

public class MonsterGun : MonoBehaviour
{

    public float MinimumShootPeriod;
    public float muzzleShowPeriod;

    private float shootCounter = 0;
    private float muzzleCounter = 0;

    public GameObject muzzleFlash;
    public GameObject bulletCandidate;

    public void Start()
    {
        
    }

    public void TryToTriggerGun()
    {
        if (shootCounter <= 0)
        {

            this.transform.DOShakeRotation(MinimumShootPeriod * 0.8f, 3f);

            muzzleCounter = muzzleShowPeriod;
            muzzleFlash.transform.localEulerAngles = new Vector3(0, 0, Random.Range(0, 360));

            shootCounter = MinimumShootPeriod;
            //Debug.Log("should creat a monster bullet");
            GameObject newBullet = GameObject.Instantiate(bulletCandidate);
            MonsterBulletScript bullet = newBullet.GetComponent<MonsterBulletScript>();
            bullet.transform.position = muzzleFlash.transform.position;
            bullet.transform.rotation = muzzleFlash.transform.rotation;

            bullet.InitAndShoot(muzzleFlash.transform.forward);
        }
    }

    public void Update()
    {
        if (shootCounter > 0)
        {
            shootCounter -= Time.deltaTime;
        }

        if (muzzleCounter > 0)
        {
            muzzleFlash.gameObject.SetActive(true);
            muzzleCounter -= Time.deltaTime;
        }
        else
        {
            muzzleFlash.gameObject.SetActive(false);
        }
    }


}


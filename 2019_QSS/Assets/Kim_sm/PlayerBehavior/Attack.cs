using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public GameObject bullet;
    Vector3 attackVector = new Vector3(0f, 0f);
    public Transform BulletLocation;
    public float BulletDelay;
    private bool BulletState;
    // Start is called before the first frame update
    void Start()
    {
        BulletState = true;
    }

    // Update is called once per frame
    void Update()
    {
        attackVector = AttackPrepare.PullAttackVector();
        BulletLocation.eulerAngles = attackVector;
    }

    private void FixedUpdate()
    {
        
    }

    public void UserAttack(int WeaponType)
    {
        StartCoroutine(FireCycleControl());
        Instantiate(bullet, BulletLocation.position, BulletLocation.rotation);
    }

    IEnumerator FireCycleControl()
    {
        BulletState = false;
        yield return new WaitForSeconds(BulletDelay);
        BulletState = true;
    }
}

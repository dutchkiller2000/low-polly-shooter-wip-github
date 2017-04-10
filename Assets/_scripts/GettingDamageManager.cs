using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class GettingDamageManager : MonoBehaviour
{
    public bool debug;
    public float maxHealth;
    public bool hasArmor;
    public float currentHealth;
    [HeaderAttribute("enemy killed counter")]
    public Text text;
    void Start()
    {
        currentHealth = maxHealth;
        text = GameObject.Find("killCounter").GetComponent<Text>();
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            DeadCounter();
        }
    }
    void OnCollisionEnter(Collision coll)
    {
        BulletDamageManager bulletDamageManager = coll.gameObject.GetComponent<BulletDamageManager>();

        if (hasArmor)
        {
            bulletDamageManager.body = bulletDamageManager.body / 100 * 85;
        }
    }
    void DeadCounter()
    {
        PlayerPrefs.SetInt("zk", PlayerPrefs.GetInt("zk") + 1);
        text.text = PlayerPrefs.GetInt("zk").ToString();
        Destroy(this.gameObject);
    }
}

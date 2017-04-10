using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class deathManager : MonoBehaviour
{
    public Text killedZombies;
    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        killedZombies.text = PlayerPrefs.GetInt("zk").ToString();

    }
}

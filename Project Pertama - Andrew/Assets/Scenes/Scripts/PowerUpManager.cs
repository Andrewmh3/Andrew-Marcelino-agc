using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform SpawnArea;
    public int MaxPowerUpAmount;
    public int SpawnInterval;
    public int DeleteInterval;
    public Vector2 PowerUpAreaMin;
    public Vector2 PowerUpAreaMax;
    public List<GameObject> PowerUpTemplateList;

    private List<GameObject> PowerUpList;

    private float Timer;

    private void Start()
    {
        //membuat kumpulan jenis powerup
        PowerUpList = new List<GameObject>(); 
    }

    private void Update()
    {
        // timer add per second
        Timer += Time.deltaTime;

        // timer sudah mencapai waktu yang telah ditentukan
        if (Timer > SpawnInterval)
        {
            // maka spawn powerup
            GenerateRandomPowerUp();
            // reset waktu
            Timer -= SpawnInterval;
        }
    }

    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(PowerUpAreaMin.x, PowerUpAreaMax.x), Random.Range(PowerUpAreaMin.y , PowerUpAreaMax.y)));
        
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        if(PowerUpList.Count >= MaxPowerUpAmount)
        {
            return;
        }

        if (position.x < PowerUpAreaMin.x ||
            position.x > PowerUpAreaMax.x ||
            position.y < PowerUpAreaMin.y ||
            position.y > PowerUpAreaMax.y )
        {
            return; 
        }

        int randomIndex = Random.Range(0, PowerUpTemplateList.Count);


        GameObject powerUp = Instantiate(PowerUpTemplateList[randomIndex], new Vector3 (position.x, position.y, PowerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, SpawnArea);
        powerUp.SetActive(true);

        PowerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        PowerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (PowerUpList.Count > 0)
        {
            RemovePowerUp(PowerUpList[0]); 
        }
    }
}

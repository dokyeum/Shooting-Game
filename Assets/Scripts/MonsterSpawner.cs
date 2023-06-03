using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] Monster;

    private float[] arrayPosition = { -2.2f, -1.1f, 0f, 1.1f, 2.2f };

    [SerializeField]
    private float spawnInterval = 1.5f;

    void Start()
    {
        StartMonsterRoutine();
    }

    void StartMonsterRoutine()
    {
        StartCoroutine("MonsterRoutine");
    }

    public void StopMonsterRoutine()
    {
        StopCoroutine("MonsterRoutine");
    }

       
    IEnumerator MonsterRoutine() {
        yield return new WaitForSeconds(3f);

        while (true)
        {
            foreach (float posX in arrayPosition)
            {
                int index = Random.Range(0, Monster.Length);
                SpawnMonster(posX, index);
            }

            yield return new WaitForSeconds(spawnInterval); 
        }
        }

        void SpawnMonster(float posX, int index)
        {
            Vector3 spawnPosition = new Vector3(posX, transform.position.y, transform.position.z);
            Instantiate(Monster[index], spawnPosition, Quaternion.identity);
        }

    
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawn : MonoBehaviour
{
    public GameObject[] DucksPrefab; //Array para los Prefab del Duck
    private Transform[] SpawnsPoints; //Array para los puntos del Spawn
    public float TimeToSpawn; //Tiempo de Spawn
    public float MaxNumerOfDucks; //Numero Maximo de Patos en Pantalla simultaneos
    public float CurrentNumberOfDucks; //Numero Actual de Patos
    public float TimeToDestroyObject; //Tiempo de vida del prefab en pantalla
    public float CurrentLiveTimeObject; //Tiempo de vida del prefab en pantalla

    private void Start()
    {
        SpawnsPoints = GetComponentsInChildren<Transform>(); //Metemos los puntos de Spawn en el array
        StartCoroutine(DuckSpwanCorru()); //Llamamos a la corrutina DuckSpawn
    }

    public IEnumerator DuckSpwanCorru() //Corrutina para Spawnear de forma Random al Duck en posiciones de Spawn
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeToSpawn); //Esperamos el tiempo de Spwan

            if (!TooManyDucks())// Si no hay suficientes patos (False)
            {
                GameObject WantDuckPrefab = DucksPrefab[Random.Range(0, DucksPrefab.Length)]; //Selecionamos un prefab Random del Duck
                Transform WantSpawnPoint = SpawnsPoints[Random.Range(1, SpawnsPoints.Length)]; //Selecionamos una posicion Random de Spawn
                Vector3 SpawnPosition = new Vector3(WantSpawnPoint.transform.position.x, WantSpawnPoint.transform.position.y); //Guardamos la posicion del Spwan
                GameObject RandomDuck = Instantiate(WantDuckPrefab, SpawnPosition, Quaternion.identity); //Instanciamos el prefab del duck en el punto de Spawn
                yield return null;
                CurrentNumberOfDucks++;//Incrementamos el contador de Ducks
                Destroy(RandomDuck, TimeToDestroyObject);
                //DuckDespawn(TimeToDestroyObject, RandomDuck, CurrentNumberOfDucks);//Llamamos al metedo para decrementar y destruir los Ducks
            }
            else if (TooManyDucks() && CurrentLiveTimeObject == TimeToDestroyObject)
            {
                CurrentNumberOfDucks--;
            }
        }
    }

    //public void DuckDespawn(float TimeDestroy, GameObject DuckPref, float CurrentNumberOfDucks) //Metedo para decrementar y destruir los Ducks
    //{
    //    Destroy(DuckPref, TimeDestroy);
    //    CurrentNumberOfDucks--; //Decrementamos el contador de Ducks
    //}

    public bool TooManyDucks() //Comprobacion cantidad de Ducks
    {
        if (CurrentNumberOfDucks >= MaxNumerOfDucks) // Si el numero Actual de patos es mayor o igual al Maximo numero de patos
        {
            return true; //Hay suficientes patos (True)
        }
        else
        {
            return false; //No hay suficientes patos (False)
        }
    }
}
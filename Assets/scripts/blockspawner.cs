using UnityEngine;

public class blockspawner : MonoBehaviour
{
    public GameObject blockprefab;
    public GameObject startplace;

    void Start()
    {
        Vector3 blockplace = startplace.transform.position;
        float placex = blockplace.x;
        float placey = blockplace.y;

        for (int rivi = 0; rivi < 3; rivi++)
        {
            for (int i = 0; i < 12; i++)
            {
                Instantiate(blockprefab, new Vector3(placex,placey, 0), Quaternion.identity);

                placex += 2f;
            }
            placex = blockplace.x;
            placey -= 1f;
        }
    }
}

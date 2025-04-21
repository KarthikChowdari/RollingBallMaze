using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    public GameObject wallPrefab;
    public GameObject floorPrefab;
    public GameObject ballPrefab;
    public GameObject goalPrefab;

    string[] maze = new string[]
    {
        "################",
        "#S    #   #   #",
        "# ### ### ### #",
        "# #   # # # # #",
        "# # ### # # # #",
        "# #       #   #",
        "# ########### #",
        "#   #     #   #",
        "### # ### ### #",
        "#   #   #     #",
        "# ### ##### ###",
        "#     #   #   #",
        "####### # ### #",
        "#     # #     #",
        "# ### ### ###E#",
        "################",
    };

    void Start()
    {
        for (int z = 0; z < maze.Length; z++)
        {
            string row = maze[z];
            for (int x = 0; x < row.Length; x++)
            {
                char c = row[x];
                Vector3 pos = new Vector3(x, 0, z);
                
                // Place ground tile
                Instantiate(floorPrefab, pos, Quaternion.identity, transform);
                
                if (c == '#')
                    Instantiate(wallPrefab, pos + new Vector3(0, 0.5f, 0), Quaternion.identity, transform);
                else if (c == 'S')
                    Instantiate(ballPrefab, pos + new Vector3(0, 0.5f, 0), Quaternion.identity);
                else if (c == 'E')
                    Instantiate(goalPrefab, pos + new Vector3(0, 0.5f, 0), Quaternion.identity);
            }
        }
    }
}

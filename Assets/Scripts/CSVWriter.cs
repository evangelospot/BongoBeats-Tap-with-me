using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class CSVWriter : MonoBehaviour
{
    string filename = "";

    int temp = 0;

   // [System.Serializable]

    //public class Player
    //{
    //    public string name;
    //    public int health;
    //    public int damage;
    //    public int defence;
    //}
   // [System.Serializable]

    //public class PlayerList
    //{
   //     public Player[] player;
    //}

    //public PlayerList myPlayerList = new PlayerList();

    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/test.csv";
    }

    // Update is called once per frame
    void Update()
    {
        //if (SceneManager.GetActiveScene().name == "EmptyScene")
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("YES");
            WriteCSV();
        }
    }

    public void WriteCSV()
    {
        //if (myPlayerList.player.Length > 0)
        //{

        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            writer.WriteLine(variables.leftTries + "," + variables.rightTries);

        }
        //TextWriter tw = new StreamWriter(filename, true);
        //tw.WriteLine("Name, Health, Damage, Defence");

        //tw.Close();


        // for(int i = 0; i < myPlayerList.player.Length; i++) 
        // {
        //    tw.WriteLine(myPlayerList, player[i].name + "," + myPlayerList, player[i].health + "," +
        //                   myPlayerList, player[i].damage + "," + myPlayerList, player[i].defence);

        //}
        // tw.Close();

        //}

    }
}

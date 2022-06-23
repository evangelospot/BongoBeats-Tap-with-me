using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class CSVWriter : MonoBehaviour
{
    string filename = "";

    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/test.csv";

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnApplicationQuit()
    {
        WriteCSVHeadlines();
        WriteCSVVariables();
    }

    public void WriteCSVHeadlines()
    {
        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            writer.WriteLine("Left Tries" + "," + "Right Tries");
            writer.Close();
        }
    }

    public void WriteCSVVariables()
    {
        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            writer.WriteLine(variables.leftTries + "," + variables.rightTries);
            writer.Close();
        }
    }
}

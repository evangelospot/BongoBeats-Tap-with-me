using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVWriter : MonoBehaviour
{
    string filename = "";

    private float timeDuration;
    private float secs;
    private float mins;
    string timeDurationFormated;

    // Start is called before the first frame update
    void Start()
    {

        //Display format 00:00


        filename = Application.dataPath + "/test.csv";

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnApplicationQuit()
    {
        timeDuration = Time.time;
        secs = Mathf.Round(timeDuration % 60);
        mins = Mathf.Floor(timeDuration / 60);
        timeDurationFormated = mins + ":" + secs;

        WriteCSVHeadlines();
        WriteCSVVariables();
    }

    public void WriteCSVHeadlines()
    {
        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            writer.WriteLine("Time Duration" + "," + "Left Tries" + "," + "Right Tries" + "," + "Total Tries" + "," + 
                                "Left Hits" + "," + "Right Hits" + "," + "Total Hits" + "," + "Total Score");
            writer.Close();
        }
    }

    public void WriteCSVVariables()
    {
        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            writer.WriteLine(timeDurationFormated + "," + variables.leftTries + "," + variables.rightTries + "," + variables.totalTries + "," +
                                variables.hitLeftNotes + "," + variables.hitRightNotes + "," + variables.hitTotalNotes + "," + variables.totalScore);
            writer.Close();
        }
    }
}

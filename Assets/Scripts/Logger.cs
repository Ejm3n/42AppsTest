
using System.IO;
using UnityEngine;

public class Logger : MonoBehaviour
{
    private string _workDirectory;
    private FileWriter _fileWriter;
    private void Awake()
    {
        _workDirectory = $"{Application.persistentDataPath}/Logs";
        if(!Directory.Exists(_workDirectory))
        {
            Directory.CreateDirectory(_workDirectory);
        }
        _fileWriter = new FileWriter(_workDirectory);
        Application.logMessageReceived += OnLogMessageRecived;
    }

    private void OnLogMessageRecived(string condition, string stackTrace, LogType type)
    {
        _fileWriter.Write(new LogMessage(type,condition));
    }

    private void Update()
    {
#if UNITY_EDITOR
        if(Input.GetKeyUp(KeyCode.L))
        {
            UnityEditor.EditorUtility.RevealInFinder(_workDirectory);
        }
    }
#endif
}

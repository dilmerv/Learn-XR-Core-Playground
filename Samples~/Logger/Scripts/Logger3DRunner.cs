using System.Collections;
using LearnXR.Core.Utilities;
using UnityEngine;

public class Logger3DRunner : MonoBehaviour
{   
    void Start()
    {
        SpatialLogger.Instance.LogInfo($"{nameof(Logger3DRunner)} started");
        StartCoroutine(LogLine());
    }
    
    private IEnumerator LogLine()
    {
        while (true)
        {
            var randomNumber = Random.Range(0, 3);
            if(randomNumber == 0)
                SpatialLogger.Instance.LogInfo($"{nameof(Logger3DRunner)} just logging information");
            else if(randomNumber == 1)
                SpatialLogger.Instance.LogWarning($"{nameof(Logger3DRunner)} just logging warning");
            else if(randomNumber == 2)
                SpatialLogger.Instance.LogError($"{nameof(Logger3DRunner)} just logging an error");
        
            yield return new WaitForSeconds(1.0f);
        }
    }
}

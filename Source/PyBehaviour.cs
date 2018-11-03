using UnityEngine;
using Microsoft.Scripting.Hosting;

public class PyBehaviour : MonoBehaviour
{
    [SerializeField]
    protected PythonScript script;
    private ScriptScope scope;
    private ScriptSource source;

    private void Awake()
    {
        if (script == null)
        {
            Debug.LogError("There is no script on this object: " + gameObject.name);
            return;
        }
        if (scope == null)
        {
            ScriptEngine scriptEngine = PythonUtils.GetEngine();
            scope = scriptEngine.CreateScope();
            scope.SetVariable("owner", this);
            scope.SetVariable("gameObject", gameObject);
            scope.SetVariable("transform", transform);

            source = scriptEngine.CreateScriptSourceFromString(script.text);
            source.Compile();
            source.Execute(scope);
            CallMethod("Awake");
        }
    }
    private void Start()
    {
        CallMethod("Start");
    }
    private void OnEnable()
    {
        CallMethod("OnEnable");
    }
    private void OnDisable()
    {
        CallMethod("OnDisable");
    }
    private void Update()
    {
        CallMethod("Update");
    }

    void CallMethod(string methodName)
    {
        if (scope.ContainsVariable(methodName))
            scope.GetVariable<System.Action>(methodName).Invoke();
    }
}
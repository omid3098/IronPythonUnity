# IronPythonUnity

## Sample Usage:
- Create a game object
- Add PyBehaviour
- Drag your python file into script field

![image](https://user-images.githubusercontent.com/6388730/47956680-8ea82f80-dfbd-11e8-89f1-da39c9015430.png)


- Play the game

## Sample Python code:
Hello word from Awake and Update functions in python:

``` python
import UnityEngine as unity
count = 1

def Awake():
    unity.Debug.Log("Hello from python Awake " +
                    gameObject.name + str(count))


def Update():
    global count
    count += 1
    unity.Debug.Log("Hello from python Update" + str(count))

```

Simple object rotator:
``` python
import UnityEngine as unity


def Update():
    transform.Rotate(1, 1, 1)

```

## Platforms:
- PC: supprted
- Mobile: not-supported

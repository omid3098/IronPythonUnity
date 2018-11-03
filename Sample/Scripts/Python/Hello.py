import UnityEngine as unity
count = 1

def Awake():
    unity.Debug.Log("Hello from python Awake " +
                    gameObject.name + str(count))


def Update():
    global count
    count += 1
    unity.Debug.Log("Hello from python Update" + str(count))

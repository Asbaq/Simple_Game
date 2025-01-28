# 📝 Simple_Game Documentation 🎮

## 📌 Game Overview  
![Simple_Game](https://github.com/Asbaq/Simple_Game/assets/62818241/306d7d2c-5190-479e-91c1-609b4df37c6d)

**Simple_Game** is a Unity-based **first-person character controller** that includes basic movement, camera control, and a scoring system. The game involves collecting objects of different shapes to gain points, with an immersive camera-following system to enhance player experience.

---

## 💪 Key Features

✅ **First-Person Camera Look** with smooth mouse movement.  
✅ **Character Movement** using Unity's Character Controller.  
✅ **Follow Camera System** to track player movement dynamically.  
✅ **Scoring System** that updates points based on collected objects.  
✅ **Sound Effects** for interactive feedback upon object collection.  

---

## 🎮 Game Mechanics

### 👀 Camera Control (CameraLook.cs)
- Implements **mouse-controlled camera movement**.
- Controls the **rotation of the player body** based on mouse input.
- Uses **mouse sensitivity** for smooth control.

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
```

### 📱 Camera Follow System (FollowPlayer.cs)
- Camera smoothly follows the player's position.
- Uses an **offset** to maintain a fixed distance from the player.

```csharp
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    Vector3 offset; 
    
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
```

### 🏃 Player Movement (PlayerMovement.cs)
- Uses **Unity's CharacterController** for movement.
- Allows movement using **WASD or arrow keys**.
- Moves the player in the **forward and sideways** directions.

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f;
    public float mouseSensitivity = 10f;
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}
```

### 🏆 Scoring System (Score.cs)
- Updates score based on the **type of collected object**.
- Plays **sound effects** when an object is collected.
- Displays the **updated score on UI**.

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int points = 0;
    [SerializeField] private Text PointText;
    [SerializeField] private AudioSource SoundEffect;

    void OnCollisionEnter(Collision collision)
    {     
            if(collision.gameObject.tag == "Sphere")
            {   
                Destroy(collision.gameObject);
                SoundEffect.Play();
                points+=10;
                PointText.text = "Points: " + points;
            }
            else if(collision.gameObject.tag == "Cylinder")
            {
                Destroy(collision.gameObject);
                SoundEffect.Play();
                points+=20;
                PointText.text = "Points: " + points;
            }
            else if(collision.gameObject.tag == "Cube")
            {
                Destroy(collision.gameObject);
                SoundEffect.Play();
                points+=30;
                PointText.text = "Points: " + points;
            }
            else if(collision.gameObject.tag == "Prism")
            {
                Destroy(collision.gameObject);
                SoundEffect.Play();
                points+=40;
                PointText.text = "Points: " + points;
            }
    }
}
```

---

## 🎤 Implementation Steps

1. **Create a Unity Project** and import the necessary assets.
2. **Set up the player object** and attach the `CharacterController` component.
3. **Attach CameraLook.cs** to the camera for mouse movement.
4. **Attach FollowPlayer.cs** to the camera and assign the player transform.
5. **Attach PlayerMovement.cs** to the player for movement.
6. **Attach Score.cs** to a UI text element and ensure `Text` and `AudioSource` are assigned.
7. **Tag objects** (`Sphere`, `Cylinder`, `Cube`, `Prism`) for scoring.
8. **Run the game** and collect objects to update points.

---

## 💪 Features & Future Improvements

✅ **Basic First-Person Controls**  
✅ **Object Collection System with Score Updates**  
✅ **Sound Effects for Interaction**  
✅ **Smooth Camera Movement**  

🔜 **Jumping & Sprinting Mechanics**  
🔜 **UI Enhancements & Visual Effects**  
🔜 **Multiplayer Mode Support**  

---

## 📌 Conclusion
**Simple_Game** is a foundational **first-person movement and interaction system** built in Unity. With **camera control, player movement, scoring, and sound effects**, it serves as a great starting point for more complex game projects. Future updates may include **jumping, sprinting, enhanced UI, and multiplayer support**. 🚀

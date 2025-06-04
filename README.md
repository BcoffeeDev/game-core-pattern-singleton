# 🧩 game-core-pattern-singleton

A minimal and reusable set of MonoBehaviour singleton base classes for Unity.  
Just inherit and use `T.Instance` — no boilerplate, no hassle.

---

## ✅ Included Classes

| Class | Auto-create if missing | Persistent (DDOL) | Notes |
|-------|------------------------|-------------------|-------|
| `Singleton<T>` | ✅ Yes | ❌ No | Auto-instantiated when accessed |
| `PersistentSingleton<T>` | ✅ Yes | ✅ Yes | Auto-instantiated + marked as `DontDestroyOnLoad` |
| `SingletonBehaviour<T>` | ❌ No | ❌ No | Must be in the scene manually |
| `PersistentSingletonBehaviour<T>` | ❌ No | ✅ Yes | Must be in the scene manually, persistent after `Awake()` |

---

## 🧪 Example

```csharp
// GameManager.cs
public class GameManager : Singleton<GameManager>
{
    public void Initialize()
    {
        Debug.Log("GameManager ready!");
    }
}
```

```csharp
// Anywhere else
GameManager.Instance.Initialize();
```

- If using `Singleton<T>` or `PersistentSingleton<T>`, the GameObject is created automatically.
- If using `SingletonBehaviour<T>` or `PersistentSingletonBehaviour<T>`, ensure the script is placed in the scene.

---

## 📦 Installation

Add this package to Unity via Git URL:

1. Open **Unity**, then select **Package Manager**
2. Click the **+** button and select **Add package from Git URL**
3. Enter :
   ```
   https://github.com/BcoffeeDev/game-core-pattern-singleton.git
   ```

Or edit `manifest.json`:

```json
"dependencies": {
  "com.bcoffee-dev.patterns.singleton": "https://github.com/BcoffeeDev/game-core-pattern-singleton.git"
}
```

---

## 🙋‍♂️ Contributing

Found a bug or have a feature suggestion?  
Feel free to [open an issue](https://github.com/BcoffeeDev/game-core-pattern-singleton/issues) or submit a pull request!  
All contributions are welcome and appreciated.

## 📄 License

MIT © 2025 [BcoffeeDev](https://github.com/BcoffeeDev)
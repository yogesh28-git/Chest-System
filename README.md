# **Chest System**

## Game
[CLICK HERE TO PLAY](https://y0-0go.itch.io/chest-system-clash-royale-type)

## Technical Description
- Model-View-Controller-Service(MVC-S) pattern:
    - Chest has Model, View and Controller.
    - A Service class used to create the chest.
- Singletons: 
    - Services like Chest Service, UI Service etc are created as Singletons.
- Scriptable Objects: Chest Types
    - COMMON, RARE, EPIC, LEGENDARY
    - randomized reward coins and gems according to each chest type
    - chest unlocking time
- State Pattern:
    - LOCKED state : 
        - Will have option to Unlock now using gems
        - Start Unlocking timer
    - UNLOCKING state :
        - Will have option to unlock now using gems
        - A countdown runs till chest is unlocked.
    - UNLOCKED state:
        - A prompt to open the chest.
        - a pop shows your rewards and after closing popup, the chest disappears.
- Object Pooling:
    - Only as many chest views will be in the scene and pool as there are chest slots.


## Screenshots
![image](https://github.com/yogesh28-git/Chest-System/assets/85812175/b0809c60-6fef-42dd-97f5-570e4492e3d7)
![image](https://github.com/yogesh28-git/Chest-System/assets/85812175/96940fa7-13f3-42dc-926e-7d8f5ad25941)
![image](https://github.com/yogesh28-git/Chest-System/assets/85812175/edb0423d-df14-4533-9955-8189e5b1da9e)
![image](https://github.com/yogesh28-git/Chest-System/assets/85812175/06c873d6-85ec-46d5-83fc-297fe43dad62)

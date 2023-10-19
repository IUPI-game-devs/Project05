# Project05

By: Luis Velázquez Sosa, Edward Garcia y Bryan Guevara

# Course Project Readme

Welcome to the course project! Here's a guide to get you started with various tasks.

## 1. Collaborative Music Playlist

Let's hang out and listen to your music recommendations. Each teammate must add at least one song to the Spotify playlist created for the course.

[Course Spotify Playlist](https://open.spotify.com/playlist/3N0sFN2cBW58FhKO69eVcv?si=d34d42dd841d41fc&pt=ddfbdaf97bed56a63544e786afe7345f)

## 2. Action Matrix for Robot Character

Taking the class project, write an action matrix as an input guide for the robot character.

| Action                | Mappings                                       |
|-----------------------|-----------------------------------------------|
| Horizontal movement   | A and D keys, Left and Right arrows, gamepad left stick |
| Vertical movement     | Gamepad left stick                            |
| Shoot                 | Mouse click, gamepad button                   |
| Jump                  | Spacebar, gamepad button                       |
| Look                  | Mouse movement                                |
| Fast horizontal movement | Shift key, gamepad trigger                   |
| Fast vertical movement   | Shift key, gamepad trigger                   |


## 3. C# Scripts

### Horizontal Movement and Vertical Movement
![OnMove.png](Images%2FOnMove.png)
In the code above we're using the input system for Unity and it's grabbing the vector parameters. Since we are only working with the X and Y coordinates We only need the vector2.

This function is part of the Unity Input System and is used for handling player movement input. It stores the movement input values, scaled by the speed variable.

### Shoot

![OnFire.png](Images%2FOnFire.png)

This function is called when the player initiates a fire action, typically by pressing a fire button. It instantiates a prefab (a game object) at the shootPoint position and rotation.


### Jump

![OnJump.png](Images%2FOnJump.png)

This function is used to handle jumping input. It checks if the player is grounded (isGrounded) or has remaining jumps (jumpsLeft). If so, it resets the vertical velocity, adds an upward force to jump, and reduces the available jumps if double jumping.


### Look

![OnLook.png](Images%2FOnLook.png)

This function handles player look or rotation input. It stores the horizontal look input values, scaled by the speedRotation variable.


### Dash

![OnDash.png](Images%2FOnDash.png)

This function handles dashing input, where the movementValue is multiplied by dashMulti to apply a dash effect.

### Jump

![OnJump.png](Images%2FOnJump.png)

This function is used to handle jumping input. It checks if the player is grounded (isGrounded) or has remaining jumps (jumpsLeft). If so, it resets the vertical velocity, adds an upward force to jump, and reduces the available jumps if double jumping.

onExit(Collision collision): This function is called when the game object stops colliding with an object. If the collision was with an object tagged as "Ground," it sets the isGrounded flag to false, indicating that the character is in the air.

## 4. Visual Scripting

![Screenshot 2023-10-18 at 10.30.01 PM.png](Images%2FScreenshot%202023-10-18%20at%2010.30.01%E2%80%AFPM.png)

These visual scripting tasks collectively allow the player character to move, look, shoot, dash, jump, and interact with the environment, all while detecting whether the character is grounded or in the air. This functionality is essential for creating an interactive and dynamic gameplay experience.

## 5. Visuals
### Visual Scripting
Here we can see a visualization of the visual script with the player moving around, shooting, jumping and dashing. Every parameter from the players movement speed from the dash speed from the jumping height, all are configurable.

![ezgif.com-video-to-gif copy.gif](Images%2Fezgif.com-video-to-gif%20copy.gif)

### Movement
Here we can see the movement using the WASD Keys.

![ezgif.com-video-to-gif (2).gif](Images%2Fezgif.com-video-to-gif%20%282%29.gif)

### Rotation

In this visualization we can see the rotation.

![ezgif.com-video-to-gif (4).gif](Images%2Fezgif.com-video-to-gif%20%284%29.gif)



### Dash

And this visualization we can see the dash feature using the shift key.

![ezgif.com-video-to-gif.gif](Images%2Fezgif.com-video-to-gif.gif)


### Shoot

Here we can see the shoot functionality. This is using the mouse click.

![ezgif.com-video-to-gif (3).gif](Images%2Fezgif.com-video-to-gif%20%283%29.gif)



### Jump

Here we are using the jump functionality. He uses spacebar. We see the single jump, and the double jump here.

![ezgif.com-video-to-gif (1).gif](Images%2Fezgif.com-video-to-gif%20%281%29.gif)


## 6. Sources Used

https://www.youtube.com/watch?v=0MBT9925krY&t=269s

https://www.youtube.com/watch?v=-NbBsbcZkD8
Description:

This repository provides a basic but functional third-person character controller and a script for following the camera in Unity. These snippets are intended for novice game developers and serve as a starting point for creating more complex motion and camera systems. 

Repository Content:

CameraFollow.cs: A script for following the camera behind the player with smooth movement and a fixed position relative to the target (always looking at the player).
PlayerController.cs: A basic third-person character controller that supports forward/backward movement, left/right, and jumping.

Simplicity and clarity: The code is written as simply and clearly as possible, with detailed comments.
Easy Integration: Easily integrates into any Unity 3D project.
Configurable parameters: Easily configurable parameters in the inspector for changing movement speed, jump height and other parameters.
User-friendly controls: The character is controlled using the standard WASD (or arrow) keys and the Space key for jumping.(it can be customized in any way, since the axes are used, not the keycode)
Convenient Camera: The camera smoothly follows the character, providing a basic third-person view.

Detailed description of the scripts:

CameraFollow.cs:
Smooth camera tracking of the target (player).
Adjustable camera offset relative to the target.
Automatic goal tracking (if the goal exists).
Simple and effective code.
The mouse rotation functionality is not enabled, the camera is fixed and always looks at the player.

PlayerController.cs:
Move the character forward/backward and left/right.
Jumping.
Checking the location on the ground.
Realistic physics using Rigidbody.
Configurable parameters for speed, jump force, and gravity.
Processing keyboard input.

How to use:

Add the Rigidbody component to the player object.
Add a Collider component (for example, Capsule Collider) to the player object.
Download the CameraFollow.cs and PlayerController.cs scripts from the repository.
Attach the PlayerController.cs script to the player object.
Attach the CameraFollow.cs script to the camera object.
In the Inspector:
For the player object:
Configure the moveSpeed, jumpForce, gravityScale, and groundCheckDistance parameters in the PlayerController component.
Create a new layer named “Ground” and assign it to all objects representing the earth (for example, planes).
Select the “Ground” layer in the groundLayer field of the PlayerController component.
For the camera object:
Drag the player's object to the target field in the CameraFollow component.
Adjust the smoothSpeed and offset in the CameraFollow component to get the desired camera view.
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InControl
{
    public class FPSProfile : UnityInputDeviceProfile
    {
        public FPSProfile()
        {
            Name = "FPS Keyboard/Mouse";
            Meta = "A keyboard and mouse combination profile appropriate for FPS.";

            SupportedPlatforms = new[]
            {
                "Windows",
                "Mac",
                "Linux"
            };

            Sensitivity = 1.0f;
            LowerDeadZone = 0.0f;

            ButtonMappings = new[]
            {
                new InputControlMapping
                {
                    Handle = "Fire",
                    Target = InputControlType.Action1,
                    Source = MouseButton0
                },
                new InputControlMapping
                {
                    Handle = "AltFire",
                    Target = InputControlType.Action2,
                    Source = MouseButton2
                },
                new InputControlMapping
                {
                    Handle = "Middle",
                    Target = InputControlType.Action3,
                    Source = MouseButton1
                },
                new InputControlMapping
                {
                    Handle = "Jump",
                    Target = InputControlType.Action4,
                    Source = KeyCodeButton( KeyCode.Space )
                },
                new InputControlMapping
                {
                    Handle = "LeftBumper",
                    Target = InputControlType.LeftBumper,
                    Source = KeyCodeButton(KeyCode.Space)
                },
                new InputControlMapping
                {
                    Handle = "RightBumper",
                    Target = InputControlType.RightBumper,
                    Source = MouseButton0
                },
                new InputControlMapping
                {
                    Handle = "RightTrigger",
                    Target = InputControlType.RightTrigger,
                    Source = MouseButton1
                },
                new InputControlMapping 
                {
                    Handle = "LeftTrigger",
                    Target = InputControlType.LeftTrigger,
                    Source = KeyCodeButton(KeyCode.LeftControl)
                }
            };
            
            AnalogMappings = new[]
            {
                new InputControlMapping
                {
                    Handle = "Move X",
                    Target = InputControlType.LeftStickX,
                    Source = KeyCodeAxis( KeyCode.A, KeyCode.D )
                },
                new InputControlMapping
                {
                    Handle = "Move Y",
                    Target = InputControlType.LeftStickY,
                    Source = KeyCodeAxis( KeyCode.S, KeyCode.W )
                },
                new InputControlMapping
                {
                    Handle = "Look X",
                    Target = InputControlType.RightStickX,
                    Source = MouseXAxis,
                    Raw    = true
                },
                new InputControlMapping
                {
                    Handle = "Look Y",
                    Target = InputControlType.RightStickY,
                    Source = MouseYAxis,
                    Raw    = true
                },
                new InputControlMapping
                {
                    Handle = "Look Z",
                    Target = InputControlType.ScrollWheel,
                    Source = MouseScrollWheel,
                    Raw    = true
                }
            };
        }
    }
}


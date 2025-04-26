# Handy Editor Extensions
![Unity](https://img.shields.io/badge/unity-6000.0%2B-blue.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

A collection of custom attributes and editor drawers that supercharge the Unity Inspector—add buttons, conditional visibility, readonly fields, value limits, dropdowns, color-coded thresholds, serializable dictionaries, and more, with zero boilerplate.

## Manual
Copy the Assets/HandyEditorExtensions folder into your project.

## ✨ Features
### Buttons
* `[Button(string label = null)]`

_Draws an Inspector button that invokes parameterless methods._

![image](https://github.com/user-attachments/assets/898a5c6f-3048-4e47-88a7-7a6cb61f6952)

![image](https://github.com/user-attachments/assets/70a31feb-38e0-40eb-b838-381a846774fa)


### Conditional Visibility
* `[ShowIf(bool|string condition)]`
* `[HideIf(bool|string condition)]`

_Show or hide fields, properties, or methods based on a condition or another field’s value._

![image](https://github.com/user-attachments/assets/6345fda8-0af0-43ab-a110-888108f1516a)


### Read-Only
* `[ReadOnly]`

_Marks a field as read-only in the Inspector._

![image](https://github.com/user-attachments/assets/4862c4be-672f-487e-b27e-1acd1ace9aa1)


### Limits
* `[Max(float max | string maxField)]`

_Enforces an upper value limit (constant or driven by another field)._

![image](https://github.com/user-attachments/assets/275fd580-9aa7-439c-8240-7635ac91d2ca)


### Dropdowns & Enums
* `[Dropdown(Type enumType)]`

_Renders a strongly-typed enum dropdown._

![image](https://github.com/user-attachments/assets/0b3bb71e-f202-47f7-a255-7c90a174c45b)

![image](https://github.com/user-attachments/assets/5a3b2dec-217c-4884-be78-dcf8196390e7)


### Color-Coded Thresholds
* `[MultiThresholdColor(float[] thresholds, string[] colorHexes, ThresholdColorMode mode)]`

_Change label or background color based on value thresholds (supports unlimited breakpoints)._

![image](https://github.com/user-attachments/assets/3186e3cf-4d01-43ed-b60c-a4b8d204cb5e)

![image](https://github.com/user-attachments/assets/d5577e9b-c428-4956-8f32-180f73f44336)



## 🧪 Demos
### See the Demo folder for working examples:
* Assets/handy-editor-extensions/Examples/Scripts
* Assets/handy-editor-extensions/Examples/Scenes/Demo.unity

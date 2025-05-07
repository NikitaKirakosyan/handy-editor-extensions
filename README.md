# Handy Editor Extensions
![Unity](https://img.shields.io/badge/unity-6000.0%2B-blue.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

A collection of custom attributes and editor drawers that supercharge the Unity Inspector—add buttons, conditional visibility, readonly fields, value limits, dropdowns, color-coded thresholds.

## Installation options
1) Copy the Assets/debug-pro folder into your project.
2) Download and import `.unitypackage` from [release](https://github.com/NikitaKirakosyan/handy-editor-extensions/releases/latest) into your project.

## ✨ Features
### Buttons
* `[Button(string)]`

_Draws an Inspector button that invokes parameterless methods._

![image](https://github.com/user-attachments/assets/898a5c6f-3048-4e47-88a7-7a6cb61f6952)

![image](https://github.com/user-attachments/assets/70a31feb-38e0-40eb-b838-381a846774fa)


### Conditional Visibility
* `[ShowIf(bool|string)]`
* `[HideIf(bool|string)]`

_Show or hide fields, properties, or methods based on a condition or another field’s value._

![gif](https://github.com/user-attachments/assets/5ec09ace-08eb-4bfd-93bd-635d44bfb232)

![image](https://github.com/user-attachments/assets/6345fda8-0af0-43ab-a110-888108f1516a)


### Read-Only
* `[ReadOnly]`

_Marks a field as read-only in the Inspector._

![image](https://github.com/user-attachments/assets/d805ae41-103a-4901-aacf-37509f8ac7cb)

![image](https://github.com/user-attachments/assets/4862c4be-672f-487e-b27e-1acd1ace9aa1)


### Limits
* `[Max(float|string)]`

_Enforces an upper value limit (constant or driven by another field)._

![gif](https://github.com/user-attachments/assets/acd455cb-763d-45b3-baed-7c2737daa59f)

![image](https://github.com/user-attachments/assets/275fd580-9aa7-439c-8240-7635ac91d2ca)


### Dropdowns & Enums
* `[Dropdown(Type)]`

_Renders a strongly-typed enum dropdown._

![image](https://github.com/user-attachments/assets/0b3bb71e-f202-47f7-a255-7c90a174c45b)

![image](https://github.com/user-attachments/assets/5a3b2dec-217c-4884-be78-dcf8196390e7)


### Color-Coded Thresholds
* `[MultiThresholdColor(float[], string[], ThresholdColorMode)]`

_Change label or background color based on value thresholds (supports unlimited breakpoints)._

![image](https://github.com/user-attachments/assets/3186e3cf-4d01-43ed-b60c-a4b8d204cb5e)

![image](https://github.com/user-attachments/assets/d5577e9b-c428-4956-8f32-180f73f44336)

### Progress Bar
* `[ProgressBar(string, string)]`

_Shows a progress bar below the field, taking the current and maximum values ​​from the component fields._

![gif](https://github.com/user-attachments/assets/2c49347d-e6e6-4e93-8b85-17ff5a073d29)

![image](https://github.com/user-attachments/assets/defe15ab-47b5-436b-bc20-b20d872e6fe5)

### Info Box
* `[InfoBox(string, MessageType)]`

_Inserts help/info above the field._

![image](https://github.com/user-attachments/assets/065b1185-d42e-4357-9cfa-e650e56741e5)

![image](https://github.com/user-attachments/assets/f7a0f326-1d05-480a-b2a3-af2a3dd0b84d)

### TagDropdown & LayerDropdown
* `[TagDropdown]`
* `[LayerDropdown]`

_Drop-down lists with project tags and layers._

![gif](https://github.com/user-attachments/assets/cbbab1fc-51a2-4669-b674-be4ad6772627)

![gif](https://github.com/user-attachments/assets/28dd7077-ba13-4af4-bd3b-2c85e1d3528c)

![image](https://github.com/user-attachments/assets/a3b68b4c-7157-44b8-b93e-3216621ae879)

![image](https://github.com/user-attachments/assets/5297aae9-a02b-4969-8080-f56de763cc46)

### SceneReference
* `[SceneReference]`

_Stores the path to the scene in the string field, but draws the SceneAsset object field._

![image](https://github.com/user-attachments/assets/15329a9c-9d1b-49f2-9840-24a850e4c463)

![image](https://github.com/user-attachments/assets/9c80ce47-acb9-44f7-a59d-dc59a9c9ef36)

## 🧪 Demos
### See the Demo folder for working examples:
* Assets/handy-editor-extensions/Examples/Scripts
* Assets/handy-editor-extensions/Examples/Scenes/Demo.unity

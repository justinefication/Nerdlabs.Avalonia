﻿# Nerdlabs.Avalonia.Extension

An extension to AvaloniaUI providing custom or additional control(s)
to the core project. Currently containing ```MessageBox``` control based
on [MessageBoxSlim.Avalonia](https://github.com/SirJson/MessageBoxSlim.Avalonia)

[![NuGet](https://img.shields.io/nuget/v/Nerdlabs.Avalonia.Extension)](https://www.nuget.org/packages/Nerdlabs.Avalonia.Extension/)
[![Coverage Status](https://coveralls.io/repos/github/aLexiusxx/Nerdlabs.Avalonia/badge.svg?branch=dev)](https://coveralls.io/github/aLexiusxx/Nerdlabs.Avalonia?branch=dev)

### Changelog

##### 1.0.1
- Removed ```IsResizable``` which is equivalent to ```CanResize``` property as
  I find it a nuisance more than a feature.
- ```MessageBoxStyle.Icon``` is now more aligned with the ```MessageBoxStyle.Message```
  on presentation-level.
- ```MessageBox``` width now scales with ```MessageBoxStyle.MaxWidth``` so you have a single
  property that sets both.

##### 1.0.0
- Centered the text of controls such as buttons.
- Changed the message containing control from ```TextBox``` to ```TextBlock```
  for a more MessageBox like feel.
- Message content is now wrap with the containing parent window instead of being
  chopped off.
- Added ```BorderlessMessageBox``` for other specific usage and set as the
  default MessageBox style when ```MessageBoxStyle.None``` is used.

### Installation
You can find the latest version of this Package on [NuGet](https://www.nuget.org/packages/Nerdlabs.Avalonia.Extension/)

### Example Usage

Include ```using``` statements at the top of your namespace declaration.
```csharp
using Nerdlabs.Avalonia.Extension;
using Nerdlabs.Avalonia.Extension.Controls;
using Nerdlabs.Avalonia.Extension.DtObject;
```

Next, on the method where you want to show a ```MessageBox```, include something
like this:
```csharp
await MessageBox
    .Create(new MessageBoxOptions
    {
        Button = MessageBoxButton.OK | MessageBoxButton.Cancel,
        Title = "Error",
        Icon = BitmapFactory.Load("avares://Nerdlabs.Avalonia.Extension/Assets/error.ico"),
        Message = "Sorry, Something went wrong.",
        MaxWidth = 520,
    })
    .AsyncShowDialog(this);
```
# Lab Assignment 12 - Event-driven Programming in C#

## Overview

This lab introduces **event-driven programming** in **C#**, implemented through two applications: a **console-based alarm clock** and a **Windows Forms GUI-based alarm clock**. Both tasks showcase how events can drive application behavior in response to user input and system state.

---

## Features

### 🔔 Activity 1: Console-based Alarm Clock

- **Time Input:** Accepts alarm time in `HH:MM:SS` format.
- **Robust Input Validation:** Ensures correct time format using `TimeSpan.TryParseExact()` for error-free user input.
- **Publisher-Subscriber Pattern:** Implements custom events using delegates and event handlers.
- **Real-Time Monitoring:** Continuously checks system time every second using `Thread.Sleep(1000)`.
- **Alarm Trigger:** Displays a console message when the current time matches the set time.

---

### 🖥️ Activity 2: Windows Forms Alarm Clock

- **Graphical User Interface:** Built with Windows Forms featuring a textbox for time input and a button to start the alarm.
- **Robust Input Validation:** Utilizes `TimeSpan.TryParseExact()` to verify and parse time input accurately.
- **Timer-Based Time Check:** Uses `System.Windows.Forms.Timer` to monitor time at 1-second intervals.
- **Dynamic UI Feedback:** Randomly changes the form’s background color on each tick to enhance interactivity.
- **Alarm Notification:** Pops up a `MessageBox` when the set alarm time is reached.

---

## Technologies Used

- **Language:** C#
- **IDE:** Visual Studio 2022 (Community Edition)
- **Framework:** .NET with Windows Forms

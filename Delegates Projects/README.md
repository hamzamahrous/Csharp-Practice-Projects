# ICSharp-Advanced-Delegates

This repository contains three separate C# applications demonstrating advanced concepts including Delegates, Anonymous Methods, Lambda Expressions, Multicast Delegates, Func/Action/Predicate, Events.

## Student Grading System

### Overview

A console-based application for evaluating student performance using delegates. It demonstrates how Func, Action, and Predicate can be used to process student grades in a flexible and modular way.

### Features

- Add students and enter their grades
- Calculate average grades dynamically
- Determine pass/fail using Predicate-based logic
- Process grades using Func/Action/Predicate
- Clean and simple console interface

### Project Structure

```text
Student Grading System/
│── Program.cs
│── Student.cs
└── GradingSystem.cs
```

## Temperature Sensor System (Observer Pattern Version)

### Overview

A temperature monitoring system implemented using the Observer Pattern via Events & Delegates. Observers such as Display and Alarm are automatically notified whenever the temperature changes.

### Features

- Real-time temperature reading
- Alarm triggers when threshold is exceeded
- Display shows live temperature updates
- Event-driven observer architecture

### Project Structure

```text
Temperature Sensor System - Observer/
│── Program.cs
│── Sensor.cs
│── TemperatureArguments.cs
│── DisplayScreen.cs
└── Alarm.cs
```

## Temperature Sensor System (Publish/Subscribe Version)

### Overview

A refactored version of the temperature monitoring system using the Publish/Subscribe Pattern. A central Broker handles all communication, allowing publishers and subscribers to operate in complete isolation.

### Features

- Decoupled communication through a Broker
- Publisher (Sensor) does not directly reference subscribers
- Alarm and Display subscribe through the Broker
- Cleaner and more modular architecture

### Project Structure

```text
Temperature Sensor System - PubSub/
│── Program.cs
│── Sensor.cs
│── TemperatureArguments.cs
│── DisplayScreen.cs
│── Alarm.cs
└── Broker.cs
```

# 📜 Examen — A Guided Catholic Examination of Conscience

A Windows Forms application for preparing for the Sacrament of Reconciliation.

---

## 📖 Overview

**Examen** is a Windows Forms application designed to guide users through a structured Catholic examination of conscience.  
The program walks users through identifying sins, customizing their preparation, selecting optional prayers, and finally receiving a step-by-step Confession guide tailored to their selections.

The goal of the project is to provide a simple, accessible, and reverent tool to help Catholics prepare for Confession with clarity and sincerity.

---

## ✨ Features

### **Guided Examination of Conscience**
- Select sins, categories, and personal reflections.

### **Customization Options**
- Choose whether to include prayer.
- Enable/disable step-by-step Confession guidance.
- Add or remove optional elements as needed.

### **Prayer Selection**
- Includes an *Act of Contrition* selection form.

### **Confession Walkthrough**
Generates a personalized confession script based on the user’s selections, including:
- Mortal sin indicators  
- Number of times committed  
- Dates (optional)  
- Optional prayer and guide integration  

### **State-Driven Navigation**
Uses a centralized `ExamenData` object passed between forms to maintain user progress.

### **Restart / Quit Logic**
Users can restart the process or quit cleanly at any point, with confirmation dialogs.

---

## 🏛️ Architecture

The project uses a clean, modular, and easily extendable structure.

### **ExamenController**
Handles:
- State transitions  
- Form hiding/showing  
- Restart/quit flow  
- Deciding which stage is next  

### **Stage Managers**

Each stage is wrapped in a class implementing:

```csharp
public interface IStageManager 
{
    ExamenData Run(ExamenData input);
}
```
### **Current Stage Managers**
- **ExaminationManager**
- **CustomizationManager**
- **PrayerManager**
- **ConfessionManager**

This design keeps stage-flow consistent and easily extendable.

---

### **Forms**
Each WinForms screen receives an `ExamenData` instance and updates it directly:

- **ExaminationForm**
- **CustomizeForm**
- **PrayerForm**
- **ConfessionForm**

---

### **ExamenData**
A centralized data model storing:

- Selected sins  
- Prayer options  
- Guide settings  
- Quit/reset flags  
- Customization preferences 

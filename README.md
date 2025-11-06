# Calculator Application

A feature-rich Windows Forms calculator application built with C# that provides both basic and advanced mathematical operations with a modern, customizable interface.

## Features

### 🧮 Core Calculator Functions
- **Basic Operations**: Addition, Subtraction, Multiplication, Division
- **Advanced Operations**: 
  - Square (x²)
  - Square Root (√)
  - Reciprocal (1/x)
  - Percentage Calculations
  - Negation (±)

### 💾 Memory Operations
- **Memory Store (MS)**: Store current value in memory
- **Memory Recall (MR)**: Recall stored memory value
- **Memory Clear (MC)**: Clear stored memory
- **Memory Add (M+)**: Add current value to memory
- **Memory Subtract (M-)**: Subtract current value from memory
- **Memory Display**: Toggle memory panel to view stored value

### 📚 History & Display
- **Calculation History**: View previous calculations with results
- **Real-time Operation Display**: Shows current operation being performed
- **Clear History**: Easy one-click history clearing
- **Formatted Results**: Clean, readable calculation history

### 🎨 User Interface
- **Custom Rounded Buttons**: Modern, visually appealing interface
- **Draggable Window**: Click and drag the top panel to move window
- **Window Controls**: Minimize, maximize, and close buttons
- **Responsive Design**: Smooth animations and panel transitions
- **Dark Theme**: Easy-on-the-eyes color scheme

## Technical Details

### Built With
- **.NET Framework** - Windows Forms Application
- **C#** - Primary programming language
- **Custom Controls** - Rounded buttons and enhanced UI elements

### Project Structure
```
Calculator/
├── Form1.cs                 # Main calculator form and event handlers
├── Tools.cs                 # Utility methods and operation logic
├── Operation.cs            # Enum for mathematical operations
└── CustomRoundedButton/    # Custom UI controls
```

### Key Components

#### Form1.cs
- Main application window
- Event handlers for all buttons and controls
- Memory and history management
- UI state management

#### Tools.cs
- Mathematical operation implementations
- Panel animation utilities
- Text formatting and display methods
- Window movement functionality

#### Operation Enum
```csharp
public enum Operation
{
    Add, Subtract, Multiply, Divide, Square, SQRT, Reciprocal
}
```

## Installation & Setup

### Prerequisites
- .NET Framework 4.7.2 or later
- Visual Studio 2019 or later

### Building from Source
1. Clone or download the project files
2. Open the solution in Visual Studio
3. Restore NuGet packages if necessary
4. Build the solution (Ctrl+Shift+B)
5. Run the application (F5)

## Usage

### Basic Calculations
1. Enter numbers using the number pad
2. Select an operation (+, -, ×, ÷)
3. Enter the second number (if applicable)
4. Press equals (=) to see the result

### Memory Functions
- **MS**: Store current display value in memory
- **MR**: Recall stored memory value to display
- **MC**: Clear the memory
- **M+**: Add current value to memory
- **M-**: Subtract current value from memory

### Advanced Operations
- **x²**: Square the current number
- **√**: Calculate square root
- **1/x**: Calculate reciprocal
- **%**: Calculate percentage
- **±**: Toggle positive/negative

### History Features
- Click the history button to view calculation history
- Use the clear button in history panel to clear all history
- History automatically saves all completed calculations

## Code Architecture

### Event-Driven Design
The application follows an event-driven architecture with:
- Button click events for user input
- Mouse events for window controls
- Text change events for display updates

### Extension Methods
The project utilizes C# extension methods for:
- `Move_Form()` - Enables window dragging
- `Animate_Panel()` - Smooth panel animations
- `RichTextBox_Settings()` - Consistent text box styling

### State Management
- Tracks current operation type
- Manages memory storage and recall
- Handles calculation history
- Controls panel visibility states

## Customization

### UI Modifications
- Modify colors in `Color.FromArgb()` calls
- Adjust panel animations in `Animate_Panel()` method
- Customize button styles in the RoundedButton control

### Adding New Operations
1. Extend the `Operation` enum
2. Add calculation logic in `Tools.Calculate()`
3. Implement symbol in `Get_Symbol()` method
4. Add UI button and event handler in `Form1`

## License

This project is provided for educational and personal use.

## Contributing

Feel free to fork this project and submit pull requests for any improvements or bug fixes.

---

*Built with C# and Windows Forms*

# Oblivion WPF Theme Solution

A comprehensive WPF theme inspired by the futuristic UI design from the 2013 movie "Oblivion" directed by Joseph Kosinski. This theme transforms standard WPF applications into sleek, modern interfaces with glowing accents, smooth animations, and a distinctive sci-fi aesthetic.

## 🎬 Movie Inspiration

The theme captures the distinctive visual language of Oblivion's user interfaces:
- **Color Palette**: Bright cyans and blues (#00D4FF) with warm orange accents (#FF6B35)
- **Typography**: Clean, geometric fonts with glowing effects
- **Visual Effects**: Subtle shadows, border glows, and smooth transitions
- **Layout**: Minimalist, high-tech appearance with organized information hierarchy

## ✨ Features

### 🎨 Complete Theme System
- **Movie-accurate color palette** with primary blues, accent oranges, and dark backgrounds
- **Gradient brushes** for depth and visual interest
- **Glow effects** and drop shadows for futuristic feel
- **Semi-transparent overlays** for modern layering

### 🔧 Styled Controls
All major WPF controls are fully themed:
- **Button** - Gradient backgrounds with hover glow effects
- **TextBox** - Clean borders with focus animations
- **ComboBox** - Modern dropdown with styled items
- **CheckBox & RadioButton** - Futuristic selection indicators
- **DataGrid** - Sleek headers and row highlighting
- **Slider** - Glowing thumb with gradient track
- **ProgressBar** - Animated fill with glow effects
- **TabControl** - Modern tabs with selection highlighting
- **ListBox** - Smooth selection transitions
- **GroupBox** - Organized content sections
- **ScrollBar** - Minimalist design matching theme
- **ToolTip** - Styled popups with glow effects

### 🎭 Typography & Effects
- **Orbitron font** with proper fallbacks
- **Multiple text styles**: Header, SubHeader, Body, Caption, Monospace, Glowing
- **Text glow effects** for headers and important elements
- **Consistent font sizing** system

### 🎯 Advanced Animations
- **Hover animations** with smooth transitions
- **Focus indicators** with glowing borders
- **Scale effects** on button press
- **Fade transitions** for content loading
- **Slide animations** for dynamic content
- **Pulsing effects** for attention-drawing elements

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 or later
- Windows Presentation Foundation (WPF)
- Visual Studio 2022 or JetBrains Rider

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/AdiConstantin/OblivionWPFThemeSolution.git
   cd OblivionWPFThemeSolution
   ```

2. **Build the solution**:
   ```bash
   dotnet build
   ```

3. **Run the demo application**:
   ```bash
   cd OblivionThemeWPF
   dotnet run
   ```

### Using the Theme in Your Project

1. **Add reference to OblivionTheme project** or include the theme files

2. **Apply the theme in App.xaml**:
   ```xml
   <Application.Resources>
       <ResourceDictionary>
           <ResourceDictionary.MergedDictionaries>
               <ResourceDictionary Source="pack://application:,,,/OblivionTheme;component/Themes/OblivionTheme.xaml" />
           </ResourceDictionary.MergedDictionaries>
       </ResourceDictionary>
   </Application.Resources>
   ```

3. **Use theme resources in your XAML**:
   ```xml
   <Window Background="{DynamicResource BackgroundBrush}"
           Foreground="{DynamicResource TextBrush}">
       <!-- Your content here -->
   </Window>
   ```

## 🎨 Theme Structure

The theme is organized into modular files:

- **`OblivionTheme.xaml`** - Main theme file that imports all components
- **`OblivionColors.xaml`** - Complete color palette and brush definitions
- **`OblivionFonts.xaml`** - Typography system and text styles
- **`OblivionControls.xaml`** - All control templates and styles
- **`OblivionAnimations.xaml`** - Animation definitions and triggers

## 🎯 Demo Application

The included demo application showcases all theme capabilities:

### Dashboard Tab
- **System metrics** with real-time displays
- **Control panel** with sliders, progress bars, and input controls
- **Performance monitoring** with styled data grids
- **System logs** with futuristic list displays

### Data Analysis Tab
- **Comprehensive DataGrid** with Oblivion-themed sample data
- **Advanced sorting and selection** highlighting

### Configuration Tab
- **Complete settings interface** showcasing all control types
- **Grouped options** with styled GroupBoxes
- **Form controls** demonstrating input handling

## 🎨 Customization

### Color Scheme
Modify colors in `OblivionColors.xaml`:
```xml
<Color x:Key="PrimaryColor">#00D4FF</Color>      <!-- Main cyan -->
<Color x:Key="AccentColor">#FF6B35</Color>       <!-- Orange accent -->
<Color x:Key="DarkBackground">#0A0E1A</Color>    <!-- Dark background -->
```

### Animations
Adjust animation speeds in `OblivionAnimations.xaml`:
```xml
<Duration x:Key="FastDuration">0:0:0.2</Duration>
<Duration x:Key="NormalDuration">0:0:0.3</Duration>
<Duration x:Key="SlowDuration">0:0:0.5</Duration>
```

### Typography
Customize fonts in `OblivionFonts.xaml`:
```xml
<FontFamily x:Key="SciFiFont">Orbitron, Segoe UI, Arial</FontFamily>
```

## 🤝 Contributing

Contributions are welcome! Please feel free to submit pull requests, report bugs, or suggest enhancements.

### Development Guidelines
- Follow the existing code style and organization
- Test changes with the demo application
- Ensure all controls maintain the theme consistency
- Document any new features or changes

## 📄 License

This project is open source. Please check the license file for details.

## 💖 Support the Project

If you find this theme useful, consider supporting the development:

- ☕ [Buy Me a Coffee](https://coff.ee/constantinadi)
- 🌟 Star this repository
- 🐛 Report issues and suggest improvements
- 📢 Share with others who might benefit

## 🙏 Acknowledgments

- **Joseph Kosinski** - Director of Oblivion (2013)
- **Gmunk (Bradley Munkowitz)** - UI/UX design for the movie
- **Orbitron Font** - Used for the sci-fi typography
- **WPF Community** - For extensive documentation and examples

## 📞 Contact

- **Website**: [adrianconstantin.ro](https://adrianconstantin.ro)
- **LinkedIn**: [constantinadi](https://linkedin.com/in/constantinadi)
- **GitHub**: [AdiConstantin](https://github.com/AdiConstantin)

---

*Transform your WPF applications with the power and elegance of futuristic design. Welcome to the future of desktop applications.*
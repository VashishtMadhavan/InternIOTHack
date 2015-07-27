﻿#pragma checksum "C:\Users\sthuang\Desktop\Windows-universal-samples-master\audiocreation\cs\AudioCreation\Scenario5_InboxEffects.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A0C807113464BE5B13A49E9B708C68ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AudioCreation
{
    partial class Scenario5_InboxEffects : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.fileButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 97 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.fileButton).Click += this.File_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.audioPipe = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 4:
                {
                    this.speakerContainer = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 5:
                {
                    this.graphButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 104 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.graphButton).Click += this.Graph_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.echoEffectContainer = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    this.reverbEffectContainer = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8:
                {
                    this.limiterEffectContainer = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9:
                {
                    this.equalizerEffectContainer = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10:
                {
                    this.eqToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 123 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.eqToggle).Toggled += this.EqToggle_Toggled;
                    #line default
                }
                break;
            case 11:
                {
                    this.eq1SliderContainer = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 12:
                {
                    this.eq2SliderContainer = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 13:
                {
                    this.eq3SliderContainer = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 14:
                {
                    this.eq4SliderContainer = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 15:
                {
                    this.eq4Slider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 138 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.eq4Slider).ValueChanged += this.Eq4Slider_ValueChanged;
                    #line default
                }
                break;
            case 16:
                {
                    this.eq4SliderLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.eq3Slider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 134 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.eq3Slider).ValueChanged += this.Eq3Slider_ValueChanged;
                    #line default
                }
                break;
            case 18:
                {
                    this.eq3SliderLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.eq2Slider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 130 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.eq2Slider).ValueChanged += this.Eq2Slider_ValueChanged;
                    #line default
                }
                break;
            case 20:
                {
                    this.eq2SliderLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.eq1Slider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 126 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.eq1Slider).ValueChanged += this.Eq1Slider_ValueChanged;
                    #line default
                }
                break;
            case 22:
                {
                    this.eq1SliderLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23:
                {
                    this.limiterEffectToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 118 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.limiterEffectToggle).Toggled += this.LimiterEffectToggle_Toggled;
                    #line default
                }
                break;
            case 24:
                {
                    this.loudnessLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25:
                {
                    this.loudnessSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 120 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.loudnessSlider).ValueChanged += this.LoudnessSlider_ValueChanged;
                    #line default
                }
                break;
            case 26:
                {
                    this.reverbEffectToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 113 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.reverbEffectToggle).Toggled += this.ReverbEffectToggle_Toggled;
                    #line default
                }
                break;
            case 27:
                {
                    this.decayLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28:
                {
                    this.decaySlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 115 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.decaySlider).ValueChanged += this.DecaySlider_ValueChanged;
                    #line default
                }
                break;
            case 29:
                {
                    this.echoEffectToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 108 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.echoEffectToggle).Toggled += this.EchoEffectToggle_Toggled;
                    #line default
                }
                break;
            case 30:
                {
                    this.echoLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 31:
                {
                    this.echoSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 110 "..\..\..\Scenario5_InboxEffects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.echoSlider).ValueChanged += this.EchoSlider_ValueChanged;
                    #line default
                }
                break;
            case 32:
                {
                    this.speaker = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


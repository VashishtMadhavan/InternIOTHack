﻿#pragma checksum "C:\Users\sthuang\Desktop\Windows-universal-samples-master\audiocreation\cs\AudioCreation\Scenario4_Submix.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5FD68FA5E0672FCE014918F22500A697"
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
    partial class Scenario4_Submix : 
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
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.ErrorBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 3:
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.fileButton1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 95 "..\..\..\Scenario4_Submix.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.fileButton1).Click += this.File1_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.fileButton2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 96 "..\..\..\Scenario4_Submix.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.fileButton2).Click += this.File2_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.audioPipe1 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 7:
                {
                    this.audioPipe2 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 8:
                {
                    this.subMixNode = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 9:
                {
                    this.audioPipe3 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 10:
                {
                    this.speakerContainer = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 11:
                {
                    this.graphButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 123 "..\..\..\Scenario4_Submix.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.graphButton).Click += this.GraphButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.speaker = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.submixLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.echoEffectToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 116 "..\..\..\Scenario4_Submix.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.echoEffectToggle).Toggled += this.EchoEffectToggle_Toggled;
                    #line default
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


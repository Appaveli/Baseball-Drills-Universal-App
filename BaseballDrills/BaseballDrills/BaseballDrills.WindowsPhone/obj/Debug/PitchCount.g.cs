﻿

#pragma checksum "C:\Users\Dterryable\documents\visual studio 2013\Projects\BaseballDrills\BaseballDrills\BaseballDrills.WindowsPhone\PitchCount.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A91DAC76EFF3A05A353E3A8627665DBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaseballDrills
{
    partial class PitchCount : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 24 "..\..\PitchCount.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Strikes_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 29 "..\..\PitchCount.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Balls_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 35 "..\..\PitchCount.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Reset_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 40 "..\..\PitchCount.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.HyperlinkButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


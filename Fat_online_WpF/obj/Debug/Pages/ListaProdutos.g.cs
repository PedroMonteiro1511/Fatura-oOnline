﻿#pragma checksum "..\..\..\Pages\ListaProdutos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F8B24192026916BAAC40A3DA98CF1AEE344BDA8C79FAFE9372630BEA9EAC69C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

using Fat_online_WpF.Pages;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Fat_online_WpF.Pages {
    
    
    /// <summary>
    /// ListaProdutos
    /// </summary>
    public partial class ListaProdutos : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Pages\ListaProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataProdutos;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\ListaProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNome;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\ListaProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbReferencia;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\ListaProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescricao;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\ListaProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMarca;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\ListaProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCategoria;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\ListaProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSubCategoria;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\ListaProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPreco;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\ListaProdutos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateProduto;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Fat_online_WpF;component/pages/listaprodutos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ListaProdutos.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dataProdutos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\..\Pages\ListaProdutos.xaml"
            this.dataProdutos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataProdutos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbReferencia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbDescricao = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbMarca = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbCategoria = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbSubCategoria = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbPreco = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.updateProduto = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


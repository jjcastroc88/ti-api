﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TL.API.DAL.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TL.API.DAL.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a [
        ///  {
        ///    &quot;id&quot;: &quot;aeed54ce-36d8-42f6-8055-4c648c3bd4a1&quot;,
        ///    &quot;name&quot;: &quot;Generic Concrete Computer&quot;,
        ///    &quot;description&quot;: &quot;Voluptas vel numquam culpa aut non qui aliquam ut. Sequi corrupti ducimus ex officiis aperiam. Aspernatur ea nobis sit.&quot;,
        ///    &quot;price&quot;: &quot;275.00&quot;,
        ///    &quot;brand&quot;: &quot;Hirthe - Pacocha&quot;,
        ///    &quot;stock&quot;: 47905,
        ///    &quot;photo&quot;: &quot;http://lorempixel.com/640/480/nature&quot;,
        ///    &quot;categories&quot;: [ &quot;Tech&quot;, &quot;Services&quot; ]
        ///  },
        ///  {
        ///    &quot;id&quot;: &quot;2ad52ed8-77d7-4072-ad86-42b1c3517c66&quot;,
        ///    &quot;name&quot;: &quot;Intelligent Rubber [resto de la cadena truncado]&quot;;.
        /// </summary>
        public static string data {
            get {
                return ResourceManager.GetString("data", resourceCulture);
            }
        }
    }
}
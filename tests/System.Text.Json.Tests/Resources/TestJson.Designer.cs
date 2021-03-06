﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Text.Json.Tests.Resources {
    using System;
    using System.Reflection;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TestJson {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestJson() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Text.Json.Tests.Resources.TestJson", typeof(TestJson).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///   &quot;age&quot; : 30,
        ///   &quot;first&quot; : &quot;John&quot;,
        ///   &quot;last&quot; : &quot;Smith&quot;,
        ///   &quot;phoneNumbers&quot; : [
        ///      &quot;425-000-1212&quot;,
        ///      &quot;425-000-1213&quot;
        ///   ],
        ///   &quot;address&quot; : {
        ///      &quot;street&quot; : &quot;1 Microsoft Way&quot;,
        ///      &quot;city&quot; : &quot;Redmond&quot;,
        ///      &quot;zip&quot; : 98052
        ///   }
        ///}.
        /// </summary>
        internal static string BasicJson {
            get {
                return ResourceManager.GetString("BasicJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1MicrosoftWay&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052},&quot;IDs&quot;:[0425,-70,9223372036854775807]}.
        /// </summary>
        internal static string BasicJsonWithLargeNum {
            get {
                return ResourceManager.GetString("BasicJsonWithLargeNum", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1 Microsoft Way&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052}}.
        /// </summary>
        internal static string ExpectedBasicJson {
            get {
                return ResourceManager.GetString("ExpectedBasicJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1MicrosoftWay&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052},&quot;IDs&quot;:[425,-70,9.22337203685478E+18]}.
        /// </summary>
        internal static string ExpectedBasicJsonWithLargeNum {
            get {
                return ResourceManager.GetString("ExpectedBasicJsonWithLargeNum", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1 Microsoft Way&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052}}.
        /// </summary>
        internal static string ExpectedCreateJson {
            get {
                return ResourceManager.GetString("ExpectedCreateJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1MicrosoftWay&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052},&quot;IDs&quot;:[425,-70,9.22337203685478E+18],&quot;arrayWithObjects&quot;:[&quot;text&quot;,14,[],null,false,{},{&quot;time&quot;:24},[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;]],&quot;boolean&quot;:false,&quot;null&quot;:null,&quot;objectName&quot;:{&quot;group&quot;:{&quot;array&quot;:[false],&quot;field&quot;:&quot;simple&quot;,&quot;anotherFieldNum&quot;:5,&quot;anotherFieldBool&quot;:true,&quot;lastField&quot;:null}},&quot;emptyObject&quot;:{}}.
        /// </summary>
        internal static string ExpectedFullJsonSchema1 {
            get {
                return ResourceManager.GetString("ExpectedFullJsonSchema1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;string&quot;:&quot;string&quot;,&quot;number&quot;:5,&quot;decimal&quot;:3516512.13512,&quot;long&quot;:9.22337203685478E+18,&quot;notLong&quot;:922854776000.12,&quot;boolean&quot;:false,&quot;object&quot;:{},&quot;array&quot;:[],&quot;null&quot;:null,&quot;emptyArray&quot;:[],&quot;emptyObject&quot;:{},&quot;arrayString&quot;:[&quot;alpha&quot;,&quot;beta&quot;],&quot;arrayNum&quot;:[1,212512.01,3],&quot;arrayBool&quot;:[false,true,true],&quot;arrayNull&quot;:[null,null],&quot;arrayObject&quot;:[{&quot;firstName&quot;:&quot;name1&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name1&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name2&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name3&quot;,&quot;lastName&quot;:&quot;name1&quot;}],&quot;arrayArray&quot;:[[null,false,5,&quot;-0 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExpectedFullJsonSchema2 {
            get {
                return ResourceManager.GetString("ExpectedFullJsonSchema2", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;array&quot;:[{&quot;_id&quot;:&quot;56280d1abea79cfca762cd56&quot;,&quot;index&quot;:0,&quot;isActive&quot;:false,&quot;tags&quot;:[&quot;ad&quot;,&quot;voluptate&quot;,&quot;ullamco&quot;,&quot;reprehenderit&quot;,&quot;duis&quot;,&quot;Lorem&quot;,&quot;anim&quot;],&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Fernandez Barr&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Selena Hoover&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Verna Keller&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Middleton Duncan&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Fitzgerald Mcbride&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Boyd Marshall&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Debbie Hess&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Larson Mcmahon&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name [rest of string was truncated]&qu....
        /// </summary>
        internal static string ExpectedHeavyNestedJson {
            get {
                return ResourceManager.GetString("ExpectedHeavyNestedJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to [{&quot;array&quot;:[{&quot;_id&quot;:&quot;56280d1abea79cfca762cd56&quot;,&quot;index&quot;:0,&quot;isActive&quot;:false,&quot;tags&quot;:[&quot;ad&quot;,&quot;voluptate&quot;,&quot;ullamco&quot;,&quot;reprehenderit&quot;,&quot;duis&quot;,&quot;Lorem&quot;,&quot;anim&quot;],&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Fernandez Barr&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Selena Hoover&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Verna Keller&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Middleton Duncan&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Fitzgerald Mcbride&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Boyd Marshall&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Debbie Hess&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Larson Mcmahon&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;nam [rest of string was truncated]&qu....
        /// </summary>
        internal static string ExpectedHeavyNestedJsonWithArray {
            get {
                return ResourceManager.GetString("ExpectedHeavyNestedJsonWithArray", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;+testZero+&quot;:0,&quot;+testSmallNum+&quot;:0.1,&quot;+testeZero+&quot;:0.1,&quot;+testENegtiveWithZero+&quot;:0,&quot;+testeNegativeWithInt+&quot;:0.02155,&quot;+testEPositiveWithDecimal+&quot;:215215.41,&quot;+testePositiveWithLargeInt+&quot;:1.84467440737096E+128,&quot;+testeNegativeWithLargeDecimal+&quot;:1.25125612512513E-109,&quot;-testZero-&quot;:0,&quot;-testSmallNum-&quot;:-0.1,&quot;-testeZero-&quot;:-0.1,&quot;-testENegtiveWithZero-&quot;:0,&quot;-testeNegativeWithInt-&quot;:-0.02155,&quot;-testEPositiveWithDecimal-&quot;:-215215.41,&quot;-testePositiveWithLargeInt-&quot;:-1.84467440737096E+128,&quot;-testeNegativeWithLargeDecimal-&quot;:-1.251 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExpectedJsonWithSpecialNumFormat {
            get {
                return ResourceManager.GetString("ExpectedJsonWithSpecialNumFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;Here is a string: \&quot;\&quot;&quot;:&quot;Here is a hex value -\u024A&quot;,&quot;Here is a back slash\\&quot;:[&quot;Multiline
        /// String
        ///&quot;,&quot;	Mul
        ///tiline String&quot;,&quot;\&quot;somequote\&quot;	Mu\&quot;\&quot;l
        ///tiline\&quot;another\&quot; String\\&quot;],&quot;str&quot;:&quot;\&quot;\&quot;&quot;}.
        /// </summary>
        internal static string ExpectedJsonWithSpecialStrings {
            get {
                return ResourceManager.GetString("ExpectedJsonWithSpecialStrings", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;test&quot;:[{&quot;_id&quot;:&quot;562704ab8c67fc70235cb3ee&quot;,&quot;index&quot;:0,&quot;guid&quot;:&quot;9e16ac89-e6cb-401d-b0bd-5cb567908ad7&quot;,&quot;isActive&quot;:false,&quot;balance&quot;:&quot;$2,222.13&quot;,&quot;picture&quot;:&quot;http://placehold.it/32x32&quot;,&quot;age&quot;:34,&quot;eyeColor&quot;:&quot;blue&quot;,&quot;name&quot;:&quot;Reba Abbott&quot;,&quot;gender&quot;:&quot;female&quot;,&quot;company&quot;:&quot;VERBUS&quot;,&quot;email&quot;:&quot;rebaabbott@verbus.com&quot;,&quot;phone&quot;:&quot;+1 (878) 506-3650&quot;,&quot;address&quot;:&quot;800 Anchorage Place, Crayne, Illinois, 9130&quot;,&quot;about&quot;:&quot;Proident ea dolor ullamco occaecat ut pariatur. Pariatur aute deserunt deserunt qui aute commodo. Dolor ipsum incididunt tempo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExpectedLargeJson {
            get {
                return ResourceManager.GetString("ExpectedLargeJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;locked&quot;:false,&quot;version&quot;:1,&quot;targets&quot;:{&quot;DNXCore,Version=v5.0&quot;:{&quot;Microsoft.CSharp/4.0.0&quot;:{&quot;dependencies&quot;:{&quot;System.Runtime&quot;:&quot;[4.0.20, )&quot;,&quot;System.Dynamic.Runtime&quot;:&quot;[4.0.0, )&quot;,&quot;System.Linq.Expressions&quot;:&quot;[4.0.0, )&quot;,&quot;System.Runtime.InteropServices&quot;:&quot;[4.0.20, )&quot;,&quot;System.Resources.ResourceManager&quot;:&quot;[4.0.0, )&quot;,&quot;System.Linq&quot;:&quot;[4.0.0, )&quot;,&quot;System.Reflection.TypeExtensions&quot;:&quot;[4.0.0, )&quot;,&quot;System.Reflection.Primitives&quot;:&quot;[4.0.0, )&quot;,&quot;System.Reflection.Extensions&quot;:&quot;[4.0.0, )&quot;,&quot;System.Collections&quot;:&quot;[4.0.10, )&quot;,&quot;System.Diagnost [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExpectedProjectLockJson {
            get {
                return ResourceManager.GetString("ExpectedProjectLockJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1MicrosoftWay&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052},&quot;IDs&quot;:[425,-70,9223372036854776000],&quot;arrayWithObjects&quot;:[&quot;text&quot;,14,[],null,false,{},{&quot;time&quot;:24},[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;]],&quot;boolean&quot;:false,&quot;null&quot;:null,&quot;objectName&quot;:{&quot;group&quot;:{&quot;array&quot;:[false],&quot;field&quot;:&quot;simple&quot;,&quot;anotherFieldNum&quot;:5,&quot;anotherFieldBool&quot;:true,&quot;lastField&quot;:null}},&quot;emptyObject&quot;:{}}.
        /// </summary>
        internal static string FullJsonSchema1 {
            get {
                return ResourceManager.GetString("FullJsonSchema1", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;string&quot;:&quot;string&quot;,&quot;number&quot;:5,&quot;decimal&quot;:3516512.13512,&quot;long&quot;:9223372036854776000.1200,&quot;notLong&quot;:922854776000.1200,&quot;boolean&quot;:false,&quot;object&quot;:{},&quot;array&quot;:[],&quot;null&quot;:null,&quot;emptyArray&quot;:[],&quot;emptyObject&quot;:{},&quot;arrayString&quot;:[&quot;alpha&quot;,&quot;beta&quot;],&quot;arrayNum&quot;:[1,212512.01,3.00],&quot;arrayBool&quot;:[false,true,true],&quot;arrayNull&quot;:[null,null],&quot;arrayObject&quot;:[{&quot;firstName&quot;:&quot;name1&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name1&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name2&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name3&quot;,&quot;lastName&quot;:&quot;name1&quot;}],&quot;arrayArray&quot;:[[null,fa [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FullJsonSchema2 {
            get {
                return ResourceManager.GetString("FullJsonSchema2", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;array&quot;:[  {    &quot;_id&quot;: &quot;56280d1abea79cfca762cd56&quot;,    &quot;index&quot;: 0,    &quot;isActive&quot;: false,    &quot;tags&quot;: [      &quot;ad&quot;,      &quot;voluptate&quot;,      &quot;ullamco&quot;,      &quot;reprehenderit&quot;,      &quot;duis&quot;,      &quot;Lorem&quot;,      &quot;anim&quot;    ],    &quot;friends&quot;: [      {        &quot;id&quot;: 0,        &quot;name&quot;: &quot;Fernandez Barr&quot;,        &quot;friends&quot;: [          {            &quot;id&quot;: 0,            &quot;name&quot;: &quot;Selena Hoover&quot;,            &quot;friends&quot;: [              {                &quot;id&quot;: 0,                &quot;name&quot;: &quot;Verna Keller&quot;,                &quot;friends&quot;: [           [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HeavyNestedJson {
            get {
                return ResourceManager.GetString("HeavyNestedJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to [{&quot;array&quot;:[  {    &quot;_id&quot;: &quot;56280d1abea79cfca762cd56&quot;,    &quot;index&quot;: 0,    &quot;isActive&quot;: false,    &quot;tags&quot;: [      &quot;ad&quot;,      &quot;voluptate&quot;,      &quot;ullamco&quot;,      &quot;reprehenderit&quot;,      &quot;duis&quot;,      &quot;Lorem&quot;,      &quot;anim&quot;    ],    &quot;friends&quot;: [      {        &quot;id&quot;: 0,        &quot;name&quot;: &quot;Fernandez Barr&quot;,        &quot;friends&quot;: [          {            &quot;id&quot;: 0,            &quot;name&quot;: &quot;Selena Hoover&quot;,            &quot;friends&quot;: [              {                &quot;id&quot;: 0,                &quot;name&quot;: &quot;Verna Keller&quot;,                &quot;friends&quot;: [          [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HeavyNestedJsonWithArray {
            get {
                return ResourceManager.GetString("HeavyNestedJsonWithArray", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;+testZero+&quot; : 0,&quot;+testSmallNum+&quot; : 0.1,&quot;+testeZero+&quot; : 0.1e0,&quot;+testENegtiveWithZero+&quot; : 0E-1,&quot;+testeNegativeWithInt+&quot; : 2155e-5,&quot;+testEPositiveWithDecimal+&quot; : 2152.1541E+2,&quot;+testePositiveWithLargeInt+&quot; : 18446744073709551615E109,&quot;+testeNegativeWithLargeDecimal+&quot; : 125125612512512.512512e-0123,&quot;-testZero-&quot; : -0,&quot;-testSmallNum-&quot; : -0.1,&quot;-testeZero-&quot; : -0.1e0,&quot;-testENegtiveWithZero-&quot; : -0E-1,&quot;-testeNegativeWithInt-&quot; : -2155e-5,&quot;-testEPositiveWithDecimal-&quot; : -2152.1541E+2,&quot;-testePositiveWithLargeInt-&quot; :-18446 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string JsonWithSpecialNumFormat {
            get {
                return ResourceManager.GetString("JsonWithSpecialNumFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {&quot;Here is a string: \&quot;\&quot;&quot;:&quot;Here is a hex value -\u024A&quot;,&quot;Here is a back slash\\&quot;:[&quot;Multiline
        /// String
        ///&quot;,&quot;	Mul
        ///tiline String&quot;,&quot;\&quot;somequote\&quot;	Mu\&quot;\&quot;l
        ///tiline\&quot;another\&quot; String\\&quot;],&quot;str&quot;:&quot;\&quot;\&quot;&quot;}.
        /// </summary>
        internal static string JsonWithSpecialStrings {
            get {
                return ResourceManager.GetString("JsonWithSpecialStrings", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {  &quot;test&quot; : [    {      &quot;_id&quot;: &quot;562704ab8c67fc70235cb3ee&quot;,      &quot;index&quot;: 0,      &quot;guid&quot;: &quot;9e16ac89-e6cb-401d-b0bd-5cb567908ad7&quot;,      &quot;isActive&quot;: false,      &quot;balance&quot;: &quot;$2,222.13&quot;,      &quot;picture&quot;: &quot;http://placehold.it/32x32&quot;,      &quot;age&quot;: 34,      &quot;eyeColor&quot;: &quot;blue&quot;,      &quot;name&quot;: &quot;Reba Abbott&quot;,      &quot;gender&quot;: &quot;female&quot;,      &quot;company&quot;: &quot;VERBUS&quot;,      &quot;email&quot;: &quot;rebaabbott@verbus.com&quot;,      &quot;phone&quot;: &quot;+1 (878) 506-3650&quot;,      &quot;address&quot;: &quot;800 Anchorage Place, Crayne, Illinois, 9130&quot;,      &quot;about&quot;: &quot;Proident ea d [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LargeJson {
            get {
                return ResourceManager.GetString("LargeJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to [
        ///   {
        ///      &quot;age&quot; : 30,
        ///      &quot;first&quot; : &quot;John&quot;,
        ///      &quot;last&quot; : &quot;Smith&quot;,
        ///      &quot;phoneNumbers&quot; : [
        ///         &quot;425-000-1212&quot;,
        ///         &quot;425-000-1213&quot;
        ///      ],
        ///      &quot;address&quot; : {
        ///         &quot;street&quot; : &quot;1 Microsoft Way&quot;,
        ///         &quot;city&quot; : &quot;Redmond&quot;,
        ///         &quot;zip&quot; : 98052
        ///      }
        ///   }
        ///].
        /// </summary>
        internal static string ParseJson {
            get {
                return ResourceManager.GetString("ParseJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {  &quot;locked&quot;: false,  &quot;version&quot;: 1,  &quot;targets&quot;: {    &quot;DNXCore,Version=v5.0&quot;: {      &quot;Microsoft.CSharp/4.0.0&quot;: {        &quot;dependencies&quot;: {          &quot;System.Runtime&quot;: &quot;[4.0.20, )&quot;,          &quot;System.Dynamic.Runtime&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Linq.Expressions&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Runtime.InteropServices&quot;: &quot;[4.0.20, )&quot;,          &quot;System.Resources.ResourceManager&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Linq&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Reflection.TypeExtensions&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Reflection. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ProjectLockJson {
            get {
                return ResourceManager.GetString("ProjectLockJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to [
        ///	&quot;425-214-3151&quot;,
        ///	25
        ///].
        /// </summary>
        internal static string SimpleArrayJson {
            get {
                return ResourceManager.GetString("SimpleArrayJson", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;age&quot;: 30,
        ///	&quot;first&quot;: &quot;John&quot;,
        ///	&quot;last&quot;: &quot;Smith&quot;,
        ///	&quot;phoneNumber&quot;: &quot;425-214-3151&quot;,
        ///	&quot;street&quot;: &quot;1 Microsoft Way&quot;,
        ///	&quot;city&quot;: &quot;Redmond&quot;,
        ///	&quot;zip&quot;: 98052
        ///}.
        /// </summary>
        internal static string SimpleObjectJson {
            get {
                return ResourceManager.GetString("SimpleObjectJson", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized string similar to { &quot;message&quot;: &quot;Hello, World!&quot; }.
        /// </summary>
        internal static string HelloWorld {
            get {
                return ResourceManager.GetString("HelloWorld", resourceCulture);
            }
        }
    }
}

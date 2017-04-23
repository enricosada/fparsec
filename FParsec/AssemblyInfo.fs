﻿namespace FParsec

open System.Reflection
open System.Runtime.CompilerServices
open System.Runtime.InteropServices

[<assembly: ComVisible(false)>]

#if LOW_TRUST
    [<assembly: System.Security.AllowPartiallyTrustedCallers>]
    [<assembly: System.Security.SecurityTransparent>]
#endif

[<assembly: AssemblyTitle("FParsec.dll")>]
[<assembly: AssemblyDescription("FParsec.dll")>]

[<assembly: AssemblyProduct(FParsec.CommonAssemblyInfo.Product)>]
[<assembly: AssemblyCopyright(FParsec.CommonAssemblyInfo.Copyright)>]
[<assembly: AssemblyVersion(FParsec.CommonAssemblyInfo.Version)>]
[<assembly: AssemblyFileVersion(FParsec.CommonAssemblyInfo.FileVersion)>]
[<assembly: AssemblyConfiguration(FParsec.CommonAssemblyInfo.FSConfiguration)>]

[<assembly: InternalsVisibleTo(FParsec.CommonAssemblyInfo.TestAssemblyName + FParsec.CommonAssemblyInfo.StrongNamePublicKey)>]
do ()
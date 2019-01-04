### Version 0.7.4, 2018/11/16:

* bugfix for resolving dependencies of .Net Standard and .NET Core projects ([#11](https://github.com/szehetner/InliningAnalyzer/issues/11))
* bugfix for methods with ref parameters ([#10](https://github.com/szehetner/InliningAnalyzer/issues/10))
* support for manually selecting the assembly to analyze

### Version 0.7.3, 2018/10/31:

* bugfix for missing assembly error with .NET Core projects ([#8](https://github.com/szehetner/InliningAnalyzer/issues/8))
* bugfix for ref return methods  ([#9](https://github.com/szehetner/InliningAnalyzer/issues/9))

### Version 0.7.2, 2018/08/25:

* fixed various bugs causing the Analyzer to not work due to wrong dependencies (both for .NET Core and .NET Framework)

### Version 0.7.1, 2018/07/11:

* bugfix for missing highlighting
* changed context menu action to "Run Inlining Analyzer on Current Scope". If invoked within a method, it analyzes only this method, if invoked anywhere else within a class/struct, it analyzes all methods of this class/struct.

### Version 0.7.0, 2018/05/07:

* support for .Net Core (2.1+ must be installed to run the analyzer, the projects being analyzed can have any .Net Core or .Net Standard version)
* options dialog for setting a preferred runtime (.Net Framework or .Net Core) to be used for analyzing .NET Standard projects or projects targeting multiple frameworks)

### Version 0.6.5, 2018/04/20:

* support for methods with out parameters
* various bugfixes

### Version 0.6.4, 2018/03/09:

* highlight calls in async methods
* support for ref return properties ([#3](https://github.com/szehetner/InliningAnalyzer/issues/3))

### Version 0.6.3, 2017/11/27

* Fixed false "not inlined" results ([#2](https://github.com/szehetner/InliningAnalyzer/issues/2)) by analyzing the calltree first and compiling methods in the right order (callers before callees)
* highlight calls in iterator methods (i.e. methods containing yield return)

### Version 0.6.0, 2017/10/08
* Initial Release
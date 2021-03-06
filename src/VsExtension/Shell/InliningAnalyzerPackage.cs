﻿using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Win32;
using System.ComponentModel.Composition;
using VsExtension.Model;
using VsExtension.Shell;
using System.Threading;

namespace VsExtension
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(InliningAnalyzerPackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    [ProvideOptionPage(typeof(InliningAnalyzerOptionsPage), "Inlining Analyzer", "General", 0, 0, true)]
    public sealed class InliningAnalyzerPackage : AsyncPackage
    {
        /// <summary>
        /// EnableHighlightingPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "402b7c77-1fb6-4757-b2f0-67e04391da6e";

        /// <summary>
        /// Initializes a new instance of the <see cref="InliningAnalyzerCommands"/> class.
        /// </summary>
        public InliningAnalyzerPackage()
        {
        }

        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override async System.Threading.Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await InliningAnalyzerCommands.InitializeAsync(this);
            await base.InitializeAsync(cancellationToken, progress);
        }

        #endregion
    }
}

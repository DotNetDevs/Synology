﻿using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Synology")]
[assembly: AssemblyDescription("Synology Core API for .NET")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Caelan")]
[assembly: AssemblyProduct("Synology")]
[assembly: AssemblyCopyright("Caelan © 2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.*")]

// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
// Added a Frindly assembly attribute to make some unit tests on internal classes
[assembly: InternalsVisibleTo("Synology.Tests")]
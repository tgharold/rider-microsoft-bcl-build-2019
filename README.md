# rider-microsoft-bcl-build-2019

Demonstrates a bug in Rider 2019.2 where the Microsft.Bcl.Build package was installed and then the project is converted form packages.config to PackageReferences.

The Microsoft.Bcl.Build package has a file called "Microsoft.Bcl.Build.targets" which contains an XML tag called "ValidatePackageReferences".  This tag requires that a packages.config file exists next to the project file.

Visual Studio 2017 and Visual Studio 2019 are able to build the project after the conversion to PackageReferences style, but Rider 2019.2 is not.
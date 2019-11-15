# rider-microsoft-bcl-build-2019

Demonstrates a bug in Rider 2019.2 where the Microsft.Bcl.Build package was installed and then the project is converted form packages.config to PackageReferences.

The Microsoft.Bcl.Build package has a file called "Microsoft.Bcl.Build.targets" which contains an XML tag called "ValidatePackageReferences".  This tag requires that a packages.config file exists next to the project file.

Visual Studio 2017 and Visual Studio 2019 are able to build the project after the conversion to PackageReferences style, but Rider 2019.2 is not.  Rider 2019.2 will complain with "Ensure that this project has Microsoft.Bcl.Build installed and packages.config is located next to the project file."

Notes:

- bae6adb9cb4d5be178f38d94edd13ef95fceaf97 will compile under VS 2017, VS 2019 and Rider 2019.2
- The next commit 6793cf7b0c242dc621e7956b8522441ee0ac90f2 after converting the test project to PackageReferences, will not compile under Rider 2019.2, but still compiles under VS 2017 and VS 2019.


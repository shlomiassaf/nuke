// Generated from https://github.com/nuke-build/nuke/blob/master/source/Nuke.Common/Tools/DotNet/DotNet.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.DotNet;

/// <summary><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[PathTool(Executable = PathExecutable)]
public partial class DotNetTasks : ToolTasks, IRequirePathTool
{
    public static string DotNetPath { get => new DotNetTasks().GetToolPathInternal(); set => new DotNetTasks().SetToolPath(value); }
    public const string PathExecutable = "dotnet";
    /// <summary><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    public static IReadOnlyCollection<Output> DotNet(ArgumentStringHandler arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Action<OutputType, string> logger = null, Func<IProcess, object> exitHandler = null) => new DotNetTasks().Run(arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, logger, exitHandler);
    /// <summary><p>The <c>dotnet test</c> command is used to execute unit tests in a given project. Unit tests are console application projects that have dependencies on the unit test framework (for example, MSTest, NUnit, or xUnit) and the dotnet test runner for the unit testing framework. These are packaged as NuGet packages and are restored as ordinary dependencies for the project.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;projectFile&gt;</c> via <see cref="DotNetTestSettings.ProjectFile"/></li><li><c>--</c> via <see cref="DotNetTestSettings.RunSettings"/></li><li><c>--blame</c> via <see cref="DotNetTestSettings.BlameMode"/></li><li><c>--blame-crash</c> via <see cref="DotNetTestSettings.BlameCrash"/></li><li><c>--blame-crash-collect-always</c> via <see cref="DotNetTestSettings.BlameCrashCollectAlways"/></li><li><c>--blame-crash-dump-type</c> via <see cref="DotNetTestSettings.BlameCrashDumpType"/></li><li><c>--blame-hang</c> via <see cref="DotNetTestSettings.BlameHang"/></li><li><c>--blame-hang-dump-type</c> via <see cref="DotNetTestSettings.BlameHangDumpType"/></li><li><c>--blame-hang-timeout</c> via <see cref="DotNetTestSettings.BlameHangTimeout"/></li><li><c>--collect</c> via <see cref="DotNetTestSettings.DataCollector"/></li><li><c>--configuration</c> via <see cref="DotNetTestSettings.Configuration"/></li><li><c>--diag</c> via <see cref="DotNetTestSettings.DiagnosticsFile"/></li><li><c>--disable-parallel</c> via <see cref="DotNetTestSettings.DisableParallel"/></li><li><c>--filter</c> via <see cref="DotNetTestSettings.Filter"/></li><li><c>--force</c> via <see cref="DotNetTestSettings.Force"/></li><li><c>--force-evaluate</c> via <see cref="DotNetTestSettings.ForceEvaluate"/></li><li><c>--framework</c> via <see cref="DotNetTestSettings.Framework"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetTestSettings.IgnoreFailedSources"/></li><li><c>--list-tests</c> via <see cref="DotNetTestSettings.ListTests"/></li><li><c>--lock-file-path</c> via <see cref="DotNetTestSettings.LockFilePath"/></li><li><c>--locked-mode</c> via <see cref="DotNetTestSettings.LockedMode"/></li><li><c>--logger</c> via <see cref="DotNetTestSettings.Loggers"/></li><li><c>--no-build</c> via <see cref="DotNetTestSettings.NoBuild"/></li><li><c>--no-cache</c> via <see cref="DotNetTestSettings.NoCache"/></li><li><c>--no-dependencies</c> via <see cref="DotNetTestSettings.NoDependencies"/></li><li><c>--no-restore</c> via <see cref="DotNetTestSettings.NoRestore"/></li><li><c>--nologo</c> via <see cref="DotNetTestSettings.NoLogo"/></li><li><c>--output</c> via <see cref="DotNetTestSettings.Output"/></li><li><c>--packages</c> via <see cref="DotNetTestSettings.PackageDirectory"/></li><li><c>--results-directory</c> via <see cref="DotNetTestSettings.ResultsDirectory"/></li><li><c>--runtime</c> via <see cref="DotNetTestSettings.Runtime"/></li><li><c>--settings</c> via <see cref="DotNetTestSettings.SettingsFile"/></li><li><c>--source</c> via <see cref="DotNetTestSettings.Sources"/></li><li><c>--test-adapter-path</c> via <see cref="DotNetTestSettings.TestAdapterPath"/></li><li><c>--use-lock-file</c> via <see cref="DotNetTestSettings.UseLockFile"/></li><li><c>--verbosity</c> via <see cref="DotNetTestSettings.Verbosity"/></li><li><c>/property</c> via <see cref="DotNetTestSettings.Properties"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetTest(DotNetTestSettings options = null) => new DotNetTasks().Run<DotNetTestSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetTest(Nuke.Common.Tools.DotNet.DotNetTestSettings)"/>
    public static IReadOnlyCollection<Output> DotNetTest(Configure<DotNetTestSettings> configurator) => new DotNetTasks().Run<DotNetTestSettings>(configurator.Invoke(new DotNetTestSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetTest(Nuke.Common.Tools.DotNet.DotNetTestSettings)"/>
    public static IEnumerable<(DotNetTestSettings Settings, IReadOnlyCollection<Output> Output)> DotNetTest(CombinatorialConfigure<DotNetTestSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetTest, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet run</c> command provides a convenient option to run your application from the source code with one command. It's useful for fast iterative development from the command line. The command depends on the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build"><c>dotnet build</c></a> command to build the code. Any requirements for the build, such as that the project must be restored first, apply to <c>dotnet run</c> as well.</p><p>Output files are written into the default location, which is <c>bin/&lt;configuration&gt;/&lt;target&gt;</c>. For example if you have a <c>netcoreapp1.0</c> application and you run <c>dotnet run</c>, the output is placed in <c>bin/Debug/netcoreapp1.0</c>. Files are overwritten as needed. Temporary files are placed in the <c>obj</c> directory.</p><p>If the project specifies multiple frameworks, executing <c>dotnet run</c> results in an error unless the <c>-f|--framework &lt;FRAMEWORK&gt;</c> option is used to specify the framework.</p><p>The <c>dotnet run</c> command is used in the context of projects, not built assemblies. If you're trying to run a framework-dependent application DLL instead, you must use <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet">dotnet</a> without a command. For example, to run <c>myapp.dll</c>, use: <c>dotnet myapp.dll</c></p><p>For more information on the <c>dotnet</c> driver, see the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/index">.NET Core Command Line Tools (CLI)</a> topic.</p><p>In order to run the application, the <c>dotnet run</c> command resolves the dependencies of the application that are outside of the shared runtime from the NuGet cache. Because it uses cached dependencies, it's not recommended to use <c>dotnet run</c> to run applications in production. Instead, <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/index">create a deployment</a> using the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish"><c>dotnet publish</c></a> command and deploy the published output.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--</c> via <see cref="DotNetRunSettings.ApplicationArguments"/></li><li><c>--arch</c> via <see cref="DotNetRunSettings.Architecture"/></li><li><c>--configuration</c> via <see cref="DotNetRunSettings.Configuration"/></li><li><c>--disable-build-servers</c> via <see cref="DotNetRunSettings.DisableBuildServers"/></li><li><c>--disable-parallel</c> via <see cref="DotNetRunSettings.DisableParallel"/></li><li><c>--force</c> via <see cref="DotNetRunSettings.Force"/></li><li><c>--force-evaluate</c> via <see cref="DotNetRunSettings.ForceEvaluate"/></li><li><c>--framework</c> via <see cref="DotNetRunSettings.Framework"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetRunSettings.IgnoreFailedSources"/></li><li><c>--interactive</c> via <see cref="DotNetRunSettings.Interactive"/></li><li><c>--launch-profile</c> via <see cref="DotNetRunSettings.LaunchProfile"/></li><li><c>--lock-file-path</c> via <see cref="DotNetRunSettings.LockFilePath"/></li><li><c>--locked-mode</c> via <see cref="DotNetRunSettings.LockedMode"/></li><li><c>--no-build</c> via <see cref="DotNetRunSettings.NoBuild"/></li><li><c>--no-cache</c> via <see cref="DotNetRunSettings.NoCache"/></li><li><c>--no-dependencies</c> via <see cref="DotNetRunSettings.NoDependencies"/></li><li><c>--no-launch-profile</c> via <see cref="DotNetRunSettings.NoLaunchProfile"/></li><li><c>--no-restore</c> via <see cref="DotNetRunSettings.NoRestore"/></li><li><c>--no-self-contained</c> via <see cref="DotNetRunSettings.NoSelfContained"/></li><li><c>--os</c> via <see cref="DotNetRunSettings.OperatingSystem"/></li><li><c>--packages</c> via <see cref="DotNetRunSettings.PackageDirectory"/></li><li><c>--project</c> via <see cref="DotNetRunSettings.ProjectFile"/></li><li><c>--property</c> via <see cref="DotNetRunSettings.Properties"/></li><li><c>--runtime</c> via <see cref="DotNetRunSettings.Runtime"/></li><li><c>--self-contained</c> via <see cref="DotNetRunSettings.SelfContained"/></li><li><c>--source</c> via <see cref="DotNetRunSettings.Sources"/></li><li><c>--use-lock-file</c> via <see cref="DotNetRunSettings.UseLockFile"/></li><li><c>--verbosity</c> via <see cref="DotNetRunSettings.Verbosity"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetRun(DotNetRunSettings options = null) => new DotNetTasks().Run<DotNetRunSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetRun(Nuke.Common.Tools.DotNet.DotNetRunSettings)"/>
    public static IReadOnlyCollection<Output> DotNetRun(Configure<DotNetRunSettings> configurator) => new DotNetTasks().Run<DotNetRunSettings>(configurator.Invoke(new DotNetRunSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetRun(Nuke.Common.Tools.DotNet.DotNetRunSettings)"/>
    public static IEnumerable<(DotNetRunSettings Settings, IReadOnlyCollection<Output> Output)> DotNetRun(CombinatorialConfigure<DotNetRunSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetRun, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet restore</c> command uses NuGet to restore dependencies as well as project-specific tools that are specified in the project file. By default, the restoration of dependencies and tools are performed in parallel.</p><p>Starting with .NET Core 2.0, you don't have to run <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-restore"><c>dotnet restore</c></a> because it's run implicitly by all commands, such as <c>dotnet build</c> and <c>dotnet run</c>, that require a restore to occur. It's still a valid command in certain scenarios where doing an explicit restore makes sense, such as <a href="https://docs.microsoft.com/en-us/vsts/build-release/apps/aspnet/build-aspnet-core">continuous integration builds in Visual Studio Team Services</a> or in build systems that need to explicitly control the time at which the restore occurs.</p><p>In order to restore the dependencies, NuGet needs the feeds where the packages are located. Feeds are usually provided via the <em>NuGet.config</em> configuration file. A default configuration file is provided when the CLI tools are installed. You specify additional feeds by creating your own <em>NuGet.config</em> file in the project directory. You also specify additional feeds per invocation at a command prompt.</p><p>For dependencies, you specify where the restored packages are placed during the restore operation using the <c>--packages</c> argument. If not specified, the default NuGet package cache is used, which is found in the <c>.nuget/packages</c> directory in the user's home directory on all operating systems (for example, <em>/home/user1</em> on Linux or <em>C:\Users\user1</em> on Windows).</p><p>For project-specific tooling, <c>dotnet restore</c> first restores the package in which the tool is packed, and then proceeds to restore the tool's dependencies as specified in its project file.</p><p>The behavior of the <c>dotnet restore</c> command is affected by some of the settings in the <em>Nuget.Config</em> file, if present. For example, setting the <c>globalPackagesFolder</c> in <em>NuGet.Config</em> places the restored NuGet packages in the specified folder. This is an alternative to specifying the <c>--packages</c> option on the <c>dotnet restore</c> command. For more information, see the <a href="https://docs.microsoft.com/nuget/schema/nuget-config-file">NuGet.Config reference</a>.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;projectFile&gt;</c> via <see cref="DotNetRestoreSettings.ProjectFile"/></li><li><c>--configfile</c> via <see cref="DotNetRestoreSettings.ConfigFile"/></li><li><c>--disable-parallel</c> via <see cref="DotNetRestoreSettings.DisableParallel"/></li><li><c>--force</c> via <see cref="DotNetRestoreSettings.Force"/></li><li><c>--force-evaluate</c> via <see cref="DotNetRestoreSettings.ForceEvaluate"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetRestoreSettings.IgnoreFailedSources"/></li><li><c>--lock-file-path</c> via <see cref="DotNetRestoreSettings.LockFilePath"/></li><li><c>--locked-mode</c> via <see cref="DotNetRestoreSettings.LockedMode"/></li><li><c>--no-cache</c> via <see cref="DotNetRestoreSettings.NoCache"/></li><li><c>--no-dependencies</c> via <see cref="DotNetRestoreSettings.NoDependencies"/></li><li><c>--packages</c> via <see cref="DotNetRestoreSettings.PackageDirectory"/></li><li><c>--property</c> via <see cref="DotNetRestoreSettings.Properties"/></li><li><c>--runtime</c> via <see cref="DotNetRestoreSettings.Runtime"/></li><li><c>--source</c> via <see cref="DotNetRestoreSettings.Sources"/></li><li><c>--use-lock-file</c> via <see cref="DotNetRestoreSettings.UseLockFile"/></li><li><c>--verbosity</c> via <see cref="DotNetRestoreSettings.Verbosity"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetRestore(DotNetRestoreSettings options = null) => new DotNetTasks().Run<DotNetRestoreSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetRestore(Nuke.Common.Tools.DotNet.DotNetRestoreSettings)"/>
    public static IReadOnlyCollection<Output> DotNetRestore(Configure<DotNetRestoreSettings> configurator) => new DotNetTasks().Run<DotNetRestoreSettings>(configurator.Invoke(new DotNetRestoreSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetRestore(Nuke.Common.Tools.DotNet.DotNetRestoreSettings)"/>
    public static IEnumerable<(DotNetRestoreSettings Settings, IReadOnlyCollection<Output> Output)> DotNetRestore(CombinatorialConfigure<DotNetRestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetRestore, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet pack</c> command builds the project and creates NuGet packages. The result of this command is a NuGet package. If the <c>--include-symbols</c> option is present, another package containing the debug symbols is created.</p><p>NuGet dependencies of the packed project are added to the <em>.nuspec</em> file, so they're properly resolved when the package is installed. Project-to-project references aren't packaged inside the project. Currently, you must have a package per project if you have project-to-project dependencies.</p><p>By default, <c>dotnet pack</c> builds the project first. If you wish to avoid this behavior, pass the <c>--no-build</c> option. This is often useful in Continuous Integration (CI) build scenarios where you know the code was previously built.</p><p>You can provide MSBuild properties to the <c>dotnet pack</c> command for the packing process. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/csproj#nuget-metadata-properties">NuGet metadata properties</a> and the <a href="https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-command-line-reference">MSBuild Command-Line Reference</a>.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;project&gt;</c> via <see cref="DotNetPackSettings.Project"/></li><li><c>--configuration</c> via <see cref="DotNetPackSettings.Configuration"/></li><li><c>--disable-parallel</c> via <see cref="DotNetPackSettings.DisableParallel"/></li><li><c>--force</c> via <see cref="DotNetPackSettings.Force"/></li><li><c>--force-evaluate</c> via <see cref="DotNetPackSettings.ForceEvaluate"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetPackSettings.IgnoreFailedSources"/></li><li><c>--include-source</c> via <see cref="DotNetPackSettings.IncludeSource"/></li><li><c>--include-symbols</c> via <see cref="DotNetPackSettings.IncludeSymbols"/></li><li><c>--lock-file-path</c> via <see cref="DotNetPackSettings.LockFilePath"/></li><li><c>--locked-mode</c> via <see cref="DotNetPackSettings.LockedMode"/></li><li><c>--no-build</c> via <see cref="DotNetPackSettings.NoBuild"/></li><li><c>--no-cache</c> via <see cref="DotNetPackSettings.NoCache"/></li><li><c>--no-dependencies</c> via <see cref="DotNetPackSettings.NoDependencies"/></li><li><c>--no-restore</c> via <see cref="DotNetPackSettings.NoRestore"/></li><li><c>--nologo</c> via <see cref="DotNetPackSettings.NoLogo"/></li><li><c>--output</c> via <see cref="DotNetPackSettings.OutputDirectory"/></li><li><c>--packages</c> via <see cref="DotNetPackSettings.PackageDirectory"/></li><li><c>--property</c> via <see cref="DotNetPackSettings.Properties"/></li><li><c>--runtime</c> via <see cref="DotNetPackSettings.Runtime"/></li><li><c>--serviceable</c> via <see cref="DotNetPackSettings.Serviceable"/></li><li><c>--source</c> via <see cref="DotNetPackSettings.Sources"/></li><li><c>--use-lock-file</c> via <see cref="DotNetPackSettings.UseLockFile"/></li><li><c>--verbosity</c> via <see cref="DotNetPackSettings.Verbosity"/></li><li><c>--version-suffix</c> via <see cref="DotNetPackSettings.VersionSuffix"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetPack(DotNetPackSettings options = null) => new DotNetTasks().Run<DotNetPackSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetPack(Nuke.Common.Tools.DotNet.DotNetPackSettings)"/>
    public static IReadOnlyCollection<Output> DotNetPack(Configure<DotNetPackSettings> configurator) => new DotNetTasks().Run<DotNetPackSettings>(configurator.Invoke(new DotNetPackSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetPack(Nuke.Common.Tools.DotNet.DotNetPackSettings)"/>
    public static IEnumerable<(DotNetPackSettings Settings, IReadOnlyCollection<Output> Output)> DotNetPack(CombinatorialConfigure<DotNetPackSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetPack, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet build</c> command builds the project and its dependencies into a set of binaries. The binaries include the project's code in Intermediate Language (IL) files with a <em>.dll</em> extension and symbol files used for debugging with a <em>.pdb</em> extension. A dependencies JSON file (<em>*.deps.json</em>) is produced that lists the dependencies of the application. A <em>.runtimeconfig.json</em> file is produced, which specifies the shared runtime and its version for the application.</p><p>If the project has third-party dependencies, such as libraries from NuGet, they're resolved from the NuGet cache and aren't available with the project's built output. With that in mind, the product of <c>dotnet build</c>d isn't ready to be transferred to another machine to run. This is in contrast to the behavior of the .NET Framework in which building an executable project (an application) produces output that's runnable on any machine where the .NET Framework is installed. To have a similar experience with .NET Core, you use the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish"><c>dotnet publish</c></a> command. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/index">.NET Core Application Deployment</a>.</p><p>Building requires the <em>project.assets.json</em> file, which lists the dependencies of your application. The file is created <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-restore"><c>dotnet restore</c></a> is executed. Without the assets file in place, the tooling cannot resolve reference assemblies, which will result in errors. With .NET Core 1.x SDK, you needed to explicitily run the <c>dotnet restore</c> before running <c>dotnet build</c>. Starting with .NET Core 2.0 SDK, <c>dotnet restore</c> runs implicitily when you run <c>dotnet build</c>. If you want to disable implicit restore when running the build command, you can pass the <c>--no-restore</c> option.</p><p><c>dotnet build</c> uses MSBuild to build the project; thus, it supports both parallel and incremental builds. Refer to <a href="https://docs.microsoft.com/visualstudio/msbuild/incremental-builds">Incremental Builds</a> for more information.</p><p>In addition to its options, the <c>dotnet build</c> command accepts MSBuild options, such as <c>/p</c> for setting properties or <c>/l</c> to define a logger. Learn more about these options in the <a href="https://docs.microsoft.com/visualstudio/msbuild/msbuild-command-line-reference">MSBuild Command-Line Reference</a>.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;projectFile&gt;</c> via <see cref="DotNetBuildSettings.ProjectFile"/></li><li><c>--configuration</c> via <see cref="DotNetBuildSettings.Configuration"/></li><li><c>--disable-parallel</c> via <see cref="DotNetBuildSettings.DisableParallel"/></li><li><c>--force</c> via <see cref="DotNetBuildSettings.Force"/></li><li><c>--force-evaluate</c> via <see cref="DotNetBuildSettings.ForceEvaluate"/></li><li><c>--framework</c> via <see cref="DotNetBuildSettings.Framework"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetBuildSettings.IgnoreFailedSources"/></li><li><c>--lock-file-path</c> via <see cref="DotNetBuildSettings.LockFilePath"/></li><li><c>--locked-mode</c> via <see cref="DotNetBuildSettings.LockedMode"/></li><li><c>--no-cache</c> via <see cref="DotNetBuildSettings.NoCache"/></li><li><c>--no-dependencies</c> via <see cref="DotNetBuildSettings.NoDependencies"/></li><li><c>--no-incremental</c> via <see cref="DotNetBuildSettings.NoIncremental"/></li><li><c>--no-restore</c> via <see cref="DotNetBuildSettings.NoRestore"/></li><li><c>--nologo</c> via <see cref="DotNetBuildSettings.NoLogo"/></li><li><c>--output</c> via <see cref="DotNetBuildSettings.OutputDirectory"/></li><li><c>--packages</c> via <see cref="DotNetBuildSettings.PackageDirectory"/></li><li><c>--property</c> via <see cref="DotNetBuildSettings.Properties"/></li><li><c>--runtime</c> via <see cref="DotNetBuildSettings.Runtime"/></li><li><c>--self-contained</c> via <see cref="DotNetBuildSettings.SelfContained"/></li><li><c>--source</c> via <see cref="DotNetBuildSettings.Sources"/></li><li><c>--use-lock-file</c> via <see cref="DotNetBuildSettings.UseLockFile"/></li><li><c>--verbosity</c> via <see cref="DotNetBuildSettings.Verbosity"/></li><li><c>--version-suffix</c> via <see cref="DotNetBuildSettings.VersionSuffix"/></li><li><c>-bl</c> via <see cref="DotNetBuildSettings.BinaryLog"/></li><li><c>/logger</c> via <see cref="DotNetBuildSettings.Loggers"/></li><li><c>/noconsolelogger</c> via <see cref="DotNetBuildSettings.NoConsoleLogger"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetBuild(DotNetBuildSettings options = null) => new DotNetTasks().Run<DotNetBuildSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetBuild(Nuke.Common.Tools.DotNet.DotNetBuildSettings)"/>
    public static IReadOnlyCollection<Output> DotNetBuild(Configure<DotNetBuildSettings> configurator) => new DotNetTasks().Run<DotNetBuildSettings>(configurator.Invoke(new DotNetBuildSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetBuild(Nuke.Common.Tools.DotNet.DotNetBuildSettings)"/>
    public static IEnumerable<(DotNetBuildSettings Settings, IReadOnlyCollection<Output> Output)> DotNetBuild(CombinatorialConfigure<DotNetBuildSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetBuild, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet msbuild</c> command allows access to a fully functional MSBuild.<para/>The command has the exact same capabilities as the existing MSBuild command-line client for SDK-style projects only. The options are all the same. For more information about the available options, see the <a href="https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-command-line-reference">MSBuild command-line reference</a>.<para/>The <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build">dotnet build</a> command is equivalent to <c>dotnet msbuild -restore</c>. When you don't want to build the project and you have a specific target you want to run, use <c>dotnet build</c> or <c>dotnet msbuild</c> and specify the target.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;targetPath&gt;</c> via <see cref="DotNetMSBuildSettings.TargetPath"/></li><li><c>-bl</c> via <see cref="DotNetMSBuildSettings.BinaryLog"/></li><li><c>/detailedsummary</c> via <see cref="DotNetMSBuildSettings.DetailedSummary"/></li><li><c>/graphBuild</c> via <see cref="DotNetMSBuildSettings.GraphBuild"/></li><li><c>/logger</c> via <see cref="DotNetMSBuildSettings.Loggers"/></li><li><c>/maxcpucount</c> via <see cref="DotNetMSBuildSettings.MaxCpuCount"/></li><li><c>/noconsolelogger</c> via <see cref="DotNetMSBuildSettings.NoConsoleLogger"/></li><li><c>/nodeReuse</c> via <see cref="DotNetMSBuildSettings.NodeReuse"/></li><li><c>/nologo</c> via <see cref="DotNetMSBuildSettings.NoLogo"/></li><li><c>/property</c> via <see cref="DotNetMSBuildSettings.Properties"/></li><li><c>/property:Configuration</c> via <see cref="DotNetMSBuildSettings.Configuration"/></li><li><c>/restore</c> via <see cref="DotNetMSBuildSettings.Restore"/></li><li><c>/target</c> via <see cref="DotNetMSBuildSettings.Targets"/></li><li><c>/verbosity</c> via <see cref="DotNetMSBuildSettings.Verbosity"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetMSBuild(DotNetMSBuildSettings options = null) => new DotNetTasks().Run<DotNetMSBuildSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetMSBuild(Nuke.Common.Tools.DotNet.DotNetMSBuildSettings)"/>
    public static IReadOnlyCollection<Output> DotNetMSBuild(Configure<DotNetMSBuildSettings> configurator) => new DotNetTasks().Run<DotNetMSBuildSettings>(configurator.Invoke(new DotNetMSBuildSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetMSBuild(Nuke.Common.Tools.DotNet.DotNetMSBuildSettings)"/>
    public static IEnumerable<(DotNetMSBuildSettings Settings, IReadOnlyCollection<Output> Output)> DotNetMSBuild(CombinatorialConfigure<DotNetMSBuildSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetMSBuild, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet clean</c> command cleans the output of the previous build. It's implemented as an <a href="https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-targets">MSBuild target</a>, so the project is evaluated when the command is run. Only the outputs created during the build are cleaned. Both intermediate <em>(obj)</em> and final output <em>(bin)</em> folders are cleaned.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;project&gt;</c> via <see cref="DotNetCleanSettings.Project"/></li><li><c>--configuration</c> via <see cref="DotNetCleanSettings.Configuration"/></li><li><c>--framework</c> via <see cref="DotNetCleanSettings.Framework"/></li><li><c>--nologo</c> via <see cref="DotNetCleanSettings.NoLogo"/></li><li><c>--output</c> via <see cref="DotNetCleanSettings.Output"/></li><li><c>--property</c> via <see cref="DotNetCleanSettings.Properties"/></li><li><c>--runtime</c> via <see cref="DotNetCleanSettings.Runtime"/></li><li><c>--verbosity</c> via <see cref="DotNetCleanSettings.Verbosity"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetClean(DotNetCleanSettings options = null) => new DotNetTasks().Run<DotNetCleanSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetClean(Nuke.Common.Tools.DotNet.DotNetCleanSettings)"/>
    public static IReadOnlyCollection<Output> DotNetClean(Configure<DotNetCleanSettings> configurator) => new DotNetTasks().Run<DotNetCleanSettings>(configurator.Invoke(new DotNetCleanSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetClean(Nuke.Common.Tools.DotNet.DotNetCleanSettings)"/>
    public static IEnumerable<(DotNetCleanSettings Settings, IReadOnlyCollection<Output> Output)> DotNetClean(CombinatorialConfigure<DotNetCleanSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetClean, degreeOfParallelism, completeOnFailure);
    /// <summary><p><c>dotnet format</c> is a code formatter that applies style preferences to a project or solution. Preferences will be read from an *.editorconfig* file, if present, otherwise a default set of preferences will be used. For more information, see the <a href="https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#editorconfig">EditorConfig documentation</a></p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;project&gt;</c> via <see cref="DotNetFormatSettings.Project"/></li><li><c>--binarylog</c> via <see cref="DotNetFormatSettings.BinaryLog"/></li><li><c>--exclude</c> via <see cref="DotNetFormatSettings.Exclude"/></li><li><c>--include</c> via <see cref="DotNetFormatSettings.Include"/></li><li><c>--include-generated</c> via <see cref="DotNetFormatSettings.IncludeGenerated"/></li><li><c>--no-restore</c> via <see cref="DotNetFormatSettings.NoRestore"/></li><li><c>--property</c> via <see cref="DotNetFormatSettings.Properties"/></li><li><c>--report</c> via <see cref="DotNetFormatSettings.Report"/></li><li><c>--severity</c> via <see cref="DotNetFormatSettings.Severity"/></li><li><c>--verbosity</c> via <see cref="DotNetFormatSettings.Verbosity"/></li><li><c>--verify-no-changes</c> via <see cref="DotNetFormatSettings.VerifyNoChanges"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetFormat(DotNetFormatSettings options = null) => new DotNetTasks().Run<DotNetFormatSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetFormat(Nuke.Common.Tools.DotNet.DotNetFormatSettings)"/>
    public static IReadOnlyCollection<Output> DotNetFormat(Configure<DotNetFormatSettings> configurator) => new DotNetTasks().Run<DotNetFormatSettings>(configurator.Invoke(new DotNetFormatSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetFormat(Nuke.Common.Tools.DotNet.DotNetFormatSettings)"/>
    public static IEnumerable<(DotNetFormatSettings Settings, IReadOnlyCollection<Output> Output)> DotNetFormat(CombinatorialConfigure<DotNetFormatSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetFormat, degreeOfParallelism, completeOnFailure);
    /// <summary><p><c>dotnet publish</c> compiles the application, reads through its dependencies specified in the project file, and publishes the resulting set of files to a directory. The output will contain the following:<para/><ul><li>Intermediate Language (IL) code in an assembly with a <em>dll</em> extension.</li><li><em>.deps.json</em> file that contains all of the dependencies of the project.</li><li><em>.runtime.config.json</em> file that specifies the shared runtime that the application expects, as well as other configuration options for the runtime (for example, garbage collection type).</li><li>The application's dependencies. These are copied from the NuGet cache into the output folder.</li></ul><para/>The <c>dotnet publish</c> command's output is ready for deployment to a hosting system (for example, a server, PC, Mac, laptop) for execution and is the only officially supported way to prepare the application for deployment. Depending on the type of deployment that the project specifies, the hosting system may or may not have the .NET Core shared runtime installed on it. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/index">.NET Core Application Deployment</a>. For the directory structure of a published application, see <a href="https://docs.microsoft.com/en-us/aspnet/core/hosting/directory-structure">Directory structure</a>.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;project&gt;</c> via <see cref="DotNetPublishSettings.Project"/></li><li><c>--arch</c> via <see cref="DotNetPublishSettings.Architecture"/></li><li><c>--configuration</c> via <see cref="DotNetPublishSettings.Configuration"/></li><li><c>--disable-parallel</c> via <see cref="DotNetPublishSettings.DisableParallel"/></li><li><c>--force</c> via <see cref="DotNetPublishSettings.Force"/></li><li><c>--force-evaluate</c> via <see cref="DotNetPublishSettings.ForceEvaluate"/></li><li><c>--framework</c> via <see cref="DotNetPublishSettings.Framework"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetPublishSettings.IgnoreFailedSources"/></li><li><c>--lock-file-path</c> via <see cref="DotNetPublishSettings.LockFilePath"/></li><li><c>--locked-mode</c> via <see cref="DotNetPublishSettings.LockedMode"/></li><li><c>--manifest</c> via <see cref="DotNetPublishSettings.Manifest"/></li><li><c>--no-build</c> via <see cref="DotNetPublishSettings.NoBuild"/></li><li><c>--no-cache</c> via <see cref="DotNetPublishSettings.NoCache"/></li><li><c>--no-dependencies</c> via <see cref="DotNetPublishSettings.NoDependencies"/></li><li><c>--no-restore</c> via <see cref="DotNetPublishSettings.NoRestore"/></li><li><c>--nologo</c> via <see cref="DotNetPublishSettings.NoLogo"/></li><li><c>--os</c> via <see cref="DotNetPublishSettings.OperatingSystem"/></li><li><c>--output</c> via <see cref="DotNetPublishSettings.Output"/></li><li><c>--packages</c> via <see cref="DotNetPublishSettings.PackageDirectory"/></li><li><c>--property</c> via <see cref="DotNetPublishSettings.Properties"/></li><li><c>--runtime</c> via <see cref="DotNetPublishSettings.Runtime"/></li><li><c>--self-contained</c> via <see cref="DotNetPublishSettings.SelfContained"/></li><li><c>--source</c> via <see cref="DotNetPublishSettings.Sources"/></li><li><c>--use-lock-file</c> via <see cref="DotNetPublishSettings.UseLockFile"/></li><li><c>--verbosity</c> via <see cref="DotNetPublishSettings.Verbosity"/></li><li><c>--version-suffix</c> via <see cref="DotNetPublishSettings.VersionSuffix"/></li><li><c>/t</c> via <see cref="DotNetPublishSettings.Targets"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetPublish(DotNetPublishSettings options = null) => new DotNetTasks().Run<DotNetPublishSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetPublish(Nuke.Common.Tools.DotNet.DotNetPublishSettings)"/>
    public static IReadOnlyCollection<Output> DotNetPublish(Configure<DotNetPublishSettings> configurator) => new DotNetTasks().Run<DotNetPublishSettings>(configurator.Invoke(new DotNetPublishSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetPublish(Nuke.Common.Tools.DotNet.DotNetPublishSettings)"/>
    public static IEnumerable<(DotNetPublishSettings Settings, IReadOnlyCollection<Output> Output)> DotNetPublish(CombinatorialConfigure<DotNetPublishSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetPublish, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Pushes a package to the server and publishes it.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;targetPath&gt;</c> via <see cref="DotNetNuGetPushSettings.TargetPath"/></li><li><c>--api-key</c> via <see cref="DotNetNuGetPushSettings.ApiKey"/></li><li><c>--disable-buffering</c> via <see cref="DotNetNuGetPushSettings.DisableBuffering"/></li><li><c>--force-english-output</c> via <see cref="DotNetNuGetPushSettings.ForceEnglishOutput"/></li><li><c>--no-service-endpoint</c> via <see cref="DotNetNuGetPushSettings.NoServiceEndpoint"/></li><li><c>--no-symbols</c> via <see cref="DotNetNuGetPushSettings.NoSymbols"/></li><li><c>--skip-duplicate</c> via <see cref="DotNetNuGetPushSettings.SkipDuplicate"/></li><li><c>--source</c> via <see cref="DotNetNuGetPushSettings.Source"/></li><li><c>--symbol-api-key</c> via <see cref="DotNetNuGetPushSettings.SymbolApiKey"/></li><li><c>--symbol-source</c> via <see cref="DotNetNuGetPushSettings.SymbolSource"/></li><li><c>--timeout</c> via <see cref="DotNetNuGetPushSettings.Timeout"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetNuGetPush(DotNetNuGetPushSettings options = null) => new DotNetTasks().Run<DotNetNuGetPushSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetNuGetPush(Nuke.Common.Tools.DotNet.DotNetNuGetPushSettings)"/>
    public static IReadOnlyCollection<Output> DotNetNuGetPush(Configure<DotNetNuGetPushSettings> configurator) => new DotNetTasks().Run<DotNetNuGetPushSettings>(configurator.Invoke(new DotNetNuGetPushSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetNuGetPush(Nuke.Common.Tools.DotNet.DotNetNuGetPushSettings)"/>
    public static IEnumerable<(DotNetNuGetPushSettings Settings, IReadOnlyCollection<Output> Output)> DotNetNuGetPush(CombinatorialConfigure<DotNetNuGetPushSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetNuGetPush, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Adds a NuGet source.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;source&gt;</c> via <see cref="DotNetNuGetAddSourceSettings.Source"/></li><li><c>--configfile</c> via <see cref="DotNetNuGetAddSourceSettings.ConfigFile"/></li><li><c>--name</c> via <see cref="DotNetNuGetAddSourceSettings.Name"/></li><li><c>--password</c> via <see cref="DotNetNuGetAddSourceSettings.Password"/></li><li><c>--store-password-in-clear-text</c> via <see cref="DotNetNuGetAddSourceSettings.StorePasswordInClearText"/></li><li><c>--username</c> via <see cref="DotNetNuGetAddSourceSettings.Username"/></li><li><c>--valid-authentication-types</c> via <see cref="DotNetNuGetAddSourceSettings.ValidAuthenticationTypes"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetNuGetAddSource(DotNetNuGetAddSourceSettings options = null) => new DotNetTasks().Run<DotNetNuGetAddSourceSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetNuGetAddSource(Nuke.Common.Tools.DotNet.DotNetNuGetAddSourceSettings)"/>
    public static IReadOnlyCollection<Output> DotNetNuGetAddSource(Configure<DotNetNuGetAddSourceSettings> configurator) => new DotNetTasks().Run<DotNetNuGetAddSourceSettings>(configurator.Invoke(new DotNetNuGetAddSourceSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetNuGetAddSource(Nuke.Common.Tools.DotNet.DotNetNuGetAddSourceSettings)"/>
    public static IEnumerable<(DotNetNuGetAddSourceSettings Settings, IReadOnlyCollection<Output> Output)> DotNetNuGetAddSource(CombinatorialConfigure<DotNetNuGetAddSourceSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetNuGetAddSource, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Updates a NuGet source.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;name&gt;</c> via <see cref="DotNetNuGetUpdateSourceSettings.Name"/></li><li><c>--configfile</c> via <see cref="DotNetNuGetUpdateSourceSettings.ConfigFile"/></li><li><c>--password</c> via <see cref="DotNetNuGetUpdateSourceSettings.Password"/></li><li><c>--source</c> via <see cref="DotNetNuGetUpdateSourceSettings.Source"/></li><li><c>--store-password-in-clear-text</c> via <see cref="DotNetNuGetUpdateSourceSettings.StorePasswordInClearText"/></li><li><c>--username</c> via <see cref="DotNetNuGetUpdateSourceSettings.Username"/></li><li><c>--valid-authentication-types</c> via <see cref="DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetNuGetUpdateSource(DotNetNuGetUpdateSourceSettings options = null) => new DotNetTasks().Run<DotNetNuGetUpdateSourceSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetNuGetUpdateSource(Nuke.Common.Tools.DotNet.DotNetNuGetUpdateSourceSettings)"/>
    public static IReadOnlyCollection<Output> DotNetNuGetUpdateSource(Configure<DotNetNuGetUpdateSourceSettings> configurator) => new DotNetTasks().Run<DotNetNuGetUpdateSourceSettings>(configurator.Invoke(new DotNetNuGetUpdateSourceSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetNuGetUpdateSource(Nuke.Common.Tools.DotNet.DotNetNuGetUpdateSourceSettings)"/>
    public static IEnumerable<(DotNetNuGetUpdateSourceSettings Settings, IReadOnlyCollection<Output> Output)> DotNetNuGetUpdateSource(CombinatorialConfigure<DotNetNuGetUpdateSourceSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetNuGetUpdateSource, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet tool install</c> command provides a way for you to install .NET Core Global Tools on your machine. To use the command, you either have to specify that you want a user-wide installation using the <c>--global</c> option or you specify a path to install it using the <c>--tool-path</c> option.<para/>Global Tools are installed in the following directories by default when you specify the <c>-g</c> (or <c>--global</c>) option:<ul><li>Linux/macOS: <c>$HOME/.dotnet/tools</c></li><li>Windows: <c>%USERPROFILE%\.dotnet\tools</c></li></ul></p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;packageName&gt;</c> via <see cref="DotNetToolInstallSettings.PackageName"/></li><li><c>--add-source</c> via <see cref="DotNetToolInstallSettings.Sources"/></li><li><c>--configfile</c> via <see cref="DotNetToolInstallSettings.ConfigFile"/></li><li><c>--framework</c> via <see cref="DotNetToolInstallSettings.Framework"/></li><li><c>--global</c> via <see cref="DotNetToolInstallSettings.Global"/></li><li><c>--tool-path</c> via <see cref="DotNetToolInstallSettings.ToolInstallationPath"/></li><li><c>--verbosity</c> via <see cref="DotNetToolInstallSettings.Verbosity"/></li><li><c>--version</c> via <see cref="DotNetToolInstallSettings.Version"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetToolInstall(DotNetToolInstallSettings options = null) => new DotNetTasks().Run<DotNetToolInstallSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetToolInstall(Nuke.Common.Tools.DotNet.DotNetToolInstallSettings)"/>
    public static IReadOnlyCollection<Output> DotNetToolInstall(Configure<DotNetToolInstallSettings> configurator) => new DotNetTasks().Run<DotNetToolInstallSettings>(configurator.Invoke(new DotNetToolInstallSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetToolInstall(Nuke.Common.Tools.DotNet.DotNetToolInstallSettings)"/>
    public static IEnumerable<(DotNetToolInstallSettings Settings, IReadOnlyCollection<Output> Output)> DotNetToolInstall(CombinatorialConfigure<DotNetToolInstallSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetToolInstall, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet tool restore</c> command finds the tool manifest file that is in scope for the current directory and installs the tools that are listed in it.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--add-source</c> via <see cref="DotNetToolRestoreSettings.Sources"/></li><li><c>--configfile</c> via <see cref="DotNetToolRestoreSettings.ConfigFile"/></li><li><c>--disable-parallel</c> via <see cref="DotNetToolRestoreSettings.DisableParallel"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetToolRestoreSettings.IgnoreFailedSources"/></li><li><c>--interactive</c> via <see cref="DotNetToolRestoreSettings.Interactive"/></li><li><c>--no-cache</c> via <see cref="DotNetToolRestoreSettings.NoCache"/></li><li><c>--tool-manifest</c> via <see cref="DotNetToolRestoreSettings.ToolManifest"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetToolRestore(DotNetToolRestoreSettings options = null) => new DotNetTasks().Run<DotNetToolRestoreSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetToolRestore(Nuke.Common.Tools.DotNet.DotNetToolRestoreSettings)"/>
    public static IReadOnlyCollection<Output> DotNetToolRestore(Configure<DotNetToolRestoreSettings> configurator) => new DotNetTasks().Run<DotNetToolRestoreSettings>(configurator.Invoke(new DotNetToolRestoreSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetToolRestore(Nuke.Common.Tools.DotNet.DotNetToolRestoreSettings)"/>
    public static IEnumerable<(DotNetToolRestoreSettings Settings, IReadOnlyCollection<Output> Output)> DotNetToolRestore(CombinatorialConfigure<DotNetToolRestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetToolRestore, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet tool uninstall</c> command provides a way for you to uninstall .NET Core Global Tools from your machine. To use the command, you either have to specify that you want to remove a user-wide tool using the <c>--global</c> option or specify a path to where the tool is installed using the <c>--tool-path</c> option.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;packageName&gt;</c> via <see cref="DotNetToolUninstallSettings.PackageName"/></li><li><c>--global</c> via <see cref="DotNetToolUninstallSettings.Global"/></li><li><c>--tool-path</c> via <see cref="DotNetToolUninstallSettings.ToolInstallationPath"/></li><li><c>--verbosity</c> via <see cref="DotNetToolUninstallSettings.Verbosity"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetToolUninstall(DotNetToolUninstallSettings options = null) => new DotNetTasks().Run<DotNetToolUninstallSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetToolUninstall(Nuke.Common.Tools.DotNet.DotNetToolUninstallSettings)"/>
    public static IReadOnlyCollection<Output> DotNetToolUninstall(Configure<DotNetToolUninstallSettings> configurator) => new DotNetTasks().Run<DotNetToolUninstallSettings>(configurator.Invoke(new DotNetToolUninstallSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetToolUninstall(Nuke.Common.Tools.DotNet.DotNetToolUninstallSettings)"/>
    public static IEnumerable<(DotNetToolUninstallSettings Settings, IReadOnlyCollection<Output> Output)> DotNetToolUninstall(CombinatorialConfigure<DotNetToolUninstallSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetToolUninstall, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet tool update</c> command provides a way for you to update .NET Core Global Tools on your machine to the latest stable version of the package. The command uninstalls and re-installs a tool, effectively updating it. To use the command, you either have to specify that you want to update a tool from a user-wide installation using the <c>--global</c> option or specify a path to where the tool is installed using the <c>--tool-path</c> option.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;packageName&gt;</c> via <see cref="DotNetToolUpdateSettings.PackageName"/></li><li><c>--add-source</c> via <see cref="DotNetToolUpdateSettings.Sources"/></li><li><c>--configfile</c> via <see cref="DotNetToolUpdateSettings.ConfigFile"/></li><li><c>--framework</c> via <see cref="DotNetToolUpdateSettings.Framework"/></li><li><c>--global</c> via <see cref="DotNetToolUpdateSettings.Global"/></li><li><c>--tool-path</c> via <see cref="DotNetToolUpdateSettings.ToolInstallationPath"/></li><li><c>--verbosity</c> via <see cref="DotNetToolUpdateSettings.Verbosity"/></li><li><c>--version</c> via <see cref="DotNetToolUpdateSettings.Version"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetToolUpdate(DotNetToolUpdateSettings options = null) => new DotNetTasks().Run<DotNetToolUpdateSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetToolUpdate(Nuke.Common.Tools.DotNet.DotNetToolUpdateSettings)"/>
    public static IReadOnlyCollection<Output> DotNetToolUpdate(Configure<DotNetToolUpdateSettings> configurator) => new DotNetTasks().Run<DotNetToolUpdateSettings>(configurator.Invoke(new DotNetToolUpdateSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetToolUpdate(Nuke.Common.Tools.DotNet.DotNetToolUpdateSettings)"/>
    public static IEnumerable<(DotNetToolUpdateSettings Settings, IReadOnlyCollection<Output> Output)> DotNetToolUpdate(CombinatorialConfigure<DotNetToolUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetToolUpdate, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet workload install</c> command installs one or more optional workloads. Optional workloads can be installed on top of the .NET SDK to provide support for various application types, such as .NET MAUI and Blazor WebAssembly AOT.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;workloadId&gt;</c> via <see cref="DotNetWorkloadInstallSettings.WorkloadId"/></li><li><c>--configFile</c> via <see cref="DotNetWorkloadInstallSettings.ConfigFile"/></li><li><c>--disable-parallel</c> via <see cref="DotNetWorkloadInstallSettings.DisableParallel"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetWorkloadInstallSettings.IgnoreFailedSources"/></li><li><c>--include-previews</c> via <see cref="DotNetWorkloadInstallSettings.IncludePreviews"/></li><li><c>--interactive</c> via <see cref="DotNetWorkloadInstallSettings.Interactive"/></li><li><c>--no-cache</c> via <see cref="DotNetWorkloadInstallSettings.NoCache"/></li><li><c>--skip-manifest-update</c> via <see cref="DotNetWorkloadInstallSettings.SkipManifestUpdate"/></li><li><c>--skip-sign-check</c> via <see cref="DotNetWorkloadInstallSettings.SkipSignCheck"/></li><li><c>--source</c> via <see cref="DotNetWorkloadInstallSettings.Source"/></li><li><c>--temp-dir</c> via <see cref="DotNetWorkloadInstallSettings.TempDir"/></li><li><c>--verbosity</c> via <see cref="DotNetWorkloadInstallSettings.Verbosity"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetWorkloadInstall(DotNetWorkloadInstallSettings options = null) => new DotNetTasks().Run<DotNetWorkloadInstallSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadInstall(Nuke.Common.Tools.DotNet.DotNetWorkloadInstallSettings)"/>
    public static IReadOnlyCollection<Output> DotNetWorkloadInstall(Configure<DotNetWorkloadInstallSettings> configurator) => new DotNetTasks().Run<DotNetWorkloadInstallSettings>(configurator.Invoke(new DotNetWorkloadInstallSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadInstall(Nuke.Common.Tools.DotNet.DotNetWorkloadInstallSettings)"/>
    public static IEnumerable<(DotNetWorkloadInstallSettings Settings, IReadOnlyCollection<Output> Output)> DotNetWorkloadInstall(CombinatorialConfigure<DotNetWorkloadInstallSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetWorkloadInstall, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet workload uninstall</c> command uninstalls one or more workloads.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;workloadId&gt;</c> via <see cref="DotNetWorkloadUninstallSettings.WorkloadId"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetWorkloadUninstall(DotNetWorkloadUninstallSettings options = null) => new DotNetTasks().Run<DotNetWorkloadUninstallSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadUninstall(Nuke.Common.Tools.DotNet.DotNetWorkloadUninstallSettings)"/>
    public static IReadOnlyCollection<Output> DotNetWorkloadUninstall(Configure<DotNetWorkloadUninstallSettings> configurator) => new DotNetTasks().Run<DotNetWorkloadUninstallSettings>(configurator.Invoke(new DotNetWorkloadUninstallSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadUninstall(Nuke.Common.Tools.DotNet.DotNetWorkloadUninstallSettings)"/>
    public static IEnumerable<(DotNetWorkloadUninstallSettings Settings, IReadOnlyCollection<Output> Output)> DotNetWorkloadUninstall(CombinatorialConfigure<DotNetWorkloadUninstallSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetWorkloadUninstall, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet workload restore</c> command analyzes a project or solution to determine which workloads it needs, then installs any workloads that are missing.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;project&gt;</c> via <see cref="DotNetWorkloadRestoreSettings.Project"/></li><li><c>--configFile</c> via <see cref="DotNetWorkloadRestoreSettings.ConfigFile"/></li><li><c>--disable-parallel</c> via <see cref="DotNetWorkloadRestoreSettings.DisableParallel"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetWorkloadRestoreSettings.IgnoreFailedSources"/></li><li><c>--include-previews</c> via <see cref="DotNetWorkloadRestoreSettings.IncludePreviews"/></li><li><c>--interactive</c> via <see cref="DotNetWorkloadRestoreSettings.Interactive"/></li><li><c>--no-cache</c> via <see cref="DotNetWorkloadRestoreSettings.NoCache"/></li><li><c>--skip-manifest-update</c> via <see cref="DotNetWorkloadRestoreSettings.SkipManifestUpdate"/></li><li><c>--skip-sign-check</c> via <see cref="DotNetWorkloadRestoreSettings.SkipSignCheck"/></li><li><c>--source</c> via <see cref="DotNetWorkloadRestoreSettings.Source"/></li><li><c>--temp-dir</c> via <see cref="DotNetWorkloadRestoreSettings.TempDir"/></li><li><c>--verbosity</c> via <see cref="DotNetWorkloadRestoreSettings.Verbosity"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetWorkloadRestore(DotNetWorkloadRestoreSettings options = null) => new DotNetTasks().Run<DotNetWorkloadRestoreSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadRestore(Nuke.Common.Tools.DotNet.DotNetWorkloadRestoreSettings)"/>
    public static IReadOnlyCollection<Output> DotNetWorkloadRestore(Configure<DotNetWorkloadRestoreSettings> configurator) => new DotNetTasks().Run<DotNetWorkloadRestoreSettings>(configurator.Invoke(new DotNetWorkloadRestoreSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadRestore(Nuke.Common.Tools.DotNet.DotNetWorkloadRestoreSettings)"/>
    public static IEnumerable<(DotNetWorkloadRestoreSettings Settings, IReadOnlyCollection<Output> Output)> DotNetWorkloadRestore(CombinatorialConfigure<DotNetWorkloadRestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetWorkloadRestore, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet workload update</c> command updates all installed workloads to the newest available versions. It queries Nuget.org for updated workload manifests. It then updates local manifests, downloads new versions of the installed workloads, and removes all old versions of each workload.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--advertising-manifests-only</c> via <see cref="DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly"/></li><li><c>--configFile</c> via <see cref="DotNetWorkloadUpdateSettings.ConfigFile"/></li><li><c>--disable-parallel</c> via <see cref="DotNetWorkloadUpdateSettings.DisableParallel"/></li><li><c>--from-previous-sdk</c> via <see cref="DotNetWorkloadUpdateSettings.FromPreviousSdk"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetWorkloadUpdateSettings.IgnoreFailedSources"/></li><li><c>--include-previews</c> via <see cref="DotNetWorkloadUpdateSettings.IncludePreviews"/></li><li><c>--interactive</c> via <see cref="DotNetWorkloadUpdateSettings.Interactive"/></li><li><c>--no-cache</c> via <see cref="DotNetWorkloadUpdateSettings.NoCache"/></li><li><c>--skip-sign-check</c> via <see cref="DotNetWorkloadUpdateSettings.SkipSignCheck"/></li><li><c>--source</c> via <see cref="DotNetWorkloadUpdateSettings.Source"/></li><li><c>--temp-dir</c> via <see cref="DotNetWorkloadUpdateSettings.TempDir"/></li><li><c>--verbosity</c> via <see cref="DotNetWorkloadUpdateSettings.Verbosity"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetWorkloadUpdate(DotNetWorkloadUpdateSettings options = null) => new DotNetTasks().Run<DotNetWorkloadUpdateSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadUpdate(Nuke.Common.Tools.DotNet.DotNetWorkloadUpdateSettings)"/>
    public static IReadOnlyCollection<Output> DotNetWorkloadUpdate(Configure<DotNetWorkloadUpdateSettings> configurator) => new DotNetTasks().Run<DotNetWorkloadUpdateSettings>(configurator.Invoke(new DotNetWorkloadUpdateSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadUpdate(Nuke.Common.Tools.DotNet.DotNetWorkloadUpdateSettings)"/>
    public static IEnumerable<(DotNetWorkloadUpdateSettings Settings, IReadOnlyCollection<Output> Output)> DotNetWorkloadUpdate(CombinatorialConfigure<DotNetWorkloadUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetWorkloadUpdate, degreeOfParallelism, completeOnFailure);
    /// <summary><p>The <c>dotnet workload repair</c>  command reinstalls all installed workloads. Workloads are made up of multiple workload packs and it's possible to get into a state where some installed successfully but others didn't. For example, a dotnet workload install command might not finish installing because of a dropped internet connection.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--configFile</c> via <see cref="DotNetWorkloadRepairSettings.ConfigFile"/></li><li><c>--disable-parallel</c> via <see cref="DotNetWorkloadRepairSettings.DisableParallel"/></li><li><c>--ignore-failed-sources</c> via <see cref="DotNetWorkloadRepairSettings.IgnoreFailedSources"/></li><li><c>--include-previews</c> via <see cref="DotNetWorkloadRepairSettings.IncludePreviews"/></li><li><c>--interactive</c> via <see cref="DotNetWorkloadRepairSettings.Interactive"/></li><li><c>--no-cache</c> via <see cref="DotNetWorkloadRepairSettings.NoCache"/></li><li><c>--skip-sign-check</c> via <see cref="DotNetWorkloadRepairSettings.SkipSignCheck"/></li><li><c>--source</c> via <see cref="DotNetWorkloadRepairSettings.Source"/></li><li><c>--temp-dir</c> via <see cref="DotNetWorkloadRepairSettings.TempDir"/></li><li><c>--verbosity</c> via <see cref="DotNetWorkloadRepairSettings.Verbosity"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> DotNetWorkloadRepair(DotNetWorkloadRepairSettings options = null) => new DotNetTasks().Run<DotNetWorkloadRepairSettings>(options);
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadRepair(Nuke.Common.Tools.DotNet.DotNetWorkloadRepairSettings)"/>
    public static IReadOnlyCollection<Output> DotNetWorkloadRepair(Configure<DotNetWorkloadRepairSettings> configurator) => new DotNetTasks().Run<DotNetWorkloadRepairSettings>(configurator.Invoke(new DotNetWorkloadRepairSettings()));
    /// <inheritdoc cref="DotNetTasks.DotNetWorkloadRepair(Nuke.Common.Tools.DotNet.DotNetWorkloadRepairSettings)"/>
    public static IEnumerable<(DotNetWorkloadRepairSettings Settings, IReadOnlyCollection<Output> Output)> DotNetWorkloadRepair(CombinatorialConfigure<DotNetWorkloadRepairSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(DotNetWorkloadRepair, degreeOfParallelism, completeOnFailure);
}
#region DotNetTestSettings
/// <inheritdoc cref="DotNetTasks.DotNetTest(Nuke.Common.Tools.DotNet.DotNetTestSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetTest), Arguments = "test")]
public partial class DotNetTestSettings : ToolOptions
{
    /// <summary>Specifies a path to the test project. If omitted, it defaults to current directory.</summary>
    [Argument(Format = "{value}", Position = 1)] public string ProjectFile => Get<string>(() => ProjectFile);
    /// <summary>Use the custom test adapters from the specified path in the test run.</summary>
    [Argument(Format = "--test-adapter-path {value}")] public string TestAdapterPath => Get<string>(() => TestAdapterPath);
    /// <summary>Configuration under which to build. The default value is <c>Debug</c>, but your project's configuration could override this default SDK setting.</summary>
    [Argument(Format = "--configuration {value}")] public string Configuration => Get<string>(() => Configuration);
    /// <summary>Enables data collector for the test run. For more information, see <a href="https://aka.ms/vstest-collect">Monitor and analyze test run</a>.</summary>
    [Argument(Format = "--collect {value}")] public string DataCollector => Get<string>(() => DataCollector);
    /// <summary>Enables diagnostic mode for the test platform and write diagnostic messages to the specified file.</summary>
    [Argument(Format = "--diag {value}")] public string DiagnosticsFile => Get<string>(() => DiagnosticsFile);
    /// <summary>Looks for test binaries for a specific <a href="https://docs.microsoft.com/en-us/dotnet/standard/frameworks">framework</a>.</summary>
    [Argument(Format = "--framework {value}")] public string Framework => Get<string>(() => Framework);
    /// <summary>Filters out tests in the current project using the given expression. For more information, see the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test#filter-option-details">Filter option details</a> section. For additional information and examples on how to use selective unit test filtering, see <a href="https://docs.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests">Running selective unit tests</a>.</summary>
    [Argument(Format = "--filter {value}")] public string Filter => Get<string>(() => Filter);
    /// <summary>Specifies a logger for test results. Specify the parameter multiple times to enable multiple loggers.</summary>
    [Argument(Format = "--logger {value}")] public IReadOnlyList<string> Loggers => Get<List<string>>(() => Loggers);
    /// <summary>Does not build the test project prior to running it.</summary>
    [Argument(Format = "--no-build")] public bool? NoBuild => Get<bool?>(() => NoBuild);
    /// <summary>Doesn't perform an implicit restore when running the command.</summary>
    [Argument(Format = "--no-restore")] public bool? NoRestore => Get<bool?>(() => NoRestore);
    /// <summary>Directory in which to find the binaries to run.</summary>
    [Argument(Format = "--output {value}")] public string Output => Get<string>(() => Output);
    /// <summary>The directory where the test results are going to be placed. The specified directory will be created if it doesn't exist.</summary>
    [Argument(Format = "--results-directory {value}")] public string ResultsDirectory => Get<string>(() => ResultsDirectory);
    /// <summary>Settings to use when running tests.</summary>
    [Argument(Format = "--settings {value}")] public string SettingsFile => Get<string>(() => SettingsFile);
    /// <summary>List all of the discovered tests in the current project.</summary>
    [Argument(Format = "--list-tests")] public bool? ListTests => Get<bool?>(() => ListTests);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary><p>Set or override the specified project-level properties, where name is the property name and value is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:</p><p><c>/property:WarningLevel=2;OutDir=bin\Debug</c></p></summary>
    [Argument(Format = "/property:{key}={value}")] public IReadOnlyDictionary<string, object> Properties => Get<Dictionary<string, object>>(() => Properties);
    /// <summary>Runs the tests in blame mode. This option is helpful in isolating the problematic tests causing test host to crash. It creates an output file in the current directory as <em>Sequence.xml</em> that captures the order of tests execution before the crash.</summary>
    [Argument(Format = "--blame")] public bool? BlameMode => Get<bool?>(() => BlameMode);
    /// <summary><p>Runs the tests in blame mode and collects a crash dump when the test host exits unexpectedly. This option depends on the version of .NET used, the type of error, and the operating system.</p><p>For exceptions in managed code, a dump will be automatically collected on .NET 5.0 and later versions. It will generate a dump for testhost or any child process that also ran on .NET 5.0 and crashed. Crashes in native code will not generate a dump. This option works on Windows, macOS, and Linux.</p><p>Crash dumps in native code, or when using .NET Core 3.1 or earlier versions, can only be collected on Windows, by using Procdump. A directory that contains procdump.exe and procdump64.exe must be in the PATH or PROCDUMP_PATH environment variable. <a href="https://docs.microsoft.com/en-us/sysinternals/downloads/procdump">Download the tools</a>. Implies <em>--blame</em>.</p><p>To collect a crash dump from a native application running on .NET 5.0 or later, the usage of Procdump can be forced by setting the <em>VSTEST_DUMP_FORCEPROCDUMP</em> environment variable to <em>1</em>.</p></summary>
    [Argument(Format = "--blame-crash")] public bool? BlameCrash => Get<bool?>(() => BlameCrash);
    /// <summary>The type of crash dump to be collected. Implies <em>--blame-crash</em>.</summary>
    [Argument(Format = "--blame-crash-dump-type {value}")] public string BlameCrashDumpType => Get<string>(() => BlameCrashDumpType);
    /// <summary>Collects a crash dump on expected as well as unexpected test host exit.</summary>
    [Argument(Format = "--blame-crash-collect-always")] public bool? BlameCrashCollectAlways => Get<bool?>(() => BlameCrashCollectAlways);
    /// <summary>Run the tests in blame mode and collects a hang dump when a test exceeds the given timeout.</summary>
    [Argument(Format = "--blame-hang")] public bool? BlameHang => Get<bool?>(() => BlameHang);
    /// <summary>The type of crash dump to be collected. It should be <em>full</em>, <em>mini</em>, or <em>none</em>. When <em>none</em> is specified, test host is terminated on timeout, but no dump is collected. Implies <em>--blame-hang</em>.</summary>
    [Argument(Format = "--blame-hang-dump-type {value}")] public string BlameHangDumpType => Get<string>(() => BlameHangDumpType);
    /// <summary><p>Per-test timeout, after which a hang dump is triggered and the test host process and all of its child processes are dumped and terminated. The timeout value is specified in one of the following formats:</p><p><ul><li>1.5h, 1.5hour, 1.5hours</li><li>90m, 90min, 90minute, 90minutes</li><li>5400s, 5400sec, 5400second, 5400seconds</li><li>5400000ms, 5400000mil, 5400000millisecond, 5400000milliseconds</li></ul></p><p>When no unit is used (for example, 5400000), the value is assumed to be in milliseconds. When used together with data driven tests, the timeout behavior depends on the test adapter used. For xUnit and NUnit the timeout is renewed after every test case. For MSTest, the timeout is used for all test cases. This option is supported on Windows with netcoreapp2.1 and later, on Linux with netcoreapp3.1 and later, and on macOS with net5.0 or later. Implies <em>--blame</em> and <em>--blame-hang</em>.</p></summary>
    [Argument(Format = "--blame-hang-timeout {value}")] public string BlameHangTimeout => Get<string>(() => BlameHangTimeout);
    /// <summary></summary>
    [Argument(Format = "-- {key}={value}", Position = -1, Separator = " ")] public IReadOnlyDictionary<string, object> RunSettings => Get<Dictionary<string, object>>(() => RunSettings);
    /// <summary>Run test(s), without displaying Microsoft Testplatform banner. Available since .NET Core 3.0 SDK.</summary>
    [Argument(Format = "--nologo")] public bool? NoLogo => Get<bool?>(() => NoLogo);
    /// <summary>Disables restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Forces all dependencies to be resolved even if the last restore was successful. This is equivalent to deleting the <em>project.assets.json</em> file.</summary>
    [Argument(Format = "--force")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Only warn about failed sources if there are packages meeting the version requirement.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Specifies to not cache packages and HTTP requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>When restoring a project with project-to-project (P2P) references, restore the root project and not the references.</summary>
    [Argument(Format = "--no-dependencies")] public bool? NoDependencies => Get<bool?>(() => NoDependencies);
    /// <summary>Specifies the directory for restored packages.</summary>
    [Argument(Format = "--packages {value}")] public string PackageDirectory => Get<string>(() => PackageDirectory);
    /// <summary>Specifies a NuGet package source to use during the restore operation. This overrides all of the sources specified in the <em>NuGet.config</em> file(s). Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public IReadOnlyList<string> Sources => Get<List<string>>(() => Sources);
    /// <summary>Enables project lock file to be generated and used with restore.</summary>
    [Argument(Format = "--use-lock-file")] public bool? UseLockFile => Get<bool?>(() => UseLockFile);
    /// <summary>Don't allow updating project lock file.</summary>
    [Argument(Format = "--locked-mode")] public bool? LockedMode => Get<bool?>(() => LockedMode);
    /// <summary>Output location where project lock file is written. By default, this is 'PROJECT_ROOT\packages.lock.json'.</summary>
    [Argument(Format = "--lock-file-path {value}")] public string LockFilePath => Get<string>(() => LockFilePath);
    /// <summary>Forces restore to reevaluate all dependencies even if a lock file already exists.</summary>
    [Argument(Format = "--force-evaluate")] public bool? ForceEvaluate => Get<bool?>(() => ForceEvaluate);
    /// <summary>Specifies a runtime for the package restore. This is used to restore packages for runtimes not explicitly listed in the <c>&lt;RuntimeIdentifiers&gt;</c> tag in the <em>.csproj</em> file. For a list of Runtime Identifiers (RIDs), see the <a href="https://docs.microsoft.com/en-us/dotnet/core/rid-catalog">RID catalog</a>. Provide multiple RIDs by specifying this option multiple times.</summary>
    [Argument(Format = "--runtime {value}")] public string Runtime => Get<string>(() => Runtime);
}
#endregion
#region DotNetRunSettings
/// <inheritdoc cref="DotNetTasks.DotNetRun(Nuke.Common.Tools.DotNet.DotNetRunSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetRun), Arguments = "run")]
public partial class DotNetRunSettings : ToolOptions
{
    /// <summary>Specifies the target architecture. This is a shorthand syntax for setting the <a href="https://learn.microsoft.com/en-us/dotnet/core/rid-catalog">Runtime Identifier (RID)</a>, where the provided value is combined with the default RID. For example, on a win-x64 machine, specifying --arch x86 sets the RID to win-x86. If you use this option, don't use the -r|--runtime option. Available since .NET 6 Preview 7.</summary>
    [Argument(Format = "--arch {value}")] public string Architecture => Get<string>(() => Architecture);
    /// <summary>Configuration to use for building the project. The default value is Debug.</summary>
    [Argument(Format = "--configuration {value}")] public string Configuration => Get<string>(() => Configuration);
    /// <summary>Force the command to ignore any persistent build servers. This option provides a consistent way to disable all use of build caching, which forces a build from scratch. A build that doesn't rely on caches is useful when the caches might be corrupted or incorrect for some reason. Available since .NET 7 SDK.</summary>
    [Argument(Format = "--disable-build-servers")] public bool? DisableBuildServers => Get<bool?>(() => DisableBuildServers);
    /// <summary>Builds and runs the app using the specified framework. The framework must be specified in the project file.</summary>
    [Argument(Format = "--framework {value}")] public string Framework => Get<string>(() => Framework);
    /// <summary>The name of the launch profile (if any) to use when launching the application. Launch profiles are defined in the <em>launchSettings.json</em> file and are typically called <c>Development</c>, <c>Staging</c> and <c>Production</c>. For more information, see <a href="https://docs.microsoft.com/en-us/aspnetcore/fundamentals/environments">Working with multiple environments</a>.</summary>
    [Argument(Format = "--launch-profile {value}")] public string LaunchProfile => Get<string>(() => LaunchProfile);
    /// <summary>Allows the command to stop and wait for user input or action. For example, to complete authentication. Available since .NET Core 3.0 SDK.</summary>
    [Argument(Format = "--interactive")] public bool? Interactive => Get<bool?>(() => Interactive);
    /// <summary>Doesn't build the project before running.</summary>
    [Argument(Format = "--no-build")] public bool? NoBuild => Get<bool?>(() => NoBuild);
    /// <summary>Doesn't attempt to use <em>launchSettings.json</em> to configure the application.</summary>
    [Argument(Format = "--no-launch-profile")] public bool? NoLaunchProfile => Get<bool?>(() => NoLaunchProfile);
    /// <summary>Doesn't perform an implicit restore when running the command.</summary>
    [Argument(Format = "--no-restore")] public bool? NoRestore => Get<bool?>(() => NoRestore);
    /// <summary>Publish your application as a framework dependent application. A compatible .NET runtime must be installed on the target machine to run your application.</summary>
    [Argument(Format = "--no-self-contained")] public bool? NoSelfContained => Get<bool?>(() => NoSelfContained);
    /// <summary>Specifies the target operating system (OS). This is a shorthand syntax for setting the <a href="https://learn.microsoft.com/en-us/dotnet/core/rid-catalog">Runtime Identifier (RID)</a>, where the provided value is combined with the default RID. For example, on a win-x64 machine, specifying --os linux sets the RID to linux-x64. If you use this option, don't use the -r|--runtime option. Available since .NET 6.</summary>
    [Argument(Format = "--os {value}")] public string OperatingSystem => Get<string>(() => OperatingSystem);
    /// <summary>Specifies the path and name of the project file. (See the NOTE.) It defaults to the current directory if not specified.</summary>
    [Argument(Format = "--project {value}")] public string ProjectFile => Get<string>(() => ProjectFile);
    /// <summary>Specifies the target runtime. For a list of Runtime Identifiers (RIDs), see the <a href="https://docs.microsoft.com/en-us/dotnet/core/rid-catalog">RID catalog</a>.</summary>
    [Argument(Format = "--runtime {value}")] public string Runtime => Get<string>(() => Runtime);
    /// <summary>Publishes the .NET runtime with the application so the runtime doesn't need to be installed on the target machine. The default is <c>false</c>. However, when targeting .NET 7 or lower, the default is <c>true</c> if a runtime identifier is specified.</summary>
    [Argument(Format = "--self-contained {value}")] public bool? SelfContained => Get<bool?>(() => SelfContained);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>Arguments passed to the application being run.</summary>
    [Argument(Format = "-- {value}", Position = -1, Separator = " ")] public IReadOnlyList<string> ApplicationArguments => Get<List<string>>(() => ApplicationArguments);
    /// <summary>Disables restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Forces all dependencies to be resolved even if the last restore was successful. This is equivalent to deleting the <em>project.assets.json</em> file.</summary>
    [Argument(Format = "--force")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Only warn about failed sources if there are packages meeting the version requirement.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Specifies to not cache packages and HTTP requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>When restoring a project with project-to-project (P2P) references, restore the root project and not the references.</summary>
    [Argument(Format = "--no-dependencies")] public bool? NoDependencies => Get<bool?>(() => NoDependencies);
    /// <summary>Specifies the directory for restored packages.</summary>
    [Argument(Format = "--packages {value}")] public string PackageDirectory => Get<string>(() => PackageDirectory);
    /// <summary>Specifies a NuGet package source to use during the restore operation. This overrides all of the sources specified in the <em>NuGet.config</em> file(s). Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public IReadOnlyList<string> Sources => Get<List<string>>(() => Sources);
    /// <summary>Enables project lock file to be generated and used with restore.</summary>
    [Argument(Format = "--use-lock-file")] public bool? UseLockFile => Get<bool?>(() => UseLockFile);
    /// <summary>Don't allow updating project lock file.</summary>
    [Argument(Format = "--locked-mode")] public bool? LockedMode => Get<bool?>(() => LockedMode);
    /// <summary>Output location where project lock file is written. By default, this is 'PROJECT_ROOT\packages.lock.json'.</summary>
    [Argument(Format = "--lock-file-path {value}")] public string LockFilePath => Get<string>(() => LockFilePath);
    /// <summary>Forces restore to reevaluate all dependencies even if a lock file already exists.</summary>
    [Argument(Format = "--force-evaluate")] public bool? ForceEvaluate => Get<bool?>(() => ForceEvaluate);
    /// <summary><p>Set or override the specified project-level properties, where name is the property name and value is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:</p><p><c>--property:WarningLevel=2;OutDir=bin\Debug</c></p></summary>
    [Argument(Format = "--property:{key}={value}")] public IReadOnlyDictionary<string, object> Properties => Get<Dictionary<string, object>>(() => Properties);
}
#endregion
#region DotNetRestoreSettings
/// <inheritdoc cref="DotNetTasks.DotNetRestore(Nuke.Common.Tools.DotNet.DotNetRestoreSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetRestore), Arguments = "restore")]
public partial class DotNetRestoreSettings : ToolOptions
{
    /// <summary>Optional path to the project file to restore.</summary>
    [Argument(Format = "{value}", Position = 1)] public string ProjectFile => Get<string>(() => ProjectFile);
    /// <summary>The NuGet configuration file (<em>NuGet.config</em>) to use for the restore operation.</summary>
    [Argument(Format = "--configfile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>Disables restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Forces all dependencies to be resolved even if the last restore was successful. This is equivalent to deleting the <em>project.assets.json</em> file.</summary>
    [Argument(Format = "--force")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Only warn about failed sources if there are packages meeting the version requirement.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Specifies to not cache packages and HTTP requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>When restoring a project with project-to-project (P2P) references, restore the root project and not the references.</summary>
    [Argument(Format = "--no-dependencies")] public bool? NoDependencies => Get<bool?>(() => NoDependencies);
    /// <summary>Specifies the directory for restored packages.</summary>
    [Argument(Format = "--packages {value}")] public string PackageDirectory => Get<string>(() => PackageDirectory);
    /// <summary>Specifies a NuGet package source to use during the restore operation. This overrides all of the sources specified in the <em>NuGet.config</em> file(s). Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public IReadOnlyList<string> Sources => Get<List<string>>(() => Sources);
    /// <summary>Enables project lock file to be generated and used with restore.</summary>
    [Argument(Format = "--use-lock-file")] public bool? UseLockFile => Get<bool?>(() => UseLockFile);
    /// <summary>Don't allow updating project lock file.</summary>
    [Argument(Format = "--locked-mode")] public bool? LockedMode => Get<bool?>(() => LockedMode);
    /// <summary>Output location where project lock file is written. By default, this is 'PROJECT_ROOT\packages.lock.json'.</summary>
    [Argument(Format = "--lock-file-path {value}")] public string LockFilePath => Get<string>(() => LockFilePath);
    /// <summary>Forces restore to reevaluate all dependencies even if a lock file already exists.</summary>
    [Argument(Format = "--force-evaluate")] public bool? ForceEvaluate => Get<bool?>(() => ForceEvaluate);
    /// <summary>Specifies a runtime for the package restore. This is used to restore packages for runtimes not explicitly listed in the <c>&lt;RuntimeIdentifiers&gt;</c> tag in the <em>.csproj</em> file. For a list of Runtime Identifiers (RIDs), see the <a href="https://docs.microsoft.com/en-us/dotnet/core/rid-catalog">RID catalog</a>. Provide multiple RIDs by specifying this option multiple times.</summary>
    [Argument(Format = "--runtime {value}")] public string Runtime => Get<string>(() => Runtime);
    /// <summary><p>Set or override the specified project-level properties, where name is the property name and value is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:</p><p><c>--property:WarningLevel=2;OutDir=bin\Debug</c></p></summary>
    [Argument(Format = "--property:{key}={value}")] public IReadOnlyDictionary<string, object> Properties => Get<Dictionary<string, object>>(() => Properties);
}
#endregion
#region DotNetPackSettings
/// <inheritdoc cref="DotNetTasks.DotNetPack(Nuke.Common.Tools.DotNet.DotNetPackSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetPack), Arguments = "pack")]
public partial class DotNetPackSettings : ToolOptions
{
    /// <summary>The project to pack. It's either a path to a csproj file or to a directory. If omitted, it defaults to the current directory.</summary>
    [Argument(Format = "{value}", Position = 1)] public string Project => Get<string>(() => Project);
    /// <summary>Configuration to use when building the project. If not specified, configuration defaults to <c>Debug</c>.</summary>
    [Argument(Format = "--configuration {value}")] public string Configuration => Get<string>(() => Configuration);
    /// <summary>Includes the source files in the NuGet package. The sources files are included in the <c>src</c> folder within the <c>nupkg</c>.</summary>
    [Argument(Format = "--include-source")] public bool? IncludeSource => Get<bool?>(() => IncludeSource);
    /// <summary>Generates the symbols <c>nupkg</c>.</summary>
    [Argument(Format = "--include-symbols")] public bool? IncludeSymbols => Get<bool?>(() => IncludeSymbols);
    /// <summary>Don't build the project before packing.</summary>
    [Argument(Format = "--no-build")] public bool? NoBuild => Get<bool?>(() => NoBuild);
    /// <summary>Doesn't perform an implicit restore when running the command.</summary>
    [Argument(Format = "--no-restore")] public bool? NoRestore => Get<bool?>(() => NoRestore);
    /// <summary>Places the built packages in the directory specified.</summary>
    [Argument(Format = "--output {value}")] public string OutputDirectory => Get<string>(() => OutputDirectory);
    /// <summary>Sets the serviceable flag in the package. For more information, see <a href="https://aka.ms/nupkgservicing">.NET Blog: .NET 4.5.1 Supports Microsoft Security Updates for .NET NuGet Libraries</a>.</summary>
    [Argument(Format = "--serviceable")] public bool? Serviceable => Get<bool?>(() => Serviceable);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>Defines the value for the <c>$(VersionSuffix)</c> MSBuild property in the project.</summary>
    [Argument(Format = "--version-suffix {value}")] public string VersionSuffix => Get<string>(() => VersionSuffix);
    /// <summary>Doesn't display the startup banner or the copyright message. Available since .NET Core 3.0 SDK.</summary>
    [Argument(Format = "--nologo")] public bool? NoLogo => Get<bool?>(() => NoLogo);
    /// <summary>Disables restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Forces all dependencies to be resolved even if the last restore was successful. This is equivalent to deleting the <em>project.assets.json</em> file.</summary>
    [Argument(Format = "--force")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Only warn about failed sources if there are packages meeting the version requirement.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Specifies to not cache packages and HTTP requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>When restoring a project with project-to-project (P2P) references, restore the root project and not the references.</summary>
    [Argument(Format = "--no-dependencies")] public bool? NoDependencies => Get<bool?>(() => NoDependencies);
    /// <summary>Specifies the directory for restored packages.</summary>
    [Argument(Format = "--packages {value}")] public string PackageDirectory => Get<string>(() => PackageDirectory);
    /// <summary>Specifies a NuGet package source to use during the restore operation. This overrides all of the sources specified in the <em>NuGet.config</em> file(s). Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public IReadOnlyList<string> Sources => Get<List<string>>(() => Sources);
    /// <summary>Enables project lock file to be generated and used with restore.</summary>
    [Argument(Format = "--use-lock-file")] public bool? UseLockFile => Get<bool?>(() => UseLockFile);
    /// <summary>Don't allow updating project lock file.</summary>
    [Argument(Format = "--locked-mode")] public bool? LockedMode => Get<bool?>(() => LockedMode);
    /// <summary>Output location where project lock file is written. By default, this is 'PROJECT_ROOT\packages.lock.json'.</summary>
    [Argument(Format = "--lock-file-path {value}")] public string LockFilePath => Get<string>(() => LockFilePath);
    /// <summary>Forces restore to reevaluate all dependencies even if a lock file already exists.</summary>
    [Argument(Format = "--force-evaluate")] public bool? ForceEvaluate => Get<bool?>(() => ForceEvaluate);
    /// <summary>Specifies a runtime for the package restore. This is used to restore packages for runtimes not explicitly listed in the <c>&lt;RuntimeIdentifiers&gt;</c> tag in the <em>.csproj</em> file. For a list of Runtime Identifiers (RIDs), see the <a href="https://docs.microsoft.com/en-us/dotnet/core/rid-catalog">RID catalog</a>. Provide multiple RIDs by specifying this option multiple times.</summary>
    [Argument(Format = "--runtime {value}")] public string Runtime => Get<string>(() => Runtime);
    /// <summary><p>Set or override the specified project-level properties, where name is the property name and value is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:</p><p><c>--property:WarningLevel=2;OutDir=bin\Debug</c></p></summary>
    [Argument(Format = "--property:{key}={value}")] public IReadOnlyDictionary<string, object> Properties => Get<Dictionary<string, object>>(() => Properties);
}
#endregion
#region DotNetBuildSettings
/// <inheritdoc cref="DotNetTasks.DotNetBuild(Nuke.Common.Tools.DotNet.DotNetBuildSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetBuild), Arguments = "build")]
public partial class DotNetBuildSettings : ToolOptions
{
    /// <summary>The project file to build. If a project file is not specified, MSBuild searches the current working directory for a file that has a file extension that ends in proj and uses that file.</summary>
    [Argument(Format = "{value}", Position = 1)] public string ProjectFile => Get<string>(() => ProjectFile);
    /// <summary>Defines the build configuration. If omitted, the build configuration defaults to <c>Debug</c>. Use <c>Release</c> build a Release configuration.</summary>
    [Argument(Format = "--configuration {value}")] public string Configuration => Get<string>(() => Configuration);
    /// <summary>Compiles for a specific <a href="https://docs.microsoft.com/en-us/dotnet/standard/frameworks">framework</a>. The framework must be defined in the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/csproj">project file</a>.</summary>
    [Argument(Format = "--framework {value}")] public string Framework => Get<string>(() => Framework);
    /// <summary>Marks the build as unsafe for incremental build. This turns off incremental compilation and forces a clean rebuild of the project's dependency graph.</summary>
    [Argument(Format = "--no-incremental")] public bool? NoIncremental => Get<bool?>(() => NoIncremental);
    /// <summary>Doesn't perform an implicit restore during build.</summary>
    [Argument(Format = "--no-restore")] public bool? NoRestore => Get<bool?>(() => NoRestore);
    /// <summary>Directory in which to place the built binaries. You also need to define <c>--framework</c> when you specify this option.</summary>
    [Argument(Format = "--output {value}")] public string OutputDirectory => Get<string>(() => OutputDirectory);
    /// <summary>Publishes the .NET runtime with the application so the runtime doesn't need to be installed on the target machine. The default is <c>true</c> if a runtime identifier is specified. Available since .NET 6 SDK</summary>
    [Argument(Format = "--self-contained {value}")] public bool? SelfContained => Get<bool?>(() => SelfContained);
    /// <summary>Specifies the target runtime. For a list of Runtime Identifiers (RIDs), see the <a href="https://docs.microsoft.com/en-us/dotnet/core/rid-catalog">RID catalog</a>.</summary>
    [Argument(Format = "--runtime {value}")] public string Runtime => Get<string>(() => Runtime);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>Defines the version suffix for an asterisk (<c>*</c>) in the version field of the project file. The format follows NuGet's version guidelines.</summary>
    [Argument(Format = "--version-suffix {value}")] public string VersionSuffix => Get<string>(() => VersionSuffix);
    /// <summary>Specifies the loggers to use to log events from MSBuild.</summary>
    [Argument(Format = "/logger:{value}")] public IReadOnlyList<string> Loggers => Get<List<string>>(() => Loggers);
    /// <summary>Disable the default console logger, and don't log events to the console.</summary>
    [Argument(Format = "/noconsolelogger")] public bool? NoConsoleLogger => Get<bool?>(() => NoConsoleLogger);
    /// <summary>Doesn't display the startup banner or the copyright message. Available since .NET Core 3.0 SDK.</summary>
    [Argument(Format = "--nologo")] public bool? NoLogo => Get<bool?>(() => NoLogo);
    /// <summary>Generare MSBuild <a href="https://github.com/dotnet/msbuild/blob/main/documentation/wiki/Binary-Log.md">binary log</a>.</summary>
    [Argument(Format = "-bl:{value}")] public string BinaryLog => Get<string>(() => BinaryLog);
    /// <summary>Disables restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Forces all dependencies to be resolved even if the last restore was successful. This is equivalent to deleting the <em>project.assets.json</em> file.</summary>
    [Argument(Format = "--force")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Only warn about failed sources if there are packages meeting the version requirement.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Specifies to not cache packages and HTTP requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>When restoring a project with project-to-project (P2P) references, restore the root project and not the references.</summary>
    [Argument(Format = "--no-dependencies")] public bool? NoDependencies => Get<bool?>(() => NoDependencies);
    /// <summary>Specifies the directory for restored packages.</summary>
    [Argument(Format = "--packages {value}")] public string PackageDirectory => Get<string>(() => PackageDirectory);
    /// <summary>Specifies a NuGet package source to use during the restore operation. This overrides all of the sources specified in the <em>NuGet.config</em> file(s). Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public IReadOnlyList<string> Sources => Get<List<string>>(() => Sources);
    /// <summary>Enables project lock file to be generated and used with restore.</summary>
    [Argument(Format = "--use-lock-file")] public bool? UseLockFile => Get<bool?>(() => UseLockFile);
    /// <summary>Don't allow updating project lock file.</summary>
    [Argument(Format = "--locked-mode")] public bool? LockedMode => Get<bool?>(() => LockedMode);
    /// <summary>Output location where project lock file is written. By default, this is 'PROJECT_ROOT\packages.lock.json'.</summary>
    [Argument(Format = "--lock-file-path {value}")] public string LockFilePath => Get<string>(() => LockFilePath);
    /// <summary>Forces restore to reevaluate all dependencies even if a lock file already exists.</summary>
    [Argument(Format = "--force-evaluate")] public bool? ForceEvaluate => Get<bool?>(() => ForceEvaluate);
    /// <summary><p>Set or override the specified project-level properties, where name is the property name and value is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:</p><p><c>--property:WarningLevel=2;OutDir=bin\Debug</c></p></summary>
    [Argument(Format = "--property:{key}={value}")] public IReadOnlyDictionary<string, object> Properties => Get<Dictionary<string, object>>(() => Properties);
}
#endregion
#region DotNetMSBuildSettings
/// <inheritdoc cref="DotNetTasks.DotNetMSBuild(Nuke.Common.Tools.DotNet.DotNetMSBuildSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetMSBuild), Arguments = "msbuild")]
public partial class DotNetMSBuildSettings : ToolOptions
{
    /// <summary>The solution or project file on which MSBuild is executed.</summary>
    [Argument(Format = "{value}", Position = 1)] public string TargetPath => Get<string>(() => TargetPath);
    /// <summary>Show detailed information at the end of the build log about the configurations that were built and how they were scheduled to nodes.</summary>
    [Argument(Format = "/detailedsummary")] public bool? DetailedSummary => Get<bool?>(() => DetailedSummary);
    /// <summary><p>Specifies the maximum number of concurrent processes to use when building. If you don't include this switch, the default value is 1. If you include this switch without specifying a value, MSBuild will use up to the number of processors in the computer. For more information, see <a href="https://msdn.microsoft.com/en-us/library/bb651793.aspx">Building Multiple Projects in Parallel</a>.</p><p>The following example instructs MSBuild to build using three MSBuild processes, which allows three projects to build at the same time:</p><p><c>msbuild myproject.proj /maxcpucount:3</c></p></summary>
    [Argument(Format = "/maxcpucount:{value}")] public int? MaxCpuCount => Get<int?>(() => MaxCpuCount);
    /// <summary><p>Enable or disable the re-use of MSBuild nodes. You can specify the following values: <ul><li><c>true</c>: Nodes remain after the build finishes so that subsequent builds can use them (default).</li><li><c>false</c>. Nodes don't remain after the build completes.</li></ul></p><p>A node corresponds to a project that's executing. If you include the <c>/maxcpucount</c> switch, multiple nodes can execute concurrently.</p></summary>
    [Argument(Format = "/nodeReuse:{value}")] public bool? NodeReuse => Get<bool?>(() => NodeReuse);
    /// <summary>Don't display the startup banner or the copyright message.</summary>
    [Argument(Format = "/nologo")] public bool? NoLogo => Get<bool?>(() => NoLogo);
    /// <summary>Runs the <c>Restore</c> target prior to building the actual targets.</summary>
    [Argument(Format = "/restore")] public bool? Restore => Get<bool?>(() => Restore);
    /// <summary><p>Build the specified targets in the project. Specify each target separately, or use a semicolon or comma to separate multiple targets, as the following example shows:<br/><c>/target:Resources;Compile</c></p><p>If you specify any targets by using this switch, they are run instead of any targets in the DefaultTargets attribute in the project file. For more information, see <a href="https://msdn.microsoft.com/en-us/library/ee216359.aspx">Target Build Order</a> and <a href="https://msdn.microsoft.com/en-us/library/ms171463.aspx">How to: Specify Which Target to Build First</a>.</p><p>A target is a group of tasks. For more information, see <a href="https://msdn.microsoft.com/en-us/library/ms171462.aspx">Targets</a>.</p></summary>
    [Argument(Format = "/target:{value}", Separator = ";")] public IReadOnlyList<string> Targets => Get<List<string>>(() => Targets);
    /// <summary><p>Specifies the amount of information to display in the build log. Each logger displays events based on the verbosity level that you set for that logger.</p><p>You can specify the following verbosity levels: <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</p><p>The following setting is an example: <c>/verbosity:quiet</c></p></summary>
    [Argument(Format = "/verbosity:{value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>Specifies the loggers to use to log events from MSBuild.</summary>
    [Argument(Format = "/logger:{value}")] public IReadOnlyList<string> Loggers => Get<List<string>>(() => Loggers);
    /// <summary>Disable the default console logger, and don't log events to the console.</summary>
    [Argument(Format = "/noconsolelogger")] public bool? NoConsoleLogger => Get<bool?>(() => NoConsoleLogger);
    /// <summary>Defines the build configuration. The default value is <c>Debug</c>. This option is only required when cleaning if you specified it during build time.</summary>
    [Argument(Format = "/property:Configuration={value}")] public string Configuration => Get<string>(() => Configuration);
    /// <summary>Causes MSBuild to construct and build a project graph. Constructing a graph involves identifying project references to form dependencies. Building that graph involves attempting to build project references prior to the projects that reference them, differing from traditional MSBuild scheduling. Requires MSBuild 16 or later.</summary>
    [Argument(Format = "/graphBuild")] public bool? GraphBuild => Get<bool?>(() => GraphBuild);
    /// <summary>Generate MSBuild <a href="https://github.com/dotnet/msbuild/blob/main/documentation/wiki/Binary-Log.md">binary log</a>.</summary>
    [Argument(Format = "-bl:{value}")] public string BinaryLog => Get<string>(() => BinaryLog);
    /// <summary><p>Set or override the specified project-level properties, where name is the property name and value is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:</p><p><c>/property:WarningLevel=2;OutDir=bin\Debug</c></p></summary>
    [Argument(Format = "/property:{key}={value}")] public IReadOnlyDictionary<string, object> Properties => Get<Dictionary<string, object>>(() => Properties);
}
#endregion
#region DotNetCleanSettings
/// <inheritdoc cref="DotNetTasks.DotNetClean(Nuke.Common.Tools.DotNet.DotNetCleanSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetClean), Arguments = "clean")]
public partial class DotNetCleanSettings : ToolOptions
{
    /// <summary>The MSBuild project to clean. If a project file is not specified, MSBuild searches the current working directory for a file that has a file extension that ends in <em>proj</em> and uses that file.</summary>
    [Argument(Format = "{value}", Position = 1)] public string Project => Get<string>(() => Project);
    /// <summary>Defines the build configuration. The default value is <c>Debug</c>. This option is only required when cleaning if you specified it during build time.</summary>
    [Argument(Format = "--configuration {value}")] public string Configuration => Get<string>(() => Configuration);
    /// <summary>The <a href="https://docs.microsoft.com/en-us/dotnet/standard/frameworks">framework</a> that was specified at build time. The framework must be defined in the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/csproj">project file</a>. If you specified the framework at build time, you must specify the framework when cleaning.</summary>
    [Argument(Format = "--framework {value}")] public string Framework => Get<string>(() => Framework);
    /// <summary>Directory in which the build outputs are placed. Specify the <c>--framework</c> switch with the output directory switch if you specified the framework when the project was built.</summary>
    [Argument(Format = "--output {value}")] public string Output => Get<string>(() => Output);
    /// <summary>Cleans the output folder of the specified runtime. This is used when a <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/index#self-contained-deployments-scd">self-contained deployment</a> was created.</summary>
    [Argument(Format = "--runtime {value}")] public string Runtime => Get<string>(() => Runtime);
    /// <summary>Sets the verbosity level of the command. Allowed levels are q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic].</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>Doesn't display the startup banner or the copyright message. Available since .NET Core 3.0 SDK.</summary>
    [Argument(Format = "--nologo")] public bool? NoLogo => Get<bool?>(() => NoLogo);
    /// <summary><p>Set or override the specified project-level properties, where name is the property name and value is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:</p><p><c>--property:WarningLevel=2;OutDir=bin\Debug</c></p></summary>
    [Argument(Format = "--property:{key}={value}")] public IReadOnlyDictionary<string, object> Properties => Get<Dictionary<string, object>>(() => Properties);
}
#endregion
#region DotNetFormatSettings
/// <inheritdoc cref="DotNetTasks.DotNetFormat(Nuke.Common.Tools.DotNet.DotNetFormatSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetFormat), Arguments = "format")]
public partial class DotNetFormatSettings : ToolOptions
{
    /// <summary>The MSBuild project or solution to run code formatting on. If a project or solution file is not specified, MSBuild searches the current working directory for a file that has a file extension that ends in <em>proj</em> or <em>sln</em>, and uses that file.</summary>
    [Argument(Format = "{value}", Position = 1)] public string Project => Get<string>(() => Project);
    /// <summary>The minimum severity of diagnostics to fix. Allowed values are info, warn, and error. The default value is warn.</summary>
    [Argument(Format = "--severity {value}")] public DotNetFormatSeverity Severity => Get<DotNetFormatSeverity>(() => Severity);
    /// <summary>Doesn't execute an implicit restore before formatting. Default is to do implicit restore.</summary>
    [Argument(Format = "--no-restore")] public bool? NoRestore => Get<bool?>(() => NoRestore);
    /// <summary>Verifies that no formatting changes would be performed. Terminates with a non zero exit code if any files would have been formatted.</summary>
    [Argument(Format = "--verify-no-changes")] public bool? VerifyNoChanges => Get<bool?>(() => VerifyNoChanges);
    /// <summary>A space-separated list of relative file or folder paths to include in formatting. The default is all files in the solution or project.</summary>
    [Argument(Format = "--include {value}")] public IReadOnlyList<string> Include => Get<List<string>>(() => Include);
    /// <summary>A space-separated list of relative file or folder paths to exclude from formatting. The default is none.</summary>
    [Argument(Format = "--exclude {value}")] public IReadOnlyList<string> Exclude => Get<List<string>>(() => Exclude);
    /// <summary>Formats files generated by the SDK.</summary>
    [Argument(Format = "--include-generated")] public bool? IncludeGenerated => Get<bool?>(() => IncludeGenerated);
    /// <summary>Sets the verbosity level. Allowed levels are q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic].</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>Logs all project or solution load information to a binary log file.</summary>
    [Argument(Format = "--binarylog {value}")] public string BinaryLog => Get<string>(() => BinaryLog);
    /// <summary>Produces a JSON report in the directory specified by <c>REPORT_PATH</c>.</summary>
    [Argument(Format = "--report {value}")] public string Report => Get<string>(() => Report);
    /// <summary><p>Set or override the specified project-level properties, where name is the property name and value is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:</p><p><c>--property:WarningLevel=2;OutDir=bin\Debug</c></p></summary>
    [Argument(Format = "--property:{key}={value}")] public IReadOnlyDictionary<string, object> Properties => Get<Dictionary<string, object>>(() => Properties);
}
#endregion
#region DotNetPublishSettings
/// <inheritdoc cref="DotNetTasks.DotNetPublish(Nuke.Common.Tools.DotNet.DotNetPublishSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetPublish), Arguments = "publish")]
public partial class DotNetPublishSettings : ToolOptions
{
    /// <summary>The project to publish, which defaults to the current directory if not specified.</summary>
    [Argument(Format = "{value}", Position = 1)] public string Project => Get<string>(() => Project);
    /// <summary>Specifies the target architecture. This is a shorthand syntax for setting the <a href="https://learn.microsoft.com/en-us/dotnet/core/rid-catalog">Runtime Identifier (RID)</a>, where the provided value is combined with the default RID. For example, on a win-x64 machine, specifying --arch x86 sets the RID to win-x86. If you use this option, don't use the -r|--runtime option. Available since .NET 6 Preview 7.</summary>
    [Argument(Format = "--arch {value}")] public string Architecture => Get<string>(() => Architecture);
    /// <summary>Defines the build configuration. The default value is <c>Debug</c>.</summary>
    [Argument(Format = "--configuration {value}")] public string Configuration => Get<string>(() => Configuration);
    /// <summary>Publishes the application for the specified <a href="https://docs.microsoft.com/en-us/dotnet/standard/frameworks">target framework</a>. You must specify the target framework in the project file.</summary>
    [Argument(Format = "--framework {value}")] public string Framework => Get<string>(() => Framework);
    /// <summary>Specifies one or several <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/runtime-store">target manifests</a> to use to trim the set of packages published with the app. The manifest file is part of the output of the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-store"><c>dotnet store</c></a> command. To specify multiple manifests, add a <c>--manifest</c> option for each manifest. This option is available starting with .NET Core 2.0 SDK.</summary>
    [Argument(Format = "--manifest {value}")] public string Manifest => Get<string>(() => Manifest);
    /// <summary>Doesn't perform an implicit restore when running the command.</summary>
    [Argument(Format = "--no-restore")] public bool? NoRestore => Get<bool?>(() => NoRestore);
    /// <summary>Doesn't build the project before publishing. It also implicitly sets the <c>--no-restore</c> flag.</summary>
    [Argument(Format = "--no-build")] public bool? NoBuild => Get<bool?>(() => NoBuild);
    /// <summary>Specifies the path for the output directory. If not specified, it defaults to <em>./bin/[configuration]/[framework]/</em> for a framework-dependent deployment or <em>./bin/[configuration]/[framework]/[runtime]</em> for a self-contained deployment.<para/>If a relative path is provided, the output directory generated is relative to the project file location, not to the current working directory.</summary>
    [Argument(Format = "--output {value}")] public string Output => Get<string>(() => Output);
    /// <summary>Specifies the target operating system (OS). This is a shorthand syntax for setting the <a href="https://learn.microsoft.com/en-us/dotnet/core/rid-catalog">Runtime Identifier (RID)</a>, where the provided value is combined with the default RID. For example, on a win-x64 machine, specifying --os linux sets the RID to linux-x64. If you use this option, don't use the -r|--runtime option. Available since .NET 6.</summary>
    [Argument(Format = "--os {value}")] public string OperatingSystem => Get<string>(() => OperatingSystem);
    /// <summary>Publishes the .NET Core runtime with your application so the runtime doesn't need to be installed on the target machine. If a runtime identifier is specified, its default value is <c>true</c>. For more information about the different deployment types, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/index">.NET Core application deployment</a>.</summary>
    [Argument(Format = "--self-contained {value}")] public bool? SelfContained => Get<bool?>(() => SelfContained);
    /// <summary>Publishes the application for a given runtime. This is used when creating a <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/index#self-contained-deployments-scd">self-contained deployment (SCD)</a>. For a list of Runtime Identifiers (RIDs), see the <a href="https://docs.microsoft.com/en-us/dotnet/core/rid-catalog">RID catalog</a>. Default is to publish a <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/index#framework-dependent-deployments-fdd">framework-dependent deployment (FDD)</a>.</summary>
    [Argument(Format = "--runtime {value}")] public string Runtime => Get<string>(() => Runtime);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>Defines the version suffix for an asterisk (<c>*</c>) in the version field of the project file. The format follows NuGet's version guidelines.</summary>
    [Argument(Format = "--version-suffix {value}")] public string VersionSuffix => Get<string>(() => VersionSuffix);
    /// <summary>Doesn't display the startup banner or the copyright message. Available since .NET Core 3.0 SDK.</summary>
    [Argument(Format = "--nologo")] public bool? NoLogo => Get<bool?>(() => NoLogo);
    /// <summary><p>Build the specified targets in the project. Specify each target separately, or use a semicolon or comma to separate multiple targets, as the following example shows:<br/><c>/target:Resources;Compile</c></p><p>If you specify any targets by using this switch, they are run instead of any targets in the DefaultTargets attribute in the project file. For more information, see <a href="https://msdn.microsoft.com/en-us/library/ee216359.aspx">Target Build Order</a> and <a href="https://msdn.microsoft.com/en-us/library/ms171463.aspx">How to: Specify Which Target to Build First</a>.</p><p>A target is a group of tasks. For more information, see <a href="https://msdn.microsoft.com/en-us/library/ms171462.aspx">Targets</a>.</p></summary>
    [Argument(Format = "/t:{value}", Separator = ";")] public IReadOnlyList<string> Targets => Get<List<string>>(() => Targets);
    /// <summary>Disables restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Forces all dependencies to be resolved even if the last restore was successful. This is equivalent to deleting the <em>project.assets.json</em> file.</summary>
    [Argument(Format = "--force")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Only warn about failed sources if there are packages meeting the version requirement.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Specifies to not cache packages and HTTP requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>When restoring a project with project-to-project (P2P) references, restore the root project and not the references.</summary>
    [Argument(Format = "--no-dependencies")] public bool? NoDependencies => Get<bool?>(() => NoDependencies);
    /// <summary>Specifies the directory for restored packages.</summary>
    [Argument(Format = "--packages {value}")] public string PackageDirectory => Get<string>(() => PackageDirectory);
    /// <summary>Specifies a NuGet package source to use during the restore operation. This overrides all of the sources specified in the <em>NuGet.config</em> file(s). Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public IReadOnlyList<string> Sources => Get<List<string>>(() => Sources);
    /// <summary>Enables project lock file to be generated and used with restore.</summary>
    [Argument(Format = "--use-lock-file")] public bool? UseLockFile => Get<bool?>(() => UseLockFile);
    /// <summary>Don't allow updating project lock file.</summary>
    [Argument(Format = "--locked-mode")] public bool? LockedMode => Get<bool?>(() => LockedMode);
    /// <summary>Output location where project lock file is written. By default, this is 'PROJECT_ROOT\packages.lock.json'.</summary>
    [Argument(Format = "--lock-file-path {value}")] public string LockFilePath => Get<string>(() => LockFilePath);
    /// <summary>Forces restore to reevaluate all dependencies even if a lock file already exists.</summary>
    [Argument(Format = "--force-evaluate")] public bool? ForceEvaluate => Get<bool?>(() => ForceEvaluate);
    /// <summary><p>Set or override the specified project-level properties, where name is the property name and value is the property value. Specify each property separately, or use a semicolon or comma to separate multiple properties, as the following example shows:</p><p><c>--property:WarningLevel=2;OutDir=bin\Debug</c></p></summary>
    [Argument(Format = "--property:{key}={value}")] public IReadOnlyDictionary<string, object> Properties => Get<Dictionary<string, object>>(() => Properties);
}
#endregion
#region DotNetNuGetPushSettings
/// <inheritdoc cref="DotNetTasks.DotNetNuGetPush(Nuke.Common.Tools.DotNet.DotNetNuGetPushSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetNuGetPush), Arguments = "nuget push")]
public partial class DotNetNuGetPushSettings : ToolOptions
{
    /// <summary>Path of the package to push.</summary>
    [Argument(Format = "{value}", Position = 1)] public string TargetPath => Get<string>(() => TargetPath);
    /// <summary>Specifies the server URL. This option is required unless <c>DefaultPushSource</c> config value is set in the NuGet config file.</summary>
    [Argument(Format = "--source {value}")] public string Source => Get<string>(() => Source);
    /// <summary>Specifies the symbol server URL.</summary>
    [Argument(Format = "--symbol-source {value}")] public string SymbolSource => Get<string>(() => SymbolSource);
    /// <summary>Specifies the timeout for pushing to a server in seconds. Defaults to 300 seconds (5 minutes). Specifying 0 (zero seconds) applies the default value.</summary>
    [Argument(Format = "--timeout {value}")] public int? Timeout => Get<int?>(() => Timeout);
    /// <summary>The API key for the server.</summary>
    [Argument(Format = "--api-key {value}", Secret = true)] public string ApiKey => Get<string>(() => ApiKey);
    /// <summary>The API key for the symbol server.</summary>
    [Argument(Format = "--symbol-api-key {value}", Secret = true)] public string SymbolApiKey => Get<string>(() => SymbolApiKey);
    /// <summary>Disables buffering when pushing to an HTTP(S) server to decrease memory usage.</summary>
    [Argument(Format = "--disable-buffering")] public bool? DisableBuffering => Get<bool?>(() => DisableBuffering);
    /// <summary>Doesn't push symbols (even if present).</summary>
    [Argument(Format = "--no-symbols")] public bool? NoSymbols => Get<bool?>(() => NoSymbols);
    /// <summary>Forces all logged output in English.</summary>
    [Argument(Format = "--force-english-output")] public bool? ForceEnglishOutput => Get<bool?>(() => ForceEnglishOutput);
    /// <summary>When pushing multiple packages to an HTTP(S) server, treats any 409 Conflict response as a warning so that the push can continue. Available since .NET Core 3.1 SDK.</summary>
    [Argument(Format = "--skip-duplicate")] public bool? SkipDuplicate => Get<bool?>(() => SkipDuplicate);
    /// <summary>Doesn't append <c>api/v2/package</c> to the source URL. Option available since .NET Core 2.1 SDK.</summary>
    [Argument(Format = "--no-service-endpoint")] public bool? NoServiceEndpoint => Get<bool?>(() => NoServiceEndpoint);
}
#endregion
#region DotNetNuGetAddSourceSettings
/// <inheritdoc cref="DotNetTasks.DotNetNuGetAddSource(Nuke.Common.Tools.DotNet.DotNetNuGetAddSourceSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetNuGetAddSource), Arguments = "nuget add source")]
public partial class DotNetNuGetAddSourceSettings : ToolOptions
{
    /// <summary>URL of the source.</summary>
    [Argument(Format = "{value}", Position = 1)] public string Source => Get<string>(() => Source);
    /// <summary>Name of the source.</summary>
    [Argument(Format = "--name {value}")] public string Name => Get<string>(() => Name);
    /// <summary>Username to be used when connecting to an authenticated source.</summary>
    [Argument(Format = "--username {value}")] public string Username => Get<string>(() => Username);
    /// <summary>Password to be used when connecting to an authenticated source.</summary>
    [Argument(Format = "--password {value}", Secret = true)] public string Password => Get<string>(() => Password);
    /// <summary>Enables storing portable package source credentials by disabling password encryption.</summary>
    [Argument(Format = "--store-password-in-clear-text", Secret = false)] public bool? StorePasswordInClearText => Get<bool?>(() => StorePasswordInClearText);
    /// <summary>List of valid authentication types for this source. Set this to <c>basic</c> if the server advertises NTLM or Negotiate and your credentials must be sent using the Basic mechanism, for instance when using a PAT with on-premises Azure DevOps Server. Other valid values include <c>negotiate</c>, <c>kerberos</c>, <c>ntlm</c>, and <c>digest</c>, but these values are unlikely to be useful.</summary>
    [Argument(Format = "--valid-authentication-types {value}", Separator = ",")] public IReadOnlyList<DotNetNuGetAuthentication> ValidAuthenticationTypes => Get<List<DotNetNuGetAuthentication>>(() => ValidAuthenticationTypes);
    /// <summary>The NuGet configuration file (nuget.config) to use. If specified, only the settings from this file will be used. If not specified, the hierarchy of configuration files from the current directory will be used. For more information, see <a href="https://learn.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior">Common NuGet Configurations</a>.</summary>
    [Argument(Format = "--configfile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
}
#endregion
#region DotNetNuGetUpdateSourceSettings
/// <inheritdoc cref="DotNetTasks.DotNetNuGetUpdateSource(Nuke.Common.Tools.DotNet.DotNetNuGetUpdateSourceSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetNuGetUpdateSource), Arguments = "nuget update source")]
public partial class DotNetNuGetUpdateSourceSettings : ToolOptions
{
    /// <summary>Name of the source.</summary>
    [Argument(Format = "{value}", Position = 1)] public string Name => Get<string>(() => Name);
    /// <summary>URL of the source.</summary>
    [Argument(Format = "--source {value}")] public string Source => Get<string>(() => Source);
    /// <summary>Username to be used when connecting to an authenticated source.</summary>
    [Argument(Format = "--username {value}")] public string Username => Get<string>(() => Username);
    /// <summary>Password to be used when connecting to an authenticated source.</summary>
    [Argument(Format = "--password {value}", Secret = true)] public string Password => Get<string>(() => Password);
    /// <summary>Enables storing portable package source credentials by disabling password encryption.</summary>
    [Argument(Format = "--store-password-in-clear-text", Secret = false)] public bool? StorePasswordInClearText => Get<bool?>(() => StorePasswordInClearText);
    /// <summary>List of valid authentication types for this source. Set this to <c>basic</c> if the server advertises NTLM or Negotiate and your credentials must be sent using the Basic mechanism, for instance when using a PAT with on-premises Azure DevOps Server. Other valid values include <c>negotiate</c>, <c>kerberos</c>, <c>ntlm</c>, and <c>digest</c>, but these values are unlikely to be useful.</summary>
    [Argument(Format = "--valid-authentication-types {value}", Separator = ",")] public IReadOnlyList<DotNetNuGetAuthentication> ValidAuthenticationTypes => Get<List<DotNetNuGetAuthentication>>(() => ValidAuthenticationTypes);
    /// <summary>The NuGet configuration file (nuget.config) to use. If specified, only the settings from this file will be used. If not specified, the hierarchy of configuration files from the current directory will be used. For more information, see <a href="https://learn.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior">Common NuGet Configurations</a>.</summary>
    [Argument(Format = "--configfile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
}
#endregion
#region DotNetToolInstallSettings
/// <inheritdoc cref="DotNetTasks.DotNetToolInstall(Nuke.Common.Tools.DotNet.DotNetToolInstallSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetToolInstall), Arguments = "tool install")]
public partial class DotNetToolInstallSettings : ToolOptions
{
    /// <summary>The Name/ID of the NuGet package that contains the .NET Core Global Tool to install.</summary>
    [Argument(Format = "{value}", Position = 1)] public string PackageName => Get<string>(() => PackageName);
    /// <summary>Adds an additional NuGet package source to use during installation.</summary>
    [Argument(Format = "--add-source {value}")] public IReadOnlyList<string> Sources => Get<List<string>>(() => Sources);
    /// <summary>Specifies the NuGet configuration (<em>nuget.config</em>) file to use.</summary>
    [Argument(Format = "--configfile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
    /// <summary>Specifies the <a href="https://docs.microsoft.com/en-us/dotnet/standard/frameworks">target framework</a> to install the tool for. By default, the .NET Core SDK tries to choose the most appropriate target framework.</summary>
    [Argument(Format = "--framework {value}")] public string Framework => Get<string>(() => Framework);
    /// <summary>Specifies that the installation is user wide. Can't be combined with the <c>--tool-path</c> option. If you don't specify this option, you must specify the <c>--tool-path</c> option.</summary>
    [Argument(Format = "--global")] public bool? Global => Get<bool?>(() => Global);
    /// <summary>Specifies the location where to install the Global Tool. The path can be absolute or relative. If the path doesn't exist, the command tries to create it. Can't be combined with the <c>--global</c> option. If you don't specify this option, you must specify the <c>--global</c> option.</summary>
    [Argument(Format = "--tool-path {value}")] public string ToolInstallationPath => Get<string>(() => ToolInstallationPath);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>The version of the tool to install. By default, the latest stable package version is installed. Use this option to install preview or older versions of the tool.</summary>
    [Argument(Format = "--version {value}")] public string Version => Get<string>(() => Version);
}
#endregion
#region DotNetToolRestoreSettings
/// <inheritdoc cref="DotNetTasks.DotNetToolRestore(Nuke.Common.Tools.DotNet.DotNetToolRestoreSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetToolRestore), Arguments = "tool restore")]
public partial class DotNetToolRestoreSettings : ToolOptions
{
    /// <summary>Specifies the NuGet configuration (<em>nuget.config</em>) file to use.</summary>
    [Argument(Format = "--configfile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
    /// <summary>Adds an additional NuGet package source to use during installation.</summary>
    [Argument(Format = "--add-source {value}")] public IReadOnlyList<string> Sources => Get<List<string>>(() => Sources);
    /// <summary>Path to the manifest file.</summary>
    [Argument(Format = "--tool-manifest {value}")] public string ToolManifest => Get<string>(() => ToolManifest);
    /// <summary>Prevent restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Treat package source failures as warnings.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Do not cache packages and http requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>Allows the command to stop and wait for user input or action (for example to complete authentication).</summary>
    [Argument(Format = "--interactive")] public bool? Interactive => Get<bool?>(() => Interactive);
}
#endregion
#region DotNetToolUninstallSettings
/// <inheritdoc cref="DotNetTasks.DotNetToolUninstall(Nuke.Common.Tools.DotNet.DotNetToolUninstallSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetToolUninstall), Arguments = "tool uninstall")]
public partial class DotNetToolUninstallSettings : ToolOptions
{
    /// <summary>The Name/ID of the NuGet package that contains the .NET Core Global Tool to uninstall. You can find the package name using the <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-list">dotnet tool list</a> command.</summary>
    [Argument(Format = "{value}", Position = 1)] public string PackageName => Get<string>(() => PackageName);
    /// <summary>Specifies that the tool to be removed is from a user-wide installation. Can't be combined with the <c>--tool-path</c> option. If you don't specify this option, you must specify the <c>--tool-path</c> option.</summary>
    [Argument(Format = "--global")] public bool? Global => Get<bool?>(() => Global);
    /// <summary>Specifies the location where to uninstall the Global Tool. The path can be absolute or relative. Can't be combined with the <c>--global</c> option. If you don't specify this option, you must specify the <c>--global</c> option.</summary>
    [Argument(Format = "--tool-path {value}")] public string ToolInstallationPath => Get<string>(() => ToolInstallationPath);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
}
#endregion
#region DotNetToolUpdateSettings
/// <inheritdoc cref="DotNetTasks.DotNetToolUpdate(Nuke.Common.Tools.DotNet.DotNetToolUpdateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetToolUpdate), Arguments = "tool update")]
public partial class DotNetToolUpdateSettings : ToolOptions
{
    /// <summary>The Name/ID of the NuGet package that contains the .NET Core Global Tool to install.</summary>
    [Argument(Format = "{value}", Position = 1)] public string PackageName => Get<string>(() => PackageName);
    /// <summary>Adds an additional NuGet package source to use during installation.</summary>
    [Argument(Format = "--add-source {value}")] public IReadOnlyList<string> Sources => Get<List<string>>(() => Sources);
    /// <summary>Specifies the NuGet configuration (<em>nuget.config</em>) file to use.</summary>
    [Argument(Format = "--configfile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
    /// <summary>Specifies the <a href="https://docs.microsoft.com/en-us/dotnet/standard/frameworks">target framework</a> to update the tool for.</summary>
    [Argument(Format = "--framework {value}")] public string Framework => Get<string>(() => Framework);
    /// <summary>Specifies that the installation is user wide. Can't be combined with the <c>--tool-path</c> option. If you don't specify this option, you must specify the <c>--tool-path</c> option.</summary>
    [Argument(Format = "--global")] public bool? Global => Get<bool?>(() => Global);
    /// <summary>Specifies the location where the Global Tool is installed. The path can be absolute or relative. Can't be combined with the <c>--global</c> option. If you don't specify this option, you must specify the <c>--global</c> option.</summary>
    [Argument(Format = "--tool-path {value}")] public string ToolInstallationPath => Get<string>(() => ToolInstallationPath);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
    /// <summary>The version of the tool to install. By default, the latest stable package version is installed. Use this option to install preview or older versions of the tool.</summary>
    [Argument(Format = "--version {value}")] public string Version => Get<string>(() => Version);
}
#endregion
#region DotNetWorkloadInstallSettings
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadInstall(Nuke.Common.Tools.DotNet.DotNetWorkloadInstallSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetWorkloadInstall), Arguments = "workload install")]
public partial class DotNetWorkloadInstallSettings : ToolOptions
{
    /// <summary>The workload ID or multiple IDs to install.</summary>
    [Argument(Format = "{value}", Position = 1)] public IReadOnlyList<string> WorkloadId => Get<List<string>>(() => WorkloadId);
    /// <summary>The NuGet configuration file (nuget.config) to use. If specified, only the settings from this file will be used. If not specified, the hierarchy of configuration files from the current directory will be used.</summary>
    [Argument(Format = "--configFile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
    /// <summary>Prevents restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Treats package source failures as warnings.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Allows prerelease workload manifests.</summary>
    [Argument(Format = "--include-previews")] public bool? IncludePreviews => Get<bool?>(() => IncludePreviews);
    /// <summary>Allows the command to stop and wait for user input or action. For example, to complete authentication.</summary>
    [Argument(Format = "--interactive")] public bool? Interactive => Get<bool?>(() => Interactive);
    /// <summary>Prevents caching of packages and http requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>Skip updating the workload manifests. The workload manifests define what assets and versions need to be installed for each workload.</summary>
    [Argument(Format = "--skip-manifest-update")] public bool? SkipManifestUpdate => Get<bool?>(() => SkipManifestUpdate);
    /// <summary>Skipping the nuget package signature verification.</summary>
    [Argument(Format = "--skip-sign-check")] public bool? SkipSignCheck => Get<bool?>(() => SkipSignCheck);
    /// <summary>Specifies the URI of the NuGet package source to use. This setting overrides all of the sources specified in the nuget.config files. Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public string Source => Get<string>(() => Source);
    /// <summary>Specify the temporary directory used to download and extract NuGet packages (must be secure).</summary>
    [Argument(Format = "--temp-dir {value}")] public string TempDir => Get<string>(() => TempDir);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
}
#endregion
#region DotNetWorkloadUninstallSettings
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadUninstall(Nuke.Common.Tools.DotNet.DotNetWorkloadUninstallSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetWorkloadUninstall), Arguments = "workload uninstall")]
public partial class DotNetWorkloadUninstallSettings : ToolOptions
{
    /// <summary>The workload ID or multiple IDs to install.</summary>
    [Argument(Format = "{value}")] public IReadOnlyList<string> WorkloadId => Get<List<string>>(() => WorkloadId);
}
#endregion
#region DotNetWorkloadRestoreSettings
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadRestore(Nuke.Common.Tools.DotNet.DotNetWorkloadRestoreSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetWorkloadRestore), Arguments = "workload restore")]
public partial class DotNetWorkloadRestoreSettings : ToolOptions
{
    /// <summary>The project or solution file to install workloads for. If a file is not specified, the command searches the current directory for one.</summary>
    [Argument(Format = "{value}", Position = 1)] public string Project => Get<string>(() => Project);
    /// <summary>The NuGet configuration file (nuget.config) to use. If specified, only the settings from this file will be used. If not specified, the hierarchy of configuration files from the current directory will be used.</summary>
    [Argument(Format = "--configFile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
    /// <summary>Prevents restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Treats package source failures as warnings.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Allows prerelease workload manifests.</summary>
    [Argument(Format = "--include-previews")] public bool? IncludePreviews => Get<bool?>(() => IncludePreviews);
    /// <summary>Allows the command to stop and wait for user input or action. For example, to complete authentication.</summary>
    [Argument(Format = "--interactive")] public bool? Interactive => Get<bool?>(() => Interactive);
    /// <summary>Prevents caching of packages and http requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>Skip updating the workload manifests. The workload manifests define what assets and versions need to be installed for each workload.</summary>
    [Argument(Format = "--skip-manifest-update")] public bool? SkipManifestUpdate => Get<bool?>(() => SkipManifestUpdate);
    /// <summary>Skipping the nuget package signature verification.</summary>
    [Argument(Format = "--skip-sign-check")] public bool? SkipSignCheck => Get<bool?>(() => SkipSignCheck);
    /// <summary>Specifies the URI of the NuGet package source to use. This setting overrides all of the sources specified in the nuget.config files. Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public string Source => Get<string>(() => Source);
    /// <summary>Specify the temporary directory used to download and extract NuGet packages (must be secure).</summary>
    [Argument(Format = "--temp-dir {value}")] public string TempDir => Get<string>(() => TempDir);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
}
#endregion
#region DotNetWorkloadUpdateSettings
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadUpdate(Nuke.Common.Tools.DotNet.DotNetWorkloadUpdateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetWorkloadUpdate), Arguments = "workload update")]
public partial class DotNetWorkloadUpdateSettings : ToolOptions
{
    /// <summary>Downloads advertising manifests but doesn't update any workloads.</summary>
    [Argument(Format = "--advertising-manifests-only")] public bool? AdvertisingManifestsOnly => Get<bool?>(() => AdvertisingManifestsOnly);
    /// <summary>The NuGet configuration file (nuget.config) to use. If specified, only the settings from this file will be used. If not specified, the hierarchy of configuration files from the current directory will be used.</summary>
    [Argument(Format = "--configFile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
    /// <summary>Prevents restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Include workloads installed with previous SDK versions in the update.</summary>
    [Argument(Format = "--from-previous-sdk")] public bool? FromPreviousSdk => Get<bool?>(() => FromPreviousSdk);
    /// <summary>Treats package source failures as warnings.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Allows prerelease workload manifests.</summary>
    [Argument(Format = "--include-previews")] public bool? IncludePreviews => Get<bool?>(() => IncludePreviews);
    /// <summary>Allows the command to stop and wait for user input or action. For example, to complete authentication.</summary>
    [Argument(Format = "--interactive")] public bool? Interactive => Get<bool?>(() => Interactive);
    /// <summary>Prevents caching of packages and http requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>Skipping the nuget package signature verification.</summary>
    [Argument(Format = "--skip-sign-check")] public bool? SkipSignCheck => Get<bool?>(() => SkipSignCheck);
    /// <summary>Specifies the URI of the NuGet package source to use. This setting overrides all of the sources specified in the nuget.config files. Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public string Source => Get<string>(() => Source);
    /// <summary>Specify the temporary directory used to download and extract NuGet packages (must be secure).</summary>
    [Argument(Format = "--temp-dir {value}")] public string TempDir => Get<string>(() => TempDir);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
}
#endregion
#region DotNetWorkloadRepairSettings
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadRepair(Nuke.Common.Tools.DotNet.DotNetWorkloadRepairSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(DotNetTasks), Command = nameof(DotNetTasks.DotNetWorkloadRepair), Arguments = "workload repair")]
public partial class DotNetWorkloadRepairSettings : ToolOptions
{
    /// <summary>The NuGet configuration file (nuget.config) to use. If specified, only the settings from this file will be used. If not specified, the hierarchy of configuration files from the current directory will be used.</summary>
    [Argument(Format = "--configFile {value}")] public string ConfigFile => Get<string>(() => ConfigFile);
    /// <summary>Prevents restoring multiple projects in parallel.</summary>
    [Argument(Format = "--disable-parallel")] public bool? DisableParallel => Get<bool?>(() => DisableParallel);
    /// <summary>Treats package source failures as warnings.</summary>
    [Argument(Format = "--ignore-failed-sources")] public bool? IgnoreFailedSources => Get<bool?>(() => IgnoreFailedSources);
    /// <summary>Allows prerelease workload manifests.</summary>
    [Argument(Format = "--include-previews")] public bool? IncludePreviews => Get<bool?>(() => IncludePreviews);
    /// <summary>Allows the command to stop and wait for user input or action. For example, to complete authentication.</summary>
    [Argument(Format = "--interactive")] public bool? Interactive => Get<bool?>(() => Interactive);
    /// <summary>Prevents caching of packages and http requests.</summary>
    [Argument(Format = "--no-cache")] public bool? NoCache => Get<bool?>(() => NoCache);
    /// <summary>Skipping the nuget package signature verification.</summary>
    [Argument(Format = "--skip-sign-check")] public bool? SkipSignCheck => Get<bool?>(() => SkipSignCheck);
    /// <summary>Specifies the URI of the NuGet package source to use. This setting overrides all of the sources specified in the nuget.config files. Multiple sources can be provided by specifying this option multiple times.</summary>
    [Argument(Format = "--source {value}")] public string Source => Get<string>(() => Source);
    /// <summary>Specify the temporary directory used to download and extract NuGet packages (must be secure).</summary>
    [Argument(Format = "--temp-dir {value}")] public string TempDir => Get<string>(() => TempDir);
    /// <summary>Sets the verbosity level of the command. Allowed values are <c>q[uiet]</c>, <c>m[inimal]</c>, <c>n[ormal]</c>, <c>d[etailed]</c>, and <c>diag[nostic]</c>.</summary>
    [Argument(Format = "--verbosity {value}")] public DotNetVerbosity Verbosity => Get<DotNetVerbosity>(() => Verbosity);
}
#endregion
#region DotNetTestSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetTest(Nuke.Common.Tools.DotNet.DotNetTestSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetTestSettingsExtensions
{
    #region ProjectFile
    /// <inheritdoc cref="DotNetTestSettings.ProjectFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ProjectFile))]
    public static T SetProjectFile<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ProjectFile, v));
    /// <inheritdoc cref="DotNetTestSettings.ProjectFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ProjectFile))]
    public static T ResetProjectFile<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.ProjectFile));
    #endregion
    #region TestAdapterPath
    /// <inheritdoc cref="DotNetTestSettings.TestAdapterPath"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.TestAdapterPath))]
    public static T SetTestAdapterPath<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.TestAdapterPath, v));
    /// <inheritdoc cref="DotNetTestSettings.TestAdapterPath"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.TestAdapterPath))]
    public static T ResetTestAdapterPath<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.TestAdapterPath));
    #endregion
    #region Configuration
    /// <inheritdoc cref="DotNetTestSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Configuration))]
    public static T SetConfiguration<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Configuration, v));
    /// <inheritdoc cref="DotNetTestSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Configuration))]
    public static T ResetConfiguration<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.Configuration));
    #endregion
    #region DataCollector
    /// <inheritdoc cref="DotNetTestSettings.DataCollector"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.DataCollector))]
    public static T SetDataCollector<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.DataCollector, v));
    /// <inheritdoc cref="DotNetTestSettings.DataCollector"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.DataCollector))]
    public static T ResetDataCollector<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.DataCollector));
    #endregion
    #region DiagnosticsFile
    /// <inheritdoc cref="DotNetTestSettings.DiagnosticsFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.DiagnosticsFile))]
    public static T SetDiagnosticsFile<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.DiagnosticsFile, v));
    /// <inheritdoc cref="DotNetTestSettings.DiagnosticsFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.DiagnosticsFile))]
    public static T ResetDiagnosticsFile<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.DiagnosticsFile));
    #endregion
    #region Framework
    /// <inheritdoc cref="DotNetTestSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Framework))]
    public static T SetFramework<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Framework, v));
    /// <inheritdoc cref="DotNetTestSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Framework))]
    public static T ResetFramework<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.Framework));
    #endregion
    #region Filter
    /// <inheritdoc cref="DotNetTestSettings.Filter"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Filter))]
    public static T SetFilter<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Filter, v));
    /// <inheritdoc cref="DotNetTestSettings.Filter"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Filter))]
    public static T ResetFilter<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.Filter));
    #endregion
    #region Loggers
    /// <inheritdoc cref="DotNetTestSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Loggers))]
    public static T SetLoggers<T>(this T o, params string[] v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetTestSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Loggers))]
    public static T SetLoggers<T>(this T o, IEnumerable<string> v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetTestSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Loggers))]
    public static T AddLoggers<T>(this T o, params string[] v) where T : DotNetTestSettings => o.Modify(b => b.AddCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetTestSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Loggers))]
    public static T AddLoggers<T>(this T o, IEnumerable<string> v) where T : DotNetTestSettings => o.Modify(b => b.AddCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetTestSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Loggers))]
    public static T RemoveLoggers<T>(this T o, params string[] v) where T : DotNetTestSettings => o.Modify(b => b.RemoveCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetTestSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Loggers))]
    public static T RemoveLoggers<T>(this T o, IEnumerable<string> v) where T : DotNetTestSettings => o.Modify(b => b.RemoveCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetTestSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Loggers))]
    public static T ClearLoggers<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.ClearCollection(() => o.Loggers));
    #endregion
    #region NoBuild
    /// <inheritdoc cref="DotNetTestSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoBuild))]
    public static T SetNoBuild<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoBuild, v));
    /// <inheritdoc cref="DotNetTestSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoBuild))]
    public static T ResetNoBuild<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.NoBuild));
    /// <inheritdoc cref="DotNetTestSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoBuild))]
    public static T EnableNoBuild<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoBuild, true));
    /// <inheritdoc cref="DotNetTestSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoBuild))]
    public static T DisableNoBuild<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoBuild, false));
    /// <inheritdoc cref="DotNetTestSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoBuild))]
    public static T ToggleNoBuild<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoBuild, !o.NoBuild));
    #endregion
    #region NoRestore
    /// <inheritdoc cref="DotNetTestSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoRestore))]
    public static T SetNoRestore<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoRestore, v));
    /// <inheritdoc cref="DotNetTestSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoRestore))]
    public static T ResetNoRestore<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.NoRestore));
    /// <inheritdoc cref="DotNetTestSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoRestore))]
    public static T EnableNoRestore<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoRestore, true));
    /// <inheritdoc cref="DotNetTestSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoRestore))]
    public static T DisableNoRestore<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoRestore, false));
    /// <inheritdoc cref="DotNetTestSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoRestore))]
    public static T ToggleNoRestore<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoRestore, !o.NoRestore));
    #endregion
    #region Output
    /// <inheritdoc cref="DotNetTestSettings.Output"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Output))]
    public static T SetOutput<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="DotNetTestSettings.Output"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region ResultsDirectory
    /// <inheritdoc cref="DotNetTestSettings.ResultsDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ResultsDirectory))]
    public static T SetResultsDirectory<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ResultsDirectory, v));
    /// <inheritdoc cref="DotNetTestSettings.ResultsDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ResultsDirectory))]
    public static T ResetResultsDirectory<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.ResultsDirectory));
    #endregion
    #region SettingsFile
    /// <inheritdoc cref="DotNetTestSettings.SettingsFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.SettingsFile))]
    public static T SetSettingsFile<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.SettingsFile, v));
    /// <inheritdoc cref="DotNetTestSettings.SettingsFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.SettingsFile))]
    public static T ResetSettingsFile<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.SettingsFile));
    #endregion
    #region ListTests
    /// <inheritdoc cref="DotNetTestSettings.ListTests"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ListTests))]
    public static T SetListTests<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ListTests, v));
    /// <inheritdoc cref="DotNetTestSettings.ListTests"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ListTests))]
    public static T ResetListTests<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.ListTests));
    /// <inheritdoc cref="DotNetTestSettings.ListTests"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ListTests))]
    public static T EnableListTests<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ListTests, true));
    /// <inheritdoc cref="DotNetTestSettings.ListTests"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ListTests))]
    public static T DisableListTests<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ListTests, false));
    /// <inheritdoc cref="DotNetTestSettings.ListTests"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ListTests))]
    public static T ToggleListTests<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ListTests, !o.ListTests));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetTestSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetTestSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region Properties
    /// <inheritdoc cref="DotNetTestSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Properties))]
    public static T SetProperties<T>(this T o, IDictionary<string, object> v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Properties, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetTestSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Properties))]
    public static T SetProperty<T>(this T o, string k, object v) where T : DotNetTestSettings => o.Modify(b => b.SetDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetTestSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Properties))]
    public static T AddProperty<T>(this T o, string k, object v) where T : DotNetTestSettings => o.Modify(b => b.AddDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetTestSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Properties))]
    public static T RemoveProperty<T>(this T o, string k) where T : DotNetTestSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, k));
    /// <inheritdoc cref="DotNetTestSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Properties))]
    public static T ClearProperties<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.ClearDictionary(() => o.Properties));
    #endregion
    #region BlameMode
    /// <inheritdoc cref="DotNetTestSettings.BlameMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameMode))]
    public static T SetBlameMode<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameMode, v));
    /// <inheritdoc cref="DotNetTestSettings.BlameMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameMode))]
    public static T ResetBlameMode<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.BlameMode));
    /// <inheritdoc cref="DotNetTestSettings.BlameMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameMode))]
    public static T EnableBlameMode<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameMode, true));
    /// <inheritdoc cref="DotNetTestSettings.BlameMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameMode))]
    public static T DisableBlameMode<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameMode, false));
    /// <inheritdoc cref="DotNetTestSettings.BlameMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameMode))]
    public static T ToggleBlameMode<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameMode, !o.BlameMode));
    #endregion
    #region BlameCrash
    /// <inheritdoc cref="DotNetTestSettings.BlameCrash"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrash))]
    public static T SetBlameCrash<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameCrash, v));
    /// <inheritdoc cref="DotNetTestSettings.BlameCrash"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrash))]
    public static T ResetBlameCrash<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.BlameCrash));
    /// <inheritdoc cref="DotNetTestSettings.BlameCrash"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrash))]
    public static T EnableBlameCrash<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameCrash, true));
    /// <inheritdoc cref="DotNetTestSettings.BlameCrash"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrash))]
    public static T DisableBlameCrash<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameCrash, false));
    /// <inheritdoc cref="DotNetTestSettings.BlameCrash"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrash))]
    public static T ToggleBlameCrash<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameCrash, !o.BlameCrash));
    #endregion
    #region BlameCrashDumpType
    /// <inheritdoc cref="DotNetTestSettings.BlameCrashDumpType"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrashDumpType))]
    public static T SetBlameCrashDumpType<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameCrashDumpType, v));
    /// <inheritdoc cref="DotNetTestSettings.BlameCrashDumpType"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrashDumpType))]
    public static T ResetBlameCrashDumpType<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.BlameCrashDumpType));
    #endregion
    #region BlameCrashCollectAlways
    /// <inheritdoc cref="DotNetTestSettings.BlameCrashCollectAlways"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrashCollectAlways))]
    public static T SetBlameCrashCollectAlways<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameCrashCollectAlways, v));
    /// <inheritdoc cref="DotNetTestSettings.BlameCrashCollectAlways"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrashCollectAlways))]
    public static T ResetBlameCrashCollectAlways<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.BlameCrashCollectAlways));
    /// <inheritdoc cref="DotNetTestSettings.BlameCrashCollectAlways"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrashCollectAlways))]
    public static T EnableBlameCrashCollectAlways<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameCrashCollectAlways, true));
    /// <inheritdoc cref="DotNetTestSettings.BlameCrashCollectAlways"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrashCollectAlways))]
    public static T DisableBlameCrashCollectAlways<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameCrashCollectAlways, false));
    /// <inheritdoc cref="DotNetTestSettings.BlameCrashCollectAlways"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameCrashCollectAlways))]
    public static T ToggleBlameCrashCollectAlways<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameCrashCollectAlways, !o.BlameCrashCollectAlways));
    #endregion
    #region BlameHang
    /// <inheritdoc cref="DotNetTestSettings.BlameHang"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameHang))]
    public static T SetBlameHang<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameHang, v));
    /// <inheritdoc cref="DotNetTestSettings.BlameHang"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameHang))]
    public static T ResetBlameHang<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.BlameHang));
    /// <inheritdoc cref="DotNetTestSettings.BlameHang"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameHang))]
    public static T EnableBlameHang<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameHang, true));
    /// <inheritdoc cref="DotNetTestSettings.BlameHang"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameHang))]
    public static T DisableBlameHang<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameHang, false));
    /// <inheritdoc cref="DotNetTestSettings.BlameHang"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameHang))]
    public static T ToggleBlameHang<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameHang, !o.BlameHang));
    #endregion
    #region BlameHangDumpType
    /// <inheritdoc cref="DotNetTestSettings.BlameHangDumpType"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameHangDumpType))]
    public static T SetBlameHangDumpType<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameHangDumpType, v));
    /// <inheritdoc cref="DotNetTestSettings.BlameHangDumpType"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameHangDumpType))]
    public static T ResetBlameHangDumpType<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.BlameHangDumpType));
    #endregion
    #region BlameHangTimeout
    /// <inheritdoc cref="DotNetTestSettings.BlameHangTimeout"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameHangTimeout))]
    public static T SetBlameHangTimeout<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.BlameHangTimeout, v));
    /// <inheritdoc cref="DotNetTestSettings.BlameHangTimeout"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.BlameHangTimeout))]
    public static T ResetBlameHangTimeout<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.BlameHangTimeout));
    #endregion
    #region RunSettings
    /// <inheritdoc cref="DotNetTestSettings.RunSettings"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.RunSettings))]
    public static T SetRunSettings<T>(this T o, IDictionary<string, object> v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.RunSettings, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetTestSettings.RunSettings"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.RunSettings))]
    public static T SetRunSetting<T>(this T o, string k, object v) where T : DotNetTestSettings => o.Modify(b => b.SetDictionary(() => o.RunSettings, k, v));
    /// <inheritdoc cref="DotNetTestSettings.RunSettings"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.RunSettings))]
    public static T AddRunSetting<T>(this T o, string k, object v) where T : DotNetTestSettings => o.Modify(b => b.AddDictionary(() => o.RunSettings, k, v));
    /// <inheritdoc cref="DotNetTestSettings.RunSettings"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.RunSettings))]
    public static T RemoveRunSetting<T>(this T o, string k) where T : DotNetTestSettings => o.Modify(b => b.RemoveDictionary(() => o.RunSettings, k));
    /// <inheritdoc cref="DotNetTestSettings.RunSettings"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.RunSettings))]
    public static T ClearRunSettings<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.ClearDictionary(() => o.RunSettings));
    #endregion
    #region NoLogo
    /// <inheritdoc cref="DotNetTestSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoLogo))]
    public static T SetNoLogo<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoLogo, v));
    /// <inheritdoc cref="DotNetTestSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoLogo))]
    public static T ResetNoLogo<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.NoLogo));
    /// <inheritdoc cref="DotNetTestSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoLogo))]
    public static T EnableNoLogo<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoLogo, true));
    /// <inheritdoc cref="DotNetTestSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoLogo))]
    public static T DisableNoLogo<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoLogo, false));
    /// <inheritdoc cref="DotNetTestSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoLogo))]
    public static T ToggleNoLogo<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoLogo, !o.NoLogo));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetTestSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetTestSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetTestSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetTestSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetTestSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region Force
    /// <inheritdoc cref="DotNetTestSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="DotNetTestSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Force))]
    public static T ResetForce<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="DotNetTestSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Force))]
    public static T EnableForce<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="DotNetTestSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Force))]
    public static T DisableForce<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="DotNetTestSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetTestSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetTestSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetTestSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetTestSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetTestSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetTestSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetTestSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetTestSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetTestSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetTestSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region NoDependencies
    /// <inheritdoc cref="DotNetTestSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoDependencies))]
    public static T SetNoDependencies<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoDependencies, v));
    /// <inheritdoc cref="DotNetTestSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoDependencies))]
    public static T ResetNoDependencies<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.NoDependencies));
    /// <inheritdoc cref="DotNetTestSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoDependencies))]
    public static T EnableNoDependencies<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoDependencies, true));
    /// <inheritdoc cref="DotNetTestSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoDependencies))]
    public static T DisableNoDependencies<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoDependencies, false));
    /// <inheritdoc cref="DotNetTestSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.NoDependencies))]
    public static T ToggleNoDependencies<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.NoDependencies, !o.NoDependencies));
    #endregion
    #region PackageDirectory
    /// <inheritdoc cref="DotNetTestSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.PackageDirectory))]
    public static T SetPackageDirectory<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.PackageDirectory, v));
    /// <inheritdoc cref="DotNetTestSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.PackageDirectory))]
    public static T ResetPackageDirectory<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.PackageDirectory));
    #endregion
    #region Sources
    /// <inheritdoc cref="DotNetTestSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Sources))]
    public static T SetSources<T>(this T o, params string[] v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetTestSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Sources))]
    public static T SetSources<T>(this T o, IEnumerable<string> v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetTestSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Sources))]
    public static T AddSources<T>(this T o, params string[] v) where T : DotNetTestSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetTestSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Sources))]
    public static T AddSources<T>(this T o, IEnumerable<string> v) where T : DotNetTestSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetTestSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Sources))]
    public static T RemoveSources<T>(this T o, params string[] v) where T : DotNetTestSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetTestSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Sources))]
    public static T RemoveSources<T>(this T o, IEnumerable<string> v) where T : DotNetTestSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetTestSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Sources))]
    public static T ClearSources<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.ClearCollection(() => o.Sources));
    #endregion
    #region UseLockFile
    /// <inheritdoc cref="DotNetTestSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.UseLockFile))]
    public static T SetUseLockFile<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.UseLockFile, v));
    /// <inheritdoc cref="DotNetTestSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.UseLockFile))]
    public static T ResetUseLockFile<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.UseLockFile));
    /// <inheritdoc cref="DotNetTestSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.UseLockFile))]
    public static T EnableUseLockFile<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.UseLockFile, true));
    /// <inheritdoc cref="DotNetTestSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.UseLockFile))]
    public static T DisableUseLockFile<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.UseLockFile, false));
    /// <inheritdoc cref="DotNetTestSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.UseLockFile))]
    public static T ToggleUseLockFile<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.UseLockFile, !o.UseLockFile));
    #endregion
    #region LockedMode
    /// <inheritdoc cref="DotNetTestSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.LockedMode))]
    public static T SetLockedMode<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.LockedMode, v));
    /// <inheritdoc cref="DotNetTestSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.LockedMode))]
    public static T ResetLockedMode<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.LockedMode));
    /// <inheritdoc cref="DotNetTestSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.LockedMode))]
    public static T EnableLockedMode<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.LockedMode, true));
    /// <inheritdoc cref="DotNetTestSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.LockedMode))]
    public static T DisableLockedMode<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.LockedMode, false));
    /// <inheritdoc cref="DotNetTestSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.LockedMode))]
    public static T ToggleLockedMode<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.LockedMode, !o.LockedMode));
    #endregion
    #region LockFilePath
    /// <inheritdoc cref="DotNetTestSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.LockFilePath))]
    public static T SetLockFilePath<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.LockFilePath, v));
    /// <inheritdoc cref="DotNetTestSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.LockFilePath))]
    public static T ResetLockFilePath<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.LockFilePath));
    #endregion
    #region ForceEvaluate
    /// <inheritdoc cref="DotNetTestSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ForceEvaluate))]
    public static T SetForceEvaluate<T>(this T o, bool? v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, v));
    /// <inheritdoc cref="DotNetTestSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ForceEvaluate))]
    public static T ResetForceEvaluate<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.ForceEvaluate));
    /// <inheritdoc cref="DotNetTestSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ForceEvaluate))]
    public static T EnableForceEvaluate<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, true));
    /// <inheritdoc cref="DotNetTestSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ForceEvaluate))]
    public static T DisableForceEvaluate<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, false));
    /// <inheritdoc cref="DotNetTestSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.ForceEvaluate))]
    public static T ToggleForceEvaluate<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, !o.ForceEvaluate));
    #endregion
    #region Runtime
    /// <inheritdoc cref="DotNetTestSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Runtime))]
    public static T SetRuntime<T>(this T o, string v) where T : DotNetTestSettings => o.Modify(b => b.Set(() => o.Runtime, v));
    /// <inheritdoc cref="DotNetTestSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetTestSettings), Property = nameof(DotNetTestSettings.Runtime))]
    public static T ResetRuntime<T>(this T o) where T : DotNetTestSettings => o.Modify(b => b.Remove(() => o.Runtime));
    #endregion
}
#endregion
#region DotNetRunSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetRun(Nuke.Common.Tools.DotNet.DotNetRunSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetRunSettingsExtensions
{
    #region Architecture
    /// <inheritdoc cref="DotNetRunSettings.Architecture"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Architecture))]
    public static T SetArchitecture<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Architecture, v));
    /// <inheritdoc cref="DotNetRunSettings.Architecture"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Architecture))]
    public static T ResetArchitecture<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.Architecture));
    #endregion
    #region Configuration
    /// <inheritdoc cref="DotNetRunSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Configuration))]
    public static T SetConfiguration<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Configuration, v));
    /// <inheritdoc cref="DotNetRunSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Configuration))]
    public static T ResetConfiguration<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.Configuration));
    #endregion
    #region DisableBuildServers
    /// <inheritdoc cref="DotNetRunSettings.DisableBuildServers"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableBuildServers))]
    public static T SetDisableBuildServers<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.DisableBuildServers, v));
    /// <inheritdoc cref="DotNetRunSettings.DisableBuildServers"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableBuildServers))]
    public static T ResetDisableBuildServers<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.DisableBuildServers));
    /// <inheritdoc cref="DotNetRunSettings.DisableBuildServers"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableBuildServers))]
    public static T EnableDisableBuildServers<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.DisableBuildServers, true));
    /// <inheritdoc cref="DotNetRunSettings.DisableBuildServers"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableBuildServers))]
    public static T DisableDisableBuildServers<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.DisableBuildServers, false));
    /// <inheritdoc cref="DotNetRunSettings.DisableBuildServers"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableBuildServers))]
    public static T ToggleDisableBuildServers<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.DisableBuildServers, !o.DisableBuildServers));
    #endregion
    #region Framework
    /// <inheritdoc cref="DotNetRunSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Framework))]
    public static T SetFramework<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Framework, v));
    /// <inheritdoc cref="DotNetRunSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Framework))]
    public static T ResetFramework<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.Framework));
    #endregion
    #region LaunchProfile
    /// <inheritdoc cref="DotNetRunSettings.LaunchProfile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.LaunchProfile))]
    public static T SetLaunchProfile<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.LaunchProfile, v));
    /// <inheritdoc cref="DotNetRunSettings.LaunchProfile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.LaunchProfile))]
    public static T ResetLaunchProfile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.LaunchProfile));
    #endregion
    #region Interactive
    /// <inheritdoc cref="DotNetRunSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Interactive))]
    public static T SetInteractive<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Interactive, v));
    /// <inheritdoc cref="DotNetRunSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Interactive))]
    public static T ResetInteractive<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.Interactive));
    /// <inheritdoc cref="DotNetRunSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Interactive))]
    public static T EnableInteractive<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Interactive, true));
    /// <inheritdoc cref="DotNetRunSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Interactive))]
    public static T DisableInteractive<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Interactive, false));
    /// <inheritdoc cref="DotNetRunSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Interactive))]
    public static T ToggleInteractive<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Interactive, !o.Interactive));
    #endregion
    #region NoBuild
    /// <inheritdoc cref="DotNetRunSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoBuild))]
    public static T SetNoBuild<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoBuild, v));
    /// <inheritdoc cref="DotNetRunSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoBuild))]
    public static T ResetNoBuild<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.NoBuild));
    /// <inheritdoc cref="DotNetRunSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoBuild))]
    public static T EnableNoBuild<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoBuild, true));
    /// <inheritdoc cref="DotNetRunSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoBuild))]
    public static T DisableNoBuild<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoBuild, false));
    /// <inheritdoc cref="DotNetRunSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoBuild))]
    public static T ToggleNoBuild<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoBuild, !o.NoBuild));
    #endregion
    #region NoLaunchProfile
    /// <inheritdoc cref="DotNetRunSettings.NoLaunchProfile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoLaunchProfile))]
    public static T SetNoLaunchProfile<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoLaunchProfile, v));
    /// <inheritdoc cref="DotNetRunSettings.NoLaunchProfile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoLaunchProfile))]
    public static T ResetNoLaunchProfile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.NoLaunchProfile));
    /// <inheritdoc cref="DotNetRunSettings.NoLaunchProfile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoLaunchProfile))]
    public static T EnableNoLaunchProfile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoLaunchProfile, true));
    /// <inheritdoc cref="DotNetRunSettings.NoLaunchProfile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoLaunchProfile))]
    public static T DisableNoLaunchProfile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoLaunchProfile, false));
    /// <inheritdoc cref="DotNetRunSettings.NoLaunchProfile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoLaunchProfile))]
    public static T ToggleNoLaunchProfile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoLaunchProfile, !o.NoLaunchProfile));
    #endregion
    #region NoRestore
    /// <inheritdoc cref="DotNetRunSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoRestore))]
    public static T SetNoRestore<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoRestore, v));
    /// <inheritdoc cref="DotNetRunSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoRestore))]
    public static T ResetNoRestore<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.NoRestore));
    /// <inheritdoc cref="DotNetRunSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoRestore))]
    public static T EnableNoRestore<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoRestore, true));
    /// <inheritdoc cref="DotNetRunSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoRestore))]
    public static T DisableNoRestore<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoRestore, false));
    /// <inheritdoc cref="DotNetRunSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoRestore))]
    public static T ToggleNoRestore<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoRestore, !o.NoRestore));
    #endregion
    #region NoSelfContained
    /// <inheritdoc cref="DotNetRunSettings.NoSelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoSelfContained))]
    public static T SetNoSelfContained<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoSelfContained, v));
    /// <inheritdoc cref="DotNetRunSettings.NoSelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoSelfContained))]
    public static T ResetNoSelfContained<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.NoSelfContained));
    /// <inheritdoc cref="DotNetRunSettings.NoSelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoSelfContained))]
    public static T EnableNoSelfContained<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoSelfContained, true));
    /// <inheritdoc cref="DotNetRunSettings.NoSelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoSelfContained))]
    public static T DisableNoSelfContained<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoSelfContained, false));
    /// <inheritdoc cref="DotNetRunSettings.NoSelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoSelfContained))]
    public static T ToggleNoSelfContained<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoSelfContained, !o.NoSelfContained));
    #endregion
    #region OperatingSystem
    /// <inheritdoc cref="DotNetRunSettings.OperatingSystem"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.OperatingSystem))]
    public static T SetOperatingSystem<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.OperatingSystem, v));
    /// <inheritdoc cref="DotNetRunSettings.OperatingSystem"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.OperatingSystem))]
    public static T ResetOperatingSystem<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.OperatingSystem));
    #endregion
    #region ProjectFile
    /// <inheritdoc cref="DotNetRunSettings.ProjectFile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ProjectFile))]
    public static T SetProjectFile<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.ProjectFile, v));
    /// <inheritdoc cref="DotNetRunSettings.ProjectFile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ProjectFile))]
    public static T ResetProjectFile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.ProjectFile));
    #endregion
    #region Runtime
    /// <inheritdoc cref="DotNetRunSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Runtime))]
    public static T SetRuntime<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Runtime, v));
    /// <inheritdoc cref="DotNetRunSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Runtime))]
    public static T ResetRuntime<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.Runtime));
    #endregion
    #region SelfContained
    /// <inheritdoc cref="DotNetRunSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.SelfContained))]
    public static T SetSelfContained<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.SelfContained, v));
    /// <inheritdoc cref="DotNetRunSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.SelfContained))]
    public static T ResetSelfContained<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.SelfContained));
    /// <inheritdoc cref="DotNetRunSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.SelfContained))]
    public static T EnableSelfContained<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.SelfContained, true));
    /// <inheritdoc cref="DotNetRunSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.SelfContained))]
    public static T DisableSelfContained<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.SelfContained, false));
    /// <inheritdoc cref="DotNetRunSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.SelfContained))]
    public static T ToggleSelfContained<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.SelfContained, !o.SelfContained));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetRunSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetRunSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region ApplicationArguments
    /// <inheritdoc cref="DotNetRunSettings.ApplicationArguments"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ApplicationArguments))]
    public static T SetApplicationArguments<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.ApplicationArguments, v));
    /// <inheritdoc cref="DotNetRunSettings.ApplicationArguments"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ApplicationArguments))]
    public static T SetApplicationArguments<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.ApplicationArguments, v));
    /// <inheritdoc cref="DotNetRunSettings.ApplicationArguments"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ApplicationArguments))]
    public static T AddApplicationArguments<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.AddCollection(() => o.ApplicationArguments, v));
    /// <inheritdoc cref="DotNetRunSettings.ApplicationArguments"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ApplicationArguments))]
    public static T AddApplicationArguments<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.AddCollection(() => o.ApplicationArguments, v));
    /// <inheritdoc cref="DotNetRunSettings.ApplicationArguments"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ApplicationArguments))]
    public static T RemoveApplicationArguments<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.RemoveCollection(() => o.ApplicationArguments, v));
    /// <inheritdoc cref="DotNetRunSettings.ApplicationArguments"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ApplicationArguments))]
    public static T RemoveApplicationArguments<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.RemoveCollection(() => o.ApplicationArguments, v));
    /// <inheritdoc cref="DotNetRunSettings.ApplicationArguments"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ApplicationArguments))]
    public static T ClearApplicationArguments<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.ClearCollection(() => o.ApplicationArguments));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetRunSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetRunSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetRunSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetRunSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetRunSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region Force
    /// <inheritdoc cref="DotNetRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="DotNetRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Force))]
    public static T ResetForce<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="DotNetRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Force))]
    public static T EnableForce<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="DotNetRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Force))]
    public static T DisableForce<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="DotNetRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetRunSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetRunSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetRunSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetRunSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetRunSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetRunSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetRunSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetRunSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetRunSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetRunSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region NoDependencies
    /// <inheritdoc cref="DotNetRunSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoDependencies))]
    public static T SetNoDependencies<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoDependencies, v));
    /// <inheritdoc cref="DotNetRunSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoDependencies))]
    public static T ResetNoDependencies<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.NoDependencies));
    /// <inheritdoc cref="DotNetRunSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoDependencies))]
    public static T EnableNoDependencies<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoDependencies, true));
    /// <inheritdoc cref="DotNetRunSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoDependencies))]
    public static T DisableNoDependencies<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoDependencies, false));
    /// <inheritdoc cref="DotNetRunSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.NoDependencies))]
    public static T ToggleNoDependencies<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.NoDependencies, !o.NoDependencies));
    #endregion
    #region PackageDirectory
    /// <inheritdoc cref="DotNetRunSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.PackageDirectory))]
    public static T SetPackageDirectory<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.PackageDirectory, v));
    /// <inheritdoc cref="DotNetRunSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.PackageDirectory))]
    public static T ResetPackageDirectory<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.PackageDirectory));
    #endregion
    #region Sources
    /// <inheritdoc cref="DotNetRunSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Sources))]
    public static T SetSources<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRunSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Sources))]
    public static T SetSources<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRunSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Sources))]
    public static T AddSources<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRunSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Sources))]
    public static T AddSources<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRunSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Sources))]
    public static T RemoveSources<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRunSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Sources))]
    public static T RemoveSources<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRunSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Sources))]
    public static T ClearSources<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.ClearCollection(() => o.Sources));
    #endregion
    #region UseLockFile
    /// <inheritdoc cref="DotNetRunSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.UseLockFile))]
    public static T SetUseLockFile<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.UseLockFile, v));
    /// <inheritdoc cref="DotNetRunSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.UseLockFile))]
    public static T ResetUseLockFile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.UseLockFile));
    /// <inheritdoc cref="DotNetRunSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.UseLockFile))]
    public static T EnableUseLockFile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.UseLockFile, true));
    /// <inheritdoc cref="DotNetRunSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.UseLockFile))]
    public static T DisableUseLockFile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.UseLockFile, false));
    /// <inheritdoc cref="DotNetRunSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.UseLockFile))]
    public static T ToggleUseLockFile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.UseLockFile, !o.UseLockFile));
    #endregion
    #region LockedMode
    /// <inheritdoc cref="DotNetRunSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.LockedMode))]
    public static T SetLockedMode<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.LockedMode, v));
    /// <inheritdoc cref="DotNetRunSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.LockedMode))]
    public static T ResetLockedMode<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.LockedMode));
    /// <inheritdoc cref="DotNetRunSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.LockedMode))]
    public static T EnableLockedMode<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.LockedMode, true));
    /// <inheritdoc cref="DotNetRunSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.LockedMode))]
    public static T DisableLockedMode<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.LockedMode, false));
    /// <inheritdoc cref="DotNetRunSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.LockedMode))]
    public static T ToggleLockedMode<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.LockedMode, !o.LockedMode));
    #endregion
    #region LockFilePath
    /// <inheritdoc cref="DotNetRunSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.LockFilePath))]
    public static T SetLockFilePath<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.LockFilePath, v));
    /// <inheritdoc cref="DotNetRunSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.LockFilePath))]
    public static T ResetLockFilePath<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.LockFilePath));
    #endregion
    #region ForceEvaluate
    /// <inheritdoc cref="DotNetRunSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ForceEvaluate))]
    public static T SetForceEvaluate<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, v));
    /// <inheritdoc cref="DotNetRunSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ForceEvaluate))]
    public static T ResetForceEvaluate<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Remove(() => o.ForceEvaluate));
    /// <inheritdoc cref="DotNetRunSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ForceEvaluate))]
    public static T EnableForceEvaluate<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, true));
    /// <inheritdoc cref="DotNetRunSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ForceEvaluate))]
    public static T DisableForceEvaluate<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, false));
    /// <inheritdoc cref="DotNetRunSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.ForceEvaluate))]
    public static T ToggleForceEvaluate<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, !o.ForceEvaluate));
    #endregion
    #region Properties
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetProperties<T>(this T o, IDictionary<string, object> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetProperty<T>(this T o, string k, object v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T AddProperty<T>(this T o, string k, object v) where T : DotNetRunSettings => o.Modify(b => b.AddDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T RemoveProperty<T>(this T o, string k) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, k));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ClearProperties<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.ClearDictionary(() => o.Properties));
    #region RunCodeAnalysis
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetRunCodeAnalysis<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetRunCodeAnalysis<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RunCodeAnalysis"));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T EnableRunCodeAnalysis<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", true));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T DisableRunCodeAnalysis<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", false));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ToggleRunCodeAnalysis<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "RunCodeAnalysis")));
    #endregion
    #region NoWarn
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetNoWarns<T>(this T o, params int[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T AddNoWarns<T>(this T o, params int[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T AddNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, params int[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetNoWarn<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "NoWarn"));
    #endregion
    #region WarningsAsErrors
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetWarningsAsErrors<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningsAsErrors"));
    #endregion
    #region WarningLevel
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetWarningLevel<T>(this T o, int? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "WarningLevel", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetWarningLevel<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningLevel"));
    #endregion
    #region TreatWarningsAsErrors
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetTreatWarningsAsErrors<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetTreatWarningsAsErrors<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "TreatWarningsAsErrors"));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T EnableTreatWarningsAsErrors<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", true));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T DisableTreatWarningsAsErrors<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", false));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ToggleTreatWarningsAsErrors<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "TreatWarningsAsErrors")));
    #endregion
    #region AssemblyVersion
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetAssemblyVersion<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "AssemblyVersion", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetAssemblyVersion<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "AssemblyVersion"));
    #endregion
    #region FileVersion
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetFileVersion<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "FileVersion", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetFileVersion<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "FileVersion"));
    #endregion
    #region InformationalVersion
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetInformationalVersion<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "InformationalVersion", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetInformationalVersion<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "InformationalVersion"));
    #endregion
    #region PackageId
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPackageId<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageId", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPackageId<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageId"));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Version", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetVersion<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Version"));
    #endregion
    #region VersionPrefix
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetVersionPrefix<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "VersionPrefix", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetVersionPrefix<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "VersionPrefix"));
    #endregion
    #region Authors
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetAuthors<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T AddAuthors<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T AddAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetAuthors<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Authors"));
    #endregion
    #region Title
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetTitle<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Title", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetTitle<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Title"));
    #endregion
    #region Description
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetDescription<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Description", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetDescription<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Description"));
    #endregion
    #region Copyright
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetCopyright<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Copyright", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetCopyright<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Copyright"));
    #endregion
    #region PackageRequireLicenseAcceptance
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPackageRequireLicenseAcceptance<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPackageRequireLicenseAcceptance<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageRequireLicenseAcceptance"));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T EnablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", true));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T DisablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", false));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T TogglePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PackageRequireLicenseAcceptance")));
    #endregion
    #region PackageLicenseUrl
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPackageLicenseUrl<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageLicenseUrl", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPackageLicenseUrl<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageLicenseUrl"));
    #endregion
    #region PackageProjectUrl
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPackageProjectUrl<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageProjectUrl", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPackageProjectUrl<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageProjectUrl"));
    #endregion
    #region PackageIconUrl
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPackageIconUrl<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageIconUrl", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPackageIconUrl<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageIconUrl"));
    #endregion
    #region PackageTags
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPackageTags<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T AddPackageTags<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T AddPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, params string[] v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPackageTags<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageTags"));
    #endregion
    #region PackageReleaseNotes
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPackageReleaseNotes<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageReleaseNotes", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPackageReleaseNotes<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageReleaseNotes"));
    #endregion
    #region RepositoryUrl
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetRepositoryUrl<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryUrl", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetRepositoryUrl<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryUrl"));
    #endregion
    #region RepositoryType
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetRepositoryType<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryType", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetRepositoryType<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryType"));
    #endregion
    #region SymbolPackageFormat
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetSymbolPackageFormat<T>(this T o, DotNetSymbolPackageFormat v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "SymbolPackageFormat", v));
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetSymbolPackageFormat<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "SymbolPackageFormat"));
    #endregion
    #region PublishReadyToRun
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPublishReadyToRun<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", v));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPublishReadyToRun<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishReadyToRun"));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T EnablePublishReadyToRun<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", true));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T DisablePublishReadyToRun<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", false));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T TogglePublishReadyToRun<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishReadyToRun")));
    #endregion
    #region PublishSingleFile
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPublishSingleFile<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", v));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPublishSingleFile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishSingleFile"));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T EnablePublishSingleFile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", true));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T DisablePublishSingleFile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", false));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T TogglePublishSingleFile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishSingleFile")));
    #endregion
    #region PublishTrimmed
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPublishTrimmed<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", v));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPublishTrimmed<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishTrimmed"));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T EnablePublishTrimmed<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", true));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T DisablePublishTrimmed<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", false));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T TogglePublishTrimmed<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishTrimmed")));
    #endregion
    #region PublishProfile
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPublishProfile<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishProfile", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPublishProfile<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishProfile"));
    #endregion
    #region Platform
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetPlatform<T>(this T o, string v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Platform", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetPlatform<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Platform"));
    #endregion
    #region ContinuousIntegrationBuild
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetContinuousIntegrationBuild<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetContinuousIntegrationBuild<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "ContinuousIntegrationBuild"));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T EnableContinuousIntegrationBuild<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", true));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T DisableContinuousIntegrationBuild<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", false));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ToggleContinuousIntegrationBuild<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "ContinuousIntegrationBuild")));
    #endregion
    #region DeterministicSourcePaths
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetDeterministicSourcePaths<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetDeterministicSourcePaths<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "DeterministicSourcePaths"));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T EnableDeterministicSourcePaths<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", true));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T DisableDeterministicSourcePaths<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", false));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ToggleDeterministicSourcePaths<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "DeterministicSourcePaths")));
    #endregion
    #region Deterministic
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T SetDeterministic<T>(this T o, bool? v) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", v));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ResetDeterministic<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Deterministic"));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T EnableDeterministic<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", true));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T DisableDeterministic<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", false));
    /// <inheritdoc cref="DotNetRunSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRunSettings), Property = nameof(DotNetRunSettings.Properties))]
    public static T ToggleDeterministic<T>(this T o) where T : DotNetRunSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "Deterministic")));
    #endregion
    #endregion
}
#endregion
#region DotNetRestoreSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetRestore(Nuke.Common.Tools.DotNet.DotNetRestoreSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetRestoreSettingsExtensions
{
    #region ProjectFile
    /// <inheritdoc cref="DotNetRestoreSettings.ProjectFile"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.ProjectFile))]
    public static T SetProjectFile<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.ProjectFile, v));
    /// <inheritdoc cref="DotNetRestoreSettings.ProjectFile"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.ProjectFile))]
    public static T ResetProjectFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.ProjectFile));
    #endregion
    #region ConfigFile
    /// <inheritdoc cref="DotNetRestoreSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetRestoreSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetRestoreSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region Force
    /// <inheritdoc cref="DotNetRestoreSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Force))]
    public static T ResetForce<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="DotNetRestoreSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Force))]
    public static T EnableForce<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="DotNetRestoreSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Force))]
    public static T DisableForce<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="DotNetRestoreSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region NoDependencies
    /// <inheritdoc cref="DotNetRestoreSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoDependencies))]
    public static T SetNoDependencies<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.NoDependencies, v));
    /// <inheritdoc cref="DotNetRestoreSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoDependencies))]
    public static T ResetNoDependencies<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.NoDependencies));
    /// <inheritdoc cref="DotNetRestoreSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoDependencies))]
    public static T EnableNoDependencies<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.NoDependencies, true));
    /// <inheritdoc cref="DotNetRestoreSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoDependencies))]
    public static T DisableNoDependencies<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.NoDependencies, false));
    /// <inheritdoc cref="DotNetRestoreSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.NoDependencies))]
    public static T ToggleNoDependencies<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.NoDependencies, !o.NoDependencies));
    #endregion
    #region PackageDirectory
    /// <inheritdoc cref="DotNetRestoreSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.PackageDirectory))]
    public static T SetPackageDirectory<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.PackageDirectory, v));
    /// <inheritdoc cref="DotNetRestoreSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.PackageDirectory))]
    public static T ResetPackageDirectory<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.PackageDirectory));
    #endregion
    #region Sources
    /// <inheritdoc cref="DotNetRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Sources))]
    public static T SetSources<T>(this T o, params string[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Sources))]
    public static T SetSources<T>(this T o, IEnumerable<string> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Sources))]
    public static T AddSources<T>(this T o, params string[] v) where T : DotNetRestoreSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Sources))]
    public static T AddSources<T>(this T o, IEnumerable<string> v) where T : DotNetRestoreSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Sources))]
    public static T RemoveSources<T>(this T o, params string[] v) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Sources))]
    public static T RemoveSources<T>(this T o, IEnumerable<string> v) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Sources))]
    public static T ClearSources<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.ClearCollection(() => o.Sources));
    #endregion
    #region UseLockFile
    /// <inheritdoc cref="DotNetRestoreSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.UseLockFile))]
    public static T SetUseLockFile<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.UseLockFile, v));
    /// <inheritdoc cref="DotNetRestoreSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.UseLockFile))]
    public static T ResetUseLockFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.UseLockFile));
    /// <inheritdoc cref="DotNetRestoreSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.UseLockFile))]
    public static T EnableUseLockFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.UseLockFile, true));
    /// <inheritdoc cref="DotNetRestoreSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.UseLockFile))]
    public static T DisableUseLockFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.UseLockFile, false));
    /// <inheritdoc cref="DotNetRestoreSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.UseLockFile))]
    public static T ToggleUseLockFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.UseLockFile, !o.UseLockFile));
    #endregion
    #region LockedMode
    /// <inheritdoc cref="DotNetRestoreSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.LockedMode))]
    public static T SetLockedMode<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.LockedMode, v));
    /// <inheritdoc cref="DotNetRestoreSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.LockedMode))]
    public static T ResetLockedMode<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.LockedMode));
    /// <inheritdoc cref="DotNetRestoreSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.LockedMode))]
    public static T EnableLockedMode<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.LockedMode, true));
    /// <inheritdoc cref="DotNetRestoreSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.LockedMode))]
    public static T DisableLockedMode<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.LockedMode, false));
    /// <inheritdoc cref="DotNetRestoreSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.LockedMode))]
    public static T ToggleLockedMode<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.LockedMode, !o.LockedMode));
    #endregion
    #region LockFilePath
    /// <inheritdoc cref="DotNetRestoreSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.LockFilePath))]
    public static T SetLockFilePath<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.LockFilePath, v));
    /// <inheritdoc cref="DotNetRestoreSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.LockFilePath))]
    public static T ResetLockFilePath<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.LockFilePath));
    #endregion
    #region ForceEvaluate
    /// <inheritdoc cref="DotNetRestoreSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.ForceEvaluate))]
    public static T SetForceEvaluate<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, v));
    /// <inheritdoc cref="DotNetRestoreSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.ForceEvaluate))]
    public static T ResetForceEvaluate<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.ForceEvaluate));
    /// <inheritdoc cref="DotNetRestoreSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.ForceEvaluate))]
    public static T EnableForceEvaluate<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, true));
    /// <inheritdoc cref="DotNetRestoreSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.ForceEvaluate))]
    public static T DisableForceEvaluate<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, false));
    /// <inheritdoc cref="DotNetRestoreSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.ForceEvaluate))]
    public static T ToggleForceEvaluate<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, !o.ForceEvaluate));
    #endregion
    #region Runtime
    /// <inheritdoc cref="DotNetRestoreSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Runtime))]
    public static T SetRuntime<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Runtime, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Runtime))]
    public static T ResetRuntime<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Remove(() => o.Runtime));
    #endregion
    #region Properties
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetProperties<T>(this T o, IDictionary<string, object> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetProperty<T>(this T o, string k, object v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T AddProperty<T>(this T o, string k, object v) where T : DotNetRestoreSettings => o.Modify(b => b.AddDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T RemoveProperty<T>(this T o, string k) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, k));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ClearProperties<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.ClearDictionary(() => o.Properties));
    #region RunCodeAnalysis
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetRunCodeAnalysis<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetRunCodeAnalysis<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RunCodeAnalysis"));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T EnableRunCodeAnalysis<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", true));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T DisableRunCodeAnalysis<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", false));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ToggleRunCodeAnalysis<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "RunCodeAnalysis")));
    #endregion
    #region NoWarn
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetNoWarns<T>(this T o, params int[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T AddNoWarns<T>(this T o, params int[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T AddNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, params int[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetNoWarn<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "NoWarn"));
    #endregion
    #region WarningsAsErrors
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetWarningsAsErrors<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningsAsErrors"));
    #endregion
    #region WarningLevel
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetWarningLevel<T>(this T o, int? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "WarningLevel", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetWarningLevel<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningLevel"));
    #endregion
    #region TreatWarningsAsErrors
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetTreatWarningsAsErrors<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetTreatWarningsAsErrors<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "TreatWarningsAsErrors"));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T EnableTreatWarningsAsErrors<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", true));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T DisableTreatWarningsAsErrors<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", false));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ToggleTreatWarningsAsErrors<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "TreatWarningsAsErrors")));
    #endregion
    #region AssemblyVersion
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetAssemblyVersion<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "AssemblyVersion", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetAssemblyVersion<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "AssemblyVersion"));
    #endregion
    #region FileVersion
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetFileVersion<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "FileVersion", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetFileVersion<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "FileVersion"));
    #endregion
    #region InformationalVersion
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetInformationalVersion<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "InformationalVersion", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetInformationalVersion<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "InformationalVersion"));
    #endregion
    #region PackageId
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPackageId<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageId", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPackageId<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageId"));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Version", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetVersion<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Version"));
    #endregion
    #region VersionPrefix
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetVersionPrefix<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "VersionPrefix", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetVersionPrefix<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "VersionPrefix"));
    #endregion
    #region Authors
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetAuthors<T>(this T o, params string[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T AddAuthors<T>(this T o, params string[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T AddAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, params string[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetAuthors<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Authors"));
    #endregion
    #region Title
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetTitle<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Title", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetTitle<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Title"));
    #endregion
    #region Description
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetDescription<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Description", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetDescription<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Description"));
    #endregion
    #region Copyright
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetCopyright<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Copyright", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetCopyright<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Copyright"));
    #endregion
    #region PackageRequireLicenseAcceptance
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPackageRequireLicenseAcceptance<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPackageRequireLicenseAcceptance<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageRequireLicenseAcceptance"));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T EnablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", true));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T DisablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", false));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T TogglePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PackageRequireLicenseAcceptance")));
    #endregion
    #region PackageLicenseUrl
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPackageLicenseUrl<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageLicenseUrl", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPackageLicenseUrl<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageLicenseUrl"));
    #endregion
    #region PackageProjectUrl
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPackageProjectUrl<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageProjectUrl", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPackageProjectUrl<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageProjectUrl"));
    #endregion
    #region PackageIconUrl
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPackageIconUrl<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageIconUrl", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPackageIconUrl<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageIconUrl"));
    #endregion
    #region PackageTags
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPackageTags<T>(this T o, params string[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T AddPackageTags<T>(this T o, params string[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T AddPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, params string[] v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPackageTags<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageTags"));
    #endregion
    #region PackageReleaseNotes
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPackageReleaseNotes<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageReleaseNotes", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPackageReleaseNotes<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageReleaseNotes"));
    #endregion
    #region RepositoryUrl
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetRepositoryUrl<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryUrl", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetRepositoryUrl<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryUrl"));
    #endregion
    #region RepositoryType
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetRepositoryType<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryType", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetRepositoryType<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryType"));
    #endregion
    #region SymbolPackageFormat
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetSymbolPackageFormat<T>(this T o, DotNetSymbolPackageFormat v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "SymbolPackageFormat", v));
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetSymbolPackageFormat<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "SymbolPackageFormat"));
    #endregion
    #region PublishReadyToRun
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPublishReadyToRun<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", v));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPublishReadyToRun<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishReadyToRun"));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T EnablePublishReadyToRun<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", true));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T DisablePublishReadyToRun<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", false));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T TogglePublishReadyToRun<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishReadyToRun")));
    #endregion
    #region PublishSingleFile
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPublishSingleFile<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", v));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPublishSingleFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishSingleFile"));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T EnablePublishSingleFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", true));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T DisablePublishSingleFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", false));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T TogglePublishSingleFile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishSingleFile")));
    #endregion
    #region PublishTrimmed
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPublishTrimmed<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", v));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPublishTrimmed<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishTrimmed"));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T EnablePublishTrimmed<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", true));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T DisablePublishTrimmed<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", false));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T TogglePublishTrimmed<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishTrimmed")));
    #endregion
    #region PublishProfile
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPublishProfile<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishProfile", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPublishProfile<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishProfile"));
    #endregion
    #region Platform
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetPlatform<T>(this T o, string v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Platform", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetPlatform<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Platform"));
    #endregion
    #region ContinuousIntegrationBuild
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetContinuousIntegrationBuild<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetContinuousIntegrationBuild<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "ContinuousIntegrationBuild"));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T EnableContinuousIntegrationBuild<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", true));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T DisableContinuousIntegrationBuild<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", false));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ToggleContinuousIntegrationBuild<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "ContinuousIntegrationBuild")));
    #endregion
    #region DeterministicSourcePaths
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetDeterministicSourcePaths<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetDeterministicSourcePaths<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "DeterministicSourcePaths"));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T EnableDeterministicSourcePaths<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", true));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T DisableDeterministicSourcePaths<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", false));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ToggleDeterministicSourcePaths<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "DeterministicSourcePaths")));
    #endregion
    #region Deterministic
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T SetDeterministic<T>(this T o, bool? v) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", v));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ResetDeterministic<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Deterministic"));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T EnableDeterministic<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", true));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T DisableDeterministic<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", false));
    /// <inheritdoc cref="DotNetRestoreSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetRestoreSettings), Property = nameof(DotNetRestoreSettings.Properties))]
    public static T ToggleDeterministic<T>(this T o) where T : DotNetRestoreSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "Deterministic")));
    #endregion
    #endregion
}
#endregion
#region DotNetPackSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetPack(Nuke.Common.Tools.DotNet.DotNetPackSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetPackSettingsExtensions
{
    #region Project
    /// <inheritdoc cref="DotNetPackSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Project))]
    public static T SetProject<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Project, v));
    /// <inheritdoc cref="DotNetPackSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Project))]
    public static T ResetProject<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.Project));
    #endregion
    #region Configuration
    /// <inheritdoc cref="DotNetPackSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Configuration))]
    public static T SetConfiguration<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Configuration, v));
    /// <inheritdoc cref="DotNetPackSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Configuration))]
    public static T ResetConfiguration<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.Configuration));
    #endregion
    #region IncludeSource
    /// <inheritdoc cref="DotNetPackSettings.IncludeSource"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSource))]
    public static T SetIncludeSource<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IncludeSource, v));
    /// <inheritdoc cref="DotNetPackSettings.IncludeSource"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSource))]
    public static T ResetIncludeSource<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.IncludeSource));
    /// <inheritdoc cref="DotNetPackSettings.IncludeSource"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSource))]
    public static T EnableIncludeSource<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IncludeSource, true));
    /// <inheritdoc cref="DotNetPackSettings.IncludeSource"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSource))]
    public static T DisableIncludeSource<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IncludeSource, false));
    /// <inheritdoc cref="DotNetPackSettings.IncludeSource"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSource))]
    public static T ToggleIncludeSource<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IncludeSource, !o.IncludeSource));
    #endregion
    #region IncludeSymbols
    /// <inheritdoc cref="DotNetPackSettings.IncludeSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSymbols))]
    public static T SetIncludeSymbols<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IncludeSymbols, v));
    /// <inheritdoc cref="DotNetPackSettings.IncludeSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSymbols))]
    public static T ResetIncludeSymbols<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.IncludeSymbols));
    /// <inheritdoc cref="DotNetPackSettings.IncludeSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSymbols))]
    public static T EnableIncludeSymbols<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IncludeSymbols, true));
    /// <inheritdoc cref="DotNetPackSettings.IncludeSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSymbols))]
    public static T DisableIncludeSymbols<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IncludeSymbols, false));
    /// <inheritdoc cref="DotNetPackSettings.IncludeSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IncludeSymbols))]
    public static T ToggleIncludeSymbols<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IncludeSymbols, !o.IncludeSymbols));
    #endregion
    #region NoBuild
    /// <inheritdoc cref="DotNetPackSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoBuild))]
    public static T SetNoBuild<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoBuild, v));
    /// <inheritdoc cref="DotNetPackSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoBuild))]
    public static T ResetNoBuild<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.NoBuild));
    /// <inheritdoc cref="DotNetPackSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoBuild))]
    public static T EnableNoBuild<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoBuild, true));
    /// <inheritdoc cref="DotNetPackSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoBuild))]
    public static T DisableNoBuild<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoBuild, false));
    /// <inheritdoc cref="DotNetPackSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoBuild))]
    public static T ToggleNoBuild<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoBuild, !o.NoBuild));
    #endregion
    #region NoRestore
    /// <inheritdoc cref="DotNetPackSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoRestore))]
    public static T SetNoRestore<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoRestore, v));
    /// <inheritdoc cref="DotNetPackSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoRestore))]
    public static T ResetNoRestore<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.NoRestore));
    /// <inheritdoc cref="DotNetPackSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoRestore))]
    public static T EnableNoRestore<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoRestore, true));
    /// <inheritdoc cref="DotNetPackSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoRestore))]
    public static T DisableNoRestore<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoRestore, false));
    /// <inheritdoc cref="DotNetPackSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoRestore))]
    public static T ToggleNoRestore<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoRestore, !o.NoRestore));
    #endregion
    #region OutputDirectory
    /// <inheritdoc cref="DotNetPackSettings.OutputDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.OutputDirectory))]
    public static T SetOutputDirectory<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.OutputDirectory, v));
    /// <inheritdoc cref="DotNetPackSettings.OutputDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.OutputDirectory))]
    public static T ResetOutputDirectory<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.OutputDirectory));
    #endregion
    #region Serviceable
    /// <inheritdoc cref="DotNetPackSettings.Serviceable"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Serviceable))]
    public static T SetServiceable<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Serviceable, v));
    /// <inheritdoc cref="DotNetPackSettings.Serviceable"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Serviceable))]
    public static T ResetServiceable<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.Serviceable));
    /// <inheritdoc cref="DotNetPackSettings.Serviceable"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Serviceable))]
    public static T EnableServiceable<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Serviceable, true));
    /// <inheritdoc cref="DotNetPackSettings.Serviceable"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Serviceable))]
    public static T DisableServiceable<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Serviceable, false));
    /// <inheritdoc cref="DotNetPackSettings.Serviceable"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Serviceable))]
    public static T ToggleServiceable<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Serviceable, !o.Serviceable));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetPackSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetPackSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region VersionSuffix
    /// <inheritdoc cref="DotNetPackSettings.VersionSuffix"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.VersionSuffix))]
    public static T SetVersionSuffix<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.VersionSuffix, v));
    /// <inheritdoc cref="DotNetPackSettings.VersionSuffix"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.VersionSuffix))]
    public static T ResetVersionSuffix<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.VersionSuffix));
    #endregion
    #region NoLogo
    /// <inheritdoc cref="DotNetPackSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoLogo))]
    public static T SetNoLogo<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoLogo, v));
    /// <inheritdoc cref="DotNetPackSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoLogo))]
    public static T ResetNoLogo<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.NoLogo));
    /// <inheritdoc cref="DotNetPackSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoLogo))]
    public static T EnableNoLogo<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoLogo, true));
    /// <inheritdoc cref="DotNetPackSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoLogo))]
    public static T DisableNoLogo<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoLogo, false));
    /// <inheritdoc cref="DotNetPackSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoLogo))]
    public static T ToggleNoLogo<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoLogo, !o.NoLogo));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetPackSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetPackSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetPackSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetPackSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetPackSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region Force
    /// <inheritdoc cref="DotNetPackSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="DotNetPackSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Force))]
    public static T ResetForce<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="DotNetPackSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Force))]
    public static T EnableForce<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="DotNetPackSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Force))]
    public static T DisableForce<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="DotNetPackSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetPackSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetPackSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetPackSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetPackSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetPackSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetPackSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetPackSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetPackSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetPackSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetPackSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region NoDependencies
    /// <inheritdoc cref="DotNetPackSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoDependencies))]
    public static T SetNoDependencies<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoDependencies, v));
    /// <inheritdoc cref="DotNetPackSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoDependencies))]
    public static T ResetNoDependencies<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.NoDependencies));
    /// <inheritdoc cref="DotNetPackSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoDependencies))]
    public static T EnableNoDependencies<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoDependencies, true));
    /// <inheritdoc cref="DotNetPackSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoDependencies))]
    public static T DisableNoDependencies<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoDependencies, false));
    /// <inheritdoc cref="DotNetPackSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.NoDependencies))]
    public static T ToggleNoDependencies<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.NoDependencies, !o.NoDependencies));
    #endregion
    #region PackageDirectory
    /// <inheritdoc cref="DotNetPackSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.PackageDirectory))]
    public static T SetPackageDirectory<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.PackageDirectory, v));
    /// <inheritdoc cref="DotNetPackSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.PackageDirectory))]
    public static T ResetPackageDirectory<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.PackageDirectory));
    #endregion
    #region Sources
    /// <inheritdoc cref="DotNetPackSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Sources))]
    public static T SetSources<T>(this T o, params string[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPackSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Sources))]
    public static T SetSources<T>(this T o, IEnumerable<string> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPackSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Sources))]
    public static T AddSources<T>(this T o, params string[] v) where T : DotNetPackSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPackSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Sources))]
    public static T AddSources<T>(this T o, IEnumerable<string> v) where T : DotNetPackSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPackSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Sources))]
    public static T RemoveSources<T>(this T o, params string[] v) where T : DotNetPackSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPackSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Sources))]
    public static T RemoveSources<T>(this T o, IEnumerable<string> v) where T : DotNetPackSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPackSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Sources))]
    public static T ClearSources<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.ClearCollection(() => o.Sources));
    #endregion
    #region UseLockFile
    /// <inheritdoc cref="DotNetPackSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.UseLockFile))]
    public static T SetUseLockFile<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.UseLockFile, v));
    /// <inheritdoc cref="DotNetPackSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.UseLockFile))]
    public static T ResetUseLockFile<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.UseLockFile));
    /// <inheritdoc cref="DotNetPackSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.UseLockFile))]
    public static T EnableUseLockFile<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.UseLockFile, true));
    /// <inheritdoc cref="DotNetPackSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.UseLockFile))]
    public static T DisableUseLockFile<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.UseLockFile, false));
    /// <inheritdoc cref="DotNetPackSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.UseLockFile))]
    public static T ToggleUseLockFile<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.UseLockFile, !o.UseLockFile));
    #endregion
    #region LockedMode
    /// <inheritdoc cref="DotNetPackSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.LockedMode))]
    public static T SetLockedMode<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.LockedMode, v));
    /// <inheritdoc cref="DotNetPackSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.LockedMode))]
    public static T ResetLockedMode<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.LockedMode));
    /// <inheritdoc cref="DotNetPackSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.LockedMode))]
    public static T EnableLockedMode<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.LockedMode, true));
    /// <inheritdoc cref="DotNetPackSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.LockedMode))]
    public static T DisableLockedMode<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.LockedMode, false));
    /// <inheritdoc cref="DotNetPackSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.LockedMode))]
    public static T ToggleLockedMode<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.LockedMode, !o.LockedMode));
    #endregion
    #region LockFilePath
    /// <inheritdoc cref="DotNetPackSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.LockFilePath))]
    public static T SetLockFilePath<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.LockFilePath, v));
    /// <inheritdoc cref="DotNetPackSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.LockFilePath))]
    public static T ResetLockFilePath<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.LockFilePath));
    #endregion
    #region ForceEvaluate
    /// <inheritdoc cref="DotNetPackSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.ForceEvaluate))]
    public static T SetForceEvaluate<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, v));
    /// <inheritdoc cref="DotNetPackSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.ForceEvaluate))]
    public static T ResetForceEvaluate<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.ForceEvaluate));
    /// <inheritdoc cref="DotNetPackSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.ForceEvaluate))]
    public static T EnableForceEvaluate<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, true));
    /// <inheritdoc cref="DotNetPackSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.ForceEvaluate))]
    public static T DisableForceEvaluate<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, false));
    /// <inheritdoc cref="DotNetPackSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.ForceEvaluate))]
    public static T ToggleForceEvaluate<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, !o.ForceEvaluate));
    #endregion
    #region Runtime
    /// <inheritdoc cref="DotNetPackSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Runtime))]
    public static T SetRuntime<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Runtime, v));
    /// <inheritdoc cref="DotNetPackSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Runtime))]
    public static T ResetRuntime<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Remove(() => o.Runtime));
    #endregion
    #region Properties
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetProperties<T>(this T o, IDictionary<string, object> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetProperty<T>(this T o, string k, object v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T AddProperty<T>(this T o, string k, object v) where T : DotNetPackSettings => o.Modify(b => b.AddDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T RemoveProperty<T>(this T o, string k) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, k));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ClearProperties<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.ClearDictionary(() => o.Properties));
    #region RunCodeAnalysis
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetRunCodeAnalysis<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetRunCodeAnalysis<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RunCodeAnalysis"));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T EnableRunCodeAnalysis<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", true));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T DisableRunCodeAnalysis<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", false));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ToggleRunCodeAnalysis<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "RunCodeAnalysis")));
    #endregion
    #region NoWarn
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetNoWarns<T>(this T o, params int[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T AddNoWarns<T>(this T o, params int[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T AddNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, params int[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetNoWarn<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "NoWarn"));
    #endregion
    #region WarningsAsErrors
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetWarningsAsErrors<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningsAsErrors"));
    #endregion
    #region WarningLevel
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetWarningLevel<T>(this T o, int? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "WarningLevel", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetWarningLevel<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningLevel"));
    #endregion
    #region TreatWarningsAsErrors
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetTreatWarningsAsErrors<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetTreatWarningsAsErrors<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "TreatWarningsAsErrors"));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T EnableTreatWarningsAsErrors<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", true));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T DisableTreatWarningsAsErrors<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", false));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ToggleTreatWarningsAsErrors<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "TreatWarningsAsErrors")));
    #endregion
    #region AssemblyVersion
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetAssemblyVersion<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "AssemblyVersion", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetAssemblyVersion<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "AssemblyVersion"));
    #endregion
    #region FileVersion
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetFileVersion<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "FileVersion", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetFileVersion<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "FileVersion"));
    #endregion
    #region InformationalVersion
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetInformationalVersion<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "InformationalVersion", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetInformationalVersion<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "InformationalVersion"));
    #endregion
    #region PackageId
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPackageId<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageId", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPackageId<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageId"));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Version", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetVersion<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Version"));
    #endregion
    #region VersionPrefix
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetVersionPrefix<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "VersionPrefix", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetVersionPrefix<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "VersionPrefix"));
    #endregion
    #region Authors
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetAuthors<T>(this T o, params string[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T AddAuthors<T>(this T o, params string[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T AddAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, params string[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetAuthors<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Authors"));
    #endregion
    #region Title
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetTitle<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Title", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetTitle<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Title"));
    #endregion
    #region Description
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetDescription<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Description", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetDescription<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Description"));
    #endregion
    #region Copyright
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetCopyright<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Copyright", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetCopyright<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Copyright"));
    #endregion
    #region PackageRequireLicenseAcceptance
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPackageRequireLicenseAcceptance<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPackageRequireLicenseAcceptance<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageRequireLicenseAcceptance"));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T EnablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", true));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T DisablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", false));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T TogglePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PackageRequireLicenseAcceptance")));
    #endregion
    #region PackageLicenseUrl
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPackageLicenseUrl<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageLicenseUrl", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPackageLicenseUrl<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageLicenseUrl"));
    #endregion
    #region PackageProjectUrl
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPackageProjectUrl<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageProjectUrl", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPackageProjectUrl<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageProjectUrl"));
    #endregion
    #region PackageIconUrl
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPackageIconUrl<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageIconUrl", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPackageIconUrl<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageIconUrl"));
    #endregion
    #region PackageTags
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPackageTags<T>(this T o, params string[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T AddPackageTags<T>(this T o, params string[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T AddPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, params string[] v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPackageTags<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageTags"));
    #endregion
    #region PackageReleaseNotes
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPackageReleaseNotes<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageReleaseNotes", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPackageReleaseNotes<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageReleaseNotes"));
    #endregion
    #region RepositoryUrl
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetRepositoryUrl<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryUrl", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetRepositoryUrl<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryUrl"));
    #endregion
    #region RepositoryType
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetRepositoryType<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryType", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetRepositoryType<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryType"));
    #endregion
    #region SymbolPackageFormat
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetSymbolPackageFormat<T>(this T o, DotNetSymbolPackageFormat v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "SymbolPackageFormat", v));
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetSymbolPackageFormat<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "SymbolPackageFormat"));
    #endregion
    #region PublishReadyToRun
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPublishReadyToRun<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", v));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPublishReadyToRun<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishReadyToRun"));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T EnablePublishReadyToRun<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", true));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T DisablePublishReadyToRun<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", false));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T TogglePublishReadyToRun<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishReadyToRun")));
    #endregion
    #region PublishSingleFile
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPublishSingleFile<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", v));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPublishSingleFile<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishSingleFile"));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T EnablePublishSingleFile<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", true));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T DisablePublishSingleFile<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", false));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T TogglePublishSingleFile<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishSingleFile")));
    #endregion
    #region PublishTrimmed
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPublishTrimmed<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", v));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPublishTrimmed<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishTrimmed"));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T EnablePublishTrimmed<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", true));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T DisablePublishTrimmed<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", false));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T TogglePublishTrimmed<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishTrimmed")));
    #endregion
    #region PublishProfile
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPublishProfile<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishProfile", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPublishProfile<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishProfile"));
    #endregion
    #region Platform
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetPlatform<T>(this T o, string v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Platform", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetPlatform<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Platform"));
    #endregion
    #region ContinuousIntegrationBuild
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetContinuousIntegrationBuild<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetContinuousIntegrationBuild<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "ContinuousIntegrationBuild"));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T EnableContinuousIntegrationBuild<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", true));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T DisableContinuousIntegrationBuild<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", false));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ToggleContinuousIntegrationBuild<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "ContinuousIntegrationBuild")));
    #endregion
    #region DeterministicSourcePaths
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetDeterministicSourcePaths<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetDeterministicSourcePaths<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "DeterministicSourcePaths"));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T EnableDeterministicSourcePaths<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", true));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T DisableDeterministicSourcePaths<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", false));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ToggleDeterministicSourcePaths<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "DeterministicSourcePaths")));
    #endregion
    #region Deterministic
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T SetDeterministic<T>(this T o, bool? v) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", v));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ResetDeterministic<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Deterministic"));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T EnableDeterministic<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", true));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T DisableDeterministic<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", false));
    /// <inheritdoc cref="DotNetPackSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPackSettings), Property = nameof(DotNetPackSettings.Properties))]
    public static T ToggleDeterministic<T>(this T o) where T : DotNetPackSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "Deterministic")));
    #endregion
    #endregion
}
#endregion
#region DotNetBuildSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetBuild(Nuke.Common.Tools.DotNet.DotNetBuildSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetBuildSettingsExtensions
{
    #region ProjectFile
    /// <inheritdoc cref="DotNetBuildSettings.ProjectFile"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.ProjectFile))]
    public static T SetProjectFile<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.ProjectFile, v));
    /// <inheritdoc cref="DotNetBuildSettings.ProjectFile"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.ProjectFile))]
    public static T ResetProjectFile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.ProjectFile));
    #endregion
    #region Configuration
    /// <inheritdoc cref="DotNetBuildSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Configuration))]
    public static T SetConfiguration<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Configuration, v));
    /// <inheritdoc cref="DotNetBuildSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Configuration))]
    public static T ResetConfiguration<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.Configuration));
    #endregion
    #region Framework
    /// <inheritdoc cref="DotNetBuildSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Framework))]
    public static T SetFramework<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Framework, v));
    /// <inheritdoc cref="DotNetBuildSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Framework))]
    public static T ResetFramework<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.Framework));
    #endregion
    #region NoIncremental
    /// <inheritdoc cref="DotNetBuildSettings.NoIncremental"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoIncremental))]
    public static T SetNoIncremental<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoIncremental, v));
    /// <inheritdoc cref="DotNetBuildSettings.NoIncremental"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoIncremental))]
    public static T ResetNoIncremental<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.NoIncremental));
    /// <inheritdoc cref="DotNetBuildSettings.NoIncremental"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoIncremental))]
    public static T EnableNoIncremental<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoIncremental, true));
    /// <inheritdoc cref="DotNetBuildSettings.NoIncremental"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoIncremental))]
    public static T DisableNoIncremental<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoIncremental, false));
    /// <inheritdoc cref="DotNetBuildSettings.NoIncremental"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoIncremental))]
    public static T ToggleNoIncremental<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoIncremental, !o.NoIncremental));
    #endregion
    #region NoRestore
    /// <inheritdoc cref="DotNetBuildSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoRestore))]
    public static T SetNoRestore<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoRestore, v));
    /// <inheritdoc cref="DotNetBuildSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoRestore))]
    public static T ResetNoRestore<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.NoRestore));
    /// <inheritdoc cref="DotNetBuildSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoRestore))]
    public static T EnableNoRestore<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoRestore, true));
    /// <inheritdoc cref="DotNetBuildSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoRestore))]
    public static T DisableNoRestore<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoRestore, false));
    /// <inheritdoc cref="DotNetBuildSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoRestore))]
    public static T ToggleNoRestore<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoRestore, !o.NoRestore));
    #endregion
    #region OutputDirectory
    /// <inheritdoc cref="DotNetBuildSettings.OutputDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.OutputDirectory))]
    public static T SetOutputDirectory<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.OutputDirectory, v));
    /// <inheritdoc cref="DotNetBuildSettings.OutputDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.OutputDirectory))]
    public static T ResetOutputDirectory<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.OutputDirectory));
    #endregion
    #region SelfContained
    /// <inheritdoc cref="DotNetBuildSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.SelfContained))]
    public static T SetSelfContained<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.SelfContained, v));
    /// <inheritdoc cref="DotNetBuildSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.SelfContained))]
    public static T ResetSelfContained<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.SelfContained));
    /// <inheritdoc cref="DotNetBuildSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.SelfContained))]
    public static T EnableSelfContained<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.SelfContained, true));
    /// <inheritdoc cref="DotNetBuildSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.SelfContained))]
    public static T DisableSelfContained<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.SelfContained, false));
    /// <inheritdoc cref="DotNetBuildSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.SelfContained))]
    public static T ToggleSelfContained<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.SelfContained, !o.SelfContained));
    #endregion
    #region Runtime
    /// <inheritdoc cref="DotNetBuildSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Runtime))]
    public static T SetRuntime<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Runtime, v));
    /// <inheritdoc cref="DotNetBuildSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Runtime))]
    public static T ResetRuntime<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.Runtime));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetBuildSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetBuildSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region VersionSuffix
    /// <inheritdoc cref="DotNetBuildSettings.VersionSuffix"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.VersionSuffix))]
    public static T SetVersionSuffix<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.VersionSuffix, v));
    /// <inheritdoc cref="DotNetBuildSettings.VersionSuffix"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.VersionSuffix))]
    public static T ResetVersionSuffix<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.VersionSuffix));
    #endregion
    #region Loggers
    /// <inheritdoc cref="DotNetBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Loggers))]
    public static T SetLoggers<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Loggers))]
    public static T SetLoggers<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Loggers))]
    public static T AddLoggers<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.AddCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Loggers))]
    public static T AddLoggers<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.AddCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Loggers))]
    public static T RemoveLoggers<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.RemoveCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Loggers))]
    public static T RemoveLoggers<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.RemoveCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Loggers))]
    public static T ClearLoggers<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.ClearCollection(() => o.Loggers));
    #endregion
    #region NoConsoleLogger
    /// <inheritdoc cref="DotNetBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoConsoleLogger))]
    public static T SetNoConsoleLogger<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoConsoleLogger, v));
    /// <inheritdoc cref="DotNetBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoConsoleLogger))]
    public static T ResetNoConsoleLogger<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.NoConsoleLogger));
    /// <inheritdoc cref="DotNetBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoConsoleLogger))]
    public static T EnableNoConsoleLogger<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoConsoleLogger, true));
    /// <inheritdoc cref="DotNetBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoConsoleLogger))]
    public static T DisableNoConsoleLogger<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoConsoleLogger, false));
    /// <inheritdoc cref="DotNetBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoConsoleLogger))]
    public static T ToggleNoConsoleLogger<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoConsoleLogger, !o.NoConsoleLogger));
    #endregion
    #region NoLogo
    /// <inheritdoc cref="DotNetBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoLogo))]
    public static T SetNoLogo<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoLogo, v));
    /// <inheritdoc cref="DotNetBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoLogo))]
    public static T ResetNoLogo<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.NoLogo));
    /// <inheritdoc cref="DotNetBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoLogo))]
    public static T EnableNoLogo<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoLogo, true));
    /// <inheritdoc cref="DotNetBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoLogo))]
    public static T DisableNoLogo<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoLogo, false));
    /// <inheritdoc cref="DotNetBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoLogo))]
    public static T ToggleNoLogo<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoLogo, !o.NoLogo));
    #endregion
    #region BinaryLog
    /// <inheritdoc cref="DotNetBuildSettings.BinaryLog"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.BinaryLog))]
    public static T SetBinaryLog<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.BinaryLog, v));
    /// <inheritdoc cref="DotNetBuildSettings.BinaryLog"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.BinaryLog))]
    public static T ResetBinaryLog<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.BinaryLog));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetBuildSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetBuildSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetBuildSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetBuildSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetBuildSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region Force
    /// <inheritdoc cref="DotNetBuildSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="DotNetBuildSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Force))]
    public static T ResetForce<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="DotNetBuildSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Force))]
    public static T EnableForce<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="DotNetBuildSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Force))]
    public static T DisableForce<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="DotNetBuildSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetBuildSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetBuildSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetBuildSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetBuildSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetBuildSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetBuildSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetBuildSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetBuildSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetBuildSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetBuildSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region NoDependencies
    /// <inheritdoc cref="DotNetBuildSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoDependencies))]
    public static T SetNoDependencies<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoDependencies, v));
    /// <inheritdoc cref="DotNetBuildSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoDependencies))]
    public static T ResetNoDependencies<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.NoDependencies));
    /// <inheritdoc cref="DotNetBuildSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoDependencies))]
    public static T EnableNoDependencies<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoDependencies, true));
    /// <inheritdoc cref="DotNetBuildSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoDependencies))]
    public static T DisableNoDependencies<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoDependencies, false));
    /// <inheritdoc cref="DotNetBuildSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.NoDependencies))]
    public static T ToggleNoDependencies<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.NoDependencies, !o.NoDependencies));
    #endregion
    #region PackageDirectory
    /// <inheritdoc cref="DotNetBuildSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.PackageDirectory))]
    public static T SetPackageDirectory<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.PackageDirectory, v));
    /// <inheritdoc cref="DotNetBuildSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.PackageDirectory))]
    public static T ResetPackageDirectory<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.PackageDirectory));
    #endregion
    #region Sources
    /// <inheritdoc cref="DotNetBuildSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Sources))]
    public static T SetSources<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetBuildSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Sources))]
    public static T SetSources<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetBuildSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Sources))]
    public static T AddSources<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetBuildSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Sources))]
    public static T AddSources<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetBuildSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Sources))]
    public static T RemoveSources<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetBuildSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Sources))]
    public static T RemoveSources<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetBuildSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Sources))]
    public static T ClearSources<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.ClearCollection(() => o.Sources));
    #endregion
    #region UseLockFile
    /// <inheritdoc cref="DotNetBuildSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.UseLockFile))]
    public static T SetUseLockFile<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.UseLockFile, v));
    /// <inheritdoc cref="DotNetBuildSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.UseLockFile))]
    public static T ResetUseLockFile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.UseLockFile));
    /// <inheritdoc cref="DotNetBuildSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.UseLockFile))]
    public static T EnableUseLockFile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.UseLockFile, true));
    /// <inheritdoc cref="DotNetBuildSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.UseLockFile))]
    public static T DisableUseLockFile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.UseLockFile, false));
    /// <inheritdoc cref="DotNetBuildSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.UseLockFile))]
    public static T ToggleUseLockFile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.UseLockFile, !o.UseLockFile));
    #endregion
    #region LockedMode
    /// <inheritdoc cref="DotNetBuildSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.LockedMode))]
    public static T SetLockedMode<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.LockedMode, v));
    /// <inheritdoc cref="DotNetBuildSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.LockedMode))]
    public static T ResetLockedMode<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.LockedMode));
    /// <inheritdoc cref="DotNetBuildSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.LockedMode))]
    public static T EnableLockedMode<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.LockedMode, true));
    /// <inheritdoc cref="DotNetBuildSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.LockedMode))]
    public static T DisableLockedMode<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.LockedMode, false));
    /// <inheritdoc cref="DotNetBuildSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.LockedMode))]
    public static T ToggleLockedMode<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.LockedMode, !o.LockedMode));
    #endregion
    #region LockFilePath
    /// <inheritdoc cref="DotNetBuildSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.LockFilePath))]
    public static T SetLockFilePath<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.LockFilePath, v));
    /// <inheritdoc cref="DotNetBuildSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.LockFilePath))]
    public static T ResetLockFilePath<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.LockFilePath));
    #endregion
    #region ForceEvaluate
    /// <inheritdoc cref="DotNetBuildSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.ForceEvaluate))]
    public static T SetForceEvaluate<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, v));
    /// <inheritdoc cref="DotNetBuildSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.ForceEvaluate))]
    public static T ResetForceEvaluate<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Remove(() => o.ForceEvaluate));
    /// <inheritdoc cref="DotNetBuildSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.ForceEvaluate))]
    public static T EnableForceEvaluate<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, true));
    /// <inheritdoc cref="DotNetBuildSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.ForceEvaluate))]
    public static T DisableForceEvaluate<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, false));
    /// <inheritdoc cref="DotNetBuildSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.ForceEvaluate))]
    public static T ToggleForceEvaluate<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, !o.ForceEvaluate));
    #endregion
    #region Properties
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetProperties<T>(this T o, IDictionary<string, object> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetProperty<T>(this T o, string k, object v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T AddProperty<T>(this T o, string k, object v) where T : DotNetBuildSettings => o.Modify(b => b.AddDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T RemoveProperty<T>(this T o, string k) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, k));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ClearProperties<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.ClearDictionary(() => o.Properties));
    #region RunCodeAnalysis
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetRunCodeAnalysis<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetRunCodeAnalysis<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RunCodeAnalysis"));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T EnableRunCodeAnalysis<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", true));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T DisableRunCodeAnalysis<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", false));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ToggleRunCodeAnalysis<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "RunCodeAnalysis")));
    #endregion
    #region NoWarn
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetNoWarns<T>(this T o, params int[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T AddNoWarns<T>(this T o, params int[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T AddNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, params int[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetNoWarn<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "NoWarn"));
    #endregion
    #region WarningsAsErrors
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetWarningsAsErrors<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningsAsErrors"));
    #endregion
    #region WarningLevel
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetWarningLevel<T>(this T o, int? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "WarningLevel", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetWarningLevel<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningLevel"));
    #endregion
    #region TreatWarningsAsErrors
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetTreatWarningsAsErrors<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetTreatWarningsAsErrors<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "TreatWarningsAsErrors"));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T EnableTreatWarningsAsErrors<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", true));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T DisableTreatWarningsAsErrors<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", false));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ToggleTreatWarningsAsErrors<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "TreatWarningsAsErrors")));
    #endregion
    #region AssemblyVersion
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetAssemblyVersion<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "AssemblyVersion", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetAssemblyVersion<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "AssemblyVersion"));
    #endregion
    #region FileVersion
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetFileVersion<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "FileVersion", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetFileVersion<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "FileVersion"));
    #endregion
    #region InformationalVersion
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetInformationalVersion<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "InformationalVersion", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetInformationalVersion<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "InformationalVersion"));
    #endregion
    #region PackageId
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPackageId<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageId", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPackageId<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageId"));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Version", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetVersion<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Version"));
    #endregion
    #region VersionPrefix
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetVersionPrefix<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "VersionPrefix", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetVersionPrefix<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "VersionPrefix"));
    #endregion
    #region Authors
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetAuthors<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T AddAuthors<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T AddAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetAuthors<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Authors"));
    #endregion
    #region Title
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetTitle<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Title", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetTitle<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Title"));
    #endregion
    #region Description
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetDescription<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Description", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetDescription<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Description"));
    #endregion
    #region Copyright
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetCopyright<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Copyright", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetCopyright<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Copyright"));
    #endregion
    #region PackageRequireLicenseAcceptance
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPackageRequireLicenseAcceptance<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPackageRequireLicenseAcceptance<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageRequireLicenseAcceptance"));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T EnablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", true));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T DisablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", false));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T TogglePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PackageRequireLicenseAcceptance")));
    #endregion
    #region PackageLicenseUrl
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPackageLicenseUrl<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageLicenseUrl", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPackageLicenseUrl<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageLicenseUrl"));
    #endregion
    #region PackageProjectUrl
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPackageProjectUrl<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageProjectUrl", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPackageProjectUrl<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageProjectUrl"));
    #endregion
    #region PackageIconUrl
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPackageIconUrl<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageIconUrl", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPackageIconUrl<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageIconUrl"));
    #endregion
    #region PackageTags
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPackageTags<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T AddPackageTags<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T AddPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, params string[] v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPackageTags<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageTags"));
    #endregion
    #region PackageReleaseNotes
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPackageReleaseNotes<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageReleaseNotes", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPackageReleaseNotes<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageReleaseNotes"));
    #endregion
    #region RepositoryUrl
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetRepositoryUrl<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryUrl", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetRepositoryUrl<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryUrl"));
    #endregion
    #region RepositoryType
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetRepositoryType<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryType", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetRepositoryType<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryType"));
    #endregion
    #region SymbolPackageFormat
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetSymbolPackageFormat<T>(this T o, DotNetSymbolPackageFormat v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "SymbolPackageFormat", v));
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetSymbolPackageFormat<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "SymbolPackageFormat"));
    #endregion
    #region PublishReadyToRun
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPublishReadyToRun<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", v));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPublishReadyToRun<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishReadyToRun"));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T EnablePublishReadyToRun<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", true));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T DisablePublishReadyToRun<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", false));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T TogglePublishReadyToRun<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishReadyToRun")));
    #endregion
    #region PublishSingleFile
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPublishSingleFile<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", v));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPublishSingleFile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishSingleFile"));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T EnablePublishSingleFile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", true));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T DisablePublishSingleFile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", false));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T TogglePublishSingleFile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishSingleFile")));
    #endregion
    #region PublishTrimmed
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPublishTrimmed<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", v));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPublishTrimmed<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishTrimmed"));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T EnablePublishTrimmed<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", true));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T DisablePublishTrimmed<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", false));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T TogglePublishTrimmed<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishTrimmed")));
    #endregion
    #region PublishProfile
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPublishProfile<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishProfile", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPublishProfile<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishProfile"));
    #endregion
    #region Platform
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetPlatform<T>(this T o, string v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Platform", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetPlatform<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Platform"));
    #endregion
    #region ContinuousIntegrationBuild
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetContinuousIntegrationBuild<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetContinuousIntegrationBuild<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "ContinuousIntegrationBuild"));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T EnableContinuousIntegrationBuild<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", true));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T DisableContinuousIntegrationBuild<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", false));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ToggleContinuousIntegrationBuild<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "ContinuousIntegrationBuild")));
    #endregion
    #region DeterministicSourcePaths
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetDeterministicSourcePaths<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetDeterministicSourcePaths<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "DeterministicSourcePaths"));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T EnableDeterministicSourcePaths<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", true));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T DisableDeterministicSourcePaths<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", false));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ToggleDeterministicSourcePaths<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "DeterministicSourcePaths")));
    #endregion
    #region Deterministic
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T SetDeterministic<T>(this T o, bool? v) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", v));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ResetDeterministic<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Deterministic"));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T EnableDeterministic<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", true));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T DisableDeterministic<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", false));
    /// <inheritdoc cref="DotNetBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetBuildSettings), Property = nameof(DotNetBuildSettings.Properties))]
    public static T ToggleDeterministic<T>(this T o) where T : DotNetBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "Deterministic")));
    #endregion
    #endregion
}
#endregion
#region DotNetMSBuildSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetMSBuild(Nuke.Common.Tools.DotNet.DotNetMSBuildSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetMSBuildSettingsExtensions
{
    #region TargetPath
    /// <inheritdoc cref="DotNetMSBuildSettings.TargetPath"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.TargetPath))]
    public static T SetTargetPath<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.TargetPath, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.TargetPath"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.TargetPath))]
    public static T ResetTargetPath<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.TargetPath));
    #endregion
    #region DetailedSummary
    /// <inheritdoc cref="DotNetMSBuildSettings.DetailedSummary"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.DetailedSummary))]
    public static T SetDetailedSummary<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.DetailedSummary, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.DetailedSummary"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.DetailedSummary))]
    public static T ResetDetailedSummary<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.DetailedSummary));
    /// <inheritdoc cref="DotNetMSBuildSettings.DetailedSummary"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.DetailedSummary))]
    public static T EnableDetailedSummary<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.DetailedSummary, true));
    /// <inheritdoc cref="DotNetMSBuildSettings.DetailedSummary"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.DetailedSummary))]
    public static T DisableDetailedSummary<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.DetailedSummary, false));
    /// <inheritdoc cref="DotNetMSBuildSettings.DetailedSummary"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.DetailedSummary))]
    public static T ToggleDetailedSummary<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.DetailedSummary, !o.DetailedSummary));
    #endregion
    #region MaxCpuCount
    /// <inheritdoc cref="DotNetMSBuildSettings.MaxCpuCount"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.MaxCpuCount))]
    public static T SetMaxCpuCount<T>(this T o, int? v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.MaxCpuCount, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.MaxCpuCount"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.MaxCpuCount))]
    public static T ResetMaxCpuCount<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.MaxCpuCount));
    #endregion
    #region NodeReuse
    /// <inheritdoc cref="DotNetMSBuildSettings.NodeReuse"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NodeReuse))]
    public static T SetNodeReuse<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NodeReuse, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.NodeReuse"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NodeReuse))]
    public static T ResetNodeReuse<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.NodeReuse));
    /// <inheritdoc cref="DotNetMSBuildSettings.NodeReuse"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NodeReuse))]
    public static T EnableNodeReuse<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NodeReuse, true));
    /// <inheritdoc cref="DotNetMSBuildSettings.NodeReuse"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NodeReuse))]
    public static T DisableNodeReuse<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NodeReuse, false));
    /// <inheritdoc cref="DotNetMSBuildSettings.NodeReuse"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NodeReuse))]
    public static T ToggleNodeReuse<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NodeReuse, !o.NodeReuse));
    #endregion
    #region NoLogo
    /// <inheritdoc cref="DotNetMSBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoLogo))]
    public static T SetNoLogo<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NoLogo, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoLogo))]
    public static T ResetNoLogo<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.NoLogo));
    /// <inheritdoc cref="DotNetMSBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoLogo))]
    public static T EnableNoLogo<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NoLogo, true));
    /// <inheritdoc cref="DotNetMSBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoLogo))]
    public static T DisableNoLogo<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NoLogo, false));
    /// <inheritdoc cref="DotNetMSBuildSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoLogo))]
    public static T ToggleNoLogo<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NoLogo, !o.NoLogo));
    #endregion
    #region Restore
    /// <inheritdoc cref="DotNetMSBuildSettings.Restore"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Restore))]
    public static T SetRestore<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Restore, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Restore"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Restore))]
    public static T ResetRestore<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.Restore));
    /// <inheritdoc cref="DotNetMSBuildSettings.Restore"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Restore))]
    public static T EnableRestore<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Restore, true));
    /// <inheritdoc cref="DotNetMSBuildSettings.Restore"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Restore))]
    public static T DisableRestore<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Restore, false));
    /// <inheritdoc cref="DotNetMSBuildSettings.Restore"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Restore))]
    public static T ToggleRestore<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Restore, !o.Restore));
    #endregion
    #region Targets
    /// <inheritdoc cref="DotNetMSBuildSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Targets))]
    public static T SetTargets<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Targets, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Targets))]
    public static T SetTargets<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Targets, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Targets))]
    public static T AddTargets<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.AddCollection(() => o.Targets, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Targets))]
    public static T AddTargets<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.AddCollection(() => o.Targets, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Targets))]
    public static T RemoveTargets<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveCollection(() => o.Targets, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Targets))]
    public static T RemoveTargets<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveCollection(() => o.Targets, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Targets))]
    public static T ClearTargets<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.ClearCollection(() => o.Targets));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetMSBuildSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region Loggers
    /// <inheritdoc cref="DotNetMSBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Loggers))]
    public static T SetLoggers<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Loggers))]
    public static T SetLoggers<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Loggers))]
    public static T AddLoggers<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.AddCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Loggers))]
    public static T AddLoggers<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.AddCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Loggers))]
    public static T RemoveLoggers<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Loggers))]
    public static T RemoveLoggers<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveCollection(() => o.Loggers, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Loggers"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Loggers))]
    public static T ClearLoggers<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.ClearCollection(() => o.Loggers));
    #endregion
    #region NoConsoleLogger
    /// <inheritdoc cref="DotNetMSBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoConsoleLogger))]
    public static T SetNoConsoleLogger<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NoConsoleLogger, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoConsoleLogger))]
    public static T ResetNoConsoleLogger<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.NoConsoleLogger));
    /// <inheritdoc cref="DotNetMSBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoConsoleLogger))]
    public static T EnableNoConsoleLogger<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NoConsoleLogger, true));
    /// <inheritdoc cref="DotNetMSBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoConsoleLogger))]
    public static T DisableNoConsoleLogger<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NoConsoleLogger, false));
    /// <inheritdoc cref="DotNetMSBuildSettings.NoConsoleLogger"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.NoConsoleLogger))]
    public static T ToggleNoConsoleLogger<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.NoConsoleLogger, !o.NoConsoleLogger));
    #endregion
    #region Configuration
    /// <inheritdoc cref="DotNetMSBuildSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Configuration))]
    public static T SetConfiguration<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Configuration, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Configuration))]
    public static T ResetConfiguration<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.Configuration));
    #endregion
    #region GraphBuild
    /// <inheritdoc cref="DotNetMSBuildSettings.GraphBuild"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.GraphBuild))]
    public static T SetGraphBuild<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.GraphBuild, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.GraphBuild"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.GraphBuild))]
    public static T ResetGraphBuild<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.GraphBuild));
    /// <inheritdoc cref="DotNetMSBuildSettings.GraphBuild"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.GraphBuild))]
    public static T EnableGraphBuild<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.GraphBuild, true));
    /// <inheritdoc cref="DotNetMSBuildSettings.GraphBuild"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.GraphBuild))]
    public static T DisableGraphBuild<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.GraphBuild, false));
    /// <inheritdoc cref="DotNetMSBuildSettings.GraphBuild"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.GraphBuild))]
    public static T ToggleGraphBuild<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.GraphBuild, !o.GraphBuild));
    #endregion
    #region BinaryLog
    /// <inheritdoc cref="DotNetMSBuildSettings.BinaryLog"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.BinaryLog))]
    public static T SetBinaryLog<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.BinaryLog, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.BinaryLog"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.BinaryLog))]
    public static T ResetBinaryLog<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Remove(() => o.BinaryLog));
    #endregion
    #region Properties
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetProperties<T>(this T o, IDictionary<string, object> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetProperty<T>(this T o, string k, object v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T AddProperty<T>(this T o, string k, object v) where T : DotNetMSBuildSettings => o.Modify(b => b.AddDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T RemoveProperty<T>(this T o, string k) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, k));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ClearProperties<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.ClearDictionary(() => o.Properties));
    #region RunCodeAnalysis
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetRunCodeAnalysis<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetRunCodeAnalysis<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RunCodeAnalysis"));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T EnableRunCodeAnalysis<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", true));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T DisableRunCodeAnalysis<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", false));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ToggleRunCodeAnalysis<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "RunCodeAnalysis")));
    #endregion
    #region NoWarn
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetNoWarns<T>(this T o, params int[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T AddNoWarns<T>(this T o, params int[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T AddNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, params int[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetNoWarn<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "NoWarn"));
    #endregion
    #region WarningsAsErrors
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetWarningsAsErrors<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningsAsErrors"));
    #endregion
    #region WarningLevel
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetWarningLevel<T>(this T o, int? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "WarningLevel", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetWarningLevel<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningLevel"));
    #endregion
    #region TreatWarningsAsErrors
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetTreatWarningsAsErrors<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetTreatWarningsAsErrors<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "TreatWarningsAsErrors"));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T EnableTreatWarningsAsErrors<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", true));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T DisableTreatWarningsAsErrors<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", false));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ToggleTreatWarningsAsErrors<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "TreatWarningsAsErrors")));
    #endregion
    #region AssemblyVersion
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetAssemblyVersion<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "AssemblyVersion", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetAssemblyVersion<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "AssemblyVersion"));
    #endregion
    #region FileVersion
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetFileVersion<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "FileVersion", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetFileVersion<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "FileVersion"));
    #endregion
    #region InformationalVersion
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetInformationalVersion<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "InformationalVersion", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetInformationalVersion<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "InformationalVersion"));
    #endregion
    #region PackageId
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPackageId<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageId", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPackageId<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageId"));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Version", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetVersion<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Version"));
    #endregion
    #region VersionPrefix
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetVersionPrefix<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "VersionPrefix", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetVersionPrefix<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "VersionPrefix"));
    #endregion
    #region Authors
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetAuthors<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T AddAuthors<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T AddAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetAuthors<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Authors"));
    #endregion
    #region Title
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetTitle<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Title", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetTitle<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Title"));
    #endregion
    #region Description
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetDescription<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Description", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetDescription<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Description"));
    #endregion
    #region Copyright
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetCopyright<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Copyright", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetCopyright<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Copyright"));
    #endregion
    #region PackageRequireLicenseAcceptance
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPackageRequireLicenseAcceptance<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPackageRequireLicenseAcceptance<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageRequireLicenseAcceptance"));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T EnablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", true));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T DisablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", false));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T TogglePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PackageRequireLicenseAcceptance")));
    #endregion
    #region PackageLicenseUrl
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPackageLicenseUrl<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageLicenseUrl", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPackageLicenseUrl<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageLicenseUrl"));
    #endregion
    #region PackageProjectUrl
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPackageProjectUrl<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageProjectUrl", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPackageProjectUrl<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageProjectUrl"));
    #endregion
    #region PackageIconUrl
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPackageIconUrl<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageIconUrl", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPackageIconUrl<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageIconUrl"));
    #endregion
    #region PackageTags
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPackageTags<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T AddPackageTags<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T AddPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, params string[] v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPackageTags<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageTags"));
    #endregion
    #region PackageReleaseNotes
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPackageReleaseNotes<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageReleaseNotes", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPackageReleaseNotes<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageReleaseNotes"));
    #endregion
    #region RepositoryUrl
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetRepositoryUrl<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryUrl", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetRepositoryUrl<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryUrl"));
    #endregion
    #region RepositoryType
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetRepositoryType<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryType", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetRepositoryType<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryType"));
    #endregion
    #region SymbolPackageFormat
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetSymbolPackageFormat<T>(this T o, DotNetSymbolPackageFormat v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "SymbolPackageFormat", v));
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetSymbolPackageFormat<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "SymbolPackageFormat"));
    #endregion
    #region PublishReadyToRun
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPublishReadyToRun<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", v));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPublishReadyToRun<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishReadyToRun"));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T EnablePublishReadyToRun<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", true));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T DisablePublishReadyToRun<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", false));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T TogglePublishReadyToRun<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishReadyToRun")));
    #endregion
    #region PublishSingleFile
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPublishSingleFile<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", v));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPublishSingleFile<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishSingleFile"));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T EnablePublishSingleFile<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", true));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T DisablePublishSingleFile<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", false));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T TogglePublishSingleFile<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishSingleFile")));
    #endregion
    #region PublishTrimmed
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPublishTrimmed<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", v));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPublishTrimmed<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishTrimmed"));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T EnablePublishTrimmed<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", true));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T DisablePublishTrimmed<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", false));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T TogglePublishTrimmed<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishTrimmed")));
    #endregion
    #region PublishProfile
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPublishProfile<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishProfile", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPublishProfile<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishProfile"));
    #endregion
    #region Platform
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetPlatform<T>(this T o, string v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Platform", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetPlatform<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Platform"));
    #endregion
    #region ContinuousIntegrationBuild
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetContinuousIntegrationBuild<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetContinuousIntegrationBuild<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "ContinuousIntegrationBuild"));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T EnableContinuousIntegrationBuild<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", true));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T DisableContinuousIntegrationBuild<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", false));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ToggleContinuousIntegrationBuild<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "ContinuousIntegrationBuild")));
    #endregion
    #region DeterministicSourcePaths
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetDeterministicSourcePaths<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetDeterministicSourcePaths<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "DeterministicSourcePaths"));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T EnableDeterministicSourcePaths<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", true));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T DisableDeterministicSourcePaths<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", false));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ToggleDeterministicSourcePaths<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "DeterministicSourcePaths")));
    #endregion
    #region Deterministic
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T SetDeterministic<T>(this T o, bool? v) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", v));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ResetDeterministic<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Deterministic"));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T EnableDeterministic<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", true));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T DisableDeterministic<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", false));
    /// <inheritdoc cref="DotNetMSBuildSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetMSBuildSettings), Property = nameof(DotNetMSBuildSettings.Properties))]
    public static T ToggleDeterministic<T>(this T o) where T : DotNetMSBuildSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "Deterministic")));
    #endregion
    #endregion
}
#endregion
#region DotNetCleanSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetClean(Nuke.Common.Tools.DotNet.DotNetCleanSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetCleanSettingsExtensions
{
    #region Project
    /// <inheritdoc cref="DotNetCleanSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Project))]
    public static T SetProject<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Project, v));
    /// <inheritdoc cref="DotNetCleanSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Project))]
    public static T ResetProject<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Remove(() => o.Project));
    #endregion
    #region Configuration
    /// <inheritdoc cref="DotNetCleanSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Configuration))]
    public static T SetConfiguration<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Configuration, v));
    /// <inheritdoc cref="DotNetCleanSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Configuration))]
    public static T ResetConfiguration<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Remove(() => o.Configuration));
    #endregion
    #region Framework
    /// <inheritdoc cref="DotNetCleanSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Framework))]
    public static T SetFramework<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Framework, v));
    /// <inheritdoc cref="DotNetCleanSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Framework))]
    public static T ResetFramework<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Remove(() => o.Framework));
    #endregion
    #region Output
    /// <inheritdoc cref="DotNetCleanSettings.Output"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Output))]
    public static T SetOutput<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="DotNetCleanSettings.Output"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Runtime
    /// <inheritdoc cref="DotNetCleanSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Runtime))]
    public static T SetRuntime<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Runtime, v));
    /// <inheritdoc cref="DotNetCleanSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Runtime))]
    public static T ResetRuntime<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Remove(() => o.Runtime));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetCleanSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetCleanSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region NoLogo
    /// <inheritdoc cref="DotNetCleanSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.NoLogo))]
    public static T SetNoLogo<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.NoLogo, v));
    /// <inheritdoc cref="DotNetCleanSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.NoLogo))]
    public static T ResetNoLogo<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Remove(() => o.NoLogo));
    /// <inheritdoc cref="DotNetCleanSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.NoLogo))]
    public static T EnableNoLogo<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.NoLogo, true));
    /// <inheritdoc cref="DotNetCleanSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.NoLogo))]
    public static T DisableNoLogo<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.NoLogo, false));
    /// <inheritdoc cref="DotNetCleanSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.NoLogo))]
    public static T ToggleNoLogo<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.NoLogo, !o.NoLogo));
    #endregion
    #region Properties
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetProperties<T>(this T o, IDictionary<string, object> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetProperty<T>(this T o, string k, object v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T AddProperty<T>(this T o, string k, object v) where T : DotNetCleanSettings => o.Modify(b => b.AddDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T RemoveProperty<T>(this T o, string k) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, k));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ClearProperties<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.ClearDictionary(() => o.Properties));
    #region RunCodeAnalysis
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetRunCodeAnalysis<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetRunCodeAnalysis<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RunCodeAnalysis"));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T EnableRunCodeAnalysis<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", true));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T DisableRunCodeAnalysis<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", false));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ToggleRunCodeAnalysis<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "RunCodeAnalysis")));
    #endregion
    #region NoWarn
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetNoWarns<T>(this T o, params int[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T AddNoWarns<T>(this T o, params int[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T AddNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, params int[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetNoWarn<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "NoWarn"));
    #endregion
    #region WarningsAsErrors
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetWarningsAsErrors<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningsAsErrors"));
    #endregion
    #region WarningLevel
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetWarningLevel<T>(this T o, int? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "WarningLevel", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetWarningLevel<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningLevel"));
    #endregion
    #region TreatWarningsAsErrors
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetTreatWarningsAsErrors<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetTreatWarningsAsErrors<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "TreatWarningsAsErrors"));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T EnableTreatWarningsAsErrors<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", true));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T DisableTreatWarningsAsErrors<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", false));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ToggleTreatWarningsAsErrors<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "TreatWarningsAsErrors")));
    #endregion
    #region AssemblyVersion
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetAssemblyVersion<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "AssemblyVersion", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetAssemblyVersion<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "AssemblyVersion"));
    #endregion
    #region FileVersion
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetFileVersion<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "FileVersion", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetFileVersion<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "FileVersion"));
    #endregion
    #region InformationalVersion
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetInformationalVersion<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "InformationalVersion", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetInformationalVersion<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "InformationalVersion"));
    #endregion
    #region PackageId
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPackageId<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageId", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPackageId<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageId"));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Version", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetVersion<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Version"));
    #endregion
    #region VersionPrefix
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetVersionPrefix<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "VersionPrefix", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetVersionPrefix<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "VersionPrefix"));
    #endregion
    #region Authors
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetAuthors<T>(this T o, params string[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T AddAuthors<T>(this T o, params string[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T AddAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, params string[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetAuthors<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Authors"));
    #endregion
    #region Title
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetTitle<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Title", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetTitle<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Title"));
    #endregion
    #region Description
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetDescription<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Description", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetDescription<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Description"));
    #endregion
    #region Copyright
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetCopyright<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Copyright", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetCopyright<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Copyright"));
    #endregion
    #region PackageRequireLicenseAcceptance
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPackageRequireLicenseAcceptance<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPackageRequireLicenseAcceptance<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageRequireLicenseAcceptance"));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T EnablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", true));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T DisablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", false));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T TogglePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PackageRequireLicenseAcceptance")));
    #endregion
    #region PackageLicenseUrl
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPackageLicenseUrl<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageLicenseUrl", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPackageLicenseUrl<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageLicenseUrl"));
    #endregion
    #region PackageProjectUrl
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPackageProjectUrl<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageProjectUrl", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPackageProjectUrl<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageProjectUrl"));
    #endregion
    #region PackageIconUrl
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPackageIconUrl<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageIconUrl", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPackageIconUrl<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageIconUrl"));
    #endregion
    #region PackageTags
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPackageTags<T>(this T o, params string[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T AddPackageTags<T>(this T o, params string[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T AddPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, params string[] v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPackageTags<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageTags"));
    #endregion
    #region PackageReleaseNotes
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPackageReleaseNotes<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageReleaseNotes", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPackageReleaseNotes<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageReleaseNotes"));
    #endregion
    #region RepositoryUrl
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetRepositoryUrl<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryUrl", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetRepositoryUrl<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryUrl"));
    #endregion
    #region RepositoryType
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetRepositoryType<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryType", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetRepositoryType<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryType"));
    #endregion
    #region SymbolPackageFormat
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetSymbolPackageFormat<T>(this T o, DotNetSymbolPackageFormat v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "SymbolPackageFormat", v));
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetSymbolPackageFormat<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "SymbolPackageFormat"));
    #endregion
    #region PublishReadyToRun
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPublishReadyToRun<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", v));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPublishReadyToRun<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishReadyToRun"));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T EnablePublishReadyToRun<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", true));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T DisablePublishReadyToRun<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", false));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T TogglePublishReadyToRun<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishReadyToRun")));
    #endregion
    #region PublishSingleFile
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPublishSingleFile<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", v));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPublishSingleFile<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishSingleFile"));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T EnablePublishSingleFile<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", true));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T DisablePublishSingleFile<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", false));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T TogglePublishSingleFile<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishSingleFile")));
    #endregion
    #region PublishTrimmed
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPublishTrimmed<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", v));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPublishTrimmed<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishTrimmed"));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T EnablePublishTrimmed<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", true));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T DisablePublishTrimmed<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", false));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T TogglePublishTrimmed<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishTrimmed")));
    #endregion
    #region PublishProfile
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPublishProfile<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishProfile", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPublishProfile<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishProfile"));
    #endregion
    #region Platform
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetPlatform<T>(this T o, string v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Platform", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetPlatform<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Platform"));
    #endregion
    #region ContinuousIntegrationBuild
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetContinuousIntegrationBuild<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetContinuousIntegrationBuild<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "ContinuousIntegrationBuild"));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T EnableContinuousIntegrationBuild<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", true));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T DisableContinuousIntegrationBuild<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", false));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ToggleContinuousIntegrationBuild<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "ContinuousIntegrationBuild")));
    #endregion
    #region DeterministicSourcePaths
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetDeterministicSourcePaths<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetDeterministicSourcePaths<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "DeterministicSourcePaths"));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T EnableDeterministicSourcePaths<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", true));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T DisableDeterministicSourcePaths<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", false));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ToggleDeterministicSourcePaths<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "DeterministicSourcePaths")));
    #endregion
    #region Deterministic
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T SetDeterministic<T>(this T o, bool? v) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", v));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ResetDeterministic<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Deterministic"));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T EnableDeterministic<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", true));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T DisableDeterministic<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", false));
    /// <inheritdoc cref="DotNetCleanSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetCleanSettings), Property = nameof(DotNetCleanSettings.Properties))]
    public static T ToggleDeterministic<T>(this T o) where T : DotNetCleanSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "Deterministic")));
    #endregion
    #endregion
}
#endregion
#region DotNetFormatSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetFormat(Nuke.Common.Tools.DotNet.DotNetFormatSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetFormatSettingsExtensions
{
    #region Project
    /// <inheritdoc cref="DotNetFormatSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Project))]
    public static T SetProject<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Project, v));
    /// <inheritdoc cref="DotNetFormatSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Project))]
    public static T ResetProject<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Remove(() => o.Project));
    #endregion
    #region Severity
    /// <inheritdoc cref="DotNetFormatSettings.Severity"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Severity))]
    public static T SetSeverity<T>(this T o, DotNetFormatSeverity v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Severity, v));
    /// <inheritdoc cref="DotNetFormatSettings.Severity"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Severity))]
    public static T ResetSeverity<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Remove(() => o.Severity));
    #endregion
    #region NoRestore
    /// <inheritdoc cref="DotNetFormatSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.NoRestore))]
    public static T SetNoRestore<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.NoRestore, v));
    /// <inheritdoc cref="DotNetFormatSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.NoRestore))]
    public static T ResetNoRestore<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Remove(() => o.NoRestore));
    /// <inheritdoc cref="DotNetFormatSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.NoRestore))]
    public static T EnableNoRestore<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.NoRestore, true));
    /// <inheritdoc cref="DotNetFormatSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.NoRestore))]
    public static T DisableNoRestore<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.NoRestore, false));
    /// <inheritdoc cref="DotNetFormatSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.NoRestore))]
    public static T ToggleNoRestore<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.NoRestore, !o.NoRestore));
    #endregion
    #region VerifyNoChanges
    /// <inheritdoc cref="DotNetFormatSettings.VerifyNoChanges"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.VerifyNoChanges))]
    public static T SetVerifyNoChanges<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.VerifyNoChanges, v));
    /// <inheritdoc cref="DotNetFormatSettings.VerifyNoChanges"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.VerifyNoChanges))]
    public static T ResetVerifyNoChanges<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Remove(() => o.VerifyNoChanges));
    /// <inheritdoc cref="DotNetFormatSettings.VerifyNoChanges"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.VerifyNoChanges))]
    public static T EnableVerifyNoChanges<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.VerifyNoChanges, true));
    /// <inheritdoc cref="DotNetFormatSettings.VerifyNoChanges"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.VerifyNoChanges))]
    public static T DisableVerifyNoChanges<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.VerifyNoChanges, false));
    /// <inheritdoc cref="DotNetFormatSettings.VerifyNoChanges"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.VerifyNoChanges))]
    public static T ToggleVerifyNoChanges<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.VerifyNoChanges, !o.VerifyNoChanges));
    #endregion
    #region Include
    /// <inheritdoc cref="DotNetFormatSettings.Include"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Include))]
    public static T SetInclude<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Include, v));
    /// <inheritdoc cref="DotNetFormatSettings.Include"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Include))]
    public static T SetInclude<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Include, v));
    /// <inheritdoc cref="DotNetFormatSettings.Include"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Include))]
    public static T AddInclude<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.AddCollection(() => o.Include, v));
    /// <inheritdoc cref="DotNetFormatSettings.Include"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Include))]
    public static T AddInclude<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.AddCollection(() => o.Include, v));
    /// <inheritdoc cref="DotNetFormatSettings.Include"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Include))]
    public static T RemoveInclude<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.RemoveCollection(() => o.Include, v));
    /// <inheritdoc cref="DotNetFormatSettings.Include"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Include))]
    public static T RemoveInclude<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.RemoveCollection(() => o.Include, v));
    /// <inheritdoc cref="DotNetFormatSettings.Include"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Include))]
    public static T ClearInclude<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.ClearCollection(() => o.Include));
    #endregion
    #region Exclude
    /// <inheritdoc cref="DotNetFormatSettings.Exclude"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Exclude))]
    public static T SetExclude<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Exclude, v));
    /// <inheritdoc cref="DotNetFormatSettings.Exclude"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Exclude))]
    public static T SetExclude<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Exclude, v));
    /// <inheritdoc cref="DotNetFormatSettings.Exclude"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Exclude))]
    public static T AddExclude<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.AddCollection(() => o.Exclude, v));
    /// <inheritdoc cref="DotNetFormatSettings.Exclude"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Exclude))]
    public static T AddExclude<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.AddCollection(() => o.Exclude, v));
    /// <inheritdoc cref="DotNetFormatSettings.Exclude"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Exclude))]
    public static T RemoveExclude<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.RemoveCollection(() => o.Exclude, v));
    /// <inheritdoc cref="DotNetFormatSettings.Exclude"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Exclude))]
    public static T RemoveExclude<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.RemoveCollection(() => o.Exclude, v));
    /// <inheritdoc cref="DotNetFormatSettings.Exclude"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Exclude))]
    public static T ClearExclude<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.ClearCollection(() => o.Exclude));
    #endregion
    #region IncludeGenerated
    /// <inheritdoc cref="DotNetFormatSettings.IncludeGenerated"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.IncludeGenerated))]
    public static T SetIncludeGenerated<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.IncludeGenerated, v));
    /// <inheritdoc cref="DotNetFormatSettings.IncludeGenerated"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.IncludeGenerated))]
    public static T ResetIncludeGenerated<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Remove(() => o.IncludeGenerated));
    /// <inheritdoc cref="DotNetFormatSettings.IncludeGenerated"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.IncludeGenerated))]
    public static T EnableIncludeGenerated<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.IncludeGenerated, true));
    /// <inheritdoc cref="DotNetFormatSettings.IncludeGenerated"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.IncludeGenerated))]
    public static T DisableIncludeGenerated<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.IncludeGenerated, false));
    /// <inheritdoc cref="DotNetFormatSettings.IncludeGenerated"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.IncludeGenerated))]
    public static T ToggleIncludeGenerated<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.IncludeGenerated, !o.IncludeGenerated));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetFormatSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetFormatSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region BinaryLog
    /// <inheritdoc cref="DotNetFormatSettings.BinaryLog"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.BinaryLog))]
    public static T SetBinaryLog<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.BinaryLog, v));
    /// <inheritdoc cref="DotNetFormatSettings.BinaryLog"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.BinaryLog))]
    public static T ResetBinaryLog<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Remove(() => o.BinaryLog));
    #endregion
    #region Report
    /// <inheritdoc cref="DotNetFormatSettings.Report"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Report))]
    public static T SetReport<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Report, v));
    /// <inheritdoc cref="DotNetFormatSettings.Report"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Report))]
    public static T ResetReport<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Remove(() => o.Report));
    #endregion
    #region Properties
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetProperties<T>(this T o, IDictionary<string, object> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetProperty<T>(this T o, string k, object v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T AddProperty<T>(this T o, string k, object v) where T : DotNetFormatSettings => o.Modify(b => b.AddDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T RemoveProperty<T>(this T o, string k) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, k));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ClearProperties<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.ClearDictionary(() => o.Properties));
    #region RunCodeAnalysis
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetRunCodeAnalysis<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetRunCodeAnalysis<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RunCodeAnalysis"));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T EnableRunCodeAnalysis<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", true));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T DisableRunCodeAnalysis<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", false));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ToggleRunCodeAnalysis<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "RunCodeAnalysis")));
    #endregion
    #region NoWarn
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetNoWarns<T>(this T o, params int[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T AddNoWarns<T>(this T o, params int[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T AddNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, params int[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetNoWarn<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "NoWarn"));
    #endregion
    #region WarningsAsErrors
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetWarningsAsErrors<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningsAsErrors"));
    #endregion
    #region WarningLevel
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetWarningLevel<T>(this T o, int? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "WarningLevel", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetWarningLevel<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningLevel"));
    #endregion
    #region TreatWarningsAsErrors
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetTreatWarningsAsErrors<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetTreatWarningsAsErrors<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "TreatWarningsAsErrors"));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T EnableTreatWarningsAsErrors<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", true));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T DisableTreatWarningsAsErrors<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", false));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ToggleTreatWarningsAsErrors<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "TreatWarningsAsErrors")));
    #endregion
    #region AssemblyVersion
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetAssemblyVersion<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "AssemblyVersion", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetAssemblyVersion<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "AssemblyVersion"));
    #endregion
    #region FileVersion
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetFileVersion<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "FileVersion", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetFileVersion<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "FileVersion"));
    #endregion
    #region InformationalVersion
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetInformationalVersion<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "InformationalVersion", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetInformationalVersion<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "InformationalVersion"));
    #endregion
    #region PackageId
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPackageId<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageId", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPackageId<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageId"));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Version", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetVersion<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Version"));
    #endregion
    #region VersionPrefix
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetVersionPrefix<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "VersionPrefix", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetVersionPrefix<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "VersionPrefix"));
    #endregion
    #region Authors
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetAuthors<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T AddAuthors<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T AddAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetAuthors<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Authors"));
    #endregion
    #region Title
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetTitle<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Title", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetTitle<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Title"));
    #endregion
    #region Description
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetDescription<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Description", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetDescription<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Description"));
    #endregion
    #region Copyright
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetCopyright<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Copyright", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetCopyright<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Copyright"));
    #endregion
    #region PackageRequireLicenseAcceptance
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPackageRequireLicenseAcceptance<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPackageRequireLicenseAcceptance<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageRequireLicenseAcceptance"));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T EnablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", true));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T DisablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", false));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T TogglePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PackageRequireLicenseAcceptance")));
    #endregion
    #region PackageLicenseUrl
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPackageLicenseUrl<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageLicenseUrl", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPackageLicenseUrl<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageLicenseUrl"));
    #endregion
    #region PackageProjectUrl
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPackageProjectUrl<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageProjectUrl", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPackageProjectUrl<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageProjectUrl"));
    #endregion
    #region PackageIconUrl
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPackageIconUrl<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageIconUrl", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPackageIconUrl<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageIconUrl"));
    #endregion
    #region PackageTags
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPackageTags<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T AddPackageTags<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T AddPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, params string[] v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPackageTags<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageTags"));
    #endregion
    #region PackageReleaseNotes
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPackageReleaseNotes<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageReleaseNotes", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPackageReleaseNotes<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageReleaseNotes"));
    #endregion
    #region RepositoryUrl
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetRepositoryUrl<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryUrl", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetRepositoryUrl<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryUrl"));
    #endregion
    #region RepositoryType
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetRepositoryType<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryType", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetRepositoryType<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryType"));
    #endregion
    #region SymbolPackageFormat
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetSymbolPackageFormat<T>(this T o, DotNetSymbolPackageFormat v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "SymbolPackageFormat", v));
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetSymbolPackageFormat<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "SymbolPackageFormat"));
    #endregion
    #region PublishReadyToRun
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPublishReadyToRun<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", v));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPublishReadyToRun<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishReadyToRun"));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T EnablePublishReadyToRun<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", true));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T DisablePublishReadyToRun<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", false));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T TogglePublishReadyToRun<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishReadyToRun")));
    #endregion
    #region PublishSingleFile
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPublishSingleFile<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", v));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPublishSingleFile<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishSingleFile"));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T EnablePublishSingleFile<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", true));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T DisablePublishSingleFile<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", false));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T TogglePublishSingleFile<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishSingleFile")));
    #endregion
    #region PublishTrimmed
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPublishTrimmed<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", v));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPublishTrimmed<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishTrimmed"));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T EnablePublishTrimmed<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", true));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T DisablePublishTrimmed<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", false));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T TogglePublishTrimmed<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishTrimmed")));
    #endregion
    #region PublishProfile
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPublishProfile<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishProfile", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPublishProfile<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishProfile"));
    #endregion
    #region Platform
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetPlatform<T>(this T o, string v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Platform", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetPlatform<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Platform"));
    #endregion
    #region ContinuousIntegrationBuild
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetContinuousIntegrationBuild<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetContinuousIntegrationBuild<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "ContinuousIntegrationBuild"));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T EnableContinuousIntegrationBuild<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", true));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T DisableContinuousIntegrationBuild<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", false));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ToggleContinuousIntegrationBuild<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "ContinuousIntegrationBuild")));
    #endregion
    #region DeterministicSourcePaths
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetDeterministicSourcePaths<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetDeterministicSourcePaths<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "DeterministicSourcePaths"));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T EnableDeterministicSourcePaths<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", true));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T DisableDeterministicSourcePaths<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", false));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ToggleDeterministicSourcePaths<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "DeterministicSourcePaths")));
    #endregion
    #region Deterministic
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T SetDeterministic<T>(this T o, bool? v) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", v));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ResetDeterministic<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Deterministic"));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T EnableDeterministic<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", true));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T DisableDeterministic<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", false));
    /// <inheritdoc cref="DotNetFormatSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetFormatSettings), Property = nameof(DotNetFormatSettings.Properties))]
    public static T ToggleDeterministic<T>(this T o) where T : DotNetFormatSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "Deterministic")));
    #endregion
    #endregion
}
#endregion
#region DotNetPublishSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetPublish(Nuke.Common.Tools.DotNet.DotNetPublishSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetPublishSettingsExtensions
{
    #region Project
    /// <inheritdoc cref="DotNetPublishSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Project))]
    public static T SetProject<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Project, v));
    /// <inheritdoc cref="DotNetPublishSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Project))]
    public static T ResetProject<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.Project));
    #endregion
    #region Architecture
    /// <inheritdoc cref="DotNetPublishSettings.Architecture"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Architecture))]
    public static T SetArchitecture<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Architecture, v));
    /// <inheritdoc cref="DotNetPublishSettings.Architecture"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Architecture))]
    public static T ResetArchitecture<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.Architecture));
    #endregion
    #region Configuration
    /// <inheritdoc cref="DotNetPublishSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Configuration))]
    public static T SetConfiguration<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Configuration, v));
    /// <inheritdoc cref="DotNetPublishSettings.Configuration"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Configuration))]
    public static T ResetConfiguration<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.Configuration));
    #endregion
    #region Framework
    /// <inheritdoc cref="DotNetPublishSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Framework))]
    public static T SetFramework<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Framework, v));
    /// <inheritdoc cref="DotNetPublishSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Framework))]
    public static T ResetFramework<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.Framework));
    #endregion
    #region Manifest
    /// <inheritdoc cref="DotNetPublishSettings.Manifest"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Manifest))]
    public static T SetManifest<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Manifest, v));
    /// <inheritdoc cref="DotNetPublishSettings.Manifest"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Manifest))]
    public static T ResetManifest<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.Manifest));
    #endregion
    #region NoRestore
    /// <inheritdoc cref="DotNetPublishSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoRestore))]
    public static T SetNoRestore<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoRestore, v));
    /// <inheritdoc cref="DotNetPublishSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoRestore))]
    public static T ResetNoRestore<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.NoRestore));
    /// <inheritdoc cref="DotNetPublishSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoRestore))]
    public static T EnableNoRestore<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoRestore, true));
    /// <inheritdoc cref="DotNetPublishSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoRestore))]
    public static T DisableNoRestore<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoRestore, false));
    /// <inheritdoc cref="DotNetPublishSettings.NoRestore"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoRestore))]
    public static T ToggleNoRestore<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoRestore, !o.NoRestore));
    #endregion
    #region NoBuild
    /// <inheritdoc cref="DotNetPublishSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoBuild))]
    public static T SetNoBuild<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoBuild, v));
    /// <inheritdoc cref="DotNetPublishSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoBuild))]
    public static T ResetNoBuild<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.NoBuild));
    /// <inheritdoc cref="DotNetPublishSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoBuild))]
    public static T EnableNoBuild<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoBuild, true));
    /// <inheritdoc cref="DotNetPublishSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoBuild))]
    public static T DisableNoBuild<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoBuild, false));
    /// <inheritdoc cref="DotNetPublishSettings.NoBuild"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoBuild))]
    public static T ToggleNoBuild<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoBuild, !o.NoBuild));
    #endregion
    #region Output
    /// <inheritdoc cref="DotNetPublishSettings.Output"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Output))]
    public static T SetOutput<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="DotNetPublishSettings.Output"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region OperatingSystem
    /// <inheritdoc cref="DotNetPublishSettings.OperatingSystem"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.OperatingSystem))]
    public static T SetOperatingSystem<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.OperatingSystem, v));
    /// <inheritdoc cref="DotNetPublishSettings.OperatingSystem"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.OperatingSystem))]
    public static T ResetOperatingSystem<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.OperatingSystem));
    #endregion
    #region SelfContained
    /// <inheritdoc cref="DotNetPublishSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.SelfContained))]
    public static T SetSelfContained<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.SelfContained, v));
    /// <inheritdoc cref="DotNetPublishSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.SelfContained))]
    public static T ResetSelfContained<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.SelfContained));
    /// <inheritdoc cref="DotNetPublishSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.SelfContained))]
    public static T EnableSelfContained<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.SelfContained, true));
    /// <inheritdoc cref="DotNetPublishSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.SelfContained))]
    public static T DisableSelfContained<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.SelfContained, false));
    /// <inheritdoc cref="DotNetPublishSettings.SelfContained"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.SelfContained))]
    public static T ToggleSelfContained<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.SelfContained, !o.SelfContained));
    #endregion
    #region Runtime
    /// <inheritdoc cref="DotNetPublishSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Runtime))]
    public static T SetRuntime<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Runtime, v));
    /// <inheritdoc cref="DotNetPublishSettings.Runtime"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Runtime))]
    public static T ResetRuntime<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.Runtime));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetPublishSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetPublishSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region VersionSuffix
    /// <inheritdoc cref="DotNetPublishSettings.VersionSuffix"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.VersionSuffix))]
    public static T SetVersionSuffix<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.VersionSuffix, v));
    /// <inheritdoc cref="DotNetPublishSettings.VersionSuffix"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.VersionSuffix))]
    public static T ResetVersionSuffix<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.VersionSuffix));
    #endregion
    #region NoLogo
    /// <inheritdoc cref="DotNetPublishSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoLogo))]
    public static T SetNoLogo<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoLogo, v));
    /// <inheritdoc cref="DotNetPublishSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoLogo))]
    public static T ResetNoLogo<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.NoLogo));
    /// <inheritdoc cref="DotNetPublishSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoLogo))]
    public static T EnableNoLogo<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoLogo, true));
    /// <inheritdoc cref="DotNetPublishSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoLogo))]
    public static T DisableNoLogo<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoLogo, false));
    /// <inheritdoc cref="DotNetPublishSettings.NoLogo"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoLogo))]
    public static T ToggleNoLogo<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoLogo, !o.NoLogo));
    #endregion
    #region Targets
    /// <inheritdoc cref="DotNetPublishSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Targets))]
    public static T SetTargets<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Targets, v));
    /// <inheritdoc cref="DotNetPublishSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Targets))]
    public static T SetTargets<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Targets, v));
    /// <inheritdoc cref="DotNetPublishSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Targets))]
    public static T AddTargets<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.AddCollection(() => o.Targets, v));
    /// <inheritdoc cref="DotNetPublishSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Targets))]
    public static T AddTargets<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.AddCollection(() => o.Targets, v));
    /// <inheritdoc cref="DotNetPublishSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Targets))]
    public static T RemoveTargets<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.RemoveCollection(() => o.Targets, v));
    /// <inheritdoc cref="DotNetPublishSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Targets))]
    public static T RemoveTargets<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.RemoveCollection(() => o.Targets, v));
    /// <inheritdoc cref="DotNetPublishSettings.Targets"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Targets))]
    public static T ClearTargets<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.ClearCollection(() => o.Targets));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetPublishSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetPublishSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetPublishSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetPublishSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetPublishSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region Force
    /// <inheritdoc cref="DotNetPublishSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="DotNetPublishSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Force))]
    public static T ResetForce<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="DotNetPublishSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Force))]
    public static T EnableForce<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="DotNetPublishSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Force))]
    public static T DisableForce<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="DotNetPublishSettings.Force"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetPublishSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetPublishSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetPublishSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetPublishSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetPublishSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetPublishSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetPublishSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetPublishSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetPublishSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetPublishSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region NoDependencies
    /// <inheritdoc cref="DotNetPublishSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoDependencies))]
    public static T SetNoDependencies<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoDependencies, v));
    /// <inheritdoc cref="DotNetPublishSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoDependencies))]
    public static T ResetNoDependencies<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.NoDependencies));
    /// <inheritdoc cref="DotNetPublishSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoDependencies))]
    public static T EnableNoDependencies<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoDependencies, true));
    /// <inheritdoc cref="DotNetPublishSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoDependencies))]
    public static T DisableNoDependencies<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoDependencies, false));
    /// <inheritdoc cref="DotNetPublishSettings.NoDependencies"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.NoDependencies))]
    public static T ToggleNoDependencies<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.NoDependencies, !o.NoDependencies));
    #endregion
    #region PackageDirectory
    /// <inheritdoc cref="DotNetPublishSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.PackageDirectory))]
    public static T SetPackageDirectory<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.PackageDirectory, v));
    /// <inheritdoc cref="DotNetPublishSettings.PackageDirectory"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.PackageDirectory))]
    public static T ResetPackageDirectory<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.PackageDirectory));
    #endregion
    #region Sources
    /// <inheritdoc cref="DotNetPublishSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Sources))]
    public static T SetSources<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPublishSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Sources))]
    public static T SetSources<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPublishSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Sources))]
    public static T AddSources<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPublishSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Sources))]
    public static T AddSources<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPublishSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Sources))]
    public static T RemoveSources<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPublishSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Sources))]
    public static T RemoveSources<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetPublishSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Sources))]
    public static T ClearSources<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.ClearCollection(() => o.Sources));
    #endregion
    #region UseLockFile
    /// <inheritdoc cref="DotNetPublishSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.UseLockFile))]
    public static T SetUseLockFile<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.UseLockFile, v));
    /// <inheritdoc cref="DotNetPublishSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.UseLockFile))]
    public static T ResetUseLockFile<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.UseLockFile));
    /// <inheritdoc cref="DotNetPublishSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.UseLockFile))]
    public static T EnableUseLockFile<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.UseLockFile, true));
    /// <inheritdoc cref="DotNetPublishSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.UseLockFile))]
    public static T DisableUseLockFile<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.UseLockFile, false));
    /// <inheritdoc cref="DotNetPublishSettings.UseLockFile"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.UseLockFile))]
    public static T ToggleUseLockFile<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.UseLockFile, !o.UseLockFile));
    #endregion
    #region LockedMode
    /// <inheritdoc cref="DotNetPublishSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.LockedMode))]
    public static T SetLockedMode<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.LockedMode, v));
    /// <inheritdoc cref="DotNetPublishSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.LockedMode))]
    public static T ResetLockedMode<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.LockedMode));
    /// <inheritdoc cref="DotNetPublishSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.LockedMode))]
    public static T EnableLockedMode<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.LockedMode, true));
    /// <inheritdoc cref="DotNetPublishSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.LockedMode))]
    public static T DisableLockedMode<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.LockedMode, false));
    /// <inheritdoc cref="DotNetPublishSettings.LockedMode"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.LockedMode))]
    public static T ToggleLockedMode<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.LockedMode, !o.LockedMode));
    #endregion
    #region LockFilePath
    /// <inheritdoc cref="DotNetPublishSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.LockFilePath))]
    public static T SetLockFilePath<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.LockFilePath, v));
    /// <inheritdoc cref="DotNetPublishSettings.LockFilePath"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.LockFilePath))]
    public static T ResetLockFilePath<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.LockFilePath));
    #endregion
    #region ForceEvaluate
    /// <inheritdoc cref="DotNetPublishSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.ForceEvaluate))]
    public static T SetForceEvaluate<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, v));
    /// <inheritdoc cref="DotNetPublishSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.ForceEvaluate))]
    public static T ResetForceEvaluate<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Remove(() => o.ForceEvaluate));
    /// <inheritdoc cref="DotNetPublishSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.ForceEvaluate))]
    public static T EnableForceEvaluate<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, true));
    /// <inheritdoc cref="DotNetPublishSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.ForceEvaluate))]
    public static T DisableForceEvaluate<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, false));
    /// <inheritdoc cref="DotNetPublishSettings.ForceEvaluate"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.ForceEvaluate))]
    public static T ToggleForceEvaluate<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.ForceEvaluate, !o.ForceEvaluate));
    #endregion
    #region Properties
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetProperties<T>(this T o, IDictionary<string, object> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetProperty<T>(this T o, string k, object v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T AddProperty<T>(this T o, string k, object v) where T : DotNetPublishSettings => o.Modify(b => b.AddDictionary(() => o.Properties, k, v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T RemoveProperty<T>(this T o, string k) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, k));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ClearProperties<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.ClearDictionary(() => o.Properties));
    #region RunCodeAnalysis
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetRunCodeAnalysis<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetRunCodeAnalysis<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RunCodeAnalysis"));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T EnableRunCodeAnalysis<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", true));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T DisableRunCodeAnalysis<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RunCodeAnalysis", false));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ToggleRunCodeAnalysis<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "RunCodeAnalysis")));
    #endregion
    #region NoWarn
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetNoWarns<T>(this T o, params int[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T AddNoWarns<T>(this T o, params int[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T AddNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, params int[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T RemoveNoWarns<T>(this T o, IEnumerable<int> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "NoWarn", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetNoWarn<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "NoWarn"));
    #endregion
    #region WarningsAsErrors
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T AddWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, params int[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T RemoveWarningsAsErrors<T>(this T o, IEnumerable<int> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "WarningsAsErrors", v, ";")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetWarningsAsErrors<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningsAsErrors"));
    #endregion
    #region WarningLevel
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetWarningLevel<T>(this T o, int? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "WarningLevel", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetWarningLevel<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "WarningLevel"));
    #endregion
    #region TreatWarningsAsErrors
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetTreatWarningsAsErrors<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetTreatWarningsAsErrors<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "TreatWarningsAsErrors"));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T EnableTreatWarningsAsErrors<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", true));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T DisableTreatWarningsAsErrors<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "TreatWarningsAsErrors", false));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ToggleTreatWarningsAsErrors<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "TreatWarningsAsErrors")));
    #endregion
    #region AssemblyVersion
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetAssemblyVersion<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "AssemblyVersion", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetAssemblyVersion<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "AssemblyVersion"));
    #endregion
    #region FileVersion
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetFileVersion<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "FileVersion", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetFileVersion<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "FileVersion"));
    #endregion
    #region InformationalVersion
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetInformationalVersion<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "InformationalVersion", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetInformationalVersion<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "InformationalVersion"));
    #endregion
    #region PackageId
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPackageId<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageId", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPackageId<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageId"));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Version", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetVersion<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Version"));
    #endregion
    #region VersionPrefix
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetVersionPrefix<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "VersionPrefix", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetVersionPrefix<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "VersionPrefix"));
    #endregion
    #region Authors
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetAuthors<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T AddAuthors<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T AddAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T RemoveAuthors<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "Authors", v, ",")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetAuthors<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Authors"));
    #endregion
    #region Title
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetTitle<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Title", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetTitle<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Title"));
    #endregion
    #region Description
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetDescription<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Description", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetDescription<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Description"));
    #endregion
    #region Copyright
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetCopyright<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Copyright", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetCopyright<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Copyright"));
    #endregion
    #region PackageRequireLicenseAcceptance
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPackageRequireLicenseAcceptance<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPackageRequireLicenseAcceptance<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageRequireLicenseAcceptance"));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T EnablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", true));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T DisablePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageRequireLicenseAcceptance", false));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T TogglePackageRequireLicenseAcceptance<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PackageRequireLicenseAcceptance")));
    #endregion
    #region PackageLicenseUrl
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPackageLicenseUrl<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageLicenseUrl", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPackageLicenseUrl<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageLicenseUrl"));
    #endregion
    #region PackageProjectUrl
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPackageProjectUrl<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageProjectUrl", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPackageProjectUrl<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageProjectUrl"));
    #endregion
    #region PackageIconUrl
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPackageIconUrl<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageIconUrl", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPackageIconUrl<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageIconUrl"));
    #endregion
    #region PackageTags
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPackageTags<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.SetCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T AddPackageTags<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T AddPackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.AddCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, params string[] v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T RemovePackageTags<T>(this T o, IEnumerable<string> v) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.RemoveCollection(o.Properties, "PackageTags", v, " ")));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPackageTags<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageTags"));
    #endregion
    #region PackageReleaseNotes
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPackageReleaseNotes<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PackageReleaseNotes", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPackageReleaseNotes<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PackageReleaseNotes"));
    #endregion
    #region RepositoryUrl
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetRepositoryUrl<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryUrl", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetRepositoryUrl<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryUrl"));
    #endregion
    #region RepositoryType
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetRepositoryType<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "RepositoryType", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetRepositoryType<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "RepositoryType"));
    #endregion
    #region SymbolPackageFormat
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetSymbolPackageFormat<T>(this T o, DotNetSymbolPackageFormat v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "SymbolPackageFormat", v));
    /// <summary>Format for packaging symbols.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetSymbolPackageFormat<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "SymbolPackageFormat"));
    #endregion
    #region PublishReadyToRun
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPublishReadyToRun<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", v));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPublishReadyToRun<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishReadyToRun"));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T EnablePublishReadyToRun<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", true));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T DisablePublishReadyToRun<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishReadyToRun", false));
    /// <summary>Compiles application assemblies as ReadyToRun (R2R) format. R2R is a form of ahead-of-time (AOT) compilation. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run">ReadyToRun images</a>. Available since .NET Core 3.0 SDK.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T TogglePublishReadyToRun<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishReadyToRun")));
    #endregion
    #region PublishSingleFile
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPublishSingleFile<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", v));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPublishSingleFile<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishSingleFile"));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T EnablePublishSingleFile<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", true));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T DisablePublishSingleFile<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishSingleFile", false));
    /// <summary>Packages the app into a platform-specific single-file executable. The executable is self-extracting and contains all dependencies (including native) that are required to run the app. When the app is first run, the application is extracted to a directory based on the app name and build identifier. Startup is faster when the application is run again. The application doesn't need to extract itself a second time unless a new version is used. Available since .NET Core 3.0 SDK.<para/> For more information about single-file publishing, see the <a href="https://github.com/dotnet/designs/blob/master/accepted/2020/single-file/design.md">single-file bundler design document</a>.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T TogglePublishSingleFile<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishSingleFile")));
    #endregion
    #region PublishTrimmed
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPublishTrimmed<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", v));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPublishTrimmed<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishTrimmed"));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T EnablePublishTrimmed<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", true));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T DisablePublishTrimmed<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishTrimmed", false));
    /// <summary>Trims unused libraries to reduce the deployment size of an app when publishing a self-contained executable. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained">Trim self-contained deployments and executables</a>. Available since .NET Core 3.0 SDK as a preview feature.<para/>We recommend that you specify this option in a publish profile rather than on the command line. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish#msbuild">MSBuild</a>.</summary>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T TogglePublishTrimmed<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "PublishTrimmed")));
    #endregion
    #region PublishProfile
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPublishProfile<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "PublishProfile", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPublishProfile<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "PublishProfile"));
    #endregion
    #region Platform
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetPlatform<T>(this T o, string v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Platform", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetPlatform<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Platform"));
    #endregion
    #region ContinuousIntegrationBuild
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetContinuousIntegrationBuild<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetContinuousIntegrationBuild<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "ContinuousIntegrationBuild"));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T EnableContinuousIntegrationBuild<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", true));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T DisableContinuousIntegrationBuild<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "ContinuousIntegrationBuild", false));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ToggleContinuousIntegrationBuild<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "ContinuousIntegrationBuild")));
    #endregion
    #region DeterministicSourcePaths
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetDeterministicSourcePaths<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetDeterministicSourcePaths<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "DeterministicSourcePaths"));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T EnableDeterministicSourcePaths<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", true));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T DisableDeterministicSourcePaths<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "DeterministicSourcePaths", false));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ToggleDeterministicSourcePaths<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "DeterministicSourcePaths")));
    #endregion
    #region Deterministic
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T SetDeterministic<T>(this T o, bool? v) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", v));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ResetDeterministic<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.RemoveDictionary(() => o.Properties, "Deterministic"));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T EnableDeterministic<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", true));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T DisableDeterministic<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.SetDictionary(() => o.Properties, "Deterministic", false));
    /// <inheritdoc cref="DotNetPublishSettings.Properties"/>
    [Pure] [Builder(Type = typeof(DotNetPublishSettings), Property = nameof(DotNetPublishSettings.Properties))]
    public static T ToggleDeterministic<T>(this T o) where T : DotNetPublishSettings => o.Modify(b => b.Set(() => o.Properties, DelegateHelper.Toggle(o.Properties, "Deterministic")));
    #endregion
    #endregion
}
#endregion
#region DotNetNuGetPushSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetNuGetPush(Nuke.Common.Tools.DotNet.DotNetNuGetPushSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetNuGetPushSettingsExtensions
{
    #region TargetPath
    /// <inheritdoc cref="DotNetNuGetPushSettings.TargetPath"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.TargetPath))]
    public static T SetTargetPath<T>(this T o, string v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.TargetPath, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.TargetPath"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.TargetPath))]
    public static T ResetTargetPath<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.TargetPath));
    #endregion
    #region Source
    /// <inheritdoc cref="DotNetNuGetPushSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.Source))]
    public static T SetSource<T>(this T o, string v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.Source, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.Source))]
    public static T ResetSource<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.Source));
    #endregion
    #region SymbolSource
    /// <inheritdoc cref="DotNetNuGetPushSettings.SymbolSource"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.SymbolSource))]
    public static T SetSymbolSource<T>(this T o, string v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.SymbolSource, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.SymbolSource"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.SymbolSource))]
    public static T ResetSymbolSource<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.SymbolSource));
    #endregion
    #region Timeout
    /// <inheritdoc cref="DotNetNuGetPushSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.Timeout))]
    public static T SetTimeout<T>(this T o, int? v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
    #region ApiKey
    /// <inheritdoc cref="DotNetNuGetPushSettings.ApiKey"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.ApiKey))]
    public static T SetApiKey<T>(this T o, [Secret] string v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.ApiKey, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.ApiKey"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.ApiKey))]
    public static T ResetApiKey<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.ApiKey));
    #endregion
    #region SymbolApiKey
    /// <inheritdoc cref="DotNetNuGetPushSettings.SymbolApiKey"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.SymbolApiKey))]
    public static T SetSymbolApiKey<T>(this T o, [Secret] string v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.SymbolApiKey, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.SymbolApiKey"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.SymbolApiKey))]
    public static T ResetSymbolApiKey<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.SymbolApiKey));
    #endregion
    #region DisableBuffering
    /// <inheritdoc cref="DotNetNuGetPushSettings.DisableBuffering"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.DisableBuffering))]
    public static T SetDisableBuffering<T>(this T o, bool? v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.DisableBuffering, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.DisableBuffering"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.DisableBuffering))]
    public static T ResetDisableBuffering<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.DisableBuffering));
    /// <inheritdoc cref="DotNetNuGetPushSettings.DisableBuffering"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.DisableBuffering))]
    public static T EnableDisableBuffering<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.DisableBuffering, true));
    /// <inheritdoc cref="DotNetNuGetPushSettings.DisableBuffering"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.DisableBuffering))]
    public static T DisableDisableBuffering<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.DisableBuffering, false));
    /// <inheritdoc cref="DotNetNuGetPushSettings.DisableBuffering"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.DisableBuffering))]
    public static T ToggleDisableBuffering<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.DisableBuffering, !o.DisableBuffering));
    #endregion
    #region NoSymbols
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoSymbols))]
    public static T SetNoSymbols<T>(this T o, bool? v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.NoSymbols, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoSymbols))]
    public static T ResetNoSymbols<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.NoSymbols));
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoSymbols))]
    public static T EnableNoSymbols<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.NoSymbols, true));
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoSymbols))]
    public static T DisableNoSymbols<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.NoSymbols, false));
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoSymbols"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoSymbols))]
    public static T ToggleNoSymbols<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.NoSymbols, !o.NoSymbols));
    #endregion
    #region ForceEnglishOutput
    /// <inheritdoc cref="DotNetNuGetPushSettings.ForceEnglishOutput"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.ForceEnglishOutput))]
    public static T SetForceEnglishOutput<T>(this T o, bool? v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.ForceEnglishOutput, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.ForceEnglishOutput"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.ForceEnglishOutput))]
    public static T ResetForceEnglishOutput<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.ForceEnglishOutput));
    /// <inheritdoc cref="DotNetNuGetPushSettings.ForceEnglishOutput"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.ForceEnglishOutput))]
    public static T EnableForceEnglishOutput<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.ForceEnglishOutput, true));
    /// <inheritdoc cref="DotNetNuGetPushSettings.ForceEnglishOutput"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.ForceEnglishOutput))]
    public static T DisableForceEnglishOutput<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.ForceEnglishOutput, false));
    /// <inheritdoc cref="DotNetNuGetPushSettings.ForceEnglishOutput"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.ForceEnglishOutput))]
    public static T ToggleForceEnglishOutput<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.ForceEnglishOutput, !o.ForceEnglishOutput));
    #endregion
    #region SkipDuplicate
    /// <inheritdoc cref="DotNetNuGetPushSettings.SkipDuplicate"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.SkipDuplicate))]
    public static T SetSkipDuplicate<T>(this T o, bool? v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.SkipDuplicate, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.SkipDuplicate"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.SkipDuplicate))]
    public static T ResetSkipDuplicate<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.SkipDuplicate));
    /// <inheritdoc cref="DotNetNuGetPushSettings.SkipDuplicate"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.SkipDuplicate))]
    public static T EnableSkipDuplicate<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.SkipDuplicate, true));
    /// <inheritdoc cref="DotNetNuGetPushSettings.SkipDuplicate"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.SkipDuplicate))]
    public static T DisableSkipDuplicate<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.SkipDuplicate, false));
    /// <inheritdoc cref="DotNetNuGetPushSettings.SkipDuplicate"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.SkipDuplicate))]
    public static T ToggleSkipDuplicate<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.SkipDuplicate, !o.SkipDuplicate));
    #endregion
    #region NoServiceEndpoint
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoServiceEndpoint"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoServiceEndpoint))]
    public static T SetNoServiceEndpoint<T>(this T o, bool? v) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.NoServiceEndpoint, v));
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoServiceEndpoint"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoServiceEndpoint))]
    public static T ResetNoServiceEndpoint<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Remove(() => o.NoServiceEndpoint));
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoServiceEndpoint"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoServiceEndpoint))]
    public static T EnableNoServiceEndpoint<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.NoServiceEndpoint, true));
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoServiceEndpoint"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoServiceEndpoint))]
    public static T DisableNoServiceEndpoint<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.NoServiceEndpoint, false));
    /// <inheritdoc cref="DotNetNuGetPushSettings.NoServiceEndpoint"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetPushSettings), Property = nameof(DotNetNuGetPushSettings.NoServiceEndpoint))]
    public static T ToggleNoServiceEndpoint<T>(this T o) where T : DotNetNuGetPushSettings => o.Modify(b => b.Set(() => o.NoServiceEndpoint, !o.NoServiceEndpoint));
    #endregion
}
#endregion
#region DotNetNuGetAddSourceSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetNuGetAddSource(Nuke.Common.Tools.DotNet.DotNetNuGetAddSourceSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetNuGetAddSourceSettingsExtensions
{
    #region Source
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.Source))]
    public static T SetSource<T>(this T o, string v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.Source, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.Source))]
    public static T ResetSource<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Remove(() => o.Source));
    #endregion
    #region Name
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.Name"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.Name))]
    public static T SetName<T>(this T o, string v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.Name, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.Name"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.Name))]
    public static T ResetName<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Remove(() => o.Name));
    #endregion
    #region Username
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.Username"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.Username))]
    public static T SetUsername<T>(this T o, string v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.Username, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.Username"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.Username))]
    public static T ResetUsername<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Remove(() => o.Username));
    #endregion
    #region Password
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.Password"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.Password))]
    public static T SetPassword<T>(this T o, [Secret] string v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.Password, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.Password"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.Password))]
    public static T ResetPassword<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Remove(() => o.Password));
    #endregion
    #region StorePasswordInClearText
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.StorePasswordInClearText))]
    public static T SetStorePasswordInClearText<T>(this T o, bool? v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.StorePasswordInClearText, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.StorePasswordInClearText))]
    public static T ResetStorePasswordInClearText<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Remove(() => o.StorePasswordInClearText));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.StorePasswordInClearText))]
    public static T EnableStorePasswordInClearText<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.StorePasswordInClearText, true));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.StorePasswordInClearText))]
    public static T DisableStorePasswordInClearText<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.StorePasswordInClearText, false));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.StorePasswordInClearText))]
    public static T ToggleStorePasswordInClearText<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.StorePasswordInClearText, !o.StorePasswordInClearText));
    #endregion
    #region ValidAuthenticationTypes
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.ValidAuthenticationTypes))]
    public static T SetValidAuthenticationTypes<T>(this T o, params DotNetNuGetAuthentication[] v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.ValidAuthenticationTypes))]
    public static T SetValidAuthenticationTypes<T>(this T o, IEnumerable<DotNetNuGetAuthentication> v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.ValidAuthenticationTypes))]
    public static T AddValidAuthenticationTypes<T>(this T o, params DotNetNuGetAuthentication[] v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.AddCollection(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.ValidAuthenticationTypes))]
    public static T AddValidAuthenticationTypes<T>(this T o, IEnumerable<DotNetNuGetAuthentication> v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.AddCollection(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.ValidAuthenticationTypes))]
    public static T RemoveValidAuthenticationTypes<T>(this T o, params DotNetNuGetAuthentication[] v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.RemoveCollection(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.ValidAuthenticationTypes))]
    public static T RemoveValidAuthenticationTypes<T>(this T o, IEnumerable<DotNetNuGetAuthentication> v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.RemoveCollection(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.ValidAuthenticationTypes))]
    public static T ClearValidAuthenticationTypes<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.ClearCollection(() => o.ValidAuthenticationTypes));
    #endregion
    #region ConfigFile
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetNuGetAddSourceSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetAddSourceSettings), Property = nameof(DotNetNuGetAddSourceSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetNuGetAddSourceSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
}
#endregion
#region DotNetNuGetUpdateSourceSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetNuGetUpdateSource(Nuke.Common.Tools.DotNet.DotNetNuGetUpdateSourceSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetNuGetUpdateSourceSettingsExtensions
{
    #region Name
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.Name"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.Name))]
    public static T SetName<T>(this T o, string v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.Name, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.Name"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.Name))]
    public static T ResetName<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Remove(() => o.Name));
    #endregion
    #region Source
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.Source))]
    public static T SetSource<T>(this T o, string v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.Source, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.Source))]
    public static T ResetSource<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Remove(() => o.Source));
    #endregion
    #region Username
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.Username"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.Username))]
    public static T SetUsername<T>(this T o, string v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.Username, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.Username"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.Username))]
    public static T ResetUsername<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Remove(() => o.Username));
    #endregion
    #region Password
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.Password"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.Password))]
    public static T SetPassword<T>(this T o, [Secret] string v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.Password, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.Password"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.Password))]
    public static T ResetPassword<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Remove(() => o.Password));
    #endregion
    #region StorePasswordInClearText
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.StorePasswordInClearText))]
    public static T SetStorePasswordInClearText<T>(this T o, bool? v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.StorePasswordInClearText, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.StorePasswordInClearText))]
    public static T ResetStorePasswordInClearText<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Remove(() => o.StorePasswordInClearText));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.StorePasswordInClearText))]
    public static T EnableStorePasswordInClearText<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.StorePasswordInClearText, true));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.StorePasswordInClearText))]
    public static T DisableStorePasswordInClearText<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.StorePasswordInClearText, false));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.StorePasswordInClearText"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.StorePasswordInClearText))]
    public static T ToggleStorePasswordInClearText<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.StorePasswordInClearText, !o.StorePasswordInClearText));
    #endregion
    #region ValidAuthenticationTypes
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes))]
    public static T SetValidAuthenticationTypes<T>(this T o, params DotNetNuGetAuthentication[] v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes))]
    public static T SetValidAuthenticationTypes<T>(this T o, IEnumerable<DotNetNuGetAuthentication> v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes))]
    public static T AddValidAuthenticationTypes<T>(this T o, params DotNetNuGetAuthentication[] v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.AddCollection(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes))]
    public static T AddValidAuthenticationTypes<T>(this T o, IEnumerable<DotNetNuGetAuthentication> v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.AddCollection(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes))]
    public static T RemoveValidAuthenticationTypes<T>(this T o, params DotNetNuGetAuthentication[] v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.RemoveCollection(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes))]
    public static T RemoveValidAuthenticationTypes<T>(this T o, IEnumerable<DotNetNuGetAuthentication> v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.RemoveCollection(() => o.ValidAuthenticationTypes, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.ValidAuthenticationTypes))]
    public static T ClearValidAuthenticationTypes<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.ClearCollection(() => o.ValidAuthenticationTypes));
    #endregion
    #region ConfigFile
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetNuGetUpdateSourceSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetNuGetUpdateSourceSettings), Property = nameof(DotNetNuGetUpdateSourceSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetNuGetUpdateSourceSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
}
#endregion
#region DotNetToolInstallSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetToolInstall(Nuke.Common.Tools.DotNet.DotNetToolInstallSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetToolInstallSettingsExtensions
{
    #region PackageName
    /// <inheritdoc cref="DotNetToolInstallSettings.PackageName"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.PackageName))]
    public static T SetPackageName<T>(this T o, string v) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.PackageName, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.PackageName"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.PackageName))]
    public static T ResetPackageName<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Remove(() => o.PackageName));
    #endregion
    #region Sources
    /// <inheritdoc cref="DotNetToolInstallSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Sources))]
    public static T SetSources<T>(this T o, params string[] v) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Sources))]
    public static T SetSources<T>(this T o, IEnumerable<string> v) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Sources))]
    public static T AddSources<T>(this T o, params string[] v) where T : DotNetToolInstallSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Sources))]
    public static T AddSources<T>(this T o, IEnumerable<string> v) where T : DotNetToolInstallSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Sources))]
    public static T RemoveSources<T>(this T o, params string[] v) where T : DotNetToolInstallSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Sources))]
    public static T RemoveSources<T>(this T o, IEnumerable<string> v) where T : DotNetToolInstallSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Sources))]
    public static T ClearSources<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.ClearCollection(() => o.Sources));
    #endregion
    #region ConfigFile
    /// <inheritdoc cref="DotNetToolInstallSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
    #region Framework
    /// <inheritdoc cref="DotNetToolInstallSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Framework))]
    public static T SetFramework<T>(this T o, string v) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.Framework, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Framework))]
    public static T ResetFramework<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Remove(() => o.Framework));
    #endregion
    #region Global
    /// <inheritdoc cref="DotNetToolInstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Global))]
    public static T SetGlobal<T>(this T o, bool? v) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.Global, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Global))]
    public static T ResetGlobal<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Remove(() => o.Global));
    /// <inheritdoc cref="DotNetToolInstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Global))]
    public static T EnableGlobal<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.Global, true));
    /// <inheritdoc cref="DotNetToolInstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Global))]
    public static T DisableGlobal<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.Global, false));
    /// <inheritdoc cref="DotNetToolInstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Global))]
    public static T ToggleGlobal<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.Global, !o.Global));
    #endregion
    #region ToolInstallationPath
    /// <inheritdoc cref="DotNetToolInstallSettings.ToolInstallationPath"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.ToolInstallationPath))]
    public static T SetToolInstallationPath<T>(this T o, string v) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.ToolInstallationPath, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.ToolInstallationPath"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.ToolInstallationPath))]
    public static T ResetToolInstallationPath<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Remove(() => o.ToolInstallationPath));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetToolInstallSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetToolInstallSettings.Version"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Version))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetToolInstallSettings => o.Modify(b => b.Set(() => o.Version, v));
    /// <inheritdoc cref="DotNetToolInstallSettings.Version"/>
    [Pure] [Builder(Type = typeof(DotNetToolInstallSettings), Property = nameof(DotNetToolInstallSettings.Version))]
    public static T ResetVersion<T>(this T o) where T : DotNetToolInstallSettings => o.Modify(b => b.Remove(() => o.Version));
    #endregion
}
#endregion
#region DotNetToolRestoreSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetToolRestore(Nuke.Common.Tools.DotNet.DotNetToolRestoreSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetToolRestoreSettingsExtensions
{
    #region ConfigFile
    /// <inheritdoc cref="DotNetToolRestoreSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
    #region Sources
    /// <inheritdoc cref="DotNetToolRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Sources))]
    public static T SetSources<T>(this T o, params string[] v) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Sources))]
    public static T SetSources<T>(this T o, IEnumerable<string> v) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Sources))]
    public static T AddSources<T>(this T o, params string[] v) where T : DotNetToolRestoreSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Sources))]
    public static T AddSources<T>(this T o, IEnumerable<string> v) where T : DotNetToolRestoreSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Sources))]
    public static T RemoveSources<T>(this T o, params string[] v) where T : DotNetToolRestoreSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Sources))]
    public static T RemoveSources<T>(this T o, IEnumerable<string> v) where T : DotNetToolRestoreSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Sources))]
    public static T ClearSources<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.ClearCollection(() => o.Sources));
    #endregion
    #region ToolManifest
    /// <inheritdoc cref="DotNetToolRestoreSettings.ToolManifest"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.ToolManifest))]
    public static T SetToolManifest<T>(this T o, string v) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.ToolManifest, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.ToolManifest"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.ToolManifest))]
    public static T ResetToolManifest<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Remove(() => o.ToolManifest));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetToolRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetToolRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetToolRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetToolRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetToolRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetToolRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetToolRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetToolRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetToolRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetToolRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetToolRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetToolRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region Interactive
    /// <inheritdoc cref="DotNetToolRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Interactive))]
    public static T SetInteractive<T>(this T o, bool? v) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.Interactive, v));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Interactive))]
    public static T ResetInteractive<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Remove(() => o.Interactive));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Interactive))]
    public static T EnableInteractive<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.Interactive, true));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Interactive))]
    public static T DisableInteractive<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.Interactive, false));
    /// <inheritdoc cref="DotNetToolRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetToolRestoreSettings), Property = nameof(DotNetToolRestoreSettings.Interactive))]
    public static T ToggleInteractive<T>(this T o) where T : DotNetToolRestoreSettings => o.Modify(b => b.Set(() => o.Interactive, !o.Interactive));
    #endregion
}
#endregion
#region DotNetToolUninstallSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetToolUninstall(Nuke.Common.Tools.DotNet.DotNetToolUninstallSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetToolUninstallSettingsExtensions
{
    #region PackageName
    /// <inheritdoc cref="DotNetToolUninstallSettings.PackageName"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.PackageName))]
    public static T SetPackageName<T>(this T o, string v) where T : DotNetToolUninstallSettings => o.Modify(b => b.Set(() => o.PackageName, v));
    /// <inheritdoc cref="DotNetToolUninstallSettings.PackageName"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.PackageName))]
    public static T ResetPackageName<T>(this T o) where T : DotNetToolUninstallSettings => o.Modify(b => b.Remove(() => o.PackageName));
    #endregion
    #region Global
    /// <inheritdoc cref="DotNetToolUninstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.Global))]
    public static T SetGlobal<T>(this T o, bool? v) where T : DotNetToolUninstallSettings => o.Modify(b => b.Set(() => o.Global, v));
    /// <inheritdoc cref="DotNetToolUninstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.Global))]
    public static T ResetGlobal<T>(this T o) where T : DotNetToolUninstallSettings => o.Modify(b => b.Remove(() => o.Global));
    /// <inheritdoc cref="DotNetToolUninstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.Global))]
    public static T EnableGlobal<T>(this T o) where T : DotNetToolUninstallSettings => o.Modify(b => b.Set(() => o.Global, true));
    /// <inheritdoc cref="DotNetToolUninstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.Global))]
    public static T DisableGlobal<T>(this T o) where T : DotNetToolUninstallSettings => o.Modify(b => b.Set(() => o.Global, false));
    /// <inheritdoc cref="DotNetToolUninstallSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.Global))]
    public static T ToggleGlobal<T>(this T o) where T : DotNetToolUninstallSettings => o.Modify(b => b.Set(() => o.Global, !o.Global));
    #endregion
    #region ToolInstallationPath
    /// <inheritdoc cref="DotNetToolUninstallSettings.ToolInstallationPath"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.ToolInstallationPath))]
    public static T SetToolInstallationPath<T>(this T o, string v) where T : DotNetToolUninstallSettings => o.Modify(b => b.Set(() => o.ToolInstallationPath, v));
    /// <inheritdoc cref="DotNetToolUninstallSettings.ToolInstallationPath"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.ToolInstallationPath))]
    public static T ResetToolInstallationPath<T>(this T o) where T : DotNetToolUninstallSettings => o.Modify(b => b.Remove(() => o.ToolInstallationPath));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetToolUninstallSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetToolUninstallSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetToolUninstallSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetToolUninstallSettings), Property = nameof(DotNetToolUninstallSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetToolUninstallSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
}
#endregion
#region DotNetToolUpdateSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetToolUpdate(Nuke.Common.Tools.DotNet.DotNetToolUpdateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetToolUpdateSettingsExtensions
{
    #region PackageName
    /// <inheritdoc cref="DotNetToolUpdateSettings.PackageName"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.PackageName))]
    public static T SetPackageName<T>(this T o, string v) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.PackageName, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.PackageName"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.PackageName))]
    public static T ResetPackageName<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Remove(() => o.PackageName));
    #endregion
    #region Sources
    /// <inheritdoc cref="DotNetToolUpdateSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Sources))]
    public static T SetSources<T>(this T o, params string[] v) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Sources))]
    public static T SetSources<T>(this T o, IEnumerable<string> v) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Sources))]
    public static T AddSources<T>(this T o, params string[] v) where T : DotNetToolUpdateSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Sources))]
    public static T AddSources<T>(this T o, IEnumerable<string> v) where T : DotNetToolUpdateSettings => o.Modify(b => b.AddCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Sources))]
    public static T RemoveSources<T>(this T o, params string[] v) where T : DotNetToolUpdateSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Sources))]
    public static T RemoveSources<T>(this T o, IEnumerable<string> v) where T : DotNetToolUpdateSettings => o.Modify(b => b.RemoveCollection(() => o.Sources, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Sources"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Sources))]
    public static T ClearSources<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.ClearCollection(() => o.Sources));
    #endregion
    #region ConfigFile
    /// <inheritdoc cref="DotNetToolUpdateSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
    #region Framework
    /// <inheritdoc cref="DotNetToolUpdateSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Framework))]
    public static T SetFramework<T>(this T o, string v) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.Framework, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Framework"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Framework))]
    public static T ResetFramework<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Remove(() => o.Framework));
    #endregion
    #region Global
    /// <inheritdoc cref="DotNetToolUpdateSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Global))]
    public static T SetGlobal<T>(this T o, bool? v) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.Global, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Global))]
    public static T ResetGlobal<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Remove(() => o.Global));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Global))]
    public static T EnableGlobal<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.Global, true));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Global))]
    public static T DisableGlobal<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.Global, false));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Global"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Global))]
    public static T ToggleGlobal<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.Global, !o.Global));
    #endregion
    #region ToolInstallationPath
    /// <inheritdoc cref="DotNetToolUpdateSettings.ToolInstallationPath"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.ToolInstallationPath))]
    public static T SetToolInstallationPath<T>(this T o, string v) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.ToolInstallationPath, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.ToolInstallationPath"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.ToolInstallationPath))]
    public static T ResetToolInstallationPath<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Remove(() => o.ToolInstallationPath));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetToolUpdateSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
    #region Version
    /// <inheritdoc cref="DotNetToolUpdateSettings.Version"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Version))]
    public static T SetVersion<T>(this T o, string v) where T : DotNetToolUpdateSettings => o.Modify(b => b.Set(() => o.Version, v));
    /// <inheritdoc cref="DotNetToolUpdateSettings.Version"/>
    [Pure] [Builder(Type = typeof(DotNetToolUpdateSettings), Property = nameof(DotNetToolUpdateSettings.Version))]
    public static T ResetVersion<T>(this T o) where T : DotNetToolUpdateSettings => o.Modify(b => b.Remove(() => o.Version));
    #endregion
}
#endregion
#region DotNetWorkloadInstallSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadInstall(Nuke.Common.Tools.DotNet.DotNetWorkloadInstallSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetWorkloadInstallSettingsExtensions
{
    #region WorkloadId
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.WorkloadId))]
    public static T SetWorkloadId<T>(this T o, params string[] v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.WorkloadId))]
    public static T SetWorkloadId<T>(this T o, IEnumerable<string> v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.WorkloadId))]
    public static T AddWorkloadId<T>(this T o, params string[] v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.AddCollection(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.WorkloadId))]
    public static T AddWorkloadId<T>(this T o, IEnumerable<string> v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.AddCollection(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.WorkloadId))]
    public static T RemoveWorkloadId<T>(this T o, params string[] v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.RemoveCollection(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.WorkloadId))]
    public static T RemoveWorkloadId<T>(this T o, IEnumerable<string> v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.RemoveCollection(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.WorkloadId))]
    public static T ClearWorkloadId<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.ClearCollection(() => o.WorkloadId));
    #endregion
    #region ConfigFile
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region IncludePreviews
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IncludePreviews))]
    public static T SetIncludePreviews<T>(this T o, bool? v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.IncludePreviews, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IncludePreviews))]
    public static T ResetIncludePreviews<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.IncludePreviews));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IncludePreviews))]
    public static T EnableIncludePreviews<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.IncludePreviews, true));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IncludePreviews))]
    public static T DisableIncludePreviews<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.IncludePreviews, false));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.IncludePreviews))]
    public static T ToggleIncludePreviews<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.IncludePreviews, !o.IncludePreviews));
    #endregion
    #region Interactive
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.Interactive))]
    public static T SetInteractive<T>(this T o, bool? v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.Interactive, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.Interactive))]
    public static T ResetInteractive<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.Interactive));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.Interactive))]
    public static T EnableInteractive<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.Interactive, true));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.Interactive))]
    public static T DisableInteractive<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.Interactive, false));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.Interactive))]
    public static T ToggleInteractive<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.Interactive, !o.Interactive));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region SkipManifestUpdate
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipManifestUpdate))]
    public static T SetSkipManifestUpdate<T>(this T o, bool? v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.SkipManifestUpdate, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipManifestUpdate))]
    public static T ResetSkipManifestUpdate<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.SkipManifestUpdate));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipManifestUpdate))]
    public static T EnableSkipManifestUpdate<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.SkipManifestUpdate, true));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipManifestUpdate))]
    public static T DisableSkipManifestUpdate<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.SkipManifestUpdate, false));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipManifestUpdate))]
    public static T ToggleSkipManifestUpdate<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.SkipManifestUpdate, !o.SkipManifestUpdate));
    #endregion
    #region SkipSignCheck
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipSignCheck))]
    public static T SetSkipSignCheck<T>(this T o, bool? v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipSignCheck))]
    public static T ResetSkipSignCheck<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.SkipSignCheck));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipSignCheck))]
    public static T EnableSkipSignCheck<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, true));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipSignCheck))]
    public static T DisableSkipSignCheck<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, false));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.SkipSignCheck))]
    public static T ToggleSkipSignCheck<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, !o.SkipSignCheck));
    #endregion
    #region Source
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.Source))]
    public static T SetSource<T>(this T o, string v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.Source, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.Source))]
    public static T ResetSource<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.Source));
    #endregion
    #region TempDir
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.TempDir"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.TempDir))]
    public static T SetTempDir<T>(this T o, string v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.TempDir, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.TempDir"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.TempDir))]
    public static T ResetTempDir<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.TempDir));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetWorkloadInstallSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadInstallSettings), Property = nameof(DotNetWorkloadInstallSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetWorkloadInstallSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
}
#endregion
#region DotNetWorkloadUninstallSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadUninstall(Nuke.Common.Tools.DotNet.DotNetWorkloadUninstallSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetWorkloadUninstallSettingsExtensions
{
    #region WorkloadId
    /// <inheritdoc cref="DotNetWorkloadUninstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUninstallSettings), Property = nameof(DotNetWorkloadUninstallSettings.WorkloadId))]
    public static T SetWorkloadId<T>(this T o, params string[] v) where T : DotNetWorkloadUninstallSettings => o.Modify(b => b.Set(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadUninstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUninstallSettings), Property = nameof(DotNetWorkloadUninstallSettings.WorkloadId))]
    public static T SetWorkloadId<T>(this T o, IEnumerable<string> v) where T : DotNetWorkloadUninstallSettings => o.Modify(b => b.Set(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadUninstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUninstallSettings), Property = nameof(DotNetWorkloadUninstallSettings.WorkloadId))]
    public static T AddWorkloadId<T>(this T o, params string[] v) where T : DotNetWorkloadUninstallSettings => o.Modify(b => b.AddCollection(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadUninstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUninstallSettings), Property = nameof(DotNetWorkloadUninstallSettings.WorkloadId))]
    public static T AddWorkloadId<T>(this T o, IEnumerable<string> v) where T : DotNetWorkloadUninstallSettings => o.Modify(b => b.AddCollection(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadUninstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUninstallSettings), Property = nameof(DotNetWorkloadUninstallSettings.WorkloadId))]
    public static T RemoveWorkloadId<T>(this T o, params string[] v) where T : DotNetWorkloadUninstallSettings => o.Modify(b => b.RemoveCollection(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadUninstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUninstallSettings), Property = nameof(DotNetWorkloadUninstallSettings.WorkloadId))]
    public static T RemoveWorkloadId<T>(this T o, IEnumerable<string> v) where T : DotNetWorkloadUninstallSettings => o.Modify(b => b.RemoveCollection(() => o.WorkloadId, v));
    /// <inheritdoc cref="DotNetWorkloadUninstallSettings.WorkloadId"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUninstallSettings), Property = nameof(DotNetWorkloadUninstallSettings.WorkloadId))]
    public static T ClearWorkloadId<T>(this T o) where T : DotNetWorkloadUninstallSettings => o.Modify(b => b.ClearCollection(() => o.WorkloadId));
    #endregion
}
#endregion
#region DotNetWorkloadRestoreSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadRestore(Nuke.Common.Tools.DotNet.DotNetWorkloadRestoreSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetWorkloadRestoreSettingsExtensions
{
    #region Project
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Project))]
    public static T SetProject<T>(this T o, string v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.Project, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Project"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Project))]
    public static T ResetProject<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.Project));
    #endregion
    #region ConfigFile
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region IncludePreviews
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IncludePreviews))]
    public static T SetIncludePreviews<T>(this T o, bool? v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.IncludePreviews, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IncludePreviews))]
    public static T ResetIncludePreviews<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.IncludePreviews));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IncludePreviews))]
    public static T EnableIncludePreviews<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.IncludePreviews, true));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IncludePreviews))]
    public static T DisableIncludePreviews<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.IncludePreviews, false));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.IncludePreviews))]
    public static T ToggleIncludePreviews<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.IncludePreviews, !o.IncludePreviews));
    #endregion
    #region Interactive
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Interactive))]
    public static T SetInteractive<T>(this T o, bool? v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.Interactive, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Interactive))]
    public static T ResetInteractive<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.Interactive));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Interactive))]
    public static T EnableInteractive<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.Interactive, true));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Interactive))]
    public static T DisableInteractive<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.Interactive, false));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Interactive))]
    public static T ToggleInteractive<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.Interactive, !o.Interactive));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region SkipManifestUpdate
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipManifestUpdate))]
    public static T SetSkipManifestUpdate<T>(this T o, bool? v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.SkipManifestUpdate, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipManifestUpdate))]
    public static T ResetSkipManifestUpdate<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.SkipManifestUpdate));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipManifestUpdate))]
    public static T EnableSkipManifestUpdate<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.SkipManifestUpdate, true));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipManifestUpdate))]
    public static T DisableSkipManifestUpdate<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.SkipManifestUpdate, false));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipManifestUpdate"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipManifestUpdate))]
    public static T ToggleSkipManifestUpdate<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.SkipManifestUpdate, !o.SkipManifestUpdate));
    #endregion
    #region SkipSignCheck
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipSignCheck))]
    public static T SetSkipSignCheck<T>(this T o, bool? v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipSignCheck))]
    public static T ResetSkipSignCheck<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.SkipSignCheck));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipSignCheck))]
    public static T EnableSkipSignCheck<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, true));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipSignCheck))]
    public static T DisableSkipSignCheck<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, false));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.SkipSignCheck))]
    public static T ToggleSkipSignCheck<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, !o.SkipSignCheck));
    #endregion
    #region Source
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Source))]
    public static T SetSource<T>(this T o, string v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.Source, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Source))]
    public static T ResetSource<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.Source));
    #endregion
    #region TempDir
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.TempDir"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.TempDir))]
    public static T SetTempDir<T>(this T o, string v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.TempDir, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.TempDir"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.TempDir))]
    public static T ResetTempDir<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.TempDir));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetWorkloadRestoreSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRestoreSettings), Property = nameof(DotNetWorkloadRestoreSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetWorkloadRestoreSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
}
#endregion
#region DotNetWorkloadUpdateSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadUpdate(Nuke.Common.Tools.DotNet.DotNetWorkloadUpdateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetWorkloadUpdateSettingsExtensions
{
    #region AdvertisingManifestsOnly
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly))]
    public static T SetAdvertisingManifestsOnly<T>(this T o, bool? v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.AdvertisingManifestsOnly, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly))]
    public static T ResetAdvertisingManifestsOnly<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.AdvertisingManifestsOnly));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly))]
    public static T EnableAdvertisingManifestsOnly<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.AdvertisingManifestsOnly, true));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly))]
    public static T DisableAdvertisingManifestsOnly<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.AdvertisingManifestsOnly, false));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.AdvertisingManifestsOnly))]
    public static T ToggleAdvertisingManifestsOnly<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.AdvertisingManifestsOnly, !o.AdvertisingManifestsOnly));
    #endregion
    #region ConfigFile
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region FromPreviousSdk
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.FromPreviousSdk"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.FromPreviousSdk))]
    public static T SetFromPreviousSdk<T>(this T o, bool? v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.FromPreviousSdk, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.FromPreviousSdk"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.FromPreviousSdk))]
    public static T ResetFromPreviousSdk<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.FromPreviousSdk));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.FromPreviousSdk"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.FromPreviousSdk))]
    public static T EnableFromPreviousSdk<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.FromPreviousSdk, true));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.FromPreviousSdk"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.FromPreviousSdk))]
    public static T DisableFromPreviousSdk<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.FromPreviousSdk, false));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.FromPreviousSdk"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.FromPreviousSdk))]
    public static T ToggleFromPreviousSdk<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.FromPreviousSdk, !o.FromPreviousSdk));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region IncludePreviews
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IncludePreviews))]
    public static T SetIncludePreviews<T>(this T o, bool? v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.IncludePreviews, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IncludePreviews))]
    public static T ResetIncludePreviews<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.IncludePreviews));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IncludePreviews))]
    public static T EnableIncludePreviews<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.IncludePreviews, true));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IncludePreviews))]
    public static T DisableIncludePreviews<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.IncludePreviews, false));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.IncludePreviews))]
    public static T ToggleIncludePreviews<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.IncludePreviews, !o.IncludePreviews));
    #endregion
    #region Interactive
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.Interactive))]
    public static T SetInteractive<T>(this T o, bool? v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.Interactive, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.Interactive))]
    public static T ResetInteractive<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.Interactive));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.Interactive))]
    public static T EnableInteractive<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.Interactive, true));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.Interactive))]
    public static T DisableInteractive<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.Interactive, false));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.Interactive))]
    public static T ToggleInteractive<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.Interactive, !o.Interactive));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region SkipSignCheck
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.SkipSignCheck))]
    public static T SetSkipSignCheck<T>(this T o, bool? v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.SkipSignCheck))]
    public static T ResetSkipSignCheck<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.SkipSignCheck));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.SkipSignCheck))]
    public static T EnableSkipSignCheck<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, true));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.SkipSignCheck))]
    public static T DisableSkipSignCheck<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, false));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.SkipSignCheck))]
    public static T ToggleSkipSignCheck<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, !o.SkipSignCheck));
    #endregion
    #region Source
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.Source))]
    public static T SetSource<T>(this T o, string v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.Source, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.Source))]
    public static T ResetSource<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.Source));
    #endregion
    #region TempDir
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.TempDir"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.TempDir))]
    public static T SetTempDir<T>(this T o, string v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.TempDir, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.TempDir"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.TempDir))]
    public static T ResetTempDir<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.TempDir));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetWorkloadUpdateSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadUpdateSettings), Property = nameof(DotNetWorkloadUpdateSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetWorkloadUpdateSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
}
#endregion
#region DotNetWorkloadRepairSettingsExtensions
/// <inheritdoc cref="DotNetTasks.DotNetWorkloadRepair(Nuke.Common.Tools.DotNet.DotNetWorkloadRepairSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class DotNetWorkloadRepairSettingsExtensions
{
    #region ConfigFile
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.ConfigFile))]
    public static T SetConfigFile<T>(this T o, string v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.ConfigFile, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.ConfigFile"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.ConfigFile))]
    public static T ResetConfigFile<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.ConfigFile));
    #endregion
    #region DisableParallel
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.DisableParallel))]
    public static T SetDisableParallel<T>(this T o, bool? v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.DisableParallel, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.DisableParallel))]
    public static T ResetDisableParallel<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.DisableParallel));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.DisableParallel))]
    public static T EnableDisableParallel<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.DisableParallel, true));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.DisableParallel))]
    public static T DisableDisableParallel<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.DisableParallel, false));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.DisableParallel"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.DisableParallel))]
    public static T ToggleDisableParallel<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.DisableParallel, !o.DisableParallel));
    #endregion
    #region IgnoreFailedSources
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IgnoreFailedSources))]
    public static T SetIgnoreFailedSources<T>(this T o, bool? v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IgnoreFailedSources))]
    public static T ResetIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.IgnoreFailedSources));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IgnoreFailedSources))]
    public static T EnableIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, true));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IgnoreFailedSources))]
    public static T DisableIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, false));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IgnoreFailedSources"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IgnoreFailedSources))]
    public static T ToggleIgnoreFailedSources<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.IgnoreFailedSources, !o.IgnoreFailedSources));
    #endregion
    #region IncludePreviews
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IncludePreviews))]
    public static T SetIncludePreviews<T>(this T o, bool? v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.IncludePreviews, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IncludePreviews))]
    public static T ResetIncludePreviews<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.IncludePreviews));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IncludePreviews))]
    public static T EnableIncludePreviews<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.IncludePreviews, true));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IncludePreviews))]
    public static T DisableIncludePreviews<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.IncludePreviews, false));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.IncludePreviews"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.IncludePreviews))]
    public static T ToggleIncludePreviews<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.IncludePreviews, !o.IncludePreviews));
    #endregion
    #region Interactive
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.Interactive))]
    public static T SetInteractive<T>(this T o, bool? v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.Interactive, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.Interactive))]
    public static T ResetInteractive<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.Interactive));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.Interactive))]
    public static T EnableInteractive<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.Interactive, true));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.Interactive))]
    public static T DisableInteractive<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.Interactive, false));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.Interactive))]
    public static T ToggleInteractive<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.Interactive, !o.Interactive));
    #endregion
    #region NoCache
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.NoCache))]
    public static T SetNoCache<T>(this T o, bool? v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.NoCache, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.NoCache))]
    public static T ResetNoCache<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.NoCache));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.NoCache))]
    public static T EnableNoCache<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.NoCache, true));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.NoCache))]
    public static T DisableNoCache<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.NoCache, false));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.NoCache"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.NoCache))]
    public static T ToggleNoCache<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.NoCache, !o.NoCache));
    #endregion
    #region SkipSignCheck
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.SkipSignCheck))]
    public static T SetSkipSignCheck<T>(this T o, bool? v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.SkipSignCheck))]
    public static T ResetSkipSignCheck<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.SkipSignCheck));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.SkipSignCheck))]
    public static T EnableSkipSignCheck<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, true));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.SkipSignCheck))]
    public static T DisableSkipSignCheck<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, false));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.SkipSignCheck"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.SkipSignCheck))]
    public static T ToggleSkipSignCheck<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.SkipSignCheck, !o.SkipSignCheck));
    #endregion
    #region Source
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.Source))]
    public static T SetSource<T>(this T o, string v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.Source, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.Source"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.Source))]
    public static T ResetSource<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.Source));
    #endregion
    #region TempDir
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.TempDir"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.TempDir))]
    public static T SetTempDir<T>(this T o, string v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.TempDir, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.TempDir"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.TempDir))]
    public static T ResetTempDir<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.TempDir));
    #endregion
    #region Verbosity
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.Verbosity))]
    public static T SetVerbosity<T>(this T o, DotNetVerbosity v) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Set(() => o.Verbosity, v));
    /// <inheritdoc cref="DotNetWorkloadRepairSettings.Verbosity"/>
    [Pure] [Builder(Type = typeof(DotNetWorkloadRepairSettings), Property = nameof(DotNetWorkloadRepairSettings.Verbosity))]
    public static T ResetVerbosity<T>(this T o) where T : DotNetWorkloadRepairSettings => o.Modify(b => b.Remove(() => o.Verbosity));
    #endregion
}
#endregion
#region DotNetVerbosity
/// <summary>Used within <see cref="DotNetTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<DotNetVerbosity>))]
public partial class DotNetVerbosity : Enumeration
{
    public static DotNetVerbosity quiet = (DotNetVerbosity) "quiet";
    public static DotNetVerbosity minimal = (DotNetVerbosity) "minimal";
    public static DotNetVerbosity normal = (DotNetVerbosity) "normal";
    public static DotNetVerbosity detailed = (DotNetVerbosity) "detailed";
    public static DotNetVerbosity diagnostic = (DotNetVerbosity) "diagnostic";
    public static implicit operator DotNetVerbosity(string value)
    {
        return new DotNetVerbosity { Value = value };
    }
}
#endregion
#region DotNetSymbolPackageFormat
/// <summary>Used within <see cref="DotNetTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<DotNetSymbolPackageFormat>))]
public partial class DotNetSymbolPackageFormat : Enumeration
{
    public static DotNetSymbolPackageFormat symbols_nupkg = (DotNetSymbolPackageFormat) "symbols.nupkg";
    public static DotNetSymbolPackageFormat snupkg = (DotNetSymbolPackageFormat) "snupkg";
    public static implicit operator DotNetSymbolPackageFormat(string value)
    {
        return new DotNetSymbolPackageFormat { Value = value };
    }
}
#endregion
#region DotNetNuGetAuthentication
/// <summary>Used within <see cref="DotNetTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<DotNetNuGetAuthentication>))]
public partial class DotNetNuGetAuthentication : Enumeration
{
    public static DotNetNuGetAuthentication basic = (DotNetNuGetAuthentication) "basic";
    public static DotNetNuGetAuthentication negotiate = (DotNetNuGetAuthentication) "negotiate";
    public static DotNetNuGetAuthentication kerberos = (DotNetNuGetAuthentication) "kerberos";
    public static DotNetNuGetAuthentication ntlm = (DotNetNuGetAuthentication) "ntlm";
    public static DotNetNuGetAuthentication digest = (DotNetNuGetAuthentication) "digest";
    public static implicit operator DotNetNuGetAuthentication(string value)
    {
        return new DotNetNuGetAuthentication { Value = value };
    }
}
#endregion
#region DotNetFormatSeverity
/// <summary>Used within <see cref="DotNetTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<DotNetFormatSeverity>))]
public partial class DotNetFormatSeverity : Enumeration
{
    public static DotNetFormatSeverity info = (DotNetFormatSeverity) "info";
    public static DotNetFormatSeverity warn = (DotNetFormatSeverity) "warn";
    public static DotNetFormatSeverity error = (DotNetFormatSeverity) "error";
    public static implicit operator DotNetFormatSeverity(string value)
    {
        return new DotNetFormatSeverity { Value = value };
    }
}
#endregion

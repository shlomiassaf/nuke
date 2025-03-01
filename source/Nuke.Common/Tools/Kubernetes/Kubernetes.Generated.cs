// Generated from https://github.com/nuke-build/nuke/blob/master/source/Nuke.Common/Tools/Kubernetes/Kubernetes.json

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

namespace Nuke.Common.Tools.Kubernetes;

/// <summary><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[PathTool(Executable = PathExecutable)]
public partial class KubernetesTasks : ToolTasks, IRequirePathTool
{
    public static string KubernetesPath { get => new KubernetesTasks().GetToolPathInternal(); set => new KubernetesTasks().SetToolPath(value); }
    public const string PathExecutable = "kubectl";
    /// <summary><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    public static IReadOnlyCollection<Output> Kubernetes(ArgumentStringHandler arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Action<OutputType, string> logger = null, Func<IProcess, object> exitHandler = null) => new KubernetesTasks().Run(arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, logger, exitHandler);
    /// <summary><p>Print the supported API resources on the server.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--api-group</c> via <see cref="KubernetesApiResourcesSettings.ApiGroup"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--cached</c> via <see cref="KubernetesApiResourcesSettings.Cached"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--namespaced</c> via <see cref="KubernetesApiResourcesSettings.Namespaced"/></li><li><c>--no-headers</c> via <see cref="KubernetesApiResourcesSettings.NoHeaders"/></li><li><c>--output</c> via <see cref="KubernetesApiResourcesSettings.Output"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--verbs</c> via <see cref="KubernetesApiResourcesSettings.Verbs"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesApiResources(KubernetesApiResourcesSettings options = null) => new KubernetesTasks().Run<KubernetesApiResourcesSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesApiResources(Nuke.Common.Tools.Kubernetes.KubernetesApiResourcesSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesApiResources(Configure<KubernetesApiResourcesSettings> configurator) => new KubernetesTasks().Run<KubernetesApiResourcesSettings>(configurator.Invoke(new KubernetesApiResourcesSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesApiResources(Nuke.Common.Tools.Kubernetes.KubernetesApiResourcesSettings)"/>
    public static IEnumerable<(KubernetesApiResourcesSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesApiResources(CombinatorialConfigure<KubernetesApiResourcesSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesApiResources, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Drain node in preparation for maintenance. The given node will be marked unschedulable to prevent new pods from arriving. 'drain' evicts the pods if the APIServer supports eviction (http://kubernetes.io/docs/admin/disruptions/). Otherwise, it will use normal DELETE to delete the pods. The 'drain' evicts or deletes all pods except mirror pods (which cannot be deleted through the API server).  If there are DaemonSet-managed pods, drain will not proceed without --ignore-daemonsets, and regardless it will not delete any DaemonSet-managed pods, because those pods would be immediately replaced by the DaemonSet controller, which ignores unschedulable markings.  If there are any pods that are neither mirror pods nor managed by ReplicationController, ReplicaSet, DaemonSet, StatefulSet or Job, then drain will not delete any pods unless you use --force.  --force will also allow deletion to proceed if the managing resource of one or more pods is missing. 'drain' waits for graceful termination. You should not operate on the machine until the command completes. When you are ready to put the node back into service, use kubectl uncordon, which will make the node schedulable again. ! http://kubernetes.io/images/docs/kubectl_drain.svg.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--delete-local-data</c> via <see cref="KubernetesDrainSettings.DeleteLocalData"/></li><li><c>--dry-run</c> via <see cref="KubernetesDrainSettings.DryRun"/></li><li><c>--force</c> via <see cref="KubernetesDrainSettings.Force"/></li><li><c>--grace-period</c> via <see cref="KubernetesDrainSettings.GracePeriod"/></li><li><c>--ignore-daemonsets</c> via <see cref="KubernetesDrainSettings.IgnoreDaemonsets"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--pod-selector</c> via <see cref="KubernetesDrainSettings.PodSelector"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesDrainSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--timeout</c> via <see cref="KubernetesDrainSettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesDrain(KubernetesDrainSettings options = null) => new KubernetesTasks().Run<KubernetesDrainSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesDrain(Nuke.Common.Tools.Kubernetes.KubernetesDrainSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesDrain(Configure<KubernetesDrainSettings> configurator) => new KubernetesTasks().Run<KubernetesDrainSettings>(configurator.Invoke(new KubernetesDrainSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesDrain(Nuke.Common.Tools.Kubernetes.KubernetesDrainSettings)"/>
    public static IEnumerable<(KubernetesDrainSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesDrain(CombinatorialConfigure<KubernetesDrainSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesDrain, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Create and run a particular image, possibly replicated. Creates a deployment or job to manage the created container(s).</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;name&gt;</c> via <see cref="KubernetesRunSettings.Name"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesRunSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--attach</c> via <see cref="KubernetesRunSettings.Attach"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--cascade</c> via <see cref="KubernetesRunSettings.Cascade"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--command</c> via <see cref="KubernetesRunSettings.Command"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesRunSettings.DryRun"/></li><li><c>--env</c> via <see cref="KubernetesRunSettings.Env"/></li><li><c>--expose</c> via <see cref="KubernetesRunSettings.Expose"/></li><li><c>--filename</c> via <see cref="KubernetesRunSettings.Filename"/></li><li><c>--force</c> via <see cref="KubernetesRunSettings.Force"/></li><li><c>--generator</c> via <see cref="KubernetesRunSettings.Generator"/></li><li><c>--grace-period</c> via <see cref="KubernetesRunSettings.GracePeriod"/></li><li><c>--hostport</c> via <see cref="KubernetesRunSettings.Hostport"/></li><li><c>--image</c> via <see cref="KubernetesRunSettings.Image"/></li><li><c>--image-pull-policy</c> via <see cref="KubernetesRunSettings.ImagePullPolicy"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--labels</c> via <see cref="KubernetesRunSettings.Labels"/></li><li><c>--leave-stdin-open</c> via <see cref="KubernetesRunSettings.LeaveStdinOpen"/></li><li><c>--limits</c> via <see cref="KubernetesRunSettings.Limits"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesRunSettings.Output"/></li><li><c>--overrides</c> via <see cref="KubernetesRunSettings.Overrides"/></li><li><c>--pod-running-timeout</c> via <see cref="KubernetesRunSettings.PodRunningTimeout"/></li><li><c>--port</c> via <see cref="KubernetesRunSettings.Port"/></li><li><c>--quiet</c> via <see cref="KubernetesRunSettings.Quiet"/></li><li><c>--record</c> via <see cref="KubernetesRunSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesRunSettings.Recursive"/></li><li><c>--replicas</c> via <see cref="KubernetesRunSettings.Replicas"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--requests</c> via <see cref="KubernetesRunSettings.Requests"/></li><li><c>--restart</c> via <see cref="KubernetesRunSettings.Restart"/></li><li><c>--rm</c> via <see cref="KubernetesRunSettings.Rm"/></li><li><c>--save-config</c> via <see cref="KubernetesRunSettings.SaveConfig"/></li><li><c>--schedule</c> via <see cref="KubernetesRunSettings.Schedule"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--service-generator</c> via <see cref="KubernetesRunSettings.ServiceGenerator"/></li><li><c>--service-overrides</c> via <see cref="KubernetesRunSettings.ServiceOverrides"/></li><li><c>--serviceaccount</c> via <see cref="KubernetesRunSettings.Serviceaccount"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--stdin</c> via <see cref="KubernetesRunSettings.Stdin"/></li><li><c>--template</c> via <see cref="KubernetesRunSettings.Template"/></li><li><c>--timeout</c> via <see cref="KubernetesRunSettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--tty</c> via <see cref="KubernetesRunSettings.Tty"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--wait</c> via <see cref="KubernetesRunSettings.Wait"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesRun(KubernetesRunSettings options = null) => new KubernetesTasks().Run<KubernetesRunSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesRun(Nuke.Common.Tools.Kubernetes.KubernetesRunSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesRun(Configure<KubernetesRunSettings> configurator) => new KubernetesTasks().Run<KubernetesRunSettings>(configurator.Invoke(new KubernetesRunSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesRun(Nuke.Common.Tools.Kubernetes.KubernetesRunSettings)"/>
    public static IEnumerable<(KubernetesRunSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesRun(CombinatorialConfigure<KubernetesRunSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesRun, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Display one or many resources Prints a table of the most important information about the specified resources. You can filter the list using a label selector and the --selector flag. If the desired resource type is namespaced you will only see results in your current namespace unless you pass --all-namespaces. Uninitialized objects are not shown unless --include-uninitialized is passed. By specifying the output as 'template' and providing a Go template as the value of the --template flag, you can filter the attributes of the fetched resources.Use "kubectl api-resources" for a complete list of supported resources.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesGetSettings.TypeName"/></li><li><c>--all-namespaces</c> via <see cref="KubernetesGetSettings.AllNamespaces"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesGetSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--chunk-size</c> via <see cref="KubernetesGetSettings.ChunkSize"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--export</c> via <see cref="KubernetesGetSettings.Export"/></li><li><c>--field-selector</c> via <see cref="KubernetesGetSettings.FieldSelector"/></li><li><c>--filename</c> via <see cref="KubernetesGetSettings.Filename"/></li><li><c>--ignore-not-found</c> via <see cref="KubernetesGetSettings.IgnoreNotFound"/></li><li><c>--include-uninitialized</c> via <see cref="KubernetesGetSettings.IncludeUninitialized"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--label-columns</c> via <see cref="KubernetesGetSettings.LabelColumns"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--no-headers</c> via <see cref="KubernetesGetSettings.NoHeaders"/></li><li><c>--output</c> via <see cref="KubernetesGetSettings.Output"/></li><li><c>--raw</c> via <see cref="KubernetesGetSettings.Raw"/></li><li><c>--recursive</c> via <see cref="KubernetesGetSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesGetSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--server-print</c> via <see cref="KubernetesGetSettings.ServerPrint"/></li><li><c>--show-all</c> via <see cref="KubernetesGetSettings.ShowAll"/></li><li><c>--show-kind</c> via <see cref="KubernetesGetSettings.ShowKind"/></li><li><c>--show-labels</c> via <see cref="KubernetesGetSettings.ShowLabels"/></li><li><c>--sort-by</c> via <see cref="KubernetesGetSettings.SortBy"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesGetSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--use-openapi-print-columns</c> via <see cref="KubernetesGetSettings.UseOpenapiPrintColumns"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--watch</c> via <see cref="KubernetesGetSettings.Watch"/></li><li><c>--watch-only</c> via <see cref="KubernetesGetSettings.WatchOnly"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesGet(KubernetesGetSettings options = null) => new KubernetesTasks().Run<KubernetesGetSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesGet(Nuke.Common.Tools.Kubernetes.KubernetesGetSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesGet(Configure<KubernetesGetSettings> configurator) => new KubernetesTasks().Run<KubernetesGetSettings>(configurator.Invoke(new KubernetesGetSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesGet(Nuke.Common.Tools.Kubernetes.KubernetesGetSettings)"/>
    public static IEnumerable<(KubernetesGetSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesGet(CombinatorialConfigure<KubernetesGetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesGet, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Print the client and server version information for the current context.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client</c> via <see cref="KubernetesVersionSettings.Client"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesVersionSettings.Output"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--short</c> via <see cref="KubernetesVersionSettings.Short"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesVersion(KubernetesVersionSettings options = null) => new KubernetesTasks().Run<KubernetesVersionSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesVersion(Nuke.Common.Tools.Kubernetes.KubernetesVersionSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesVersion(Configure<KubernetesVersionSettings> configurator) => new KubernetesTasks().Run<KubernetesVersionSettings>(configurator.Invoke(new KubernetesVersionSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesVersion(Nuke.Common.Tools.Kubernetes.KubernetesVersionSettings)"/>
    public static IEnumerable<(KubernetesVersionSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesVersion(CombinatorialConfigure<KubernetesVersionSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesVersion, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Display Resource (CPU/Memory/Storage) usage. The top command allows you to see the resource consumption for nodes or pods. This command requires Heapster to be correctly configured and working on the server.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesTop(KubernetesTopSettings options = null) => new KubernetesTasks().Run<KubernetesTopSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesTop(Nuke.Common.Tools.Kubernetes.KubernetesTopSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesTop(Configure<KubernetesTopSettings> configurator) => new KubernetesTasks().Run<KubernetesTopSettings>(configurator.Invoke(new KubernetesTopSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesTop(Nuke.Common.Tools.Kubernetes.KubernetesTopSettings)"/>
    public static IEnumerable<(KubernetesTopSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesTop(CombinatorialConfigure<KubernetesTopSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesTop, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Modify kubeconfig files using subcommands like "kubectl config set current-context my-context" The loading order follows these rules:   1. If the --kubeconfig flag is set, then only that file is loaded.  The flag may only be set once and no merging takes place.    2. If $KUBECONFIG environment variable is set, then it is used a list of paths (normal path delimitting rules for your system).  These paths are merged.  When a value is modified, it is modified in the file that defines the stanza.  When a value is created, it is created in the first file that exists.  If no files in the chain exist, then it creates the last file in the list.    3. Otherwise, ${HOME}/.kube/config is used and no merging takes place.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesConfig(KubernetesConfigSettings options = null) => new KubernetesTasks().Run<KubernetesConfigSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesConfig(Nuke.Common.Tools.Kubernetes.KubernetesConfigSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesConfig(Configure<KubernetesConfigSettings> configurator) => new KubernetesTasks().Run<KubernetesConfigSettings>(configurator.Invoke(new KubernetesConfigSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesConfig(Nuke.Common.Tools.Kubernetes.KubernetesConfigSettings)"/>
    public static IEnumerable<(KubernetesConfigSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesConfig(CombinatorialConfigure<KubernetesConfigSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesConfig, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Execute a command in a container.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;arguments&gt;</c> via <see cref="KubernetesExecSettings.Arguments"/></li><li><c>&lt;podName&gt;</c> via <see cref="KubernetesExecSettings.PodName"/></li><li><c>--</c> via <see cref="KubernetesExecSettings.Command"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--container</c> via <see cref="KubernetesExecSettings.Container"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--pod</c> via <see cref="KubernetesExecSettings.Pod"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--stdin</c> via <see cref="KubernetesExecSettings.Stdin"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--tty</c> via <see cref="KubernetesExecSettings.Tty"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesExec(KubernetesExecSettings options = null) => new KubernetesTasks().Run<KubernetesExecSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesExec(Nuke.Common.Tools.Kubernetes.KubernetesExecSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesExec(Configure<KubernetesExecSettings> configurator) => new KubernetesTasks().Run<KubernetesExecSettings>(configurator.Invoke(new KubernetesExecSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesExec(Nuke.Common.Tools.Kubernetes.KubernetesExecSettings)"/>
    public static IEnumerable<(KubernetesExecSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesExec(CombinatorialConfigure<KubernetesExecSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesExec, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Perform a rolling update of the given ReplicationController. Replaces the specified replication controller with a new replication controller by updating one pod at a time to use the new PodTemplate. The new-controller.json must specify the same namespace as the existing replication controller and overwrite at least one (common) label in its replicaSelector. ! http://kubernetes.io/images/docs/kubectl_rollingupdate.svg.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesRollingUpdateSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--container</c> via <see cref="KubernetesRollingUpdateSettings.Container"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--deployment-label-key</c> via <see cref="KubernetesRollingUpdateSettings.DeploymentLabelKey"/></li><li><c>--dry-run</c> via <see cref="KubernetesRollingUpdateSettings.DryRun"/></li><li><c>--filename</c> via <see cref="KubernetesRollingUpdateSettings.Filename"/></li><li><c>--image</c> via <see cref="KubernetesRollingUpdateSettings.Image"/></li><li><c>--image-pull-policy</c> via <see cref="KubernetesRollingUpdateSettings.ImagePullPolicy"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesRollingUpdateSettings.Output"/></li><li><c>--poll-interval</c> via <see cref="KubernetesRollingUpdateSettings.PollInterval"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--rollback</c> via <see cref="KubernetesRollingUpdateSettings.Rollback"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesRollingUpdateSettings.Template"/></li><li><c>--timeout</c> via <see cref="KubernetesRollingUpdateSettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--update-period</c> via <see cref="KubernetesRollingUpdateSettings.UpdatePeriod"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--validate</c> via <see cref="KubernetesRollingUpdateSettings.Validate"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesRollingUpdate(KubernetesRollingUpdateSettings options = null) => new KubernetesTasks().Run<KubernetesRollingUpdateSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesRollingUpdate(Nuke.Common.Tools.Kubernetes.KubernetesRollingUpdateSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesRollingUpdate(Configure<KubernetesRollingUpdateSettings> configurator) => new KubernetesTasks().Run<KubernetesRollingUpdateSettings>(configurator.Invoke(new KubernetesRollingUpdateSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesRollingUpdate(Nuke.Common.Tools.Kubernetes.KubernetesRollingUpdateSettings)"/>
    public static IEnumerable<(KubernetesRollingUpdateSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesRollingUpdate(CombinatorialConfigure<KubernetesRollingUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesRollingUpdate, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Update the labels on a resource.   * A label key and value must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  63 characters each.    * Optionally, the key can begin with a DNS subdomain prefix and a single '/', like example.com/my-app    * If --overwrite is true, then existing labels can be overwritten, otherwise attempting to overwrite a label will result in an error.    * If --resource-version is specified, then updates will use this resource version, otherwise the existing resource-version will be used.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;labels&gt;</c> via <see cref="KubernetesLabelSettings.Labels"/></li><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesLabelSettings.TypeName"/></li><li><c>--all</c> via <see cref="KubernetesLabelSettings.All"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesLabelSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesLabelSettings.DryRun"/></li><li><c>--field-selector</c> via <see cref="KubernetesLabelSettings.FieldSelector"/></li><li><c>--filename</c> via <see cref="KubernetesLabelSettings.Filename"/></li><li><c>--include-uninitialized</c> via <see cref="KubernetesLabelSettings.IncludeUninitialized"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--list</c> via <see cref="KubernetesLabelSettings.List"/></li><li><c>--local</c> via <see cref="KubernetesLabelSettings.Local"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesLabelSettings.Output"/></li><li><c>--overwrite</c> via <see cref="KubernetesLabelSettings.Overwrite"/></li><li><c>--record</c> via <see cref="KubernetesLabelSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesLabelSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--resource-version</c> via <see cref="KubernetesLabelSettings.ResourceVersion"/></li><li><c>--selector</c> via <see cref="KubernetesLabelSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesLabelSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesLabel(KubernetesLabelSettings options = null) => new KubernetesTasks().Run<KubernetesLabelSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesLabel(Nuke.Common.Tools.Kubernetes.KubernetesLabelSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesLabel(Configure<KubernetesLabelSettings> configurator) => new KubernetesTasks().Run<KubernetesLabelSettings>(configurator.Invoke(new KubernetesLabelSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesLabel(Nuke.Common.Tools.Kubernetes.KubernetesLabelSettings)"/>
    public static IEnumerable<(KubernetesLabelSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesLabel(CombinatorialConfigure<KubernetesLabelSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesLabel, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Update the annotations on one or more resources All Kubernetes objects support the ability to store additional data with the object as annotations. Annotations are key/value pairs that can be larger than labels and include arbitrary string values such as structured JSON. Tools and system extensions may use annotations to store their own data. Attempting to set an annotation that already exists will fail unless --overwrite is set. If --resource-version is specified and does not match the current resource version on the server the command will fail.Use "kubectl api-resources" for a complete list of supported resources.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;annotations&gt;</c> via <see cref="KubernetesAnnotateSettings.Annotations"/></li><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesAnnotateSettings.TypeName"/></li><li><c>--all</c> via <see cref="KubernetesAnnotateSettings.All"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesAnnotateSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesAnnotateSettings.DryRun"/></li><li><c>--field-selector</c> via <see cref="KubernetesAnnotateSettings.FieldSelector"/></li><li><c>--filename</c> via <see cref="KubernetesAnnotateSettings.Filename"/></li><li><c>--include-uninitialized</c> via <see cref="KubernetesAnnotateSettings.IncludeUninitialized"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--local</c> via <see cref="KubernetesAnnotateSettings.Local"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesAnnotateSettings.Output"/></li><li><c>--overwrite</c> via <see cref="KubernetesAnnotateSettings.Overwrite"/></li><li><c>--record</c> via <see cref="KubernetesAnnotateSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesAnnotateSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--resource-version</c> via <see cref="KubernetesAnnotateSettings.ResourceVersion"/></li><li><c>--selector</c> via <see cref="KubernetesAnnotateSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesAnnotateSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesAnnotate(KubernetesAnnotateSettings options = null) => new KubernetesTasks().Run<KubernetesAnnotateSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesAnnotate(Nuke.Common.Tools.Kubernetes.KubernetesAnnotateSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesAnnotate(Configure<KubernetesAnnotateSettings> configurator) => new KubernetesTasks().Run<KubernetesAnnotateSettings>(configurator.Invoke(new KubernetesAnnotateSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesAnnotate(Nuke.Common.Tools.Kubernetes.KubernetesAnnotateSettings)"/>
    public static IEnumerable<(KubernetesAnnotateSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesAnnotate(CombinatorialConfigure<KubernetesAnnotateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesAnnotate, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Delete resources by filenames, stdin, resources and names, or by resources and label selector. JSON and YAML formats are accepted. Only one type of the arguments may be specified: filenames, resources and names, or resources and label selector. Some resources, such as pods, support graceful deletion. These resources define a default period before they are forcibly terminated (the grace period) but you may override that value with the --grace-period flag, or pass --now to set a grace-period of 1. Because these resources often represent entities in the cluster, deletion may not be acknowledged immediately. If the node hosting a pod is down or cannot reach the API server, termination may take significantly longer than the grace period. To force delete a resource, you must pass a grace period of 0 and specify the --force flag. IMPORTANT: Force deleting pods does not wait for confirmation that the pod's processes have been terminated, which can leave those processes running until the node detects the deletion and completes graceful deletion. If your processes use shared storage or talk to a remote API and depend on the name of the pod to identify themselves, force deleting those pods may result in multiple processes running on different machines using the same identification which may lead to data corruption or inconsistency. Only force delete pods when you are sure the pod is terminated, or if your application can tolerate multiple copies of the same pod running at once. Also, if you force delete pods the scheduler may place new pods on those nodes before the node has released those resources and causing those pods to be evicted immediately. Note that the delete command does NOT do resource version checks, so if someone submits an update to a resource right when you submit a delete, their update will be lost along with the rest of the resource.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesDeleteSettings.TypeName"/></li><li><c>--all</c> via <see cref="KubernetesDeleteSettings.All"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--cascade</c> via <see cref="KubernetesDeleteSettings.Cascade"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--field-selector</c> via <see cref="KubernetesDeleteSettings.FieldSelector"/></li><li><c>--filename</c> via <see cref="KubernetesDeleteSettings.Filename"/></li><li><c>--force</c> via <see cref="KubernetesDeleteSettings.Force"/></li><li><c>--grace-period</c> via <see cref="KubernetesDeleteSettings.GracePeriod"/></li><li><c>--ignore-not-found</c> via <see cref="KubernetesDeleteSettings.IgnoreNotFound"/></li><li><c>--include-uninitialized</c> via <see cref="KubernetesDeleteSettings.IncludeUninitialized"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--now</c> via <see cref="KubernetesDeleteSettings.Now"/></li><li><c>--output</c> via <see cref="KubernetesDeleteSettings.Output"/></li><li><c>--recursive</c> via <see cref="KubernetesDeleteSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesDeleteSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--timeout</c> via <see cref="KubernetesDeleteSettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--wait</c> via <see cref="KubernetesDeleteSettings.Wait"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesDelete(KubernetesDeleteSettings options = null) => new KubernetesTasks().Run<KubernetesDeleteSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesDelete(Nuke.Common.Tools.Kubernetes.KubernetesDeleteSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesDelete(Configure<KubernetesDeleteSettings> configurator) => new KubernetesTasks().Run<KubernetesDeleteSettings>(configurator.Invoke(new KubernetesDeleteSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesDelete(Nuke.Common.Tools.Kubernetes.KubernetesDeleteSettings)"/>
    public static IEnumerable<(KubernetesDeleteSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesDelete(CombinatorialConfigure<KubernetesDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesDelete, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Expose a resource as a new Kubernetes service. Looks up a deployment, service, replica set, replication controller or pod by name and uses the selector for that resource as the selector for a new service on the specified port. A deployment or replica set will be exposed as a service only if its selector is convertible to a selector that service supports, i.e. when the selector contains only the matchLabels component. Note that if no port is specified via --port and the exposed resource has multiple ports, all will be re-used by the new service. Also if no labels are specified, the new service will re-use the labels from the resource it exposes. Possible resources include (case insensitive): pod (po), service (svc), replicationcontroller (rc), deployment (deploy), replicaset (rs).</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesExposeSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--cluster-ip</c> via <see cref="KubernetesExposeSettings.ClusterIp"/></li><li><c>--container-port</c> via <see cref="KubernetesExposeSettings.ContainerPort"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesExposeSettings.DryRun"/></li><li><c>--external-ip</c> via <see cref="KubernetesExposeSettings.ExternalIp"/></li><li><c>--filename</c> via <see cref="KubernetesExposeSettings.Filename"/></li><li><c>--generator</c> via <see cref="KubernetesExposeSettings.Generator"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--labels</c> via <see cref="KubernetesExposeSettings.Labels"/></li><li><c>--load-balancer-ip</c> via <see cref="KubernetesExposeSettings.LoadBalancerIp"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--name</c> via <see cref="KubernetesExposeSettings.Name"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesExposeSettings.Output"/></li><li><c>--overrides</c> via <see cref="KubernetesExposeSettings.Overrides"/></li><li><c>--port</c> via <see cref="KubernetesExposeSettings.Port"/></li><li><c>--protocol</c> via <see cref="KubernetesExposeSettings.Protocol"/></li><li><c>--record</c> via <see cref="KubernetesExposeSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesExposeSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--save-config</c> via <see cref="KubernetesExposeSettings.SaveConfig"/></li><li><c>--selector</c> via <see cref="KubernetesExposeSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--session-affinity</c> via <see cref="KubernetesExposeSettings.SessionAffinity"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--target-port</c> via <see cref="KubernetesExposeSettings.TargetPort"/></li><li><c>--template</c> via <see cref="KubernetesExposeSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--type</c> via <see cref="KubernetesExposeSettings.Type"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesExpose(KubernetesExposeSettings options = null) => new KubernetesTasks().Run<KubernetesExposeSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesExpose(Nuke.Common.Tools.Kubernetes.KubernetesExposeSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesExpose(Configure<KubernetesExposeSettings> configurator) => new KubernetesTasks().Run<KubernetesExposeSettings>(configurator.Invoke(new KubernetesExposeSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesExpose(Nuke.Common.Tools.Kubernetes.KubernetesExposeSettings)"/>
    public static IEnumerable<(KubernetesExposeSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesExpose(CombinatorialConfigure<KubernetesExposeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesExpose, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Print the list of flags inherited by all commands.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesOptions(KubernetesOptionsSettings options = null) => new KubernetesTasks().Run<KubernetesOptionsSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesOptions(Nuke.Common.Tools.Kubernetes.KubernetesOptionsSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesOptions(Configure<KubernetesOptionsSettings> configurator) => new KubernetesTasks().Run<KubernetesOptionsSettings>(configurator.Invoke(new KubernetesOptionsSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesOptions(Nuke.Common.Tools.Kubernetes.KubernetesOptionsSettings)"/>
    public static IEnumerable<(KubernetesOptionsSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesOptions(CombinatorialConfigure<KubernetesOptionsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesOptions, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Attach to a process that is already running inside an existing container.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;pod&gt;</c> via <see cref="KubernetesAttachSettings.Pod"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--container</c> via <see cref="KubernetesAttachSettings.Container"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--pod-running-timeout</c> via <see cref="KubernetesAttachSettings.PodRunningTimeout"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--stdin</c> via <see cref="KubernetesAttachSettings.Stdin"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--tty</c> via <see cref="KubernetesAttachSettings.Tty"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesAttach(KubernetesAttachSettings options = null) => new KubernetesTasks().Run<KubernetesAttachSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesAttach(Nuke.Common.Tools.Kubernetes.KubernetesAttachSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesAttach(Configure<KubernetesAttachSettings> configurator) => new KubernetesTasks().Run<KubernetesAttachSettings>(configurator.Invoke(new KubernetesAttachSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesAttach(Nuke.Common.Tools.Kubernetes.KubernetesAttachSettings)"/>
    public static IEnumerable<(KubernetesAttachSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesAttach(CombinatorialConfigure<KubernetesAttachSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesAttach, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Creates a proxy server or application-level gateway between localhost and the Kubernetes API Server. It also allows serving static content over specified HTTP path. All incoming data enters through one port and gets forwarded to the remote kubernetes API Server port, except for the path matching the static content path.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--accept-hosts</c> via <see cref="KubernetesProxySettings.AcceptHosts"/></li><li><c>--accept-paths</c> via <see cref="KubernetesProxySettings.AcceptPaths"/></li><li><c>--address</c> via <see cref="KubernetesProxySettings.Address"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--api-prefix</c> via <see cref="KubernetesProxySettings.ApiPrefix"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--disable-filter</c> via <see cref="KubernetesProxySettings.DisableFilter"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--port</c> via <see cref="KubernetesProxySettings.Port"/></li><li><c>--reject-methods</c> via <see cref="KubernetesProxySettings.RejectMethods"/></li><li><c>--reject-paths</c> via <see cref="KubernetesProxySettings.RejectPaths"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--unix-socket</c> via <see cref="KubernetesProxySettings.UnixSocket"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--www</c> via <see cref="KubernetesProxySettings.Www"/></li><li><c>--www-prefix</c> via <see cref="KubernetesProxySettings.WwwPrefix"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesProxy(KubernetesProxySettings options = null) => new KubernetesTasks().Run<KubernetesProxySettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesProxy(Nuke.Common.Tools.Kubernetes.KubernetesProxySettings)"/>
    public static IReadOnlyCollection<Output> KubernetesProxy(Configure<KubernetesProxySettings> configurator) => new KubernetesTasks().Run<KubernetesProxySettings>(configurator.Invoke(new KubernetesProxySettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesProxy(Nuke.Common.Tools.Kubernetes.KubernetesProxySettings)"/>
    public static IEnumerable<(KubernetesProxySettings Settings, IReadOnlyCollection<Output> Output)> KubernetesProxy(CombinatorialConfigure<KubernetesProxySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesProxy, degreeOfParallelism, completeOnFailure);
    /// <summary><p>These commands correspond to alpha features that are not enabled in Kubernetes clusters by default.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesAlpha(KubernetesAlphaSettings options = null) => new KubernetesTasks().Run<KubernetesAlphaSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesAlpha(Nuke.Common.Tools.Kubernetes.KubernetesAlphaSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesAlpha(Configure<KubernetesAlphaSettings> configurator) => new KubernetesTasks().Run<KubernetesAlphaSettings>(configurator.Invoke(new KubernetesAlphaSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesAlpha(Nuke.Common.Tools.Kubernetes.KubernetesAlphaSettings)"/>
    public static IEnumerable<(KubernetesAlphaSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesAlpha(CombinatorialConfigure<KubernetesAlphaSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesAlpha, degreeOfParallelism, completeOnFailure);
    /// <summary><p>kubectl controls the Kubernetes cluster manager. Find more information at: https://kubernetes.io/docs/reference/kubectl/overview/.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> Kubernetes(KubernetesSettings options = null) => new KubernetesTasks().Run<KubernetesSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.Kubernetes(Nuke.Common.Tools.Kubernetes.KubernetesSettings)"/>
    public static IReadOnlyCollection<Output> Kubernetes(Configure<KubernetesSettings> configurator) => new KubernetesTasks().Run<KubernetesSettings>(configurator.Invoke(new KubernetesSettings()));
    /// <inheritdoc cref="KubernetesTasks.Kubernetes(Nuke.Common.Tools.Kubernetes.KubernetesSettings)"/>
    public static IEnumerable<(KubernetesSettings Settings, IReadOnlyCollection<Output> Output)> Kubernetes(CombinatorialConfigure<KubernetesSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(Kubernetes, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Output shell completion code for the specified shell (bash or zsh). The shell code must be evaluated to provide interactive completion of kubectl commands.  This can be done by sourcing it from the .bash _profile. Detailed instructions on how to do this are available here: https://kubernetes.io/docs/tasks/tools/install-kubectl/#enabling-shell-autocompletion Note for zsh users: [1] zsh completions are only supported in versions of zsh &gt;= 5.2.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesCompletion(KubernetesCompletionSettings options = null) => new KubernetesTasks().Run<KubernetesCompletionSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesCompletion(Nuke.Common.Tools.Kubernetes.KubernetesCompletionSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesCompletion(Configure<KubernetesCompletionSettings> configurator) => new KubernetesTasks().Run<KubernetesCompletionSettings>(configurator.Invoke(new KubernetesCompletionSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesCompletion(Nuke.Common.Tools.Kubernetes.KubernetesCompletionSettings)"/>
    public static IEnumerable<(KubernetesCompletionSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesCompletion(CombinatorialConfigure<KubernetesCompletionSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesCompletion, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Update field(s) of a resource using strategic merge patch, a JSON merge patch, or a JSON patch. JSON and YAML formats are accepted. Please refer to the models in https://htmlpreview.github.io/?https://github.com/kubernetes/kubernetes/blob/HEAD/docs/api-reference/v1/definitions.html to find if a field is mutable.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesPatchSettings.TypeName"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesPatchSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesPatchSettings.DryRun"/></li><li><c>--filename</c> via <see cref="KubernetesPatchSettings.Filename"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--local</c> via <see cref="KubernetesPatchSettings.Local"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesPatchSettings.Output"/></li><li><c>--patch</c> via <see cref="KubernetesPatchSettings.Patch"/></li><li><c>--record</c> via <see cref="KubernetesPatchSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesPatchSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesPatchSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--type</c> via <see cref="KubernetesPatchSettings.Type"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesPatch(KubernetesPatchSettings options = null) => new KubernetesTasks().Run<KubernetesPatchSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesPatch(Nuke.Common.Tools.Kubernetes.KubernetesPatchSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesPatch(Configure<KubernetesPatchSettings> configurator) => new KubernetesTasks().Run<KubernetesPatchSettings>(configurator.Invoke(new KubernetesPatchSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesPatch(Nuke.Common.Tools.Kubernetes.KubernetesPatchSettings)"/>
    public static IEnumerable<(KubernetesPatchSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesPatch(CombinatorialConfigure<KubernetesPatchSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesPatch, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Replace a resource by filename or stdin. JSON and YAML formats are accepted. If replacing an existing resource, the complete resource spec must be provided. This can be obtained by   $ kubectl get TYPE NAME -o yaml  Please refer to the models in https://htmlpreview.github.io/?https://github.com/kubernetes/kubernetes/blob/HEAD/docs/api-reference/v1/definitions.html to find if a field is mutable.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesReplaceSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--cascade</c> via <see cref="KubernetesReplaceSettings.Cascade"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--filename</c> via <see cref="KubernetesReplaceSettings.Filename"/></li><li><c>--force</c> via <see cref="KubernetesReplaceSettings.Force"/></li><li><c>--grace-period</c> via <see cref="KubernetesReplaceSettings.GracePeriod"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesReplaceSettings.Output"/></li><li><c>--recursive</c> via <see cref="KubernetesReplaceSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--save-config</c> via <see cref="KubernetesReplaceSettings.SaveConfig"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesReplaceSettings.Template"/></li><li><c>--timeout</c> via <see cref="KubernetesReplaceSettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--validate</c> via <see cref="KubernetesReplaceSettings.Validate"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--wait</c> via <see cref="KubernetesReplaceSettings.Wait"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesReplace(KubernetesReplaceSettings options = null) => new KubernetesTasks().Run<KubernetesReplaceSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesReplace(Nuke.Common.Tools.Kubernetes.KubernetesReplaceSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesReplace(Configure<KubernetesReplaceSettings> configurator) => new KubernetesTasks().Run<KubernetesReplaceSettings>(configurator.Invoke(new KubernetesReplaceSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesReplace(Nuke.Common.Tools.Kubernetes.KubernetesReplaceSettings)"/>
    public static IEnumerable<(KubernetesReplaceSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesReplace(CombinatorialConfigure<KubernetesReplaceSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesReplace, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Update the taints on one or more nodes.   * A taint consists of a key, value, and effect. As an argument here, it is expressed as key=value:effect.    * The key must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  253 characters.    * Optionally, the key can begin with a DNS subdomain prefix and a single '/', like example.com/my-app    * The value must begin with a letter or number, and may contain letters, numbers, hyphens, dots, and underscores, up to  63 characters.    * The effect must be NoSchedule, PreferNoSchedule or NoExecute.    * Currently taint can only apply to node.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;taintEffects&gt;</c> via <see cref="KubernetesTaintSettings.TaintEffects"/></li><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesTaintSettings.TypeName"/></li><li><c>--all</c> via <see cref="KubernetesTaintSettings.All"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesTaintSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesTaintSettings.Output"/></li><li><c>--overwrite</c> via <see cref="KubernetesTaintSettings.Overwrite"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesTaintSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesTaintSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--validate</c> via <see cref="KubernetesTaintSettings.Validate"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesTaint(KubernetesTaintSettings options = null) => new KubernetesTasks().Run<KubernetesTaintSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesTaint(Nuke.Common.Tools.Kubernetes.KubernetesTaintSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesTaint(Configure<KubernetesTaintSettings> configurator) => new KubernetesTasks().Run<KubernetesTaintSettings>(configurator.Invoke(new KubernetesTaintSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesTaint(Nuke.Common.Tools.Kubernetes.KubernetesTaintSettings)"/>
    public static IEnumerable<(KubernetesTaintSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesTaint(CombinatorialConfigure<KubernetesTaintSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesTaint, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Show details of a specific resource or group of resources Print a detailed description of the selected resources, including related resources such as events or controllers. You may select a single object by name, all objects of that type, provide a name prefix, or label selector. For example:   $ kubectl describe TYPE NAME_PREFIX  will first check for an exact match on TYPE and NAME PREFIX. If no such resource exists, it will output details for every resource that has a name prefixed with NAME PREFIX.Use "kubectl api-resources" for a complete list of supported resources.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesDescribeSettings.TypeName"/></li><li><c>--all-namespaces</c> via <see cref="KubernetesDescribeSettings.AllNamespaces"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--filename</c> via <see cref="KubernetesDescribeSettings.Filename"/></li><li><c>--include-uninitialized</c> via <see cref="KubernetesDescribeSettings.IncludeUninitialized"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--recursive</c> via <see cref="KubernetesDescribeSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesDescribeSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--show-events</c> via <see cref="KubernetesDescribeSettings.ShowEvents"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesDescribe(KubernetesDescribeSettings options = null) => new KubernetesTasks().Run<KubernetesDescribeSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesDescribe(Nuke.Common.Tools.Kubernetes.KubernetesDescribeSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesDescribe(Configure<KubernetesDescribeSettings> configurator) => new KubernetesTasks().Run<KubernetesDescribeSettings>(configurator.Invoke(new KubernetesDescribeSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesDescribe(Nuke.Common.Tools.Kubernetes.KubernetesDescribeSettings)"/>
    public static IEnumerable<(KubernetesDescribeSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesDescribe(CombinatorialConfigure<KubernetesDescribeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesDescribe, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Configure application resources These commands help you make changes to existing application resources.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;subcommand&gt;</c> via <see cref="KubernetesSetSettings.Subcommand"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesSet(KubernetesSetSettings options = null) => new KubernetesTasks().Run<KubernetesSetSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesSet(Nuke.Common.Tools.Kubernetes.KubernetesSetSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesSet(Configure<KubernetesSetSettings> configurator) => new KubernetesTasks().Run<KubernetesSetSettings>(configurator.Invoke(new KubernetesSetSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesSet(Nuke.Common.Tools.Kubernetes.KubernetesSetSettings)"/>
    public static IEnumerable<(KubernetesSetSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesSet(CombinatorialConfigure<KubernetesSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesSet, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Inspect authorization.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;subcommand&gt;</c> via <see cref="KubernetesAuthSettings.Subcommand"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesAuth(KubernetesAuthSettings options = null) => new KubernetesTasks().Run<KubernetesAuthSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesAuth(Nuke.Common.Tools.Kubernetes.KubernetesAuthSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesAuth(Configure<KubernetesAuthSettings> configurator) => new KubernetesTasks().Run<KubernetesAuthSettings>(configurator.Invoke(new KubernetesAuthSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesAuth(Nuke.Common.Tools.Kubernetes.KubernetesAuthSettings)"/>
    public static IEnumerable<(KubernetesAuthSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesAuth(CombinatorialConfigure<KubernetesAuthSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesAuth, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Modify certificate resources.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;subcommand&gt;</c> via <see cref="KubernetesCertificateSettings.Subcommand"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesCertificate(KubernetesCertificateSettings options = null) => new KubernetesTasks().Run<KubernetesCertificateSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesCertificate(Nuke.Common.Tools.Kubernetes.KubernetesCertificateSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesCertificate(Configure<KubernetesCertificateSettings> configurator) => new KubernetesTasks().Run<KubernetesCertificateSettings>(configurator.Invoke(new KubernetesCertificateSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesCertificate(Nuke.Common.Tools.Kubernetes.KubernetesCertificateSettings)"/>
    public static IEnumerable<(KubernetesCertificateSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesCertificate(CombinatorialConfigure<KubernetesCertificateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesCertificate, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Manage the rollout of a resource.  Valid resource types include:   * deployments    * daemonsets    * statefulsets.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;subcommand&gt;</c> via <see cref="KubernetesRolloutSettings.Subcommand"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesRollout(KubernetesRolloutSettings options = null) => new KubernetesTasks().Run<KubernetesRolloutSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesRollout(Nuke.Common.Tools.Kubernetes.KubernetesRolloutSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesRollout(Configure<KubernetesRolloutSettings> configurator) => new KubernetesTasks().Run<KubernetesRolloutSettings>(configurator.Invoke(new KubernetesRolloutSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesRollout(Nuke.Common.Tools.Kubernetes.KubernetesRolloutSettings)"/>
    public static IEnumerable<(KubernetesRolloutSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesRollout(CombinatorialConfigure<KubernetesRolloutSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesRollout, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Apply a configuration to a resource by filename or stdin. The resource name must be specified. This resource will be created if it doesn't exist yet. To use 'apply', always create the resource initially with either 'apply' or 'create --save-config'. JSON and YAML formats are accepted. Alpha Disclaimer: the --prune functionality is not yet complete. Do not use unless you are aware of what the current state is. See https://issues.k8s.io/34274.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--all</c> via <see cref="KubernetesApplySettings.All"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesApplySettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--cascade</c> via <see cref="KubernetesApplySettings.Cascade"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesApplySettings.DryRun"/></li><li><c>--filename</c> via <see cref="KubernetesApplySettings.Filename"/></li><li><c>--force</c> via <see cref="KubernetesApplySettings.Force"/></li><li><c>--grace-period</c> via <see cref="KubernetesApplySettings.GracePeriod"/></li><li><c>--include-uninitialized</c> via <see cref="KubernetesApplySettings.IncludeUninitialized"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--openapi-patch</c> via <see cref="KubernetesApplySettings.OpenapiPatch"/></li><li><c>--output</c> via <see cref="KubernetesApplySettings.Output"/></li><li><c>--overwrite</c> via <see cref="KubernetesApplySettings.Overwrite"/></li><li><c>--prune</c> via <see cref="KubernetesApplySettings.Prune"/></li><li><c>--prune-whitelist</c> via <see cref="KubernetesApplySettings.PruneWhitelist"/></li><li><c>--record</c> via <see cref="KubernetesApplySettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesApplySettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesApplySettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesApplySettings.Template"/></li><li><c>--timeout</c> via <see cref="KubernetesApplySettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--validate</c> via <see cref="KubernetesApplySettings.Validate"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--wait</c> via <see cref="KubernetesApplySettings.Wait"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesApply(KubernetesApplySettings options = null) => new KubernetesTasks().Run<KubernetesApplySettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesApply(Nuke.Common.Tools.Kubernetes.KubernetesApplySettings)"/>
    public static IReadOnlyCollection<Output> KubernetesApply(Configure<KubernetesApplySettings> configurator) => new KubernetesTasks().Run<KubernetesApplySettings>(configurator.Invoke(new KubernetesApplySettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesApply(Nuke.Common.Tools.Kubernetes.KubernetesApplySettings)"/>
    public static IEnumerable<(KubernetesApplySettings Settings, IReadOnlyCollection<Output> Output)> KubernetesApply(CombinatorialConfigure<KubernetesApplySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesApply, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Apply a configuration to a resource by using kustomize. The resource name must be specified. This resource will be created if it doesn't exist yet. To use 'apply', always create the resource initially with either 'apply' or 'create --save-config'. JSON and YAML formats are accepted. Alpha Disclaimer: the --prune functionality is not yet complete. Do not use unless you are aware of what the current state is. See https://issues.k8s.io/34274.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;kustomize&gt;</c> via <see cref="KubernetesApplyKustomizeSettings.Kustomize"/></li><li><c>--all</c> via <see cref="KubernetesApplyKustomizeSettings.All"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--cascade</c> via <see cref="KubernetesApplyKustomizeSettings.Cascade"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesApplyKustomizeSettings.DryRun"/></li><li><c>--filename</c> via <see cref="KubernetesApplyKustomizeSettings.Filename"/></li><li><c>--force</c> via <see cref="KubernetesApplyKustomizeSettings.Force"/></li><li><c>--grace-period</c> via <see cref="KubernetesApplyKustomizeSettings.GracePeriod"/></li><li><c>--include-uninitialized</c> via <see cref="KubernetesApplyKustomizeSettings.IncludeUninitialized"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--openapi-patch</c> via <see cref="KubernetesApplyKustomizeSettings.OpenapiPatch"/></li><li><c>--output</c> via <see cref="KubernetesApplyKustomizeSettings.Output"/></li><li><c>--overwrite</c> via <see cref="KubernetesApplyKustomizeSettings.Overwrite"/></li><li><c>--prune</c> via <see cref="KubernetesApplyKustomizeSettings.Prune"/></li><li><c>--prune-whitelist</c> via <see cref="KubernetesApplyKustomizeSettings.PruneWhitelist"/></li><li><c>--record</c> via <see cref="KubernetesApplyKustomizeSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesApplyKustomizeSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesApplyKustomizeSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesApplyKustomizeSettings.Template"/></li><li><c>--timeout</c> via <see cref="KubernetesApplyKustomizeSettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--validate</c> via <see cref="KubernetesApplyKustomizeSettings.Validate"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--wait</c> via <see cref="KubernetesApplyKustomizeSettings.Wait"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesApplyKustomize(KubernetesApplyKustomizeSettings options = null) => new KubernetesTasks().Run<KubernetesApplyKustomizeSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesApplyKustomize(Nuke.Common.Tools.Kubernetes.KubernetesApplyKustomizeSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesApplyKustomize(Configure<KubernetesApplyKustomizeSettings> configurator) => new KubernetesTasks().Run<KubernetesApplyKustomizeSettings>(configurator.Invoke(new KubernetesApplyKustomizeSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesApplyKustomize(Nuke.Common.Tools.Kubernetes.KubernetesApplyKustomizeSettings)"/>
    public static IEnumerable<(KubernetesApplyKustomizeSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesApplyKustomize(CombinatorialConfigure<KubernetesApplyKustomizeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesApplyKustomize, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Mark node as unschedulable.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;node&gt;</c> via <see cref="KubernetesCordonSettings.Node"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesCordonSettings.DryRun"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesCordonSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesCordon(KubernetesCordonSettings options = null) => new KubernetesTasks().Run<KubernetesCordonSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesCordon(Nuke.Common.Tools.Kubernetes.KubernetesCordonSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesCordon(Configure<KubernetesCordonSettings> configurator) => new KubernetesTasks().Run<KubernetesCordonSettings>(configurator.Invoke(new KubernetesCordonSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesCordon(Nuke.Common.Tools.Kubernetes.KubernetesCordonSettings)"/>
    public static IEnumerable<(KubernetesCordonSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesCordon(CombinatorialConfigure<KubernetesCordonSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesCordon, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Copy files and directories to and from containers.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;destFileSpec&gt;</c> via <see cref="KubernetesCpSettings.DestFileSpec"/></li><li><c>&lt;srcFileSpec&gt;</c> via <see cref="KubernetesCpSettings.SrcFileSpec"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--container</c> via <see cref="KubernetesCpSettings.Container"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesCp(KubernetesCpSettings options = null) => new KubernetesTasks().Run<KubernetesCpSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesCp(Nuke.Common.Tools.Kubernetes.KubernetesCpSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesCp(Configure<KubernetesCpSettings> configurator) => new KubernetesTasks().Run<KubernetesCpSettings>(configurator.Invoke(new KubernetesCpSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesCp(Nuke.Common.Tools.Kubernetes.KubernetesCpSettings)"/>
    public static IEnumerable<(KubernetesCpSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesCp(CombinatorialConfigure<KubernetesCpSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesCp, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Print the supported API versions on the server, in the form of "group/version".</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesApiVersions(KubernetesApiVersionsSettings options = null) => new KubernetesTasks().Run<KubernetesApiVersionsSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesApiVersions(Nuke.Common.Tools.Kubernetes.KubernetesApiVersionsSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesApiVersions(Configure<KubernetesApiVersionsSettings> configurator) => new KubernetesTasks().Run<KubernetesApiVersionsSettings>(configurator.Invoke(new KubernetesApiVersionsSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesApiVersions(Nuke.Common.Tools.Kubernetes.KubernetesApiVersionsSettings)"/>
    public static IEnumerable<(KubernetesApiVersionsSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesApiVersions(CombinatorialConfigure<KubernetesApiVersionsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesApiVersions, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Mark node as schedulable.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;node&gt;</c> via <see cref="KubernetesUncordonSettings.Node"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesUncordonSettings.DryRun"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesUncordonSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesUncordon(KubernetesUncordonSettings options = null) => new KubernetesTasks().Run<KubernetesUncordonSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesUncordon(Nuke.Common.Tools.Kubernetes.KubernetesUncordonSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesUncordon(Configure<KubernetesUncordonSettings> configurator) => new KubernetesTasks().Run<KubernetesUncordonSettings>(configurator.Invoke(new KubernetesUncordonSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesUncordon(Nuke.Common.Tools.Kubernetes.KubernetesUncordonSettings)"/>
    public static IEnumerable<(KubernetesUncordonSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesUncordon(CombinatorialConfigure<KubernetesUncordonSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesUncordon, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Creates an autoscaler that automatically chooses and sets the number of pods that run in a kubernetes cluster. Looks up a Deployment, ReplicaSet, or ReplicationController by name and creates an autoscaler that uses the given resource as a reference. An autoscaler can automatically increase or decrease number of pods deployed within the system as needed.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesAutoscaleSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--cpu-percent</c> via <see cref="KubernetesAutoscaleSettings.CpuPercent"/></li><li><c>--dry-run</c> via <see cref="KubernetesAutoscaleSettings.DryRun"/></li><li><c>--filename</c> via <see cref="KubernetesAutoscaleSettings.Filename"/></li><li><c>--generator</c> via <see cref="KubernetesAutoscaleSettings.Generator"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--max</c> via <see cref="KubernetesAutoscaleSettings.Max"/></li><li><c>--min</c> via <see cref="KubernetesAutoscaleSettings.Min"/></li><li><c>--name</c> via <see cref="KubernetesAutoscaleSettings.Name"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesAutoscaleSettings.Output"/></li><li><c>--record</c> via <see cref="KubernetesAutoscaleSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesAutoscaleSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--save-config</c> via <see cref="KubernetesAutoscaleSettings.SaveConfig"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesAutoscaleSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesAutoscale(KubernetesAutoscaleSettings options = null) => new KubernetesTasks().Run<KubernetesAutoscaleSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesAutoscale(Nuke.Common.Tools.Kubernetes.KubernetesAutoscaleSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesAutoscale(Configure<KubernetesAutoscaleSettings> configurator) => new KubernetesTasks().Run<KubernetesAutoscaleSettings>(configurator.Invoke(new KubernetesAutoscaleSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesAutoscale(Nuke.Common.Tools.Kubernetes.KubernetesAutoscaleSettings)"/>
    public static IEnumerable<(KubernetesAutoscaleSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesAutoscale(CombinatorialConfigure<KubernetesAutoscaleSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesAutoscale, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Runs a command-line plugin. Plugins are subcommands that are not part of the major command-line distribution and can even be provided by third-parties. Please refer to the documentation and examples for more information about how to install and write your own plugins.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;name&gt;</c> via <see cref="KubernetesPluginSettings.Name"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesPlugin(KubernetesPluginSettings options = null) => new KubernetesTasks().Run<KubernetesPluginSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesPlugin(Nuke.Common.Tools.Kubernetes.KubernetesPluginSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesPlugin(Configure<KubernetesPluginSettings> configurator) => new KubernetesTasks().Run<KubernetesPluginSettings>(configurator.Invoke(new KubernetesPluginSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesPlugin(Nuke.Common.Tools.Kubernetes.KubernetesPluginSettings)"/>
    public static IEnumerable<(KubernetesPluginSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesPlugin(CombinatorialConfigure<KubernetesPluginSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesPlugin, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Display addresses of the master and services with label kubernetes.io/cluster-service=true To further debug and diagnose cluster problems, use 'kubectl cluster-info dump'.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesClusterInfo(KubernetesClusterInfoSettings options = null) => new KubernetesTasks().Run<KubernetesClusterInfoSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesClusterInfo(Nuke.Common.Tools.Kubernetes.KubernetesClusterInfoSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesClusterInfo(Configure<KubernetesClusterInfoSettings> configurator) => new KubernetesTasks().Run<KubernetesClusterInfoSettings>(configurator.Invoke(new KubernetesClusterInfoSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesClusterInfo(Nuke.Common.Tools.Kubernetes.KubernetesClusterInfoSettings)"/>
    public static IEnumerable<(KubernetesClusterInfoSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesClusterInfo(CombinatorialConfigure<KubernetesClusterInfoSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesClusterInfo, degreeOfParallelism, completeOnFailure);
    /// <summary><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--all-namespaces</c> via <see cref="KubernetesWaitSettings.AllNamespaces"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesWaitSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--filename</c> via <see cref="KubernetesWaitSettings.Filename"/></li><li><c>--for</c> via <see cref="KubernetesWaitSettings.For"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesWaitSettings.Output"/></li><li><c>--recursive</c> via <see cref="KubernetesWaitSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesWaitSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesWaitSettings.Template"/></li><li><c>--timeout</c> via <see cref="KubernetesWaitSettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesWait(KubernetesWaitSettings options = null) => new KubernetesTasks().Run<KubernetesWaitSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesWait(Nuke.Common.Tools.Kubernetes.KubernetesWaitSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesWait(Configure<KubernetesWaitSettings> configurator) => new KubernetesTasks().Run<KubernetesWaitSettings>(configurator.Invoke(new KubernetesWaitSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesWait(Nuke.Common.Tools.Kubernetes.KubernetesWaitSettings)"/>
    public static IEnumerable<(KubernetesWaitSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesWait(CombinatorialConfigure<KubernetesWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesWait, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Convert config files between different API versions. Both YAML and JSON formats are accepted. The command takes filename, directory, or URL as input, and convert it into format of version specified by --output-version flag. If target version is not specified or not supported, convert to latest version. The default output will be printed to stdout in YAML format. One can use -o option to change to output destination.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesConvertSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--filename</c> via <see cref="KubernetesConvertSettings.Filename"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--local</c> via <see cref="KubernetesConvertSettings.Local"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesConvertSettings.Output"/></li><li><c>--output-version</c> via <see cref="KubernetesConvertSettings.OutputVersion"/></li><li><c>--recursive</c> via <see cref="KubernetesConvertSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesConvertSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--validate</c> via <see cref="KubernetesConvertSettings.Validate"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesConvert(KubernetesConvertSettings options = null) => new KubernetesTasks().Run<KubernetesConvertSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesConvert(Nuke.Common.Tools.Kubernetes.KubernetesConvertSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesConvert(Configure<KubernetesConvertSettings> configurator) => new KubernetesTasks().Run<KubernetesConvertSettings>(configurator.Invoke(new KubernetesConvertSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesConvert(Nuke.Common.Tools.Kubernetes.KubernetesConvertSettings)"/>
    public static IEnumerable<(KubernetesConvertSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesConvert(CombinatorialConfigure<KubernetesConvertSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesConvert, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Create a resource from a file or from stdin. JSON and YAML formats are accepted.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesCreateSettings.TypeName"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesCreateSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesCreateSettings.DryRun"/></li><li><c>--edit</c> via <see cref="KubernetesCreateSettings.Edit"/></li><li><c>--filename</c> via <see cref="KubernetesCreateSettings.Filename"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesCreateSettings.Output"/></li><li><c>--raw</c> via <see cref="KubernetesCreateSettings.Raw"/></li><li><c>--record</c> via <see cref="KubernetesCreateSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesCreateSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--save-config</c> via <see cref="KubernetesCreateSettings.SaveConfig"/></li><li><c>--selector</c> via <see cref="KubernetesCreateSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesCreateSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--validate</c> via <see cref="KubernetesCreateSettings.Validate"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--windows-line-endings</c> via <see cref="KubernetesCreateSettings.WindowsLineEndings"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesCreate(KubernetesCreateSettings options = null) => new KubernetesTasks().Run<KubernetesCreateSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesCreate(Nuke.Common.Tools.Kubernetes.KubernetesCreateSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesCreate(Configure<KubernetesCreateSettings> configurator) => new KubernetesTasks().Run<KubernetesCreateSettings>(configurator.Invoke(new KubernetesCreateSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesCreate(Nuke.Common.Tools.Kubernetes.KubernetesCreateSettings)"/>
    public static IEnumerable<(KubernetesCreateSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesCreate(CombinatorialConfigure<KubernetesCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesCreate, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Forward one or more local ports to a pod. Use resource type/name such as deployment/mydeployment to select a pod. Resource type defaults to 'pod' if omitted. If there are multiple pods matching the criteria, a pod will be selected automatically. The forwarding session ends when the selected pod terminates, and rerun of the command is needed to resume forwarding.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;ports&gt;</c> via <see cref="KubernetesPortForwardSettings.Ports"/></li><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesPortForwardSettings.TypeName"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--pod-running-timeout</c> via <see cref="KubernetesPortForwardSettings.PodRunningTimeout"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesPortForward(KubernetesPortForwardSettings options = null) => new KubernetesTasks().Run<KubernetesPortForwardSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesPortForward(Nuke.Common.Tools.Kubernetes.KubernetesPortForwardSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesPortForward(Configure<KubernetesPortForwardSettings> configurator) => new KubernetesTasks().Run<KubernetesPortForwardSettings>(configurator.Invoke(new KubernetesPortForwardSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesPortForward(Nuke.Common.Tools.Kubernetes.KubernetesPortForwardSettings)"/>
    public static IEnumerable<(KubernetesPortForwardSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesPortForward(CombinatorialConfigure<KubernetesPortForwardSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesPortForward, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Create and run a particular image, possibly replicated. Creates a deployment or job to manage the created container(s).</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesRunContainerSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--attach</c> via <see cref="KubernetesRunContainerSettings.Attach"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--cascade</c> via <see cref="KubernetesRunContainerSettings.Cascade"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--command</c> via <see cref="KubernetesRunContainerSettings.Command"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--dry-run</c> via <see cref="KubernetesRunContainerSettings.DryRun"/></li><li><c>--env</c> via <see cref="KubernetesRunContainerSettings.Env"/></li><li><c>--expose</c> via <see cref="KubernetesRunContainerSettings.Expose"/></li><li><c>--filename</c> via <see cref="KubernetesRunContainerSettings.Filename"/></li><li><c>--force</c> via <see cref="KubernetesRunContainerSettings.Force"/></li><li><c>--generator</c> via <see cref="KubernetesRunContainerSettings.Generator"/></li><li><c>--grace-period</c> via <see cref="KubernetesRunContainerSettings.GracePeriod"/></li><li><c>--hostport</c> via <see cref="KubernetesRunContainerSettings.Hostport"/></li><li><c>--image</c> via <see cref="KubernetesRunContainerSettings.Image"/></li><li><c>--image-pull-policy</c> via <see cref="KubernetesRunContainerSettings.ImagePullPolicy"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--labels</c> via <see cref="KubernetesRunContainerSettings.Labels"/></li><li><c>--leave-stdin-open</c> via <see cref="KubernetesRunContainerSettings.LeaveStdinOpen"/></li><li><c>--limits</c> via <see cref="KubernetesRunContainerSettings.Limits"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesRunContainerSettings.Output"/></li><li><c>--overrides</c> via <see cref="KubernetesRunContainerSettings.Overrides"/></li><li><c>--pod-running-timeout</c> via <see cref="KubernetesRunContainerSettings.PodRunningTimeout"/></li><li><c>--port</c> via <see cref="KubernetesRunContainerSettings.Port"/></li><li><c>--quiet</c> via <see cref="KubernetesRunContainerSettings.Quiet"/></li><li><c>--record</c> via <see cref="KubernetesRunContainerSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesRunContainerSettings.Recursive"/></li><li><c>--replicas</c> via <see cref="KubernetesRunContainerSettings.Replicas"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--requests</c> via <see cref="KubernetesRunContainerSettings.Requests"/></li><li><c>--restart</c> via <see cref="KubernetesRunContainerSettings.Restart"/></li><li><c>--rm</c> via <see cref="KubernetesRunContainerSettings.Rm"/></li><li><c>--save-config</c> via <see cref="KubernetesRunContainerSettings.SaveConfig"/></li><li><c>--schedule</c> via <see cref="KubernetesRunContainerSettings.Schedule"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--service-generator</c> via <see cref="KubernetesRunContainerSettings.ServiceGenerator"/></li><li><c>--service-overrides</c> via <see cref="KubernetesRunContainerSettings.ServiceOverrides"/></li><li><c>--serviceaccount</c> via <see cref="KubernetesRunContainerSettings.Serviceaccount"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--stdin</c> via <see cref="KubernetesRunContainerSettings.Stdin"/></li><li><c>--template</c> via <see cref="KubernetesRunContainerSettings.Template"/></li><li><c>--timeout</c> via <see cref="KubernetesRunContainerSettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--tty</c> via <see cref="KubernetesRunContainerSettings.Tty"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--wait</c> via <see cref="KubernetesRunContainerSettings.Wait"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesRunContainer(KubernetesRunContainerSettings options = null) => new KubernetesTasks().Run<KubernetesRunContainerSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesRunContainer(Nuke.Common.Tools.Kubernetes.KubernetesRunContainerSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesRunContainer(Configure<KubernetesRunContainerSettings> configurator) => new KubernetesTasks().Run<KubernetesRunContainerSettings>(configurator.Invoke(new KubernetesRunContainerSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesRunContainer(Nuke.Common.Tools.Kubernetes.KubernetesRunContainerSettings)"/>
    public static IEnumerable<(KubernetesRunContainerSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesRunContainer(CombinatorialConfigure<KubernetesRunContainerSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesRunContainer, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Edit a resource from the default editor. The edit command allows you to directly edit any API resource you can retrieve via the command line tools. It will open the editor defined by your KUBE _EDITOR, or EDITOR environment variables, or fall back to 'vi' for Linux or 'notepad' for Windows. You can edit multiple objects, although changes are applied one at a time. The command accepts filenames as well as command line arguments, although the files you point to must be previously saved versions of resources. Editing is done with the API version used to fetch the resource. To edit using a specific API version, fully-qualify the resource, version, and group. The default format is YAML. To edit in JSON, specify "-o json". The flag --windows-line-endings can be used to force Windows line endings, otherwise the default for your operating system will be used. In the event an error occurs while updating, a temporary file will be created on disk that contains your unapplied changes. The most common error when updating a resource is another editor changing the resource on the server. When this occurs, you will have to apply your changes to the newer version of the resource, or update your temporary saved copy to include the latest resource version.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesEditSettings.TypeName"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesEditSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--filename</c> via <see cref="KubernetesEditSettings.Filename"/></li><li><c>--include-uninitialized</c> via <see cref="KubernetesEditSettings.IncludeUninitialized"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesEditSettings.Output"/></li><li><c>--output-patch</c> via <see cref="KubernetesEditSettings.OutputPatch"/></li><li><c>--record</c> via <see cref="KubernetesEditSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesEditSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--save-config</c> via <see cref="KubernetesEditSettings.SaveConfig"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesEditSettings.Template"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--validate</c> via <see cref="KubernetesEditSettings.Validate"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li><li><c>--windows-line-endings</c> via <see cref="KubernetesEditSettings.WindowsLineEndings"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesEdit(KubernetesEditSettings options = null) => new KubernetesTasks().Run<KubernetesEditSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesEdit(Nuke.Common.Tools.Kubernetes.KubernetesEditSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesEdit(Configure<KubernetesEditSettings> configurator) => new KubernetesTasks().Run<KubernetesEditSettings>(configurator.Invoke(new KubernetesEditSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesEdit(Nuke.Common.Tools.Kubernetes.KubernetesEditSettings)"/>
    public static IEnumerable<(KubernetesEditSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesEdit(CombinatorialConfigure<KubernetesEditSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesEdit, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Set a new size for a Deployment, ReplicaSet, Replication Controller, or StatefulSet. Scale also allows users to specify one or more preconditions for the scale action. If --current-replicas or --resource-version is specified, it is validated before the scale is attempted, and it is guaranteed that the precondition holds true when the scale is sent to the server.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--all</c> via <see cref="KubernetesScaleSettings.All"/></li><li><c>--allow-missing-template-keys</c> via <see cref="KubernetesScaleSettings.AllowMissingTemplateKeys"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--current-replicas</c> via <see cref="KubernetesScaleSettings.CurrentReplicas"/></li><li><c>--filename</c> via <see cref="KubernetesScaleSettings.Filename"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--output</c> via <see cref="KubernetesScaleSettings.Output"/></li><li><c>--record</c> via <see cref="KubernetesScaleSettings.Record"/></li><li><c>--recursive</c> via <see cref="KubernetesScaleSettings.Recursive"/></li><li><c>--replicas</c> via <see cref="KubernetesScaleSettings.Replicas"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--resource-version</c> via <see cref="KubernetesScaleSettings.ResourceVersion"/></li><li><c>--selector</c> via <see cref="KubernetesScaleSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--template</c> via <see cref="KubernetesScaleSettings.Template"/></li><li><c>--timeout</c> via <see cref="KubernetesScaleSettings.Timeout"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesScale(KubernetesScaleSettings options = null) => new KubernetesTasks().Run<KubernetesScaleSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesScale(Nuke.Common.Tools.Kubernetes.KubernetesScaleSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesScale(Configure<KubernetesScaleSettings> configurator) => new KubernetesTasks().Run<KubernetesScaleSettings>(configurator.Invoke(new KubernetesScaleSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesScale(Nuke.Common.Tools.Kubernetes.KubernetesScaleSettings)"/>
    public static IEnumerable<(KubernetesScaleSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesScale(CombinatorialConfigure<KubernetesScaleSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesScale, degreeOfParallelism, completeOnFailure);
    /// <summary><p>List the fields for supported resources This command describes the fields associated with each supported API resource. Fields are identified via a simple JSONPath identifier:   &lt;type&gt;.&lt;fieldName&gt;[.&lt;fieldName&gt;]  Add the --recursive flag to display all of the fields at once without descriptions. Information about each field is retrieved from the server in OpenAPI format.Use "kubectl api-resources" for a complete list of supported resources.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;resource&gt;</c> via <see cref="KubernetesExplainSettings.Resource"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--api-version</c> via <see cref="KubernetesExplainSettings.ApiVersion"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--recursive</c> via <see cref="KubernetesExplainSettings.Recursive"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesExplain(KubernetesExplainSettings options = null) => new KubernetesTasks().Run<KubernetesExplainSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesExplain(Nuke.Common.Tools.Kubernetes.KubernetesExplainSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesExplain(Configure<KubernetesExplainSettings> configurator) => new KubernetesTasks().Run<KubernetesExplainSettings>(configurator.Invoke(new KubernetesExplainSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesExplain(Nuke.Common.Tools.Kubernetes.KubernetesExplainSettings)"/>
    public static IEnumerable<(KubernetesExplainSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesExplain(CombinatorialConfigure<KubernetesExplainSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesExplain, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Print the logs for a container in a pod or specified resource. If the pod has only one container, the container name is optional.</p><p>For more details, visit the <a href="https://kubernetes.io/">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;typeName&gt;</c> via <see cref="KubernetesLogsSettings.TypeName"/></li><li><c>--all-containers</c> via <see cref="KubernetesLogsSettings.AllContainers"/></li><li><c>--alsologtostderr</c> via <see cref="KubernetesOptionsBase.Alsologtostderr"/></li><li><c>--as</c> via <see cref="KubernetesOptionsBase.As"/></li><li><c>--as-group</c> via <see cref="KubernetesOptionsBase.AsGroup"/></li><li><c>--cache-dir</c> via <see cref="KubernetesOptionsBase.CacheDir"/></li><li><c>--certificate-authority</c> via <see cref="KubernetesOptionsBase.CertificateAuthority"/></li><li><c>--client-certificate</c> via <see cref="KubernetesOptionsBase.ClientCertificate"/></li><li><c>--client-key</c> via <see cref="KubernetesOptionsBase.ClientKey"/></li><li><c>--cluster</c> via <see cref="KubernetesOptionsBase.Cluster"/></li><li><c>--container</c> via <see cref="KubernetesLogsSettings.Container"/></li><li><c>--context</c> via <see cref="KubernetesOptionsBase.Context"/></li><li><c>--follow</c> via <see cref="KubernetesLogsSettings.Follow"/></li><li><c>--insecure-skip-tls-verify</c> via <see cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/></li><li><c>--interactive</c> via <see cref="KubernetesLogsSettings.Interactive"/></li><li><c>--kubeconfig</c> via <see cref="KubernetesOptionsBase.Kubeconfig"/></li><li><c>--limit-bytes</c> via <see cref="KubernetesLogsSettings.LimitBytes"/></li><li><c>--log-backtrace-at</c> via <see cref="KubernetesOptionsBase.LogBacktraceAt"/></li><li><c>--log-dir</c> via <see cref="KubernetesOptionsBase.LogDir"/></li><li><c>--logtostderr</c> via <see cref="KubernetesOptionsBase.Logtostderr"/></li><li><c>--match-server-version</c> via <see cref="KubernetesOptionsBase.MatchServerVersion"/></li><li><c>--namespace</c> via <see cref="KubernetesOptionsBase.Namespace"/></li><li><c>--pod-running-timeout</c> via <see cref="KubernetesLogsSettings.PodRunningTimeout"/></li><li><c>--previous</c> via <see cref="KubernetesLogsSettings.Previous"/></li><li><c>--request-timeout</c> via <see cref="KubernetesOptionsBase.RequestTimeout"/></li><li><c>--selector</c> via <see cref="KubernetesLogsSettings.Selector"/></li><li><c>--server</c> via <see cref="KubernetesOptionsBase.Server"/></li><li><c>--since</c> via <see cref="KubernetesLogsSettings.Since"/></li><li><c>--since-time</c> via <see cref="KubernetesLogsSettings.SinceTime"/></li><li><c>--stderrthreshold</c> via <see cref="KubernetesOptionsBase.Stderrthreshold"/></li><li><c>--tail</c> via <see cref="KubernetesLogsSettings.Tail"/></li><li><c>--timestamps</c> via <see cref="KubernetesLogsSettings.Timestamps"/></li><li><c>--token</c> via <see cref="KubernetesOptionsBase.Token"/></li><li><c>--user</c> via <see cref="KubernetesOptionsBase.User"/></li><li><c>--v</c> via <see cref="KubernetesOptionsBase.V"/></li><li><c>--vmodule</c> via <see cref="KubernetesOptionsBase.Vmodule"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KubernetesLogs(KubernetesLogsSettings options = null) => new KubernetesTasks().Run<KubernetesLogsSettings>(options);
    /// <inheritdoc cref="KubernetesTasks.KubernetesLogs(Nuke.Common.Tools.Kubernetes.KubernetesLogsSettings)"/>
    public static IReadOnlyCollection<Output> KubernetesLogs(Configure<KubernetesLogsSettings> configurator) => new KubernetesTasks().Run<KubernetesLogsSettings>(configurator.Invoke(new KubernetesLogsSettings()));
    /// <inheritdoc cref="KubernetesTasks.KubernetesLogs(Nuke.Common.Tools.Kubernetes.KubernetesLogsSettings)"/>
    public static IEnumerable<(KubernetesLogsSettings Settings, IReadOnlyCollection<Output> Output)> KubernetesLogs(CombinatorialConfigure<KubernetesLogsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KubernetesLogs, degreeOfParallelism, completeOnFailure);
}
#region KubernetesApiResourcesSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesApiResources(Nuke.Common.Tools.Kubernetes.KubernetesApiResourcesSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesApiResources), Arguments = "api-resources")]
public partial class KubernetesApiResourcesSettings : KubernetesOptionsBase
{
    /// <summary>Limit to resources in the specified API group.</summary>
    [Argument(Format = "--api-group={value}")] public string ApiGroup => Get<string>(() => ApiGroup);
    /// <summary>Use the cached list of resources if available.</summary>
    [Argument(Format = "--cached={value}")] public bool? Cached => Get<bool?>(() => Cached);
    /// <summary>If false, non-namespaced resources will be returned, otherwise returning namespaced resources by default.</summary>
    [Argument(Format = "--namespaced={value}")] public bool? Namespaced => Get<bool?>(() => Namespaced);
    /// <summary>When using the default or custom-column output format, don't print headers (default print headers).</summary>
    [Argument(Format = "--no-headers={value}")] public bool? NoHeaders => Get<bool?>(() => NoHeaders);
    /// <summary>Output format. One of: wide|name.</summary>
    [Argument(Format = "--output={value}")] public KubernetesApiResourcesOutput Output => Get<KubernetesApiResourcesOutput>(() => Output);
    /// <summary>Limit to resources that support the specified verbs.</summary>
    [Argument(Format = "--verbs={value}", Separator = ",")] public IReadOnlyList<string> Verbs => Get<List<string>>(() => Verbs);
}
#endregion
#region KubernetesDrainSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesDrain(Nuke.Common.Tools.Kubernetes.KubernetesDrainSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesDrain), Arguments = "drain")]
public partial class KubernetesDrainSettings : KubernetesOptionsBase
{
    /// <summary>Continue even if there are pods using emptyDir (local data that will be deleted when the node is drained).</summary>
    [Argument(Format = "--delete-local-data={value}")] public bool? DeleteLocalData => Get<bool?>(() => DeleteLocalData);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Continue even if there are pods not managed by a ReplicationController, ReplicaSet, Job, DaemonSet or StatefulSet.</summary>
    [Argument(Format = "--force={value}")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Period of time in seconds given to each pod to terminate gracefully. If negative, the default value specified in the pod will be used.</summary>
    [Argument(Format = "--grace-period={value}")] public int? GracePeriod => Get<int?>(() => GracePeriod);
    /// <summary>Ignore DaemonSet-managed pods.</summary>
    [Argument(Format = "--ignore-daemonsets={value}")] public bool? IgnoreDaemonsets => Get<bool?>(() => IgnoreDaemonsets);
    /// <summary>Label selector to filter pods on the node.</summary>
    [Argument(Format = "--pod-selector={value}")] public string PodSelector => Get<string>(() => PodSelector);
    /// <summary>Selector (label query) to filter on.</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>The length of time to wait before giving up, zero means infinite.</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
}
#endregion
#region KubernetesRunSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesRun(Nuke.Common.Tools.Kubernetes.KubernetesRunSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesRun), Arguments = "run")]
public partial class KubernetesRunSettings : KubernetesOptionsBase
{
    /// <summary>The name of the container.</summary>
    [Argument(Format = "{value}")] public string Name => Get<string>(() => Name);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>If true, wait for the Pod to start running, and then attach to the Pod as if 'kubectl attach ...' were called.  Default false, unless '-i/--stdin' is set, in which case the default is true. With '--restart=Never' the exit code of the container process is returned.</summary>
    [Argument(Format = "--attach={value}")] public bool? Attach => Get<bool?>(() => Attach);
    /// <summary>If true, cascade the deletion of the resources managed by this resource (e.g. Pods created by a ReplicationController).  Default true.</summary>
    [Argument(Format = "--cascade={value}")] public bool? Cascade => Get<bool?>(() => Cascade);
    /// <summary>If true and extra arguments are present, use them as the 'command' field in the container, rather than the 'args' field which is the default.</summary>
    [Argument(Format = "--command={value}")] public bool? Command => Get<bool?>(() => Command);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Environment variables to set in the container.</summary>
    [Argument(Format = "--env={value}")] public IReadOnlyList<string> Env => Get<List<string>>(() => Env);
    /// <summary>If true, a public, external service is created for the container(s) which are run.</summary>
    [Argument(Format = "--expose={value}")] public bool? Expose => Get<bool?>(() => Expose);
    /// <summary>to use to replace the resource.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>Only used when grace-period=0. If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.</summary>
    [Argument(Format = "--force={value}")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>The name of the API generator to use, see http://kubernetes.io/docs/user-guide/kubectl-conventions/#generators for a list.</summary>
    [Argument(Format = "--generator={value}")] public string Generator => Get<string>(() => Generator);
    /// <summary>Period of time in seconds given to the resource to terminate gracefully. Ignored if negative. Set to 1 for immediate shutdown. Can only be set to 0 when --force is true (force deletion).</summary>
    [Argument(Format = "--grace-period={value}")] public int? GracePeriod => Get<int?>(() => GracePeriod);
    /// <summary>The host port mapping for the container port. To demonstrate a single-machine container.</summary>
    [Argument(Format = "--hostport={value}")] public int? Hostport => Get<int?>(() => Hostport);
    /// <summary>The image for the container to run.</summary>
    [Argument(Format = "--image={value}")] public string Image => Get<string>(() => Image);
    /// <summary>The image pull policy for the container. If left empty, this value will not be specified by the client and defaulted by the server.</summary>
    [Argument(Format = "--image-pull-policy={value}")] public string ImagePullPolicy => Get<string>(() => ImagePullPolicy);
    /// <summary>Comma separated labels to apply to the pod(s). Will override previous values.</summary>
    [Argument(Format = "--labels={value}")] public string Labels => Get<string>(() => Labels);
    /// <summary>If the pod is started in interactive mode or with stdin, leave stdin open after the first attach completes. By default, stdin will be closed after the first attach completes.</summary>
    [Argument(Format = "--leave-stdin-open={value}")] public bool? LeaveStdinOpen => Get<bool?>(() => LeaveStdinOpen);
    /// <summary>The resource requirement limits for this container.  For example, 'cpu=200m,memory=512Mi'.  Note that server side components may assign limits depending on the server configuration, such as limit ranges.</summary>
    [Argument(Format = "--limits={value}")] public string Limits => Get<string>(() => Limits);
    /// <summary>Output format. One of: json|yaml|name|templatefile|template|go-template|go-template-file|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesRunOutput Output => Get<KubernetesRunOutput>(() => Output);
    /// <summary>An inline JSON override for the generated object. If this is non-empty, it is used to override the generated object. Requires that the object supply a valid apiVersion field.</summary>
    [Argument(Format = "--overrides={value}")] public string Overrides => Get<string>(() => Overrides);
    /// <summary>The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running.</summary>
    [Argument(Format = "--pod-running-timeout={value}")] public TimeSpan? PodRunningTimeout => Get<TimeSpan?>(() => PodRunningTimeout);
    /// <summary>The port that this container exposes.  If --expose is true, this is also the port used by the service that is created.</summary>
    [Argument(Format = "--port={value}")] public string Port => Get<string>(() => Port);
    /// <summary>If true, suppress prompt messages.</summary>
    [Argument(Format = "--quiet={value}")] public bool? Quiet => Get<bool?>(() => Quiet);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Number of replicas to create for this container. Default is 1.</summary>
    [Argument(Format = "--replicas={value}")] public int? Replicas => Get<int?>(() => Replicas);
    /// <summary>The resource requirement requests for this container.  For example, 'cpu=100m,memory=256Mi'.  Note that server side components may assign requests depending on the server configuration, such as limit ranges.</summary>
    [Argument(Format = "--requests={value}")] public string Requests => Get<string>(() => Requests);
    /// <summary>The restart policy for this Pod.  Legal values [Always, OnFailure, Never].  If set to 'Always' a deployment is created, if set to 'OnFailure' a job is created, if set to 'Never', a regular pod is created. For the latter two --replicas must be 1.  Default 'Always', for CronJobs `Never`.</summary>
    [Argument(Format = "--restart={value}")] public string Restart => Get<string>(() => Restart);
    /// <summary>If true, delete resources created in this command for attached containers.</summary>
    [Argument(Format = "--rm={value}")] public bool? Rm => Get<bool?>(() => Rm);
    /// <summary>If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.</summary>
    [Argument(Format = "--save-config={value}")] public bool? SaveConfig => Get<bool?>(() => SaveConfig);
    /// <summary>A schedule in the Cron format the job should be run with.</summary>
    [Argument(Format = "--schedule={value}")] public string Schedule => Get<string>(() => Schedule);
    /// <summary>The name of the generator to use for creating a service.  Only used if --expose is true.</summary>
    [Argument(Format = "--service-generator={value}")] public string ServiceGenerator => Get<string>(() => ServiceGenerator);
    /// <summary>An inline JSON override for the generated service object. If this is non-empty, it is used to override the generated object. Requires that the object supply a valid apiVersion field.  Only used if --expose is true.</summary>
    [Argument(Format = "--service-overrides={value}")] public string ServiceOverrides => Get<string>(() => ServiceOverrides);
    /// <summary>Service account to set in the pod spec.</summary>
    [Argument(Format = "--serviceaccount={value}")] public string Serviceaccount => Get<string>(() => Serviceaccount);
    /// <summary>Keep stdin open on the container(s) in the pod, even if nothing is attached.</summary>
    [Argument(Format = "--stdin={value}")] public bool? Stdin => Get<bool?>(() => Stdin);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>The length of time to wait before giving up on a delete, zero means determine a timeout from the size of the object.</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
    /// <summary>Allocated a TTY for each container in the pod.</summary>
    [Argument(Format = "--tty={value}")] public bool? Tty => Get<bool?>(() => Tty);
    /// <summary>If true, wait for resources to be gone before returning. This waits for finalizers.</summary>
    [Argument(Format = "--wait={value}")] public bool? Wait => Get<bool?>(() => Wait);
}
#endregion
#region KubernetesGetSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesGet(Nuke.Common.Tools.Kubernetes.KubernetesGetSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesGet), Arguments = "get")]
public partial class KubernetesGetSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the ressource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>If present, list the requested object(s) across all namespaces. Namespace in current context is ignored even if specified with --namespace.</summary>
    [Argument(Format = "--all-namespaces={value}")] public bool? AllNamespaces => Get<bool?>(() => AllNamespaces);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>Return large lists in chunks rather than all at once. Pass 0 to disable. This flag is beta and may change in the future.</summary>
    [Argument(Format = "--chunk-size={value}")] public long? ChunkSize => Get<long?>(() => ChunkSize);
    /// <summary>If true, use 'export' for the resources.  Exported resources are stripped of cluster-specific information.</summary>
    [Argument(Format = "--export={value}")] public bool? Export => Get<bool?>(() => Export);
    /// <summary>Selector (field query) to filter on, supports '=', '==', and '!='.(e.g. --field-selector key1=value1,key2=value2). The server only supports a limited number of field queries per type.</summary>
    [Argument(Format = "--field-selector={value}")] public string FieldSelector => Get<string>(() => FieldSelector);
    /// <summary>Filename, directory, or URL to files identifying the resource to get from a server.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>If the requested object does not exist the command will return exit code 0.</summary>
    [Argument(Format = "--ignore-not-found={value}")] public bool? IgnoreNotFound => Get<bool?>(() => IgnoreNotFound);
    /// <summary>If true, the kubectl command applies to uninitialized objects. If explicitly set to false, this flag overrides other flags that make the kubectl commands apply to uninitialized objects, e.g., "--all". Objects with empty metadata.initializers are regarded as initialized.</summary>
    [Argument(Format = "--include-uninitialized={value}")] public bool? IncludeUninitialized => Get<bool?>(() => IncludeUninitialized);
    /// <summary>Accepts a comma separated list of labels that are going to be presented as columns. Names are case-sensitive. You can also use multiple flag options like -L label1 -L label2...</summary>
    [Argument(Format = "--label-columns={value}", Separator = ",")] public IReadOnlyList<string> LabelColumns => Get<List<string>>(() => LabelColumns);
    /// <summary>When using the default or custom-column output format, don't print headers (default print headers).</summary>
    [Argument(Format = "--no-headers={value}")] public bool? NoHeaders => Get<bool?>(() => NoHeaders);
    /// <summary>Output format. One of: json|yaml|wide|name|custom-columns=...|custom-columns-file=...|go-template=...|go-template-file=...|jsonpath=...|jsonpath-file=... See custom columns [http://kubernetes.io/docs/user-guide/kubectl-overview/#custom-columns], golang template [http://golang.org/pkg/text/template/#pkg-overview] and jsonpath template [http://kubernetes.io/docs/user-guide/jsonpath].</summary>
    [Argument(Format = "--output={value}")] public KubernetesGetOutput Output => Get<KubernetesGetOutput>(() => Output);
    /// <summary>Raw URI to request from the server.  Uses the transport specified by the kubeconfig file.</summary>
    [Argument(Format = "--raw={value}")] public string Raw => Get<string>(() => Raw);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>If true, have the server return the appropriate table output. Supports extension APIs and CRDs.</summary>
    [Argument(Format = "--server-print={value}")] public bool? ServerPrint => Get<bool?>(() => ServerPrint);
    /// <summary>When printing, show all resources (default show all pods including terminated one.).</summary>
    [Argument(Format = "--show-all={value}")] public bool? ShowAll => Get<bool?>(() => ShowAll);
    /// <summary>If present, list the resource type for the requested object(s).</summary>
    [Argument(Format = "--show-kind={value}")] public bool? ShowKind => Get<bool?>(() => ShowKind);
    /// <summary>When printing, show all labels as the last column (default hide labels column).</summary>
    [Argument(Format = "--show-labels={value}")] public bool? ShowLabels => Get<bool?>(() => ShowLabels);
    /// <summary>If non-empty, sort list types using this field specification.  The field specification is expressed as a JSONPath expression (e.g. '{.metadata.name}'). The field in the API resource specified by this JSONPath expression must be an integer or a string.</summary>
    [Argument(Format = "--sort-by={value}")] public string SortBy => Get<string>(() => SortBy);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>If true, use x-kubernetes-print-column metadata (if present) from the OpenAPI schema for displaying a resource.</summary>
    [Argument(Format = "--use-openapi-print-columns={value}")] public bool? UseOpenapiPrintColumns => Get<bool?>(() => UseOpenapiPrintColumns);
    /// <summary>After listing/getting the requested object, watch for changes. Uninitialized objects are excluded if no object name is provided.</summary>
    [Argument(Format = "--watch={value}")] public bool? Watch => Get<bool?>(() => Watch);
    /// <summary>Watch for changes to the requested object(s), without listing/getting first.</summary>
    [Argument(Format = "--watch-only={value}")] public bool? WatchOnly => Get<bool?>(() => WatchOnly);
}
#endregion
#region KubernetesVersionSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesVersion(Nuke.Common.Tools.Kubernetes.KubernetesVersionSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesVersion), Arguments = "version")]
public partial class KubernetesVersionSettings : KubernetesOptionsBase
{
    /// <summary>Client version only (no server required).</summary>
    [Argument(Format = "--client={value}")] public bool? Client => Get<bool?>(() => Client);
    /// <summary>One of 'yaml' or 'json'.</summary>
    [Argument(Format = "--output={value}")] public string Output => Get<string>(() => Output);
    /// <summary>Print just the version number.</summary>
    [Argument(Format = "--short={value}")] public bool? Short => Get<bool?>(() => Short);
}
#endregion
#region KubernetesTopSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesTop(Nuke.Common.Tools.Kubernetes.KubernetesTopSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesTop), Arguments = "top")]
public partial class KubernetesTopSettings : KubernetesOptionsBase
{
}
#endregion
#region KubernetesConfigSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesConfig(Nuke.Common.Tools.Kubernetes.KubernetesConfigSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesConfig), Arguments = "config")]
public partial class KubernetesConfigSettings : KubernetesOptionsBase
{
}
#endregion
#region KubernetesExecSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesExec(Nuke.Common.Tools.Kubernetes.KubernetesExecSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesExec), Arguments = "exec")]
public partial class KubernetesExecSettings : KubernetesOptionsBase
{
    /// <summary>The name of the pod.</summary>
    [Argument(Format = "{value}")] public string PodName => Get<string>(() => PodName);
    /// <summary>Container name. If omitted, the first container in the pod will be chosen.</summary>
    [Argument(Format = "--container={value}")] public string Container => Get<string>(() => Container);
    /// <summary>Pod name.</summary>
    [Argument(Format = "--pod={value}")] public string Pod => Get<string>(() => Pod);
    /// <summary>Pass stdin to the container.</summary>
    [Argument(Format = "--stdin={value}")] public bool? Stdin => Get<bool?>(() => Stdin);
    /// <summary>Stdin is a TTY.</summary>
    [Argument(Format = "--tty={value}")] public bool? Tty => Get<bool?>(() => Tty);
    /// <summary></summary>
    [Argument(Format = "-- {value}", Position = -2)] public string Command => Get<string>(() => Command);
    /// <summary></summary>
    [Argument(Format = "{value}", Position = -1)] public IReadOnlyList<string> Arguments => Get<List<string>>(() => Arguments);
}
#endregion
#region KubernetesRollingUpdateSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesRollingUpdate(Nuke.Common.Tools.Kubernetes.KubernetesRollingUpdateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesRollingUpdate), Arguments = "rolling-update")]
public partial class KubernetesRollingUpdateSettings : KubernetesOptionsBase
{
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>Container name which will have its image upgraded. Only relevant when --image is specified, ignored otherwise. Required when using --image on a multi-container pod.</summary>
    [Argument(Format = "--container={value}")] public string Container => Get<string>(() => Container);
    /// <summary>The key to use to differentiate between two different controllers, default 'deployment'.  Only relevant when --image is specified, ignored otherwise.</summary>
    [Argument(Format = "--deployment-label-key={value}")] public string DeploymentLabelKey => Get<string>(() => DeploymentLabelKey);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Filename or URL to file to use to create the new replication controller.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>Image to use for upgrading the replication controller. Must be distinct from the existing image (either new image or new image tag).  Can not be used with --filename/-f.</summary>
    [Argument(Format = "--image={value}")] public string Image => Get<string>(() => Image);
    /// <summary>Explicit policy for when to pull container images. Required when --image is same as existing image, ignored otherwise.</summary>
    [Argument(Format = "--image-pull-policy={value}")] public string ImagePullPolicy => Get<string>(() => ImagePullPolicy);
    /// <summary>Output format. One of: json|yaml|name|go-template-file|templatefile|template|go-template|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesRollingUpdateOutput Output => Get<KubernetesRollingUpdateOutput>(() => Output);
    /// <summary>Time delay between polling for replication controller status after the update. Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h".</summary>
    [Argument(Format = "--poll-interval={value}")] public TimeSpan? PollInterval => Get<TimeSpan?>(() => PollInterval);
    /// <summary>If true, this is a request to abort an existing rollout that is partially rolled out. It effectively reverses current and next and runs a rollout.</summary>
    [Argument(Format = "--rollback={value}")] public bool? Rollback => Get<bool?>(() => Rollback);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>Max time to wait for a replication controller to update before giving up. Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h".</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
    /// <summary>Time to wait between updating pods. Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h".</summary>
    [Argument(Format = "--update-period={value}")] public TimeSpan? UpdatePeriod => Get<TimeSpan?>(() => UpdatePeriod);
    /// <summary>If true, use a schema to validate the input before sending it.</summary>
    [Argument(Format = "--validate={value}")] public bool? Validate => Get<bool?>(() => Validate);
}
#endregion
#region KubernetesLabelSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesLabel(Nuke.Common.Tools.Kubernetes.KubernetesLabelSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesLabel), Arguments = "label")]
public partial class KubernetesLabelSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the ressource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>The Labels to set.</summary>
    [Argument(Format = "{key}={value}", Separator = " ")] public IReadOnlyDictionary<string, string> Labels => Get<Dictionary<string, string>>(() => Labels);
    /// <summary>Select all resources, including uninitialized ones, in the namespace of the specified resource types.</summary>
    [Argument(Format = "--all={value}")] public bool? All => Get<bool?>(() => All);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Selector (field query) to filter on, supports '=', '==', and '!='.(e.g. --field-selector key1=value1,key2=value2). The server only supports a limited number of field queries per type.</summary>
    [Argument(Format = "--field-selector={value}")] public string FieldSelector => Get<string>(() => FieldSelector);
    /// <summary>Filename, directory, or URL to files identifying the resource to update the labels.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>If true, the kubectl command applies to uninitialized objects. If explicitly set to false, this flag overrides other flags that make the kubectl commands apply to uninitialized objects, e.g., "--all". Objects with empty metadata.initializers are regarded as initialized.</summary>
    [Argument(Format = "--include-uninitialized={value}")] public bool? IncludeUninitialized => Get<bool?>(() => IncludeUninitialized);
    /// <summary>If true, display the labels for a given resource.</summary>
    [Argument(Format = "--list={value}")] public bool? List => Get<bool?>(() => List);
    /// <summary>If true, label will NOT contact api-server but run locally.</summary>
    [Argument(Format = "--local={value}")] public bool? Local => Get<bool?>(() => Local);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesLabelOutput Output => Get<KubernetesLabelOutput>(() => Output);
    /// <summary>If true, allow labels to be overwritten, otherwise reject label updates that overwrite existing labels.</summary>
    [Argument(Format = "--overwrite={value}")] public bool? Overwrite => Get<bool?>(() => Overwrite);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>If non-empty, the labels update will only succeed if this is the current resource-version for the object. Only valid when specifying a single resource.</summary>
    [Argument(Format = "--resource-version={value}")] public string ResourceVersion => Get<string>(() => ResourceVersion);
    /// <summary>Selector (label query) to filter on, not including uninitialized ones, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
}
#endregion
#region KubernetesAnnotateSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesAnnotate(Nuke.Common.Tools.Kubernetes.KubernetesAnnotateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesAnnotate), Arguments = "annotate")]
public partial class KubernetesAnnotateSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the ressource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>The annotations to set on the ressource</summary>
    [Argument(Format = "{key}={value}", Separator = " ")] public IReadOnlyDictionary<string, string> Annotations => Get<Dictionary<string, string>>(() => Annotations);
    /// <summary>Select all resources, including uninitialized ones, in the namespace of the specified resource types.</summary>
    [Argument(Format = "--all={value}")] public bool? All => Get<bool?>(() => All);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Selector (field query) to filter on, supports '=', '==', and '!='.(e.g. --field-selector key1=value1,key2=value2). The server only supports a limited number of field queries per type.</summary>
    [Argument(Format = "--field-selector={value}")] public string FieldSelector => Get<string>(() => FieldSelector);
    /// <summary>Filename, directory, or URL to files identifying the resource to update the annotation.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>If true, the kubectl command applies to uninitialized objects. If explicitly set to false, this flag overrides other flags that make the kubectl commands apply to uninitialized objects, e.g., "--all". Objects with empty metadata.initializers are regarded as initialized.</summary>
    [Argument(Format = "--include-uninitialized={value}")] public bool? IncludeUninitialized => Get<bool?>(() => IncludeUninitialized);
    /// <summary>If true, annotation will NOT contact api-server but run locally.</summary>
    [Argument(Format = "--local={value}")] public bool? Local => Get<bool?>(() => Local);
    /// <summary>Output format. One of: json|yaml|name|templatefile|template|go-template|go-template-file|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesAnnotateOutput Output => Get<KubernetesAnnotateOutput>(() => Output);
    /// <summary>If true, allow annotations to be overwritten, otherwise reject annotation updates that overwrite existing annotations.</summary>
    [Argument(Format = "--overwrite={value}")] public bool? Overwrite => Get<bool?>(() => Overwrite);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>If non-empty, the annotation update will only succeed if this is the current resource-version for the object. Only valid when specifying a single resource.</summary>
    [Argument(Format = "--resource-version={value}")] public string ResourceVersion => Get<string>(() => ResourceVersion);
    /// <summary>Selector (label query) to filter on, not including uninitialized ones, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
}
#endregion
#region KubernetesDeleteSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesDelete(Nuke.Common.Tools.Kubernetes.KubernetesDeleteSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesDelete), Arguments = "delete")]
public partial class KubernetesDeleteSettings : KubernetesOptionsBase
{
    /// <summary>The type (and name) of the resource. When only specifying a type either a --selector or --all needs to be specified</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>Delete all resources, including uninitialized ones, in the namespace of the specified resource types.</summary>
    [Argument(Format = "--all={value}")] public bool? All => Get<bool?>(() => All);
    /// <summary>If true, cascade the deletion of the resources managed by this resource (e.g. Pods created by a ReplicationController).  Default true.</summary>
    [Argument(Format = "--cascade={value}")] public bool? Cascade => Get<bool?>(() => Cascade);
    /// <summary>Selector (field query) to filter on, supports '=', '==', and '!='.(e.g. --field-selector key1=value1,key2=value2). The server only supports a limited number of field queries per type.</summary>
    [Argument(Format = "--field-selector={value}")] public string FieldSelector => Get<string>(() => FieldSelector);
    /// <summary>containing the resource to delete.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>Only used when grace-period=0. If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.</summary>
    [Argument(Format = "--force={value}")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Period of time in seconds given to the resource to terminate gracefully. Ignored if negative. Set to 1 for immediate shutdown. Can only be set to 0 when --force is true (force deletion).</summary>
    [Argument(Format = "--grace-period={value}")] public int? GracePeriod => Get<int?>(() => GracePeriod);
    /// <summary>Treat "resource not found" as a successful delete. Defaults to "true" when --all is specified.</summary>
    [Argument(Format = "--ignore-not-found={value}")] public bool? IgnoreNotFound => Get<bool?>(() => IgnoreNotFound);
    /// <summary>If true, the kubectl command applies to uninitialized objects. If explicitly set to false, this flag overrides other flags that make the kubectl commands apply to uninitialized objects, e.g., "--all". Objects with empty metadata.initializers are regarded as initialized.</summary>
    [Argument(Format = "--include-uninitialized={value}")] public bool? IncludeUninitialized => Get<bool?>(() => IncludeUninitialized);
    /// <summary>If true, resources are signaled for immediate shutdown (same as --grace-period=1).</summary>
    [Argument(Format = "--now={value}")] public bool? Now => Get<bool?>(() => Now);
    /// <summary>Output mode. Use "-o name" for shorter output (resource/name).</summary>
    [Argument(Format = "--output={value}")] public string Output => Get<string>(() => Output);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Selector (label query) to filter on, not including uninitialized ones.</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>The length of time to wait before giving up on a delete, zero means determine a timeout from the size of the object.</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
    /// <summary>If true, wait for resources to be gone before returning. This waits for finalizers.</summary>
    [Argument(Format = "--wait={value}")] public bool? Wait => Get<bool?>(() => Wait);
}
#endregion
#region KubernetesExposeSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesExpose(Nuke.Common.Tools.Kubernetes.KubernetesExposeSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesExpose), Arguments = "expose")]
public partial class KubernetesExposeSettings : KubernetesOptionsBase
{
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>ClusterIP to be assigned to the service. Leave empty to auto-allocate, or set to 'None' to create a headless service.</summary>
    [Argument(Format = "--cluster-ip={value}")] public string ClusterIp => Get<string>(() => ClusterIp);
    /// <summary>Synonym for --target-port.</summary>
    [Argument(Format = "--container-port={value}")] public string ContainerPort => Get<string>(() => ContainerPort);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Additional external IP address (not managed by Kubernetes) to accept for the service. If this IP is routed to a node, the service can be accessed by this IP in addition to its generated service IP.</summary>
    [Argument(Format = "--external-ip={value}")] public string ExternalIp => Get<string>(() => ExternalIp);
    /// <summary>Filename, directory, or URL to files identifying the resource to expose a service.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>The name of the API generator to use. There are 2 generators: 'service/v1' and 'service/v2'. The only difference between them is that service port in v1 is named 'default', while it is left unnamed in v2. Default is 'service/v2'.</summary>
    [Argument(Format = "--generator={value}")] public string Generator => Get<string>(() => Generator);
    /// <summary>Labels to apply to the service created by this call.</summary>
    [Argument(Format = "--labels={value}")] public string Labels => Get<string>(() => Labels);
    /// <summary>IP to assign to the LoadBalancer. If empty, an ephemeral IP will be created and used (cloud-provider specific).</summary>
    [Argument(Format = "--load-balancer-ip={value}")] public string LoadBalancerIp => Get<string>(() => LoadBalancerIp);
    /// <summary>The name for the newly created object.</summary>
    [Argument(Format = "--name={value}")] public string Name => Get<string>(() => Name);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesExposeOutput Output => Get<KubernetesExposeOutput>(() => Output);
    /// <summary>An inline JSON override for the generated object. If this is non-empty, it is used to override the generated object. Requires that the object supply a valid apiVersion field.</summary>
    [Argument(Format = "--overrides={value}")] public string Overrides => Get<string>(() => Overrides);
    /// <summary>The port that the service should serve on. Copied from the resource being exposed, if unspecified.</summary>
    [Argument(Format = "--port={value}")] public string Port => Get<string>(() => Port);
    /// <summary>The network protocol for the service to be created. Default is 'TCP'.</summary>
    [Argument(Format = "--protocol={value}")] public string Protocol => Get<string>(() => Protocol);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.</summary>
    [Argument(Format = "--save-config={value}")] public bool? SaveConfig => Get<bool?>(() => SaveConfig);
    /// <summary>A label selector to use for this service. Only equality-based selector requirements are supported. If empty (the default) infer the selector from the replication controller or replica set.).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>If non-empty, set the session affinity for the service to this; legal values: 'None', 'ClientIP'.</summary>
    [Argument(Format = "--session-affinity={value}")] public string SessionAffinity => Get<string>(() => SessionAffinity);
    /// <summary>Name or number for the port on the container that the service should direct traffic to. Optional.</summary>
    [Argument(Format = "--target-port={value}")] public string TargetPort => Get<string>(() => TargetPort);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>Type for this service: ClusterIP, NodePort, LoadBalancer, or ExternalName. Default is 'ClusterIP'.</summary>
    [Argument(Format = "--type={value}")] public string Type => Get<string>(() => Type);
}
#endregion
#region KubernetesOptionsSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesOptions(Nuke.Common.Tools.Kubernetes.KubernetesOptionsSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesOptions), Arguments = "options")]
public partial class KubernetesOptionsSettings : KubernetesOptionsBase
{
}
#endregion
#region KubernetesAttachSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesAttach(Nuke.Common.Tools.Kubernetes.KubernetesAttachSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesAttach), Arguments = "attach")]
public partial class KubernetesAttachSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the pod.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> Pod => Get<List<string>>(() => Pod);
    /// <summary>Container name. If omitted, the first container in the pod will be chosen.</summary>
    [Argument(Format = "--container={value}")] public string Container => Get<string>(() => Container);
    /// <summary>The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running.</summary>
    [Argument(Format = "--pod-running-timeout={value}")] public TimeSpan? PodRunningTimeout => Get<TimeSpan?>(() => PodRunningTimeout);
    /// <summary>Pass stdin to the container.</summary>
    [Argument(Format = "--stdin={value}")] public bool? Stdin => Get<bool?>(() => Stdin);
    /// <summary>Stdin is a TTY.</summary>
    [Argument(Format = "--tty={value}")] public bool? Tty => Get<bool?>(() => Tty);
}
#endregion
#region KubernetesProxySettings
/// <inheritdoc cref="KubernetesTasks.KubernetesProxy(Nuke.Common.Tools.Kubernetes.KubernetesProxySettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesProxy), Arguments = "proxy")]
public partial class KubernetesProxySettings : KubernetesOptionsBase
{
    /// <summary>Regular expression for hosts that the proxy should accept.</summary>
    [Argument(Format = "--accept-hosts={value}")] public string AcceptHosts => Get<string>(() => AcceptHosts);
    /// <summary>Regular expression for paths that the proxy should accept.</summary>
    [Argument(Format = "--accept-paths={value}")] public string AcceptPaths => Get<string>(() => AcceptPaths);
    /// <summary>The IP address on which to serve on.</summary>
    [Argument(Format = "--address={value}")] public string Address => Get<string>(() => Address);
    /// <summary>Prefix to serve the proxied API under.</summary>
    [Argument(Format = "--api-prefix={value}")] public string ApiPrefix => Get<string>(() => ApiPrefix);
    /// <summary>If true, disable request filtering in the proxy. This is dangerous, and can leave you vulnerable to XSRF attacks, when used with an accessible port.</summary>
    [Argument(Format = "--disable-filter={value}")] public bool? DisableFilter => Get<bool?>(() => DisableFilter);
    /// <summary>The port on which to run the proxy. Set to 0 to pick a random port.</summary>
    [Argument(Format = "--port={value}")] public int? Port => Get<int?>(() => Port);
    /// <summary>Regular expression for HTTP methods that the proxy should reject (example --reject-methods='POST,PUT,PATCH'). .</summary>
    [Argument(Format = "--reject-methods={value}")] public string RejectMethods => Get<string>(() => RejectMethods);
    /// <summary>Regular expression for paths that the proxy should reject. Paths specified here will be rejected even accepted by --accept-paths.</summary>
    [Argument(Format = "--reject-paths={value}")] public string RejectPaths => Get<string>(() => RejectPaths);
    /// <summary>Unix socket on which to run the proxy.</summary>
    [Argument(Format = "--unix-socket={value}")] public string UnixSocket => Get<string>(() => UnixSocket);
    /// <summary>Also serve static files from the given directory under the specified prefix.</summary>
    [Argument(Format = "--www={value}")] public string Www => Get<string>(() => Www);
    /// <summary>Prefix to serve static files under, if static file directory is specified.</summary>
    [Argument(Format = "--www-prefix={value}")] public string WwwPrefix => Get<string>(() => WwwPrefix);
}
#endregion
#region KubernetesAlphaSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesAlpha(Nuke.Common.Tools.Kubernetes.KubernetesAlphaSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesAlpha), Arguments = "alpha")]
public partial class KubernetesAlphaSettings : KubernetesOptionsBase
{
}
#endregion
#region KubernetesSettings
/// <inheritdoc cref="KubernetesTasks.Kubernetes(Nuke.Common.Tools.Kubernetes.KubernetesSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.Kubernetes), Arguments = "kubectl")]
public partial class KubernetesSettings : KubernetesOptionsBase
{
}
#endregion
#region KubernetesCompletionSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesCompletion(Nuke.Common.Tools.Kubernetes.KubernetesCompletionSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesCompletion), Arguments = "completion")]
public partial class KubernetesCompletionSettings : KubernetesOptionsBase
{
}
#endregion
#region KubernetesPatchSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesPatch(Nuke.Common.Tools.Kubernetes.KubernetesPatchSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesPatch), Arguments = "patch")]
public partial class KubernetesPatchSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the ressource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Filename, directory, or URL to files identifying the resource to update.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>If true, patch will operate on the content of the file, not the server-side resource.</summary>
    [Argument(Format = "--local={value}")] public bool? Local => Get<bool?>(() => Local);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesPatchOutput Output => Get<KubernetesPatchOutput>(() => Output);
    /// <summary>The patch to be applied to the resource JSON file.</summary>
    [Argument(Format = "--patch={value}")] public string Patch => Get<string>(() => Patch);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>The type of patch being provided; one of [json merge strategic].</summary>
    [Argument(Format = "--type={value}")] public KubernetesPatchType Type => Get<KubernetesPatchType>(() => Type);
}
#endregion
#region KubernetesReplaceSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesReplace(Nuke.Common.Tools.Kubernetes.KubernetesReplaceSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesReplace), Arguments = "replace")]
public partial class KubernetesReplaceSettings : KubernetesOptionsBase
{
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>If true, cascade the deletion of the resources managed by this resource (e.g. Pods created by a ReplicationController).  Default true.</summary>
    [Argument(Format = "--cascade={value}")] public bool? Cascade => Get<bool?>(() => Cascade);
    /// <summary>to use to replace the resource.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>Only used when grace-period=0. If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.</summary>
    [Argument(Format = "--force={value}")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Period of time in seconds given to the resource to terminate gracefully. Ignored if negative. Set to 1 for immediate shutdown. Can only be set to 0 when --force is true (force deletion).</summary>
    [Argument(Format = "--grace-period={value}")] public int? GracePeriod => Get<int?>(() => GracePeriod);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesReplaceOutput Output => Get<KubernetesReplaceOutput>(() => Output);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.</summary>
    [Argument(Format = "--save-config={value}")] public bool? SaveConfig => Get<bool?>(() => SaveConfig);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>The length of time to wait before giving up on a delete, zero means determine a timeout from the size of the object.</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
    /// <summary>If true, use a schema to validate the input before sending it.</summary>
    [Argument(Format = "--validate={value}")] public bool? Validate => Get<bool?>(() => Validate);
    /// <summary>If true, wait for resources to be gone before returning. This waits for finalizers.</summary>
    [Argument(Format = "--wait={value}")] public bool? Wait => Get<bool?>(() => Wait);
}
#endregion
#region KubernetesTaintSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesTaint(Nuke.Common.Tools.Kubernetes.KubernetesTaintSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesTaint), Arguments = "taint")]
public partial class KubernetesTaintSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the ressource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>The taint effects to set.</summary>
    [Argument(Format = "{key}={value}", Separator = " ")] public IReadOnlyDictionary<string, string> TaintEffects => Get<Dictionary<string, string>>(() => TaintEffects);
    /// <summary>Select all nodes in the cluster.</summary>
    [Argument(Format = "--all={value}")] public bool? All => Get<bool?>(() => All);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesTaintOutput Output => Get<KubernetesTaintOutput>(() => Output);
    /// <summary>If true, allow taints to be overwritten, otherwise reject taint updates that overwrite existing taints.</summary>
    [Argument(Format = "--overwrite={value}")] public bool? Overwrite => Get<bool?>(() => Overwrite);
    /// <summary>Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>If true, use a schema to validate the input before sending it.</summary>
    [Argument(Format = "--validate={value}")] public bool? Validate => Get<bool?>(() => Validate);
}
#endregion
#region KubernetesDescribeSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesDescribe(Nuke.Common.Tools.Kubernetes.KubernetesDescribeSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesDescribe), Arguments = "describe")]
public partial class KubernetesDescribeSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the ressource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>If present, list the requested object(s) across all namespaces. Namespace in current context is ignored even if specified with --namespace.</summary>
    [Argument(Format = "--all-namespaces={value}")] public bool? AllNamespaces => Get<bool?>(() => AllNamespaces);
    /// <summary>Filename, directory, or URL to files containing the resource to describe.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>If true, the kubectl command applies to uninitialized objects. If explicitly set to false, this flag overrides other flags that make the kubectl commands apply to uninitialized objects, e.g., "--all". Objects with empty metadata.initializers are regarded as initialized.</summary>
    [Argument(Format = "--include-uninitialized={value}")] public bool? IncludeUninitialized => Get<bool?>(() => IncludeUninitialized);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>If true, display events related to the described object.</summary>
    [Argument(Format = "--show-events={value}")] public bool? ShowEvents => Get<bool?>(() => ShowEvents);
}
#endregion
#region KubernetesSetSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesSet(Nuke.Common.Tools.Kubernetes.KubernetesSetSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesSet), Arguments = "set")]
public partial class KubernetesSetSettings : KubernetesOptionsBase
{
    /// <summary>The subcommand to run.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> Subcommand => Get<List<string>>(() => Subcommand);
}
#endregion
#region KubernetesAuthSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesAuth(Nuke.Common.Tools.Kubernetes.KubernetesAuthSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesAuth), Arguments = "auth")]
public partial class KubernetesAuthSettings : KubernetesOptionsBase
{
    /// <summary>The subcommand to run.</summary>
    [Argument(Format = "{value}")] public string Subcommand => Get<string>(() => Subcommand);
}
#endregion
#region KubernetesCertificateSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesCertificate(Nuke.Common.Tools.Kubernetes.KubernetesCertificateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesCertificate), Arguments = "certificate")]
public partial class KubernetesCertificateSettings : KubernetesOptionsBase
{
    /// <summary>The subcommand to run.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> Subcommand => Get<List<string>>(() => Subcommand);
}
#endregion
#region KubernetesRolloutSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesRollout(Nuke.Common.Tools.Kubernetes.KubernetesRolloutSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesRollout), Arguments = "rollout")]
public partial class KubernetesRolloutSettings : KubernetesOptionsBase
{
    /// <summary>The subcommand to run.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> Subcommand => Get<List<string>>(() => Subcommand);
}
#endregion
#region KubernetesApplySettings
/// <inheritdoc cref="KubernetesTasks.KubernetesApply(Nuke.Common.Tools.Kubernetes.KubernetesApplySettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesApply), Arguments = "apply")]
public partial class KubernetesApplySettings : KubernetesOptionsBase
{
    /// <summary>Select all resources in the namespace of the specified resource types.</summary>
    [Argument(Format = "--all={value}")] public bool? All => Get<bool?>(() => All);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>If true, cascade the deletion of the resources managed by this resource (e.g. Pods created by a ReplicationController).  Default true.</summary>
    [Argument(Format = "--cascade={value}")] public bool? Cascade => Get<bool?>(() => Cascade);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>that contains the configuration to apply.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>Only used when grace-period=0. If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.</summary>
    [Argument(Format = "--force={value}")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Period of time in seconds given to the resource to terminate gracefully. Ignored if negative. Set to 1 for immediate shutdown. Can only be set to 0 when --force is true (force deletion).</summary>
    [Argument(Format = "--grace-period={value}")] public int? GracePeriod => Get<int?>(() => GracePeriod);
    /// <summary>If true, the kubectl command applies to uninitialized objects. If explicitly set to false, this flag overrides other flags that make the kubectl commands apply to uninitialized objects, e.g., "--all". Objects with empty metadata.initializers are regarded as initialized.</summary>
    [Argument(Format = "--include-uninitialized={value}")] public bool? IncludeUninitialized => Get<bool?>(() => IncludeUninitialized);
    /// <summary>If true, use openapi to calculate diff when the openapi presents and the resource can be found in the openapi spec. Otherwise, fall back to use baked-in types.</summary>
    [Argument(Format = "--openapi-patch={value}")] public bool? OpenapiPatch => Get<bool?>(() => OpenapiPatch);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesApplyOutput Output => Get<KubernetesApplyOutput>(() => Output);
    /// <summary>Automatically resolve conflicts between the modified and live configuration by using values from the modified configuration.</summary>
    [Argument(Format = "--overwrite={value}")] public bool? Overwrite => Get<bool?>(() => Overwrite);
    /// <summary>Automatically delete resource objects, including the uninitialized ones, that do not appear in the configs and are created by either apply or create --save-config. Should be used with either -l or --all.</summary>
    [Argument(Format = "--prune={value}")] public bool? Prune => Get<bool?>(() => Prune);
    /// <summary>Overwrite the default whitelist with &lt;group/version/kind&gt; for --prune.</summary>
    [Argument(Format = "--prune-whitelist={value}")] public IReadOnlyList<string> PruneWhitelist => Get<List<string>>(() => PruneWhitelist);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>The length of time to wait before giving up on a delete, zero means determine a timeout from the size of the object.</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
    /// <summary>If true, use a schema to validate the input before sending it.</summary>
    [Argument(Format = "--validate={value}")] public bool? Validate => Get<bool?>(() => Validate);
    /// <summary>If true, wait for resources to be gone before returning. This waits for finalizers.</summary>
    [Argument(Format = "--wait={value}")] public bool? Wait => Get<bool?>(() => Wait);
}
#endregion
#region KubernetesApplyKustomizeSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesApplyKustomize(Nuke.Common.Tools.Kubernetes.KubernetesApplyKustomizeSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesApplyKustomize), Arguments = "apply -k")]
public partial class KubernetesApplyKustomizeSettings : KubernetesOptionsBase
{
    /// <summary>Set the target folder of the kustomize files.</summary>
    [Argument(Format = "{value}")] public string Kustomize => Get<string>(() => Kustomize);
    /// <summary>Select all resources in the namespace of the specified resource types.</summary>
    [Argument(Format = "--all={value}")] public bool? All => Get<bool?>(() => All);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>If true, cascade the deletion of the resources managed by this resource (e.g. Pods created by a ReplicationController).  Default true.</summary>
    [Argument(Format = "--cascade={value}")] public bool? Cascade => Get<bool?>(() => Cascade);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>that contains the configuration to apply.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>Only used when grace-period=0. If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.</summary>
    [Argument(Format = "--force={value}")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>Period of time in seconds given to the resource to terminate gracefully. Ignored if negative. Set to 1 for immediate shutdown. Can only be set to 0 when --force is true (force deletion).</summary>
    [Argument(Format = "--grace-period={value}")] public int? GracePeriod => Get<int?>(() => GracePeriod);
    /// <summary>If true, the kubectl command applies to uninitialized objects. If explicitly set to false, this flag overrides other flags that make the kubectl commands apply to uninitialized objects, e.g., "--all". Objects with empty metadata.initializers are regarded as initialized.</summary>
    [Argument(Format = "--include-uninitialized={value}")] public bool? IncludeUninitialized => Get<bool?>(() => IncludeUninitialized);
    /// <summary>If true, use openapi to calculate diff when the openapi presents and the resource can be found in the openapi spec. Otherwise, fall back to use baked-in types.</summary>
    [Argument(Format = "--openapi-patch={value}")] public bool? OpenapiPatch => Get<bool?>(() => OpenapiPatch);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesApplyOutput Output => Get<KubernetesApplyOutput>(() => Output);
    /// <summary>Automatically resolve conflicts between the modified and live configuration by using values from the modified configuration.</summary>
    [Argument(Format = "--overwrite={value}")] public bool? Overwrite => Get<bool?>(() => Overwrite);
    /// <summary>Automatically delete resource objects, including the uninitialized ones, that do not appear in the configs and are created by either apply or create --save-config. Should be used with either -l or --all.</summary>
    [Argument(Format = "--prune={value}")] public bool? Prune => Get<bool?>(() => Prune);
    /// <summary>Overwrite the default whitelist with &lt;group/version/kind&gt; for --prune.</summary>
    [Argument(Format = "--prune-whitelist={value}")] public IReadOnlyList<string> PruneWhitelist => Get<List<string>>(() => PruneWhitelist);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>The length of time to wait before giving up on a delete, zero means determine a timeout from the size of the object.</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
    /// <summary>If true, use a schema to validate the input before sending it.</summary>
    [Argument(Format = "--validate={value}")] public bool? Validate => Get<bool?>(() => Validate);
    /// <summary>If true, wait for resources to be gone before returning. This waits for finalizers.</summary>
    [Argument(Format = "--wait={value}")] public bool? Wait => Get<bool?>(() => Wait);
}
#endregion
#region KubernetesCordonSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesCordon(Nuke.Common.Tools.Kubernetes.KubernetesCordonSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesCordon), Arguments = "cordon")]
public partial class KubernetesCordonSettings : KubernetesOptionsBase
{
    /// <summary>The namne of the Node.</summary>
    [Argument(Format = "{value}")] public string Node => Get<string>(() => Node);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Selector (label query) to filter on.</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
}
#endregion
#region KubernetesCpSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesCp(Nuke.Common.Tools.Kubernetes.KubernetesCpSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesCp), Arguments = "cp")]
public partial class KubernetesCpSettings : KubernetesOptionsBase
{
    /// <summary>The file specification of the source. '[namespace/]pod-name:/file/path'. for a remote file '/file/path' for a local file.</summary>
    [Argument(Format = "{value}")] public string SrcFileSpec => Get<string>(() => SrcFileSpec);
    /// <summary>The file specification of the destination. '[namespace/]pod-name:/file/path'. for a remote file '/file/path' for a local file.</summary>
    [Argument(Format = "{value}")] public string DestFileSpec => Get<string>(() => DestFileSpec);
    /// <summary>Container name. If omitted, the first container in the pod will be chosen.</summary>
    [Argument(Format = "--container={value}")] public string Container => Get<string>(() => Container);
}
#endregion
#region KubernetesApiVersionsSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesApiVersions(Nuke.Common.Tools.Kubernetes.KubernetesApiVersionsSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesApiVersions), Arguments = "api-versions")]
public partial class KubernetesApiVersionsSettings : KubernetesOptionsBase
{
}
#endregion
#region KubernetesUncordonSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesUncordon(Nuke.Common.Tools.Kubernetes.KubernetesUncordonSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesUncordon), Arguments = "uncordon")]
public partial class KubernetesUncordonSettings : KubernetesOptionsBase
{
    /// <summary>The name of the node.</summary>
    [Argument(Format = "{value}")] public string Node => Get<string>(() => Node);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Selector (label query) to filter on.</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
}
#endregion
#region KubernetesAutoscaleSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesAutoscale(Nuke.Common.Tools.Kubernetes.KubernetesAutoscaleSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesAutoscale), Arguments = "autoscale")]
public partial class KubernetesAutoscaleSettings : KubernetesOptionsBase
{
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>The target average CPU utilization (represented as a percent of requested CPU) over all the pods. If it's not specified or negative, a default autoscaling policy will be used.</summary>
    [Argument(Format = "--cpu-percent={value}")] public int? CpuPercent => Get<int?>(() => CpuPercent);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Filename, directory, or URL to files identifying the resource to autoscale.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>The name of the API generator to use. Currently there is only 1 generator.</summary>
    [Argument(Format = "--generator={value}")] public string Generator => Get<string>(() => Generator);
    /// <summary>The upper limit for the number of pods that can be set by the autoscaler. Required.</summary>
    [Argument(Format = "--max={value}")] public int? Max => Get<int?>(() => Max);
    /// <summary>The lower limit for the number of pods that can be set by the autoscaler. If it's not specified or negative, the server will apply a default value.</summary>
    [Argument(Format = "--min={value}")] public int? Min => Get<int?>(() => Min);
    /// <summary>The name for the newly created object. If not specified, the name of the input resource will be used.</summary>
    [Argument(Format = "--name={value}")] public string Name => Get<string>(() => Name);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesAutoscaleOutput Output => Get<KubernetesAutoscaleOutput>(() => Output);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.</summary>
    [Argument(Format = "--save-config={value}")] public bool? SaveConfig => Get<bool?>(() => SaveConfig);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
}
#endregion
#region KubernetesPluginSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesPlugin(Nuke.Common.Tools.Kubernetes.KubernetesPluginSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesPlugin), Arguments = "plugin")]
public partial class KubernetesPluginSettings : KubernetesOptionsBase
{
    /// <summary>The name of the plugin.</summary>
    [Argument(Format = "{value}")] public string Name => Get<string>(() => Name);
}
#endregion
#region KubernetesClusterInfoSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesClusterInfo(Nuke.Common.Tools.Kubernetes.KubernetesClusterInfoSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesClusterInfo), Arguments = "cluster-info")]
public partial class KubernetesClusterInfoSettings : KubernetesOptionsBase
{
}
#endregion
#region KubernetesWaitSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesWait(Nuke.Common.Tools.Kubernetes.KubernetesWaitSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesWait), Arguments = "wait")]
public partial class KubernetesWaitSettings : KubernetesOptionsBase
{
    /// <summary>If present, list the requested object(s) across all namespaces. Namespace in current context is ignored even if specified with --namespace.</summary>
    [Argument(Format = "--all-namespaces={value}")] public bool? AllNamespaces => Get<bool?>(() => AllNamespaces);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>identifying the resource.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>The condition to wait on: [delete|condition=condition-name].</summary>
    [Argument(Format = "--for={value}")] public string For => Get<string>(() => For);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesWaitOutput Output => Get<KubernetesWaitOutput>(() => Output);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>The length of time to wait before giving up.  Zero means check once and don't wait, negative means wait for a week.</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
}
#endregion
#region KubernetesConvertSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesConvert(Nuke.Common.Tools.Kubernetes.KubernetesConvertSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesConvert), Arguments = "convert")]
public partial class KubernetesConvertSettings : KubernetesOptionsBase
{
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>Filename, directory, or URL to files to need to get converted.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>If true, convert will NOT try to contact api-server but run locally.</summary>
    [Argument(Format = "--local={value}")] public bool? Local => Get<bool?>(() => Local);
    /// <summary>Output format. One of: json|yaml|name|go-template|go-template-file|templatefile|template|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesConvertOutput Output => Get<KubernetesConvertOutput>(() => Output);
    /// <summary>Output the formatted object with the given group version (for ex: 'extensions/v1beta1').).</summary>
    [Argument(Format = "--output-version={value}")] public string OutputVersion => Get<string>(() => OutputVersion);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>If true, use a schema to validate the input before sending it.</summary>
    [Argument(Format = "--validate={value}")] public bool? Validate => Get<bool?>(() => Validate);
}
#endregion
#region KubernetesCreateSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesCreate(Nuke.Common.Tools.Kubernetes.KubernetesCreateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesCreate), Arguments = "create")]
public partial class KubernetesCreateSettings : KubernetesOptionsBase
{
    /// <summary>The type (and name) of the resource. When only specifying a type either a --selector or --all needs to be specified</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Edit the API resource before creating.</summary>
    [Argument(Format = "--edit={value}")] public bool? Edit => Get<bool?>(() => Edit);
    /// <summary>Filename, directory, or URL to files to use to create the resource.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesCreateOutput Output => Get<KubernetesCreateOutput>(() => Output);
    /// <summary>Raw URI to POST to the server.  Uses the transport specified by the kubeconfig file.</summary>
    [Argument(Format = "--raw={value}")] public string Raw => Get<string>(() => Raw);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.</summary>
    [Argument(Format = "--save-config={value}")] public bool? SaveConfig => Get<bool?>(() => SaveConfig);
    /// <summary>Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>If true, use a schema to validate the input before sending it.</summary>
    [Argument(Format = "--validate={value}")] public bool? Validate => Get<bool?>(() => Validate);
    /// <summary>Only relevant if --edit=true. Defaults to the line ending native to your platform.</summary>
    [Argument(Format = "--windows-line-endings={value}")] public bool? WindowsLineEndings => Get<bool?>(() => WindowsLineEndings);
}
#endregion
#region KubernetesPortForwardSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesPortForward(Nuke.Common.Tools.Kubernetes.KubernetesPortForwardSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesPortForward), Arguments = "port-forward")]
public partial class KubernetesPortForwardSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the resource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>The port combinations to forward. In the Format 'srcPort:destPort'.</summary>
    [Argument(Format = "{key}={value}", Separator = " ")] public IReadOnlyDictionary<int, int> Ports => Get<Dictionary<int, int>>(() => Ports);
    /// <summary>The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running.</summary>
    [Argument(Format = "--pod-running-timeout={value}")] public TimeSpan? PodRunningTimeout => Get<TimeSpan?>(() => PodRunningTimeout);
}
#endregion
#region KubernetesRunContainerSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesRunContainer(Nuke.Common.Tools.Kubernetes.KubernetesRunContainerSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesRunContainer), Arguments = "run-container")]
public partial class KubernetesRunContainerSettings : KubernetesOptionsBase
{
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>If true, wait for the Pod to start running, and then attach to the Pod as if 'kubectl attach ...' were called.  Default false, unless '-i/--stdin' is set, in which case the default is true. With '--restart=Never' the exit code of the container process is returned.</summary>
    [Argument(Format = "--attach={value}")] public bool? Attach => Get<bool?>(() => Attach);
    /// <summary>If true, cascade the deletion of the resources managed by this resource (e.g. Pods created by a ReplicationController).  Default true.</summary>
    [Argument(Format = "--cascade={value}")] public bool? Cascade => Get<bool?>(() => Cascade);
    /// <summary>If true and extra arguments are present, use them as the 'command' field in the container, rather than the 'args' field which is the default.</summary>
    [Argument(Format = "--command={value}")] public bool? Command => Get<bool?>(() => Command);
    /// <summary>If true, only print the object that would be sent, without sending it.</summary>
    [Argument(Format = "--dry-run={value}")] public bool? DryRun => Get<bool?>(() => DryRun);
    /// <summary>Environment variables to set in the container.</summary>
    [Argument(Format = "--env={value}")] public IReadOnlyList<string> Env => Get<List<string>>(() => Env);
    /// <summary>If true, a public, external service is created for the container(s) which are run.</summary>
    [Argument(Format = "--expose={value}")] public bool? Expose => Get<bool?>(() => Expose);
    /// <summary>to use to replace the resource.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>Only used when grace-period=0. If true, immediately remove resources from API and bypass graceful deletion. Note that immediate deletion of some resources may result in inconsistency or data loss and requires confirmation.</summary>
    [Argument(Format = "--force={value}")] public bool? Force => Get<bool?>(() => Force);
    /// <summary>The name of the API generator to use, see http://kubernetes.io/docs/user-guide/kubectl-conventions/#generators for a list.</summary>
    [Argument(Format = "--generator={value}")] public string Generator => Get<string>(() => Generator);
    /// <summary>Period of time in seconds given to the resource to terminate gracefully. Ignored if negative. Set to 1 for immediate shutdown. Can only be set to 0 when --force is true (force deletion).</summary>
    [Argument(Format = "--grace-period={value}")] public int? GracePeriod => Get<int?>(() => GracePeriod);
    /// <summary>The host port mapping for the container port. To demonstrate a single-machine container.</summary>
    [Argument(Format = "--hostport={value}")] public int? Hostport => Get<int?>(() => Hostport);
    /// <summary>The image for the container to run.</summary>
    [Argument(Format = "--image={value}")] public string Image => Get<string>(() => Image);
    /// <summary>The image pull policy for the container. If left empty, this value will not be specified by the client and defaulted by the server.</summary>
    [Argument(Format = "--image-pull-policy={value}")] public string ImagePullPolicy => Get<string>(() => ImagePullPolicy);
    /// <summary>Comma separated labels to apply to the pod(s). Will override previous values.</summary>
    [Argument(Format = "--labels={value}")] public string Labels => Get<string>(() => Labels);
    /// <summary>If the pod is started in interactive mode or with stdin, leave stdin open after the first attach completes. By default, stdin will be closed after the first attach completes.</summary>
    [Argument(Format = "--leave-stdin-open={value}")] public bool? LeaveStdinOpen => Get<bool?>(() => LeaveStdinOpen);
    /// <summary>The resource requirement limits for this container.  For example, 'cpu=200m,memory=512Mi'.  Note that server side components may assign limits depending on the server configuration, such as limit ranges.</summary>
    [Argument(Format = "--limits={value}")] public string Limits => Get<string>(() => Limits);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesRunContainerOutput Output => Get<KubernetesRunContainerOutput>(() => Output);
    /// <summary>An inline JSON override for the generated object. If this is non-empty, it is used to override the generated object. Requires that the object supply a valid apiVersion field.</summary>
    [Argument(Format = "--overrides={value}")] public string Overrides => Get<string>(() => Overrides);
    /// <summary>The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running.</summary>
    [Argument(Format = "--pod-running-timeout={value}")] public TimeSpan? PodRunningTimeout => Get<TimeSpan?>(() => PodRunningTimeout);
    /// <summary>The port that this container exposes.  If --expose is true, this is also the port used by the service that is created.</summary>
    [Argument(Format = "--port={value}")] public string Port => Get<string>(() => Port);
    /// <summary>If true, suppress prompt messages.</summary>
    [Argument(Format = "--quiet={value}")] public bool? Quiet => Get<bool?>(() => Quiet);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>Number of replicas to create for this container. Default is 1.</summary>
    [Argument(Format = "--replicas={value}")] public int? Replicas => Get<int?>(() => Replicas);
    /// <summary>The resource requirement requests for this container.  For example, 'cpu=100m,memory=256Mi'.  Note that server side components may assign requests depending on the server configuration, such as limit ranges.</summary>
    [Argument(Format = "--requests={value}")] public string Requests => Get<string>(() => Requests);
    /// <summary>The restart policy for this Pod.  Legal values [Always, OnFailure, Never].  If set to 'Always' a deployment is created, if set to 'OnFailure' a job is created, if set to 'Never', a regular pod is created. For the latter two --replicas must be 1.  Default 'Always', for CronJobs `Never`.</summary>
    [Argument(Format = "--restart={value}")] public string Restart => Get<string>(() => Restart);
    /// <summary>If true, delete resources created in this command for attached containers.</summary>
    [Argument(Format = "--rm={value}")] public bool? Rm => Get<bool?>(() => Rm);
    /// <summary>If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.</summary>
    [Argument(Format = "--save-config={value}")] public bool? SaveConfig => Get<bool?>(() => SaveConfig);
    /// <summary>A schedule in the Cron format the job should be run with.</summary>
    [Argument(Format = "--schedule={value}")] public string Schedule => Get<string>(() => Schedule);
    /// <summary>The name of the generator to use for creating a service.  Only used if --expose is true.</summary>
    [Argument(Format = "--service-generator={value}")] public string ServiceGenerator => Get<string>(() => ServiceGenerator);
    /// <summary>An inline JSON override for the generated service object. If this is non-empty, it is used to override the generated object. Requires that the object supply a valid apiVersion field.  Only used if --expose is true.</summary>
    [Argument(Format = "--service-overrides={value}")] public string ServiceOverrides => Get<string>(() => ServiceOverrides);
    /// <summary>Service account to set in the pod spec.</summary>
    [Argument(Format = "--serviceaccount={value}")] public string Serviceaccount => Get<string>(() => Serviceaccount);
    /// <summary>Keep stdin open on the container(s) in the pod, even if nothing is attached.</summary>
    [Argument(Format = "--stdin={value}")] public bool? Stdin => Get<bool?>(() => Stdin);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>The length of time to wait before giving up on a delete, zero means determine a timeout from the size of the object.</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
    /// <summary>Allocated a TTY for each container in the pod.</summary>
    [Argument(Format = "--tty={value}")] public bool? Tty => Get<bool?>(() => Tty);
    /// <summary>If true, wait for resources to be gone before returning. This waits for finalizers.</summary>
    [Argument(Format = "--wait={value}")] public bool? Wait => Get<bool?>(() => Wait);
}
#endregion
#region KubernetesEditSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesEdit(Nuke.Common.Tools.Kubernetes.KubernetesEditSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesEdit), Arguments = "edit")]
public partial class KubernetesEditSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the ressource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>Filename, directory, or URL to files to use to edit the resource.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>If true, the kubectl command applies to uninitialized objects. If explicitly set to false, this flag overrides other flags that make the kubectl commands apply to uninitialized objects, e.g., "--all". Objects with empty metadata.initializers are regarded as initialized.</summary>
    [Argument(Format = "--include-uninitialized={value}")] public bool? IncludeUninitialized => Get<bool?>(() => IncludeUninitialized);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesEditOutput Output => Get<KubernetesEditOutput>(() => Output);
    /// <summary>Output the patch if the resource is edited.</summary>
    [Argument(Format = "--output-patch={value}")] public bool? OutputPatch => Get<bool?>(() => OutputPatch);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>If true, the configuration of current object will be saved in its annotation. Otherwise, the annotation will be unchanged. This flag is useful when you want to perform kubectl apply on this object in the future.</summary>
    [Argument(Format = "--save-config={value}")] public bool? SaveConfig => Get<bool?>(() => SaveConfig);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>If true, use a schema to validate the input before sending it.</summary>
    [Argument(Format = "--validate={value}")] public bool? Validate => Get<bool?>(() => Validate);
    /// <summary>Defaults to the line ending native to your platform.</summary>
    [Argument(Format = "--windows-line-endings={value}")] public bool? WindowsLineEndings => Get<bool?>(() => WindowsLineEndings);
}
#endregion
#region KubernetesScaleSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesScale(Nuke.Common.Tools.Kubernetes.KubernetesScaleSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesScale), Arguments = "scale")]
public partial class KubernetesScaleSettings : KubernetesOptionsBase
{
    /// <summary>Select all resources in the namespace of the specified resource types.</summary>
    [Argument(Format = "--all={value}")] public bool? All => Get<bool?>(() => All);
    /// <summary>If true, ignore any errors in templates when a field or map key is missing in the template. Only applies to golang and jsonpath output formats.</summary>
    [Argument(Format = "--allow-missing-template-keys={value}", Secret = false)] public bool? AllowMissingTemplateKeys => Get<bool?>(() => AllowMissingTemplateKeys);
    /// <summary>Precondition for current size. Requires that the current size of the resource match this value in order to scale.</summary>
    [Argument(Format = "--current-replicas={value}")] public int? CurrentReplicas => Get<int?>(() => CurrentReplicas);
    /// <summary>Filename, directory, or URL to files identifying the resource to set a new size.</summary>
    [Argument(Format = "--filename={value}", Separator = ",")] public IReadOnlyList<string> Filename => Get<List<string>>(() => Filename);
    /// <summary>Output format. One of: json|yaml|name|template|go-template|go-template-file|templatefile|jsonpath|jsonpath-file.</summary>
    [Argument(Format = "--output={value}")] public KubernetesScaleOutput Output => Get<KubernetesScaleOutput>(() => Output);
    /// <summary>Record current kubectl command in the resource annotation. If set to false, do not record the command. If set to true, record the command. If not set, default to updating the existing annotation value only if one already exists.</summary>
    [Argument(Format = "--record={value}")] public bool? Record => Get<bool?>(() => Record);
    /// <summary>Process the directory used in -f, --filename recursively. Useful when you want to manage related manifests organized within the same directory.</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>The new desired number of replicas. Required.</summary>
    [Argument(Format = "--replicas={value}")] public int? Replicas => Get<int?>(() => Replicas);
    /// <summary>Precondition for resource version. Requires that the current resource version match this value in order to scale.</summary>
    [Argument(Format = "--resource-version={value}")] public string ResourceVersion => Get<string>(() => ResourceVersion);
    /// <summary>Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2).</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>Template string or path to template file to use when -o=go-template, -o=go-template-file. The template format is golang templates [http://golang.org/pkg/text/template/#pkg-overview].</summary>
    [Argument(Format = "--template={value}")] public string Template => Get<string>(() => Template);
    /// <summary>The length of time to wait before giving up on a scale operation, zero means don't wait. Any other values should contain a corresponding time unit (e.g. 1s, 2m, 3h).</summary>
    [Argument(Format = "--timeout={value}")] public TimeSpan? Timeout => Get<TimeSpan?>(() => Timeout);
}
#endregion
#region KubernetesExplainSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesExplain(Nuke.Common.Tools.Kubernetes.KubernetesExplainSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesExplain), Arguments = "explain")]
public partial class KubernetesExplainSettings : KubernetesOptionsBase
{
    /// <summary>Get different explanations for particular API version.</summary>
    [Argument(Format = "--api-version={value}")] public string ApiVersion => Get<string>(() => ApiVersion);
    /// <summary>Print the fields of fields (Currently only 1 level deep).</summary>
    [Argument(Format = "--recursive={value}")] public bool? Recursive => Get<bool?>(() => Recursive);
    /// <summary>The type or/and name of the ressource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> Resource => Get<List<string>>(() => Resource);
}
#endregion
#region KubernetesLogsSettings
/// <inheritdoc cref="KubernetesTasks.KubernetesLogs(Nuke.Common.Tools.Kubernetes.KubernetesLogsSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KubernetesTasks), Command = nameof(KubernetesTasks.KubernetesLogs), Arguments = "logs")]
public partial class KubernetesLogsSettings : KubernetesOptionsBase
{
    /// <summary>The type or/and name of the ressource.</summary>
    [Argument(Format = "{value}", Separator = " ")] public IReadOnlyList<string> TypeName => Get<List<string>>(() => TypeName);
    /// <summary>Get all containers's logs in the pod(s).</summary>
    [Argument(Format = "--all-containers={value}")] public bool? AllContainers => Get<bool?>(() => AllContainers);
    /// <summary>Print the logs of this container.</summary>
    [Argument(Format = "--container={value}")] public string Container => Get<string>(() => Container);
    /// <summary>Specify if the logs should be streamed.</summary>
    [Argument(Format = "--follow={value}")] public bool? Follow => Get<bool?>(() => Follow);
    /// <summary>If true, prompt the user for input when required.</summary>
    [Argument(Format = "--interactive={value}")] public bool? Interactive => Get<bool?>(() => Interactive);
    /// <summary>Maximum bytes of logs to return. Defaults to no limit.</summary>
    [Argument(Format = "--limit-bytes={value}")] public long? LimitBytes => Get<long?>(() => LimitBytes);
    /// <summary>The length of time (like 5s, 2m, or 3h, higher than zero) to wait until at least one pod is running.</summary>
    [Argument(Format = "--pod-running-timeout={value}")] public TimeSpan? PodRunningTimeout => Get<TimeSpan?>(() => PodRunningTimeout);
    /// <summary>If true, print the logs for the previous instance of the container in a pod if it exists.</summary>
    [Argument(Format = "--previous={value}")] public bool? Previous => Get<bool?>(() => Previous);
    /// <summary>Selector (label query) to filter on.</summary>
    [Argument(Format = "--selector={value}")] public string Selector => Get<string>(() => Selector);
    /// <summary>Only return logs newer than a relative duration like 5s, 2m, or 3h. Defaults to all logs. Only one of since-time / since may be used.</summary>
    [Argument(Format = "--since={value}")] public TimeSpan? Since => Get<TimeSpan?>(() => Since);
    /// <summary>Only return logs after a specific date (RFC3339). Defaults to all logs. Only one of since-time / since may be used.</summary>
    [Argument(Format = "--since-time={value}")] public string SinceTime => Get<string>(() => SinceTime);
    /// <summary>Lines of recent log file to display. Defaults to -1 with no selector, showing all log lines otherwise 10, if a selector is provided.</summary>
    [Argument(Format = "--tail={value}")] public long? Tail => Get<long?>(() => Tail);
    /// <summary>Include timestamps on each line in the log output.</summary>
    [Argument(Format = "--timestamps={value}")] public bool? Timestamps => Get<bool?>(() => Timestamps);
}
#endregion
#region KubernetesOptionsBase
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public partial class KubernetesOptionsBase : ToolOptions
{
    /// <summary>log to standard error as well as files.</summary>
    [Argument(Format = "--alsologtostderr={value}")] public bool? Alsologtostderr => Get<bool?>(() => Alsologtostderr);
    /// <summary>Username to impersonate for the operation.</summary>
    [Argument(Format = "--as={value}")] public string As => Get<string>(() => As);
    /// <summary>Group to impersonate for the operation, this flag can be repeated to specify multiple groups.</summary>
    [Argument(Format = "--as-group={value}")] public IReadOnlyList<string> AsGroup => Get<List<string>>(() => AsGroup);
    /// <summary>Default HTTP cache directory.</summary>
    [Argument(Format = "--cache-dir={value}")] public string CacheDir => Get<string>(() => CacheDir);
    /// <summary>Path to a cert file for the certificate authority.</summary>
    [Argument(Format = "--certificate-authority={value}")] public string CertificateAuthority => Get<string>(() => CertificateAuthority);
    /// <summary>Path to a client certificate file for TLS.</summary>
    [Argument(Format = "--client-certificate={value}")] public string ClientCertificate => Get<string>(() => ClientCertificate);
    /// <summary>Path to a client key file for TLS.</summary>
    [Argument(Format = "--client-key={value}")] public string ClientKey => Get<string>(() => ClientKey);
    /// <summary>The name of the kubeconfig cluster to use.</summary>
    [Argument(Format = "--cluster={value}")] public string Cluster => Get<string>(() => Cluster);
    /// <summary>The name of the kubeconfig context to use.</summary>
    [Argument(Format = "--context={value}")] public string Context => Get<string>(() => Context);
    /// <summary>If true, the server's certificate will not be checked for validity. This will make your HTTPS connections insecure.</summary>
    [Argument(Format = "--insecure-skip-tls-verify={value}")] public bool? InsecureSkipTlsVerify => Get<bool?>(() => InsecureSkipTlsVerify);
    /// <summary>Path to the kubeconfig file to use for CLI requests.</summary>
    [Argument(Format = "--kubeconfig={value}")] public string Kubeconfig => Get<string>(() => Kubeconfig);
    /// <summary>when logging hits line file:N, emit a stack trace.</summary>
    [Argument(Format = "--log-backtrace-at={value}")] public string LogBacktraceAt => Get<string>(() => LogBacktraceAt);
    /// <summary>If non-empty, write log files in this directory.</summary>
    [Argument(Format = "--log-dir={value}")] public string LogDir => Get<string>(() => LogDir);
    /// <summary>log to standard error instead of files.</summary>
    [Argument(Format = "--logtostderr={value}")] public bool? Logtostderr => Get<bool?>(() => Logtostderr);
    /// <summary>Require server version to match client version.</summary>
    [Argument(Format = "--match-server-version={value}")] public bool? MatchServerVersion => Get<bool?>(() => MatchServerVersion);
    /// <summary>If present, the namespace scope for this CLI request.</summary>
    [Argument(Format = "--namespace={value}")] public string Namespace => Get<string>(() => Namespace);
    /// <summary>The length of time to wait before giving up on a single server request. Non-zero values should contain a corresponding time unit (e.g. 1s, 2m, 3h). A value of zero means don't timeout requests.</summary>
    [Argument(Format = "--request-timeout={value}")] public string RequestTimeout => Get<string>(() => RequestTimeout);
    /// <summary>The address and port of the Kubernetes API server.</summary>
    [Argument(Format = "--server={value}")] public string Server => Get<string>(() => Server);
    /// <summary>logs at or above this threshold go to stderr.</summary>
    [Argument(Format = "--stderrthreshold={value}")] public int? Stderrthreshold => Get<int?>(() => Stderrthreshold);
    /// <summary>Bearer token for authentication to the API server.</summary>
    [Argument(Format = "--token={value}")] public string Token => Get<string>(() => Token);
    /// <summary>The name of the kubeconfig user to use.</summary>
    [Argument(Format = "--user={value}")] public string User => Get<string>(() => User);
    /// <summary>log level for V logs.</summary>
    [Argument(Format = "--v={value}")] public int? V => Get<int?>(() => V);
    /// <summary>comma-separated list of pattern=N settings for file-filtered logging.</summary>
    [Argument(Format = "--vmodule={key}={value}", Separator = ",")] public IReadOnlyDictionary<string, string> Vmodule => Get<Dictionary<string, string>>(() => Vmodule);
}
#endregion
#region KubernetesApiResourcesSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesApiResources(Nuke.Common.Tools.Kubernetes.KubernetesApiResourcesSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesApiResourcesSettingsExtensions
{
    #region ApiGroup
    /// <inheritdoc cref="KubernetesApiResourcesSettings.ApiGroup"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.ApiGroup))]
    public static T SetApiGroup<T>(this T o, string v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.ApiGroup, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.ApiGroup"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.ApiGroup))]
    public static T ResetApiGroup<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Remove(() => o.ApiGroup));
    #endregion
    #region Cached
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Cached"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Cached))]
    public static T SetCached<T>(this T o, bool? v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Cached, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Cached"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Cached))]
    public static T ResetCached<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Remove(() => o.Cached));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Cached"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Cached))]
    public static T EnableCached<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Cached, true));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Cached"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Cached))]
    public static T DisableCached<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Cached, false));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Cached"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Cached))]
    public static T ToggleCached<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Cached, !o.Cached));
    #endregion
    #region Namespaced
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Namespaced"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Namespaced))]
    public static T SetNamespaced<T>(this T o, bool? v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Namespaced, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Namespaced"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Namespaced))]
    public static T ResetNamespaced<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Remove(() => o.Namespaced));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Namespaced"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Namespaced))]
    public static T EnableNamespaced<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Namespaced, true));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Namespaced"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Namespaced))]
    public static T DisableNamespaced<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Namespaced, false));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Namespaced"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Namespaced))]
    public static T ToggleNamespaced<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Namespaced, !o.Namespaced));
    #endregion
    #region NoHeaders
    /// <inheritdoc cref="KubernetesApiResourcesSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.NoHeaders))]
    public static T SetNoHeaders<T>(this T o, bool? v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.NoHeaders, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.NoHeaders))]
    public static T ResetNoHeaders<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Remove(() => o.NoHeaders));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.NoHeaders))]
    public static T EnableNoHeaders<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.NoHeaders, true));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.NoHeaders))]
    public static T DisableNoHeaders<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.NoHeaders, false));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.NoHeaders))]
    public static T ToggleNoHeaders<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.NoHeaders, !o.NoHeaders));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesApiResourcesOutput v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Verbs
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Verbs"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Verbs))]
    public static T SetVerbs<T>(this T o, params string[] v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Verbs, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Verbs"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Verbs))]
    public static T SetVerbs<T>(this T o, IEnumerable<string> v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.Set(() => o.Verbs, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Verbs"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Verbs))]
    public static T AddVerbs<T>(this T o, params string[] v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.AddCollection(() => o.Verbs, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Verbs"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Verbs))]
    public static T AddVerbs<T>(this T o, IEnumerable<string> v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.AddCollection(() => o.Verbs, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Verbs"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Verbs))]
    public static T RemoveVerbs<T>(this T o, params string[] v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.RemoveCollection(() => o.Verbs, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Verbs"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Verbs))]
    public static T RemoveVerbs<T>(this T o, IEnumerable<string> v) where T : KubernetesApiResourcesSettings => o.Modify(b => b.RemoveCollection(() => o.Verbs, v));
    /// <inheritdoc cref="KubernetesApiResourcesSettings.Verbs"/>
    [Pure] [Builder(Type = typeof(KubernetesApiResourcesSettings), Property = nameof(KubernetesApiResourcesSettings.Verbs))]
    public static T ClearVerbs<T>(this T o) where T : KubernetesApiResourcesSettings => o.Modify(b => b.ClearCollection(() => o.Verbs));
    #endregion
}
#endregion
#region KubernetesDrainSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesDrain(Nuke.Common.Tools.Kubernetes.KubernetesDrainSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesDrainSettingsExtensions
{
    #region DeleteLocalData
    /// <inheritdoc cref="KubernetesDrainSettings.DeleteLocalData"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DeleteLocalData))]
    public static T SetDeleteLocalData<T>(this T o, bool? v) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.DeleteLocalData, v));
    /// <inheritdoc cref="KubernetesDrainSettings.DeleteLocalData"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DeleteLocalData))]
    public static T ResetDeleteLocalData<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Remove(() => o.DeleteLocalData));
    /// <inheritdoc cref="KubernetesDrainSettings.DeleteLocalData"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DeleteLocalData))]
    public static T EnableDeleteLocalData<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.DeleteLocalData, true));
    /// <inheritdoc cref="KubernetesDrainSettings.DeleteLocalData"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DeleteLocalData))]
    public static T DisableDeleteLocalData<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.DeleteLocalData, false));
    /// <inheritdoc cref="KubernetesDrainSettings.DeleteLocalData"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DeleteLocalData))]
    public static T ToggleDeleteLocalData<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.DeleteLocalData, !o.DeleteLocalData));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesDrainSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesDrainSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesDrainSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesDrainSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesDrainSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Force
    /// <inheritdoc cref="KubernetesDrainSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="KubernetesDrainSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.Force))]
    public static T ResetForce<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="KubernetesDrainSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.Force))]
    public static T EnableForce<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="KubernetesDrainSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.Force))]
    public static T DisableForce<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="KubernetesDrainSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region GracePeriod
    /// <inheritdoc cref="KubernetesDrainSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.GracePeriod))]
    public static T SetGracePeriod<T>(this T o, int? v) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.GracePeriod, v));
    /// <inheritdoc cref="KubernetesDrainSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.GracePeriod))]
    public static T ResetGracePeriod<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Remove(() => o.GracePeriod));
    #endregion
    #region IgnoreDaemonsets
    /// <inheritdoc cref="KubernetesDrainSettings.IgnoreDaemonsets"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.IgnoreDaemonsets))]
    public static T SetIgnoreDaemonsets<T>(this T o, bool? v) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.IgnoreDaemonsets, v));
    /// <inheritdoc cref="KubernetesDrainSettings.IgnoreDaemonsets"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.IgnoreDaemonsets))]
    public static T ResetIgnoreDaemonsets<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Remove(() => o.IgnoreDaemonsets));
    /// <inheritdoc cref="KubernetesDrainSettings.IgnoreDaemonsets"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.IgnoreDaemonsets))]
    public static T EnableIgnoreDaemonsets<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.IgnoreDaemonsets, true));
    /// <inheritdoc cref="KubernetesDrainSettings.IgnoreDaemonsets"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.IgnoreDaemonsets))]
    public static T DisableIgnoreDaemonsets<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.IgnoreDaemonsets, false));
    /// <inheritdoc cref="KubernetesDrainSettings.IgnoreDaemonsets"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.IgnoreDaemonsets))]
    public static T ToggleIgnoreDaemonsets<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.IgnoreDaemonsets, !o.IgnoreDaemonsets));
    #endregion
    #region PodSelector
    /// <inheritdoc cref="KubernetesDrainSettings.PodSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.PodSelector))]
    public static T SetPodSelector<T>(this T o, string v) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.PodSelector, v));
    /// <inheritdoc cref="KubernetesDrainSettings.PodSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.PodSelector))]
    public static T ResetPodSelector<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Remove(() => o.PodSelector));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesDrainSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesDrainSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesDrainSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesDrainSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesDrainSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesDrainSettings), Property = nameof(KubernetesDrainSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesDrainSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
}
#endregion
#region KubernetesRunSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesRun(Nuke.Common.Tools.Kubernetes.KubernetesRunSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesRunSettingsExtensions
{
    #region Name
    /// <inheritdoc cref="KubernetesRunSettings.Name"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Name))]
    public static T SetName<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Name, v));
    /// <inheritdoc cref="KubernetesRunSettings.Name"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Name))]
    public static T ResetName<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Name));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesRunSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesRunSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesRunSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesRunSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesRunSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Attach
    /// <inheritdoc cref="KubernetesRunSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Attach))]
    public static T SetAttach<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Attach, v));
    /// <inheritdoc cref="KubernetesRunSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Attach))]
    public static T ResetAttach<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Attach));
    /// <inheritdoc cref="KubernetesRunSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Attach))]
    public static T EnableAttach<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Attach, true));
    /// <inheritdoc cref="KubernetesRunSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Attach))]
    public static T DisableAttach<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Attach, false));
    /// <inheritdoc cref="KubernetesRunSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Attach))]
    public static T ToggleAttach<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Attach, !o.Attach));
    #endregion
    #region Cascade
    /// <inheritdoc cref="KubernetesRunSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Cascade))]
    public static T SetCascade<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Cascade, v));
    /// <inheritdoc cref="KubernetesRunSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Cascade))]
    public static T ResetCascade<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Cascade));
    /// <inheritdoc cref="KubernetesRunSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Cascade))]
    public static T EnableCascade<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Cascade, true));
    /// <inheritdoc cref="KubernetesRunSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Cascade))]
    public static T DisableCascade<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Cascade, false));
    /// <inheritdoc cref="KubernetesRunSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Cascade))]
    public static T ToggleCascade<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Cascade, !o.Cascade));
    #endregion
    #region Command
    /// <inheritdoc cref="KubernetesRunSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Command))]
    public static T SetCommand<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Command, v));
    /// <inheritdoc cref="KubernetesRunSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Command))]
    public static T ResetCommand<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Command));
    /// <inheritdoc cref="KubernetesRunSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Command))]
    public static T EnableCommand<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Command, true));
    /// <inheritdoc cref="KubernetesRunSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Command))]
    public static T DisableCommand<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Command, false));
    /// <inheritdoc cref="KubernetesRunSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Command))]
    public static T ToggleCommand<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Command, !o.Command));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesRunSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesRunSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesRunSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesRunSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesRunSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Env
    /// <inheritdoc cref="KubernetesRunSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Env))]
    public static T SetEnv<T>(this T o, params string[] v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Env))]
    public static T SetEnv<T>(this T o, IEnumerable<string> v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Env))]
    public static T AddEnv<T>(this T o, params string[] v) where T : KubernetesRunSettings => o.Modify(b => b.AddCollection(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Env))]
    public static T AddEnv<T>(this T o, IEnumerable<string> v) where T : KubernetesRunSettings => o.Modify(b => b.AddCollection(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Env))]
    public static T RemoveEnv<T>(this T o, params string[] v) where T : KubernetesRunSettings => o.Modify(b => b.RemoveCollection(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Env))]
    public static T RemoveEnv<T>(this T o, IEnumerable<string> v) where T : KubernetesRunSettings => o.Modify(b => b.RemoveCollection(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Env))]
    public static T ClearEnv<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.ClearCollection(() => o.Env));
    #endregion
    #region Expose
    /// <inheritdoc cref="KubernetesRunSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Expose))]
    public static T SetExpose<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Expose, v));
    /// <inheritdoc cref="KubernetesRunSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Expose))]
    public static T ResetExpose<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Expose));
    /// <inheritdoc cref="KubernetesRunSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Expose))]
    public static T EnableExpose<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Expose, true));
    /// <inheritdoc cref="KubernetesRunSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Expose))]
    public static T DisableExpose<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Expose, false));
    /// <inheritdoc cref="KubernetesRunSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Expose))]
    public static T ToggleExpose<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Expose, !o.Expose));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesRunSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesRunSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesRunSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesRunSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesRunSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Force
    /// <inheritdoc cref="KubernetesRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="KubernetesRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Force))]
    public static T ResetForce<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="KubernetesRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Force))]
    public static T EnableForce<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="KubernetesRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Force))]
    public static T DisableForce<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="KubernetesRunSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region Generator
    /// <inheritdoc cref="KubernetesRunSettings.Generator"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Generator))]
    public static T SetGenerator<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Generator, v));
    /// <inheritdoc cref="KubernetesRunSettings.Generator"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Generator))]
    public static T ResetGenerator<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Generator));
    #endregion
    #region GracePeriod
    /// <inheritdoc cref="KubernetesRunSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.GracePeriod))]
    public static T SetGracePeriod<T>(this T o, int? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.GracePeriod, v));
    /// <inheritdoc cref="KubernetesRunSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.GracePeriod))]
    public static T ResetGracePeriod<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.GracePeriod));
    #endregion
    #region Hostport
    /// <inheritdoc cref="KubernetesRunSettings.Hostport"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Hostport))]
    public static T SetHostport<T>(this T o, int? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Hostport, v));
    /// <inheritdoc cref="KubernetesRunSettings.Hostport"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Hostport))]
    public static T ResetHostport<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Hostport));
    #endregion
    #region Image
    /// <inheritdoc cref="KubernetesRunSettings.Image"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Image))]
    public static T SetImage<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Image, v));
    /// <inheritdoc cref="KubernetesRunSettings.Image"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Image))]
    public static T ResetImage<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Image));
    #endregion
    #region ImagePullPolicy
    /// <inheritdoc cref="KubernetesRunSettings.ImagePullPolicy"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.ImagePullPolicy))]
    public static T SetImagePullPolicy<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.ImagePullPolicy, v));
    /// <inheritdoc cref="KubernetesRunSettings.ImagePullPolicy"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.ImagePullPolicy))]
    public static T ResetImagePullPolicy<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.ImagePullPolicy));
    #endregion
    #region Labels
    /// <inheritdoc cref="KubernetesRunSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Labels))]
    public static T SetLabels<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Labels, v));
    /// <inheritdoc cref="KubernetesRunSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Labels))]
    public static T ResetLabels<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Labels));
    #endregion
    #region LeaveStdinOpen
    /// <inheritdoc cref="KubernetesRunSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.LeaveStdinOpen))]
    public static T SetLeaveStdinOpen<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.LeaveStdinOpen, v));
    /// <inheritdoc cref="KubernetesRunSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.LeaveStdinOpen))]
    public static T ResetLeaveStdinOpen<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.LeaveStdinOpen));
    /// <inheritdoc cref="KubernetesRunSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.LeaveStdinOpen))]
    public static T EnableLeaveStdinOpen<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.LeaveStdinOpen, true));
    /// <inheritdoc cref="KubernetesRunSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.LeaveStdinOpen))]
    public static T DisableLeaveStdinOpen<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.LeaveStdinOpen, false));
    /// <inheritdoc cref="KubernetesRunSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.LeaveStdinOpen))]
    public static T ToggleLeaveStdinOpen<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.LeaveStdinOpen, !o.LeaveStdinOpen));
    #endregion
    #region Limits
    /// <inheritdoc cref="KubernetesRunSettings.Limits"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Limits))]
    public static T SetLimits<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Limits, v));
    /// <inheritdoc cref="KubernetesRunSettings.Limits"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Limits))]
    public static T ResetLimits<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Limits));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesRunSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesRunOutput v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesRunSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Overrides
    /// <inheritdoc cref="KubernetesRunSettings.Overrides"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Overrides))]
    public static T SetOverrides<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Overrides, v));
    /// <inheritdoc cref="KubernetesRunSettings.Overrides"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Overrides))]
    public static T ResetOverrides<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Overrides));
    #endregion
    #region PodRunningTimeout
    /// <inheritdoc cref="KubernetesRunSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.PodRunningTimeout))]
    public static T SetPodRunningTimeout<T>(this T o, TimeSpan? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.PodRunningTimeout, v));
    /// <inheritdoc cref="KubernetesRunSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.PodRunningTimeout))]
    public static T ResetPodRunningTimeout<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.PodRunningTimeout));
    #endregion
    #region Port
    /// <inheritdoc cref="KubernetesRunSettings.Port"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Port))]
    public static T SetPort<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Port, v));
    /// <inheritdoc cref="KubernetesRunSettings.Port"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Port))]
    public static T ResetPort<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Port));
    #endregion
    #region Quiet
    /// <inheritdoc cref="KubernetesRunSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Quiet))]
    public static T SetQuiet<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Quiet, v));
    /// <inheritdoc cref="KubernetesRunSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Quiet))]
    public static T ResetQuiet<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Quiet));
    /// <inheritdoc cref="KubernetesRunSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Quiet))]
    public static T EnableQuiet<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Quiet, true));
    /// <inheritdoc cref="KubernetesRunSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Quiet))]
    public static T DisableQuiet<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Quiet, false));
    /// <inheritdoc cref="KubernetesRunSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Quiet))]
    public static T ToggleQuiet<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Quiet, !o.Quiet));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesRunSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesRunSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesRunSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesRunSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesRunSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesRunSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesRunSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesRunSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesRunSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesRunSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Replicas
    /// <inheritdoc cref="KubernetesRunSettings.Replicas"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Replicas))]
    public static T SetReplicas<T>(this T o, int? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Replicas, v));
    /// <inheritdoc cref="KubernetesRunSettings.Replicas"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Replicas))]
    public static T ResetReplicas<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Replicas));
    #endregion
    #region Requests
    /// <inheritdoc cref="KubernetesRunSettings.Requests"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Requests))]
    public static T SetRequests<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Requests, v));
    /// <inheritdoc cref="KubernetesRunSettings.Requests"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Requests))]
    public static T ResetRequests<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Requests));
    #endregion
    #region Restart
    /// <inheritdoc cref="KubernetesRunSettings.Restart"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Restart))]
    public static T SetRestart<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Restart, v));
    /// <inheritdoc cref="KubernetesRunSettings.Restart"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Restart))]
    public static T ResetRestart<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Restart));
    #endregion
    #region Rm
    /// <inheritdoc cref="KubernetesRunSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Rm))]
    public static T SetRm<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Rm, v));
    /// <inheritdoc cref="KubernetesRunSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Rm))]
    public static T ResetRm<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Rm));
    /// <inheritdoc cref="KubernetesRunSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Rm))]
    public static T EnableRm<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Rm, true));
    /// <inheritdoc cref="KubernetesRunSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Rm))]
    public static T DisableRm<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Rm, false));
    /// <inheritdoc cref="KubernetesRunSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Rm))]
    public static T ToggleRm<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Rm, !o.Rm));
    #endregion
    #region SaveConfig
    /// <inheritdoc cref="KubernetesRunSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.SaveConfig))]
    public static T SetSaveConfig<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.SaveConfig, v));
    /// <inheritdoc cref="KubernetesRunSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.SaveConfig))]
    public static T ResetSaveConfig<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.SaveConfig));
    /// <inheritdoc cref="KubernetesRunSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.SaveConfig))]
    public static T EnableSaveConfig<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.SaveConfig, true));
    /// <inheritdoc cref="KubernetesRunSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.SaveConfig))]
    public static T DisableSaveConfig<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.SaveConfig, false));
    /// <inheritdoc cref="KubernetesRunSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.SaveConfig))]
    public static T ToggleSaveConfig<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.SaveConfig, !o.SaveConfig));
    #endregion
    #region Schedule
    /// <inheritdoc cref="KubernetesRunSettings.Schedule"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Schedule))]
    public static T SetSchedule<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Schedule, v));
    /// <inheritdoc cref="KubernetesRunSettings.Schedule"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Schedule))]
    public static T ResetSchedule<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Schedule));
    #endregion
    #region ServiceGenerator
    /// <inheritdoc cref="KubernetesRunSettings.ServiceGenerator"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.ServiceGenerator))]
    public static T SetServiceGenerator<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.ServiceGenerator, v));
    /// <inheritdoc cref="KubernetesRunSettings.ServiceGenerator"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.ServiceGenerator))]
    public static T ResetServiceGenerator<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.ServiceGenerator));
    #endregion
    #region ServiceOverrides
    /// <inheritdoc cref="KubernetesRunSettings.ServiceOverrides"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.ServiceOverrides))]
    public static T SetServiceOverrides<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.ServiceOverrides, v));
    /// <inheritdoc cref="KubernetesRunSettings.ServiceOverrides"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.ServiceOverrides))]
    public static T ResetServiceOverrides<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.ServiceOverrides));
    #endregion
    #region Serviceaccount
    /// <inheritdoc cref="KubernetesRunSettings.Serviceaccount"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Serviceaccount))]
    public static T SetServiceaccount<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Serviceaccount, v));
    /// <inheritdoc cref="KubernetesRunSettings.Serviceaccount"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Serviceaccount))]
    public static T ResetServiceaccount<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Serviceaccount));
    #endregion
    #region Stdin
    /// <inheritdoc cref="KubernetesRunSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Stdin))]
    public static T SetStdin<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Stdin, v));
    /// <inheritdoc cref="KubernetesRunSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Stdin))]
    public static T ResetStdin<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Stdin));
    /// <inheritdoc cref="KubernetesRunSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Stdin))]
    public static T EnableStdin<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Stdin, true));
    /// <inheritdoc cref="KubernetesRunSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Stdin))]
    public static T DisableStdin<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Stdin, false));
    /// <inheritdoc cref="KubernetesRunSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Stdin))]
    public static T ToggleStdin<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Stdin, !o.Stdin));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesRunSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesRunSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesRunSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesRunSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
    #region Tty
    /// <inheritdoc cref="KubernetesRunSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Tty))]
    public static T SetTty<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Tty, v));
    /// <inheritdoc cref="KubernetesRunSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Tty))]
    public static T ResetTty<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Tty));
    /// <inheritdoc cref="KubernetesRunSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Tty))]
    public static T EnableTty<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Tty, true));
    /// <inheritdoc cref="KubernetesRunSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Tty))]
    public static T DisableTty<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Tty, false));
    /// <inheritdoc cref="KubernetesRunSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Tty))]
    public static T ToggleTty<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Tty, !o.Tty));
    #endregion
    #region Wait
    /// <inheritdoc cref="KubernetesRunSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Wait))]
    public static T SetWait<T>(this T o, bool? v) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Wait, v));
    /// <inheritdoc cref="KubernetesRunSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Wait))]
    public static T ResetWait<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Remove(() => o.Wait));
    /// <inheritdoc cref="KubernetesRunSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Wait))]
    public static T EnableWait<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Wait, true));
    /// <inheritdoc cref="KubernetesRunSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Wait))]
    public static T DisableWait<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Wait, false));
    /// <inheritdoc cref="KubernetesRunSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunSettings), Property = nameof(KubernetesRunSettings.Wait))]
    public static T ToggleWait<T>(this T o) where T : KubernetesRunSettings => o.Modify(b => b.Set(() => o.Wait, !o.Wait));
    #endregion
}
#endregion
#region KubernetesGetSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesGet(Nuke.Common.Tools.Kubernetes.KubernetesGetSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesGetSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesGetSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesGetSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesGetSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesGetSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesGetSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesGetSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesGetSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesGetSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesGetSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesGetSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesGetSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region AllNamespaces
    /// <inheritdoc cref="KubernetesGetSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllNamespaces))]
    public static T SetAllNamespaces<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.AllNamespaces, v));
    /// <inheritdoc cref="KubernetesGetSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllNamespaces))]
    public static T ResetAllNamespaces<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.AllNamespaces));
    /// <inheritdoc cref="KubernetesGetSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllNamespaces))]
    public static T EnableAllNamespaces<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.AllNamespaces, true));
    /// <inheritdoc cref="KubernetesGetSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllNamespaces))]
    public static T DisableAllNamespaces<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.AllNamespaces, false));
    /// <inheritdoc cref="KubernetesGetSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllNamespaces))]
    public static T ToggleAllNamespaces<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.AllNamespaces, !o.AllNamespaces));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesGetSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesGetSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesGetSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesGetSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesGetSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region ChunkSize
    /// <inheritdoc cref="KubernetesGetSettings.ChunkSize"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ChunkSize))]
    public static T SetChunkSize<T>(this T o, long? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ChunkSize, v));
    /// <inheritdoc cref="KubernetesGetSettings.ChunkSize"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ChunkSize))]
    public static T ResetChunkSize<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.ChunkSize));
    #endregion
    #region Export
    /// <inheritdoc cref="KubernetesGetSettings.Export"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Export))]
    public static T SetExport<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Export, v));
    /// <inheritdoc cref="KubernetesGetSettings.Export"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Export))]
    public static T ResetExport<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.Export));
    /// <inheritdoc cref="KubernetesGetSettings.Export"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Export))]
    public static T EnableExport<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Export, true));
    /// <inheritdoc cref="KubernetesGetSettings.Export"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Export))]
    public static T DisableExport<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Export, false));
    /// <inheritdoc cref="KubernetesGetSettings.Export"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Export))]
    public static T ToggleExport<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Export, !o.Export));
    #endregion
    #region FieldSelector
    /// <inheritdoc cref="KubernetesGetSettings.FieldSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.FieldSelector))]
    public static T SetFieldSelector<T>(this T o, string v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.FieldSelector, v));
    /// <inheritdoc cref="KubernetesGetSettings.FieldSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.FieldSelector))]
    public static T ResetFieldSelector<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.FieldSelector));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesGetSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesGetSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesGetSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesGetSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesGetSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesGetSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesGetSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesGetSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesGetSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesGetSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesGetSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region IgnoreNotFound
    /// <inheritdoc cref="KubernetesGetSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IgnoreNotFound))]
    public static T SetIgnoreNotFound<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.IgnoreNotFound, v));
    /// <inheritdoc cref="KubernetesGetSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IgnoreNotFound))]
    public static T ResetIgnoreNotFound<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.IgnoreNotFound));
    /// <inheritdoc cref="KubernetesGetSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IgnoreNotFound))]
    public static T EnableIgnoreNotFound<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.IgnoreNotFound, true));
    /// <inheritdoc cref="KubernetesGetSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IgnoreNotFound))]
    public static T DisableIgnoreNotFound<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.IgnoreNotFound, false));
    /// <inheritdoc cref="KubernetesGetSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IgnoreNotFound))]
    public static T ToggleIgnoreNotFound<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.IgnoreNotFound, !o.IgnoreNotFound));
    #endregion
    #region IncludeUninitialized
    /// <inheritdoc cref="KubernetesGetSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IncludeUninitialized))]
    public static T SetIncludeUninitialized<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, v));
    /// <inheritdoc cref="KubernetesGetSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IncludeUninitialized))]
    public static T ResetIncludeUninitialized<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.IncludeUninitialized));
    /// <inheritdoc cref="KubernetesGetSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IncludeUninitialized))]
    public static T EnableIncludeUninitialized<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, true));
    /// <inheritdoc cref="KubernetesGetSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IncludeUninitialized))]
    public static T DisableIncludeUninitialized<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, false));
    /// <inheritdoc cref="KubernetesGetSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.IncludeUninitialized))]
    public static T ToggleIncludeUninitialized<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, !o.IncludeUninitialized));
    #endregion
    #region LabelColumns
    /// <inheritdoc cref="KubernetesGetSettings.LabelColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.LabelColumns))]
    public static T SetLabelColumns<T>(this T o, params string[] v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.LabelColumns, v));
    /// <inheritdoc cref="KubernetesGetSettings.LabelColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.LabelColumns))]
    public static T SetLabelColumns<T>(this T o, IEnumerable<string> v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.LabelColumns, v));
    /// <inheritdoc cref="KubernetesGetSettings.LabelColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.LabelColumns))]
    public static T AddLabelColumns<T>(this T o, params string[] v) where T : KubernetesGetSettings => o.Modify(b => b.AddCollection(() => o.LabelColumns, v));
    /// <inheritdoc cref="KubernetesGetSettings.LabelColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.LabelColumns))]
    public static T AddLabelColumns<T>(this T o, IEnumerable<string> v) where T : KubernetesGetSettings => o.Modify(b => b.AddCollection(() => o.LabelColumns, v));
    /// <inheritdoc cref="KubernetesGetSettings.LabelColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.LabelColumns))]
    public static T RemoveLabelColumns<T>(this T o, params string[] v) where T : KubernetesGetSettings => o.Modify(b => b.RemoveCollection(() => o.LabelColumns, v));
    /// <inheritdoc cref="KubernetesGetSettings.LabelColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.LabelColumns))]
    public static T RemoveLabelColumns<T>(this T o, IEnumerable<string> v) where T : KubernetesGetSettings => o.Modify(b => b.RemoveCollection(() => o.LabelColumns, v));
    /// <inheritdoc cref="KubernetesGetSettings.LabelColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.LabelColumns))]
    public static T ClearLabelColumns<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.ClearCollection(() => o.LabelColumns));
    #endregion
    #region NoHeaders
    /// <inheritdoc cref="KubernetesGetSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.NoHeaders))]
    public static T SetNoHeaders<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.NoHeaders, v));
    /// <inheritdoc cref="KubernetesGetSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.NoHeaders))]
    public static T ResetNoHeaders<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.NoHeaders));
    /// <inheritdoc cref="KubernetesGetSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.NoHeaders))]
    public static T EnableNoHeaders<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.NoHeaders, true));
    /// <inheritdoc cref="KubernetesGetSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.NoHeaders))]
    public static T DisableNoHeaders<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.NoHeaders, false));
    /// <inheritdoc cref="KubernetesGetSettings.NoHeaders"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.NoHeaders))]
    public static T ToggleNoHeaders<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.NoHeaders, !o.NoHeaders));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesGetSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesGetOutput v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesGetSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Raw
    /// <inheritdoc cref="KubernetesGetSettings.Raw"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Raw))]
    public static T SetRaw<T>(this T o, string v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Raw, v));
    /// <inheritdoc cref="KubernetesGetSettings.Raw"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Raw))]
    public static T ResetRaw<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.Raw));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesGetSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesGetSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesGetSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesGetSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesGetSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesGetSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesGetSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region ServerPrint
    /// <inheritdoc cref="KubernetesGetSettings.ServerPrint"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ServerPrint))]
    public static T SetServerPrint<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ServerPrint, v));
    /// <inheritdoc cref="KubernetesGetSettings.ServerPrint"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ServerPrint))]
    public static T ResetServerPrint<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.ServerPrint));
    /// <inheritdoc cref="KubernetesGetSettings.ServerPrint"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ServerPrint))]
    public static T EnableServerPrint<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ServerPrint, true));
    /// <inheritdoc cref="KubernetesGetSettings.ServerPrint"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ServerPrint))]
    public static T DisableServerPrint<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ServerPrint, false));
    /// <inheritdoc cref="KubernetesGetSettings.ServerPrint"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ServerPrint))]
    public static T ToggleServerPrint<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ServerPrint, !o.ServerPrint));
    #endregion
    #region ShowAll
    /// <inheritdoc cref="KubernetesGetSettings.ShowAll"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowAll))]
    public static T SetShowAll<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowAll, v));
    /// <inheritdoc cref="KubernetesGetSettings.ShowAll"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowAll))]
    public static T ResetShowAll<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.ShowAll));
    /// <inheritdoc cref="KubernetesGetSettings.ShowAll"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowAll))]
    public static T EnableShowAll<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowAll, true));
    /// <inheritdoc cref="KubernetesGetSettings.ShowAll"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowAll))]
    public static T DisableShowAll<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowAll, false));
    /// <inheritdoc cref="KubernetesGetSettings.ShowAll"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowAll))]
    public static T ToggleShowAll<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowAll, !o.ShowAll));
    #endregion
    #region ShowKind
    /// <inheritdoc cref="KubernetesGetSettings.ShowKind"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowKind))]
    public static T SetShowKind<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowKind, v));
    /// <inheritdoc cref="KubernetesGetSettings.ShowKind"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowKind))]
    public static T ResetShowKind<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.ShowKind));
    /// <inheritdoc cref="KubernetesGetSettings.ShowKind"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowKind))]
    public static T EnableShowKind<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowKind, true));
    /// <inheritdoc cref="KubernetesGetSettings.ShowKind"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowKind))]
    public static T DisableShowKind<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowKind, false));
    /// <inheritdoc cref="KubernetesGetSettings.ShowKind"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowKind))]
    public static T ToggleShowKind<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowKind, !o.ShowKind));
    #endregion
    #region ShowLabels
    /// <inheritdoc cref="KubernetesGetSettings.ShowLabels"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowLabels))]
    public static T SetShowLabels<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowLabels, v));
    /// <inheritdoc cref="KubernetesGetSettings.ShowLabels"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowLabels))]
    public static T ResetShowLabels<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.ShowLabels));
    /// <inheritdoc cref="KubernetesGetSettings.ShowLabels"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowLabels))]
    public static T EnableShowLabels<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowLabels, true));
    /// <inheritdoc cref="KubernetesGetSettings.ShowLabels"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowLabels))]
    public static T DisableShowLabels<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowLabels, false));
    /// <inheritdoc cref="KubernetesGetSettings.ShowLabels"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.ShowLabels))]
    public static T ToggleShowLabels<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.ShowLabels, !o.ShowLabels));
    #endregion
    #region SortBy
    /// <inheritdoc cref="KubernetesGetSettings.SortBy"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.SortBy))]
    public static T SetSortBy<T>(this T o, string v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.SortBy, v));
    /// <inheritdoc cref="KubernetesGetSettings.SortBy"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.SortBy))]
    public static T ResetSortBy<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.SortBy));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesGetSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesGetSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region UseOpenapiPrintColumns
    /// <inheritdoc cref="KubernetesGetSettings.UseOpenapiPrintColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.UseOpenapiPrintColumns))]
    public static T SetUseOpenapiPrintColumns<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.UseOpenapiPrintColumns, v));
    /// <inheritdoc cref="KubernetesGetSettings.UseOpenapiPrintColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.UseOpenapiPrintColumns))]
    public static T ResetUseOpenapiPrintColumns<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.UseOpenapiPrintColumns));
    /// <inheritdoc cref="KubernetesGetSettings.UseOpenapiPrintColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.UseOpenapiPrintColumns))]
    public static T EnableUseOpenapiPrintColumns<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.UseOpenapiPrintColumns, true));
    /// <inheritdoc cref="KubernetesGetSettings.UseOpenapiPrintColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.UseOpenapiPrintColumns))]
    public static T DisableUseOpenapiPrintColumns<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.UseOpenapiPrintColumns, false));
    /// <inheritdoc cref="KubernetesGetSettings.UseOpenapiPrintColumns"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.UseOpenapiPrintColumns))]
    public static T ToggleUseOpenapiPrintColumns<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.UseOpenapiPrintColumns, !o.UseOpenapiPrintColumns));
    #endregion
    #region Watch
    /// <inheritdoc cref="KubernetesGetSettings.Watch"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Watch))]
    public static T SetWatch<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Watch, v));
    /// <inheritdoc cref="KubernetesGetSettings.Watch"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Watch))]
    public static T ResetWatch<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.Watch));
    /// <inheritdoc cref="KubernetesGetSettings.Watch"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Watch))]
    public static T EnableWatch<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Watch, true));
    /// <inheritdoc cref="KubernetesGetSettings.Watch"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Watch))]
    public static T DisableWatch<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Watch, false));
    /// <inheritdoc cref="KubernetesGetSettings.Watch"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.Watch))]
    public static T ToggleWatch<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.Watch, !o.Watch));
    #endregion
    #region WatchOnly
    /// <inheritdoc cref="KubernetesGetSettings.WatchOnly"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.WatchOnly))]
    public static T SetWatchOnly<T>(this T o, bool? v) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.WatchOnly, v));
    /// <inheritdoc cref="KubernetesGetSettings.WatchOnly"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.WatchOnly))]
    public static T ResetWatchOnly<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Remove(() => o.WatchOnly));
    /// <inheritdoc cref="KubernetesGetSettings.WatchOnly"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.WatchOnly))]
    public static T EnableWatchOnly<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.WatchOnly, true));
    /// <inheritdoc cref="KubernetesGetSettings.WatchOnly"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.WatchOnly))]
    public static T DisableWatchOnly<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.WatchOnly, false));
    /// <inheritdoc cref="KubernetesGetSettings.WatchOnly"/>
    [Pure] [Builder(Type = typeof(KubernetesGetSettings), Property = nameof(KubernetesGetSettings.WatchOnly))]
    public static T ToggleWatchOnly<T>(this T o) where T : KubernetesGetSettings => o.Modify(b => b.Set(() => o.WatchOnly, !o.WatchOnly));
    #endregion
}
#endregion
#region KubernetesVersionSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesVersion(Nuke.Common.Tools.Kubernetes.KubernetesVersionSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesVersionSettingsExtensions
{
    #region Client
    /// <inheritdoc cref="KubernetesVersionSettings.Client"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Client))]
    public static T SetClient<T>(this T o, bool? v) where T : KubernetesVersionSettings => o.Modify(b => b.Set(() => o.Client, v));
    /// <inheritdoc cref="KubernetesVersionSettings.Client"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Client))]
    public static T ResetClient<T>(this T o) where T : KubernetesVersionSettings => o.Modify(b => b.Remove(() => o.Client));
    /// <inheritdoc cref="KubernetesVersionSettings.Client"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Client))]
    public static T EnableClient<T>(this T o) where T : KubernetesVersionSettings => o.Modify(b => b.Set(() => o.Client, true));
    /// <inheritdoc cref="KubernetesVersionSettings.Client"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Client))]
    public static T DisableClient<T>(this T o) where T : KubernetesVersionSettings => o.Modify(b => b.Set(() => o.Client, false));
    /// <inheritdoc cref="KubernetesVersionSettings.Client"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Client))]
    public static T ToggleClient<T>(this T o) where T : KubernetesVersionSettings => o.Modify(b => b.Set(() => o.Client, !o.Client));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesVersionSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Output))]
    public static T SetOutput<T>(this T o, string v) where T : KubernetesVersionSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesVersionSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesVersionSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Short
    /// <inheritdoc cref="KubernetesVersionSettings.Short"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Short))]
    public static T SetShort<T>(this T o, bool? v) where T : KubernetesVersionSettings => o.Modify(b => b.Set(() => o.Short, v));
    /// <inheritdoc cref="KubernetesVersionSettings.Short"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Short))]
    public static T ResetShort<T>(this T o) where T : KubernetesVersionSettings => o.Modify(b => b.Remove(() => o.Short));
    /// <inheritdoc cref="KubernetesVersionSettings.Short"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Short))]
    public static T EnableShort<T>(this T o) where T : KubernetesVersionSettings => o.Modify(b => b.Set(() => o.Short, true));
    /// <inheritdoc cref="KubernetesVersionSettings.Short"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Short))]
    public static T DisableShort<T>(this T o) where T : KubernetesVersionSettings => o.Modify(b => b.Set(() => o.Short, false));
    /// <inheritdoc cref="KubernetesVersionSettings.Short"/>
    [Pure] [Builder(Type = typeof(KubernetesVersionSettings), Property = nameof(KubernetesVersionSettings.Short))]
    public static T ToggleShort<T>(this T o) where T : KubernetesVersionSettings => o.Modify(b => b.Set(() => o.Short, !o.Short));
    #endregion
}
#endregion
#region KubernetesTopSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesTop(Nuke.Common.Tools.Kubernetes.KubernetesTopSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesTopSettingsExtensions
{
}
#endregion
#region KubernetesConfigSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesConfig(Nuke.Common.Tools.Kubernetes.KubernetesConfigSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesConfigSettingsExtensions
{
}
#endregion
#region KubernetesExecSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesExec(Nuke.Common.Tools.Kubernetes.KubernetesExecSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesExecSettingsExtensions
{
    #region PodName
    /// <inheritdoc cref="KubernetesExecSettings.PodName"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.PodName))]
    public static T SetPodName<T>(this T o, string v) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.PodName, v));
    /// <inheritdoc cref="KubernetesExecSettings.PodName"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.PodName))]
    public static T ResetPodName<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Remove(() => o.PodName));
    #endregion
    #region Container
    /// <inheritdoc cref="KubernetesExecSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Container))]
    public static T SetContainer<T>(this T o, string v) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Container, v));
    /// <inheritdoc cref="KubernetesExecSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Container))]
    public static T ResetContainer<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Remove(() => o.Container));
    #endregion
    #region Pod
    /// <inheritdoc cref="KubernetesExecSettings.Pod"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Pod))]
    public static T SetPod<T>(this T o, string v) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Pod, v));
    /// <inheritdoc cref="KubernetesExecSettings.Pod"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Pod))]
    public static T ResetPod<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Remove(() => o.Pod));
    #endregion
    #region Stdin
    /// <inheritdoc cref="KubernetesExecSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Stdin))]
    public static T SetStdin<T>(this T o, bool? v) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Stdin, v));
    /// <inheritdoc cref="KubernetesExecSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Stdin))]
    public static T ResetStdin<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Remove(() => o.Stdin));
    /// <inheritdoc cref="KubernetesExecSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Stdin))]
    public static T EnableStdin<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Stdin, true));
    /// <inheritdoc cref="KubernetesExecSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Stdin))]
    public static T DisableStdin<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Stdin, false));
    /// <inheritdoc cref="KubernetesExecSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Stdin))]
    public static T ToggleStdin<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Stdin, !o.Stdin));
    #endregion
    #region Tty
    /// <inheritdoc cref="KubernetesExecSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Tty))]
    public static T SetTty<T>(this T o, bool? v) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Tty, v));
    /// <inheritdoc cref="KubernetesExecSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Tty))]
    public static T ResetTty<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Remove(() => o.Tty));
    /// <inheritdoc cref="KubernetesExecSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Tty))]
    public static T EnableTty<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Tty, true));
    /// <inheritdoc cref="KubernetesExecSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Tty))]
    public static T DisableTty<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Tty, false));
    /// <inheritdoc cref="KubernetesExecSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Tty))]
    public static T ToggleTty<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Tty, !o.Tty));
    #endregion
    #region Command
    /// <inheritdoc cref="KubernetesExecSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Command))]
    public static T SetCommand<T>(this T o, string v) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Command, v));
    /// <inheritdoc cref="KubernetesExecSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Command))]
    public static T ResetCommand<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.Remove(() => o.Command));
    #endregion
    #region Arguments
    /// <inheritdoc cref="KubernetesExecSettings.Arguments"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Arguments))]
    public static T SetArguments<T>(this T o, params string[] v) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Arguments, v));
    /// <inheritdoc cref="KubernetesExecSettings.Arguments"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Arguments))]
    public static T SetArguments<T>(this T o, IEnumerable<string> v) where T : KubernetesExecSettings => o.Modify(b => b.Set(() => o.Arguments, v));
    /// <inheritdoc cref="KubernetesExecSettings.Arguments"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Arguments))]
    public static T AddArguments<T>(this T o, params string[] v) where T : KubernetesExecSettings => o.Modify(b => b.AddCollection(() => o.Arguments, v));
    /// <inheritdoc cref="KubernetesExecSettings.Arguments"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Arguments))]
    public static T AddArguments<T>(this T o, IEnumerable<string> v) where T : KubernetesExecSettings => o.Modify(b => b.AddCollection(() => o.Arguments, v));
    /// <inheritdoc cref="KubernetesExecSettings.Arguments"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Arguments))]
    public static T RemoveArguments<T>(this T o, params string[] v) where T : KubernetesExecSettings => o.Modify(b => b.RemoveCollection(() => o.Arguments, v));
    /// <inheritdoc cref="KubernetesExecSettings.Arguments"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Arguments))]
    public static T RemoveArguments<T>(this T o, IEnumerable<string> v) where T : KubernetesExecSettings => o.Modify(b => b.RemoveCollection(() => o.Arguments, v));
    /// <inheritdoc cref="KubernetesExecSettings.Arguments"/>
    [Pure] [Builder(Type = typeof(KubernetesExecSettings), Property = nameof(KubernetesExecSettings.Arguments))]
    public static T ClearArguments<T>(this T o) where T : KubernetesExecSettings => o.Modify(b => b.ClearCollection(() => o.Arguments));
    #endregion
}
#endregion
#region KubernetesRollingUpdateSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesRollingUpdate(Nuke.Common.Tools.Kubernetes.KubernetesRollingUpdateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesRollingUpdateSettingsExtensions
{
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Container
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Container))]
    public static T SetContainer<T>(this T o, string v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Container, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Container))]
    public static T ResetContainer<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.Container));
    #endregion
    #region DeploymentLabelKey
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.DeploymentLabelKey"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.DeploymentLabelKey))]
    public static T SetDeploymentLabelKey<T>(this T o, string v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.DeploymentLabelKey, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.DeploymentLabelKey"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.DeploymentLabelKey))]
    public static T ResetDeploymentLabelKey<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.DeploymentLabelKey));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Image
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Image"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Image))]
    public static T SetImage<T>(this T o, string v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Image, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Image"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Image))]
    public static T ResetImage<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.Image));
    #endregion
    #region ImagePullPolicy
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.ImagePullPolicy"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.ImagePullPolicy))]
    public static T SetImagePullPolicy<T>(this T o, string v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.ImagePullPolicy, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.ImagePullPolicy"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.ImagePullPolicy))]
    public static T ResetImagePullPolicy<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.ImagePullPolicy));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesRollingUpdateOutput v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region PollInterval
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.PollInterval"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.PollInterval))]
    public static T SetPollInterval<T>(this T o, TimeSpan? v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.PollInterval, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.PollInterval"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.PollInterval))]
    public static T ResetPollInterval<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.PollInterval));
    #endregion
    #region Rollback
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Rollback"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Rollback))]
    public static T SetRollback<T>(this T o, bool? v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Rollback, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Rollback"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Rollback))]
    public static T ResetRollback<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.Rollback));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Rollback"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Rollback))]
    public static T EnableRollback<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Rollback, true));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Rollback"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Rollback))]
    public static T DisableRollback<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Rollback, false));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Rollback"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Rollback))]
    public static T ToggleRollback<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Rollback, !o.Rollback));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
    #region UpdatePeriod
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.UpdatePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.UpdatePeriod))]
    public static T SetUpdatePeriod<T>(this T o, TimeSpan? v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.UpdatePeriod, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.UpdatePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.UpdatePeriod))]
    public static T ResetUpdatePeriod<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.UpdatePeriod));
    #endregion
    #region Validate
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Validate))]
    public static T SetValidate<T>(this T o, bool? v) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Validate, v));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Validate))]
    public static T ResetValidate<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Remove(() => o.Validate));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Validate))]
    public static T EnableValidate<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Validate, true));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Validate))]
    public static T DisableValidate<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Validate, false));
    /// <inheritdoc cref="KubernetesRollingUpdateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesRollingUpdateSettings), Property = nameof(KubernetesRollingUpdateSettings.Validate))]
    public static T ToggleValidate<T>(this T o) where T : KubernetesRollingUpdateSettings => o.Modify(b => b.Set(() => o.Validate, !o.Validate));
    #endregion
}
#endregion
#region KubernetesLabelSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesLabel(Nuke.Common.Tools.Kubernetes.KubernetesLabelSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesLabelSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesLabelSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLabelSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLabelSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesLabelSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLabelSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesLabelSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLabelSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesLabelSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLabelSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesLabelSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLabelSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region Labels
    /// <inheritdoc cref="KubernetesLabelSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Labels))]
    public static T SetLabels<T>(this T o, IDictionary<string, string> v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Labels, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="KubernetesLabelSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Labels))]
    public static T SetLabel<T>(this T o, string k, string v) where T : KubernetesLabelSettings => o.Modify(b => b.SetDictionary(() => o.Labels, k, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Labels))]
    public static T AddLabel<T>(this T o, string k, string v) where T : KubernetesLabelSettings => o.Modify(b => b.AddDictionary(() => o.Labels, k, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Labels))]
    public static T RemoveLabel<T>(this T o, string k) where T : KubernetesLabelSettings => o.Modify(b => b.RemoveDictionary(() => o.Labels, k));
    /// <inheritdoc cref="KubernetesLabelSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Labels))]
    public static T ClearLabels<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.ClearDictionary(() => o.Labels));
    #endregion
    #region All
    /// <inheritdoc cref="KubernetesLabelSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.All))]
    public static T SetAll<T>(this T o, bool? v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.All, v));
    /// <inheritdoc cref="KubernetesLabelSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.All))]
    public static T ResetAll<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.All));
    /// <inheritdoc cref="KubernetesLabelSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.All))]
    public static T EnableAll<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.All, true));
    /// <inheritdoc cref="KubernetesLabelSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.All))]
    public static T DisableAll<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.All, false));
    /// <inheritdoc cref="KubernetesLabelSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.All))]
    public static T ToggleAll<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.All, !o.All));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesLabelSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesLabelSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesLabelSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesLabelSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesLabelSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesLabelSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesLabelSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesLabelSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesLabelSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesLabelSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region FieldSelector
    /// <inheritdoc cref="KubernetesLabelSettings.FieldSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.FieldSelector))]
    public static T SetFieldSelector<T>(this T o, string v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.FieldSelector, v));
    /// <inheritdoc cref="KubernetesLabelSettings.FieldSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.FieldSelector))]
    public static T ResetFieldSelector<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.FieldSelector));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesLabelSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesLabelSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesLabelSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesLabelSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesLabelSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region IncludeUninitialized
    /// <inheritdoc cref="KubernetesLabelSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.IncludeUninitialized))]
    public static T SetIncludeUninitialized<T>(this T o, bool? v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, v));
    /// <inheritdoc cref="KubernetesLabelSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.IncludeUninitialized))]
    public static T ResetIncludeUninitialized<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.IncludeUninitialized));
    /// <inheritdoc cref="KubernetesLabelSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.IncludeUninitialized))]
    public static T EnableIncludeUninitialized<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, true));
    /// <inheritdoc cref="KubernetesLabelSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.IncludeUninitialized))]
    public static T DisableIncludeUninitialized<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, false));
    /// <inheritdoc cref="KubernetesLabelSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.IncludeUninitialized))]
    public static T ToggleIncludeUninitialized<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, !o.IncludeUninitialized));
    #endregion
    #region List
    /// <inheritdoc cref="KubernetesLabelSettings.List"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.List))]
    public static T SetList<T>(this T o, bool? v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.List, v));
    /// <inheritdoc cref="KubernetesLabelSettings.List"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.List))]
    public static T ResetList<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.List));
    /// <inheritdoc cref="KubernetesLabelSettings.List"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.List))]
    public static T EnableList<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.List, true));
    /// <inheritdoc cref="KubernetesLabelSettings.List"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.List))]
    public static T DisableList<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.List, false));
    /// <inheritdoc cref="KubernetesLabelSettings.List"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.List))]
    public static T ToggleList<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.List, !o.List));
    #endregion
    #region Local
    /// <inheritdoc cref="KubernetesLabelSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Local))]
    public static T SetLocal<T>(this T o, bool? v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Local, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Local))]
    public static T ResetLocal<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.Local));
    /// <inheritdoc cref="KubernetesLabelSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Local))]
    public static T EnableLocal<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Local, true));
    /// <inheritdoc cref="KubernetesLabelSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Local))]
    public static T DisableLocal<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Local, false));
    /// <inheritdoc cref="KubernetesLabelSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Local))]
    public static T ToggleLocal<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Local, !o.Local));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesLabelSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesLabelOutput v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Overwrite
    /// <inheritdoc cref="KubernetesLabelSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Overwrite))]
    public static T SetOverwrite<T>(this T o, bool? v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Overwrite, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Overwrite))]
    public static T ResetOverwrite<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.Overwrite));
    /// <inheritdoc cref="KubernetesLabelSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Overwrite))]
    public static T EnableOverwrite<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Overwrite, true));
    /// <inheritdoc cref="KubernetesLabelSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Overwrite))]
    public static T DisableOverwrite<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Overwrite, false));
    /// <inheritdoc cref="KubernetesLabelSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Overwrite))]
    public static T ToggleOverwrite<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Overwrite, !o.Overwrite));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesLabelSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesLabelSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesLabelSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesLabelSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesLabelSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesLabelSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesLabelSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesLabelSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region ResourceVersion
    /// <inheritdoc cref="KubernetesLabelSettings.ResourceVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.ResourceVersion))]
    public static T SetResourceVersion<T>(this T o, string v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.ResourceVersion, v));
    /// <inheritdoc cref="KubernetesLabelSettings.ResourceVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.ResourceVersion))]
    public static T ResetResourceVersion<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.ResourceVersion));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesLabelSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesLabelSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesLabelSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesLabelSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesLabelSettings), Property = nameof(KubernetesLabelSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesLabelSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
}
#endregion
#region KubernetesAnnotateSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesAnnotate(Nuke.Common.Tools.Kubernetes.KubernetesAnnotateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesAnnotateSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesAnnotateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesAnnotateSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesAnnotateSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesAnnotateSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesAnnotateSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region Annotations
    /// <inheritdoc cref="KubernetesAnnotateSettings.Annotations"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Annotations))]
    public static T SetAnnotations<T>(this T o, IDictionary<string, string> v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Annotations, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Annotations"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Annotations))]
    public static T SetAnnotation<T>(this T o, string k, string v) where T : KubernetesAnnotateSettings => o.Modify(b => b.SetDictionary(() => o.Annotations, k, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Annotations"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Annotations))]
    public static T AddAnnotation<T>(this T o, string k, string v) where T : KubernetesAnnotateSettings => o.Modify(b => b.AddDictionary(() => o.Annotations, k, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Annotations"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Annotations))]
    public static T RemoveAnnotation<T>(this T o, string k) where T : KubernetesAnnotateSettings => o.Modify(b => b.RemoveDictionary(() => o.Annotations, k));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Annotations"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Annotations))]
    public static T ClearAnnotations<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.ClearDictionary(() => o.Annotations));
    #endregion
    #region All
    /// <inheritdoc cref="KubernetesAnnotateSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.All))]
    public static T SetAll<T>(this T o, bool? v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.All, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.All))]
    public static T ResetAll<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.All));
    /// <inheritdoc cref="KubernetesAnnotateSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.All))]
    public static T EnableAll<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.All, true));
    /// <inheritdoc cref="KubernetesAnnotateSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.All))]
    public static T DisableAll<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.All, false));
    /// <inheritdoc cref="KubernetesAnnotateSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.All))]
    public static T ToggleAll<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.All, !o.All));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesAnnotateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesAnnotateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesAnnotateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesAnnotateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesAnnotateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesAnnotateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesAnnotateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesAnnotateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region FieldSelector
    /// <inheritdoc cref="KubernetesAnnotateSettings.FieldSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.FieldSelector))]
    public static T SetFieldSelector<T>(this T o, string v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.FieldSelector, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.FieldSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.FieldSelector))]
    public static T ResetFieldSelector<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.FieldSelector));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesAnnotateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesAnnotateSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesAnnotateSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesAnnotateSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesAnnotateSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region IncludeUninitialized
    /// <inheritdoc cref="KubernetesAnnotateSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.IncludeUninitialized))]
    public static T SetIncludeUninitialized<T>(this T o, bool? v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.IncludeUninitialized))]
    public static T ResetIncludeUninitialized<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.IncludeUninitialized));
    /// <inheritdoc cref="KubernetesAnnotateSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.IncludeUninitialized))]
    public static T EnableIncludeUninitialized<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, true));
    /// <inheritdoc cref="KubernetesAnnotateSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.IncludeUninitialized))]
    public static T DisableIncludeUninitialized<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, false));
    /// <inheritdoc cref="KubernetesAnnotateSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.IncludeUninitialized))]
    public static T ToggleIncludeUninitialized<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, !o.IncludeUninitialized));
    #endregion
    #region Local
    /// <inheritdoc cref="KubernetesAnnotateSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Local))]
    public static T SetLocal<T>(this T o, bool? v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Local, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Local))]
    public static T ResetLocal<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.Local));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Local))]
    public static T EnableLocal<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Local, true));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Local))]
    public static T DisableLocal<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Local, false));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Local))]
    public static T ToggleLocal<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Local, !o.Local));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesAnnotateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesAnnotateOutput v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Overwrite
    /// <inheritdoc cref="KubernetesAnnotateSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Overwrite))]
    public static T SetOverwrite<T>(this T o, bool? v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Overwrite, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Overwrite))]
    public static T ResetOverwrite<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.Overwrite));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Overwrite))]
    public static T EnableOverwrite<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Overwrite, true));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Overwrite))]
    public static T DisableOverwrite<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Overwrite, false));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Overwrite))]
    public static T ToggleOverwrite<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Overwrite, !o.Overwrite));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesAnnotateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesAnnotateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region ResourceVersion
    /// <inheritdoc cref="KubernetesAnnotateSettings.ResourceVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.ResourceVersion))]
    public static T SetResourceVersion<T>(this T o, string v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.ResourceVersion, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.ResourceVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.ResourceVersion))]
    public static T ResetResourceVersion<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.ResourceVersion));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesAnnotateSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesAnnotateSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesAnnotateSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesAnnotateSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesAnnotateSettings), Property = nameof(KubernetesAnnotateSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesAnnotateSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
}
#endregion
#region KubernetesDeleteSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesDelete(Nuke.Common.Tools.Kubernetes.KubernetesDeleteSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesDeleteSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesDeleteSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesDeleteSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesDeleteSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesDeleteSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesDeleteSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region All
    /// <inheritdoc cref="KubernetesDeleteSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.All))]
    public static T SetAll<T>(this T o, bool? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.All, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.All))]
    public static T ResetAll<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.All));
    /// <inheritdoc cref="KubernetesDeleteSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.All))]
    public static T EnableAll<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.All, true));
    /// <inheritdoc cref="KubernetesDeleteSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.All))]
    public static T DisableAll<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.All, false));
    /// <inheritdoc cref="KubernetesDeleteSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.All))]
    public static T ToggleAll<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.All, !o.All));
    #endregion
    #region Cascade
    /// <inheritdoc cref="KubernetesDeleteSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Cascade))]
    public static T SetCascade<T>(this T o, bool? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Cascade, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Cascade))]
    public static T ResetCascade<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.Cascade));
    /// <inheritdoc cref="KubernetesDeleteSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Cascade))]
    public static T EnableCascade<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Cascade, true));
    /// <inheritdoc cref="KubernetesDeleteSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Cascade))]
    public static T DisableCascade<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Cascade, false));
    /// <inheritdoc cref="KubernetesDeleteSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Cascade))]
    public static T ToggleCascade<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Cascade, !o.Cascade));
    #endregion
    #region FieldSelector
    /// <inheritdoc cref="KubernetesDeleteSettings.FieldSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.FieldSelector))]
    public static T SetFieldSelector<T>(this T o, string v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.FieldSelector, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.FieldSelector"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.FieldSelector))]
    public static T ResetFieldSelector<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.FieldSelector));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesDeleteSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesDeleteSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesDeleteSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesDeleteSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesDeleteSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Force
    /// <inheritdoc cref="KubernetesDeleteSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Force))]
    public static T ResetForce<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="KubernetesDeleteSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Force))]
    public static T EnableForce<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="KubernetesDeleteSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Force))]
    public static T DisableForce<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="KubernetesDeleteSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region GracePeriod
    /// <inheritdoc cref="KubernetesDeleteSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.GracePeriod))]
    public static T SetGracePeriod<T>(this T o, int? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.GracePeriod, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.GracePeriod))]
    public static T ResetGracePeriod<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.GracePeriod));
    #endregion
    #region IgnoreNotFound
    /// <inheritdoc cref="KubernetesDeleteSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IgnoreNotFound))]
    public static T SetIgnoreNotFound<T>(this T o, bool? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.IgnoreNotFound, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IgnoreNotFound))]
    public static T ResetIgnoreNotFound<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.IgnoreNotFound));
    /// <inheritdoc cref="KubernetesDeleteSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IgnoreNotFound))]
    public static T EnableIgnoreNotFound<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.IgnoreNotFound, true));
    /// <inheritdoc cref="KubernetesDeleteSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IgnoreNotFound))]
    public static T DisableIgnoreNotFound<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.IgnoreNotFound, false));
    /// <inheritdoc cref="KubernetesDeleteSettings.IgnoreNotFound"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IgnoreNotFound))]
    public static T ToggleIgnoreNotFound<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.IgnoreNotFound, !o.IgnoreNotFound));
    #endregion
    #region IncludeUninitialized
    /// <inheritdoc cref="KubernetesDeleteSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IncludeUninitialized))]
    public static T SetIncludeUninitialized<T>(this T o, bool? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IncludeUninitialized))]
    public static T ResetIncludeUninitialized<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.IncludeUninitialized));
    /// <inheritdoc cref="KubernetesDeleteSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IncludeUninitialized))]
    public static T EnableIncludeUninitialized<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, true));
    /// <inheritdoc cref="KubernetesDeleteSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IncludeUninitialized))]
    public static T DisableIncludeUninitialized<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, false));
    /// <inheritdoc cref="KubernetesDeleteSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.IncludeUninitialized))]
    public static T ToggleIncludeUninitialized<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, !o.IncludeUninitialized));
    #endregion
    #region Now
    /// <inheritdoc cref="KubernetesDeleteSettings.Now"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Now))]
    public static T SetNow<T>(this T o, bool? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Now, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Now"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Now))]
    public static T ResetNow<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.Now));
    /// <inheritdoc cref="KubernetesDeleteSettings.Now"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Now))]
    public static T EnableNow<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Now, true));
    /// <inheritdoc cref="KubernetesDeleteSettings.Now"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Now))]
    public static T DisableNow<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Now, false));
    /// <inheritdoc cref="KubernetesDeleteSettings.Now"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Now))]
    public static T ToggleNow<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Now, !o.Now));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesDeleteSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Output))]
    public static T SetOutput<T>(this T o, string v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesDeleteSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesDeleteSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesDeleteSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesDeleteSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesDeleteSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesDeleteSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
    #region Wait
    /// <inheritdoc cref="KubernetesDeleteSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Wait))]
    public static T SetWait<T>(this T o, bool? v) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Wait, v));
    /// <inheritdoc cref="KubernetesDeleteSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Wait))]
    public static T ResetWait<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Remove(() => o.Wait));
    /// <inheritdoc cref="KubernetesDeleteSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Wait))]
    public static T EnableWait<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Wait, true));
    /// <inheritdoc cref="KubernetesDeleteSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Wait))]
    public static T DisableWait<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Wait, false));
    /// <inheritdoc cref="KubernetesDeleteSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesDeleteSettings), Property = nameof(KubernetesDeleteSettings.Wait))]
    public static T ToggleWait<T>(this T o) where T : KubernetesDeleteSettings => o.Modify(b => b.Set(() => o.Wait, !o.Wait));
    #endregion
}
#endregion
#region KubernetesExposeSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesExpose(Nuke.Common.Tools.Kubernetes.KubernetesExposeSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesExposeSettingsExtensions
{
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesExposeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesExposeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesExposeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesExposeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesExposeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region ClusterIp
    /// <inheritdoc cref="KubernetesExposeSettings.ClusterIp"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.ClusterIp))]
    public static T SetClusterIp<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.ClusterIp, v));
    /// <inheritdoc cref="KubernetesExposeSettings.ClusterIp"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.ClusterIp))]
    public static T ResetClusterIp<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.ClusterIp));
    #endregion
    #region ContainerPort
    /// <inheritdoc cref="KubernetesExposeSettings.ContainerPort"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.ContainerPort))]
    public static T SetContainerPort<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.ContainerPort, v));
    /// <inheritdoc cref="KubernetesExposeSettings.ContainerPort"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.ContainerPort))]
    public static T ResetContainerPort<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.ContainerPort));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesExposeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesExposeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesExposeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesExposeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesExposeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region ExternalIp
    /// <inheritdoc cref="KubernetesExposeSettings.ExternalIp"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.ExternalIp))]
    public static T SetExternalIp<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.ExternalIp, v));
    /// <inheritdoc cref="KubernetesExposeSettings.ExternalIp"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.ExternalIp))]
    public static T ResetExternalIp<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.ExternalIp));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesExposeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesExposeSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesExposeSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesExposeSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesExposeSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Generator
    /// <inheritdoc cref="KubernetesExposeSettings.Generator"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Generator))]
    public static T SetGenerator<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Generator, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Generator"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Generator))]
    public static T ResetGenerator<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Generator));
    #endregion
    #region Labels
    /// <inheritdoc cref="KubernetesExposeSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Labels))]
    public static T SetLabels<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Labels, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Labels))]
    public static T ResetLabels<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Labels));
    #endregion
    #region LoadBalancerIp
    /// <inheritdoc cref="KubernetesExposeSettings.LoadBalancerIp"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.LoadBalancerIp))]
    public static T SetLoadBalancerIp<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.LoadBalancerIp, v));
    /// <inheritdoc cref="KubernetesExposeSettings.LoadBalancerIp"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.LoadBalancerIp))]
    public static T ResetLoadBalancerIp<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.LoadBalancerIp));
    #endregion
    #region Name
    /// <inheritdoc cref="KubernetesExposeSettings.Name"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Name))]
    public static T SetName<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Name, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Name"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Name))]
    public static T ResetName<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Name));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesExposeSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesExposeOutput v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Overrides
    /// <inheritdoc cref="KubernetesExposeSettings.Overrides"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Overrides))]
    public static T SetOverrides<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Overrides, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Overrides"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Overrides))]
    public static T ResetOverrides<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Overrides));
    #endregion
    #region Port
    /// <inheritdoc cref="KubernetesExposeSettings.Port"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Port))]
    public static T SetPort<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Port, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Port"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Port))]
    public static T ResetPort<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Port));
    #endregion
    #region Protocol
    /// <inheritdoc cref="KubernetesExposeSettings.Protocol"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Protocol))]
    public static T SetProtocol<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Protocol, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Protocol"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Protocol))]
    public static T ResetProtocol<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Protocol));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesExposeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesExposeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesExposeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesExposeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesExposeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesExposeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesExposeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesExposeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region SaveConfig
    /// <inheritdoc cref="KubernetesExposeSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.SaveConfig))]
    public static T SetSaveConfig<T>(this T o, bool? v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.SaveConfig, v));
    /// <inheritdoc cref="KubernetesExposeSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.SaveConfig))]
    public static T ResetSaveConfig<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.SaveConfig));
    /// <inheritdoc cref="KubernetesExposeSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.SaveConfig))]
    public static T EnableSaveConfig<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.SaveConfig, true));
    /// <inheritdoc cref="KubernetesExposeSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.SaveConfig))]
    public static T DisableSaveConfig<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.SaveConfig, false));
    /// <inheritdoc cref="KubernetesExposeSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.SaveConfig))]
    public static T ToggleSaveConfig<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.SaveConfig, !o.SaveConfig));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesExposeSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region SessionAffinity
    /// <inheritdoc cref="KubernetesExposeSettings.SessionAffinity"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.SessionAffinity))]
    public static T SetSessionAffinity<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.SessionAffinity, v));
    /// <inheritdoc cref="KubernetesExposeSettings.SessionAffinity"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.SessionAffinity))]
    public static T ResetSessionAffinity<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.SessionAffinity));
    #endregion
    #region TargetPort
    /// <inheritdoc cref="KubernetesExposeSettings.TargetPort"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.TargetPort))]
    public static T SetTargetPort<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.TargetPort, v));
    /// <inheritdoc cref="KubernetesExposeSettings.TargetPort"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.TargetPort))]
    public static T ResetTargetPort<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.TargetPort));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesExposeSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Type
    /// <inheritdoc cref="KubernetesExposeSettings.Type"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Type))]
    public static T SetType<T>(this T o, string v) where T : KubernetesExposeSettings => o.Modify(b => b.Set(() => o.Type, v));
    /// <inheritdoc cref="KubernetesExposeSettings.Type"/>
    [Pure] [Builder(Type = typeof(KubernetesExposeSettings), Property = nameof(KubernetesExposeSettings.Type))]
    public static T ResetType<T>(this T o) where T : KubernetesExposeSettings => o.Modify(b => b.Remove(() => o.Type));
    #endregion
}
#endregion
#region KubernetesOptionsSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesOptions(Nuke.Common.Tools.Kubernetes.KubernetesOptionsSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesOptionsSettingsExtensions
{
}
#endregion
#region KubernetesAttachSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesAttach(Nuke.Common.Tools.Kubernetes.KubernetesAttachSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesAttachSettingsExtensions
{
    #region Pod
    /// <inheritdoc cref="KubernetesAttachSettings.Pod"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Pod))]
    public static T SetPod<T>(this T o, params string[] v) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Pod, v));
    /// <inheritdoc cref="KubernetesAttachSettings.Pod"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Pod))]
    public static T SetPod<T>(this T o, IEnumerable<string> v) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Pod, v));
    /// <inheritdoc cref="KubernetesAttachSettings.Pod"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Pod))]
    public static T AddPod<T>(this T o, params string[] v) where T : KubernetesAttachSettings => o.Modify(b => b.AddCollection(() => o.Pod, v));
    /// <inheritdoc cref="KubernetesAttachSettings.Pod"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Pod))]
    public static T AddPod<T>(this T o, IEnumerable<string> v) where T : KubernetesAttachSettings => o.Modify(b => b.AddCollection(() => o.Pod, v));
    /// <inheritdoc cref="KubernetesAttachSettings.Pod"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Pod))]
    public static T RemovePod<T>(this T o, params string[] v) where T : KubernetesAttachSettings => o.Modify(b => b.RemoveCollection(() => o.Pod, v));
    /// <inheritdoc cref="KubernetesAttachSettings.Pod"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Pod))]
    public static T RemovePod<T>(this T o, IEnumerable<string> v) where T : KubernetesAttachSettings => o.Modify(b => b.RemoveCollection(() => o.Pod, v));
    /// <inheritdoc cref="KubernetesAttachSettings.Pod"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Pod))]
    public static T ClearPod<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.ClearCollection(() => o.Pod));
    #endregion
    #region Container
    /// <inheritdoc cref="KubernetesAttachSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Container))]
    public static T SetContainer<T>(this T o, string v) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Container, v));
    /// <inheritdoc cref="KubernetesAttachSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Container))]
    public static T ResetContainer<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Remove(() => o.Container));
    #endregion
    #region PodRunningTimeout
    /// <inheritdoc cref="KubernetesAttachSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.PodRunningTimeout))]
    public static T SetPodRunningTimeout<T>(this T o, TimeSpan? v) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.PodRunningTimeout, v));
    /// <inheritdoc cref="KubernetesAttachSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.PodRunningTimeout))]
    public static T ResetPodRunningTimeout<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Remove(() => o.PodRunningTimeout));
    #endregion
    #region Stdin
    /// <inheritdoc cref="KubernetesAttachSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Stdin))]
    public static T SetStdin<T>(this T o, bool? v) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Stdin, v));
    /// <inheritdoc cref="KubernetesAttachSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Stdin))]
    public static T ResetStdin<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Remove(() => o.Stdin));
    /// <inheritdoc cref="KubernetesAttachSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Stdin))]
    public static T EnableStdin<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Stdin, true));
    /// <inheritdoc cref="KubernetesAttachSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Stdin))]
    public static T DisableStdin<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Stdin, false));
    /// <inheritdoc cref="KubernetesAttachSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Stdin))]
    public static T ToggleStdin<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Stdin, !o.Stdin));
    #endregion
    #region Tty
    /// <inheritdoc cref="KubernetesAttachSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Tty))]
    public static T SetTty<T>(this T o, bool? v) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Tty, v));
    /// <inheritdoc cref="KubernetesAttachSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Tty))]
    public static T ResetTty<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Remove(() => o.Tty));
    /// <inheritdoc cref="KubernetesAttachSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Tty))]
    public static T EnableTty<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Tty, true));
    /// <inheritdoc cref="KubernetesAttachSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Tty))]
    public static T DisableTty<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Tty, false));
    /// <inheritdoc cref="KubernetesAttachSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesAttachSettings), Property = nameof(KubernetesAttachSettings.Tty))]
    public static T ToggleTty<T>(this T o) where T : KubernetesAttachSettings => o.Modify(b => b.Set(() => o.Tty, !o.Tty));
    #endregion
}
#endregion
#region KubernetesProxySettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesProxy(Nuke.Common.Tools.Kubernetes.KubernetesProxySettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesProxySettingsExtensions
{
    #region AcceptHosts
    /// <inheritdoc cref="KubernetesProxySettings.AcceptHosts"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.AcceptHosts))]
    public static T SetAcceptHosts<T>(this T o, string v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.AcceptHosts, v));
    /// <inheritdoc cref="KubernetesProxySettings.AcceptHosts"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.AcceptHosts))]
    public static T ResetAcceptHosts<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.AcceptHosts));
    #endregion
    #region AcceptPaths
    /// <inheritdoc cref="KubernetesProxySettings.AcceptPaths"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.AcceptPaths))]
    public static T SetAcceptPaths<T>(this T o, string v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.AcceptPaths, v));
    /// <inheritdoc cref="KubernetesProxySettings.AcceptPaths"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.AcceptPaths))]
    public static T ResetAcceptPaths<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.AcceptPaths));
    #endregion
    #region Address
    /// <inheritdoc cref="KubernetesProxySettings.Address"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.Address))]
    public static T SetAddress<T>(this T o, string v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.Address, v));
    /// <inheritdoc cref="KubernetesProxySettings.Address"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.Address))]
    public static T ResetAddress<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.Address));
    #endregion
    #region ApiPrefix
    /// <inheritdoc cref="KubernetesProxySettings.ApiPrefix"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.ApiPrefix))]
    public static T SetApiPrefix<T>(this T o, string v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.ApiPrefix, v));
    /// <inheritdoc cref="KubernetesProxySettings.ApiPrefix"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.ApiPrefix))]
    public static T ResetApiPrefix<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.ApiPrefix));
    #endregion
    #region DisableFilter
    /// <inheritdoc cref="KubernetesProxySettings.DisableFilter"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.DisableFilter))]
    public static T SetDisableFilter<T>(this T o, bool? v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.DisableFilter, v));
    /// <inheritdoc cref="KubernetesProxySettings.DisableFilter"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.DisableFilter))]
    public static T ResetDisableFilter<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.DisableFilter));
    /// <inheritdoc cref="KubernetesProxySettings.DisableFilter"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.DisableFilter))]
    public static T EnableDisableFilter<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.DisableFilter, true));
    /// <inheritdoc cref="KubernetesProxySettings.DisableFilter"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.DisableFilter))]
    public static T DisableDisableFilter<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.DisableFilter, false));
    /// <inheritdoc cref="KubernetesProxySettings.DisableFilter"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.DisableFilter))]
    public static T ToggleDisableFilter<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.DisableFilter, !o.DisableFilter));
    #endregion
    #region Port
    /// <inheritdoc cref="KubernetesProxySettings.Port"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.Port))]
    public static T SetPort<T>(this T o, int? v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.Port, v));
    /// <inheritdoc cref="KubernetesProxySettings.Port"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.Port))]
    public static T ResetPort<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.Port));
    #endregion
    #region RejectMethods
    /// <inheritdoc cref="KubernetesProxySettings.RejectMethods"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.RejectMethods))]
    public static T SetRejectMethods<T>(this T o, string v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.RejectMethods, v));
    /// <inheritdoc cref="KubernetesProxySettings.RejectMethods"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.RejectMethods))]
    public static T ResetRejectMethods<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.RejectMethods));
    #endregion
    #region RejectPaths
    /// <inheritdoc cref="KubernetesProxySettings.RejectPaths"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.RejectPaths))]
    public static T SetRejectPaths<T>(this T o, string v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.RejectPaths, v));
    /// <inheritdoc cref="KubernetesProxySettings.RejectPaths"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.RejectPaths))]
    public static T ResetRejectPaths<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.RejectPaths));
    #endregion
    #region UnixSocket
    /// <inheritdoc cref="KubernetesProxySettings.UnixSocket"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.UnixSocket))]
    public static T SetUnixSocket<T>(this T o, string v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.UnixSocket, v));
    /// <inheritdoc cref="KubernetesProxySettings.UnixSocket"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.UnixSocket))]
    public static T ResetUnixSocket<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.UnixSocket));
    #endregion
    #region Www
    /// <inheritdoc cref="KubernetesProxySettings.Www"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.Www))]
    public static T SetWww<T>(this T o, string v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.Www, v));
    /// <inheritdoc cref="KubernetesProxySettings.Www"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.Www))]
    public static T ResetWww<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.Www));
    #endregion
    #region WwwPrefix
    /// <inheritdoc cref="KubernetesProxySettings.WwwPrefix"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.WwwPrefix))]
    public static T SetWwwPrefix<T>(this T o, string v) where T : KubernetesProxySettings => o.Modify(b => b.Set(() => o.WwwPrefix, v));
    /// <inheritdoc cref="KubernetesProxySettings.WwwPrefix"/>
    [Pure] [Builder(Type = typeof(KubernetesProxySettings), Property = nameof(KubernetesProxySettings.WwwPrefix))]
    public static T ResetWwwPrefix<T>(this T o) where T : KubernetesProxySettings => o.Modify(b => b.Remove(() => o.WwwPrefix));
    #endregion
}
#endregion
#region KubernetesAlphaSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesAlpha(Nuke.Common.Tools.Kubernetes.KubernetesAlphaSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesAlphaSettingsExtensions
{
}
#endregion
#region KubernetesSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.Kubernetes(Nuke.Common.Tools.Kubernetes.KubernetesSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesSettingsExtensions
{
}
#endregion
#region KubernetesCompletionSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesCompletion(Nuke.Common.Tools.Kubernetes.KubernetesCompletionSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesCompletionSettingsExtensions
{
}
#endregion
#region KubernetesPatchSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesPatch(Nuke.Common.Tools.Kubernetes.KubernetesPatchSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesPatchSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesPatchSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPatchSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPatchSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesPatchSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPatchSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesPatchSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPatchSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesPatchSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPatchSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesPatchSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPatchSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesPatchSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesPatchSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesPatchSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesPatchSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesPatchSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesPatchSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesPatchSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesPatchSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesPatchSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesPatchSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesPatchSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesPatchSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesPatchSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesPatchSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesPatchSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Local
    /// <inheritdoc cref="KubernetesPatchSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Local))]
    public static T SetLocal<T>(this T o, bool? v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Local, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Local))]
    public static T ResetLocal<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Remove(() => o.Local));
    /// <inheritdoc cref="KubernetesPatchSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Local))]
    public static T EnableLocal<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Local, true));
    /// <inheritdoc cref="KubernetesPatchSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Local))]
    public static T DisableLocal<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Local, false));
    /// <inheritdoc cref="KubernetesPatchSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Local))]
    public static T ToggleLocal<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Local, !o.Local));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesPatchSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesPatchOutput v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Patch
    /// <inheritdoc cref="KubernetesPatchSettings.Patch"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Patch))]
    public static T SetPatch<T>(this T o, string v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Patch, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Patch"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Patch))]
    public static T ResetPatch<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Remove(() => o.Patch));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesPatchSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesPatchSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesPatchSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesPatchSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesPatchSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesPatchSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesPatchSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesPatchSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesPatchSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Type
    /// <inheritdoc cref="KubernetesPatchSettings.Type"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Type))]
    public static T SetType<T>(this T o, KubernetesPatchType v) where T : KubernetesPatchSettings => o.Modify(b => b.Set(() => o.Type, v));
    /// <inheritdoc cref="KubernetesPatchSettings.Type"/>
    [Pure] [Builder(Type = typeof(KubernetesPatchSettings), Property = nameof(KubernetesPatchSettings.Type))]
    public static T ResetType<T>(this T o) where T : KubernetesPatchSettings => o.Modify(b => b.Remove(() => o.Type));
    #endregion
}
#endregion
#region KubernetesReplaceSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesReplace(Nuke.Common.Tools.Kubernetes.KubernetesReplaceSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesReplaceSettingsExtensions
{
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesReplaceSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesReplaceSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesReplaceSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesReplaceSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Cascade
    /// <inheritdoc cref="KubernetesReplaceSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Cascade))]
    public static T SetCascade<T>(this T o, bool? v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Cascade, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Cascade))]
    public static T ResetCascade<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.Cascade));
    /// <inheritdoc cref="KubernetesReplaceSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Cascade))]
    public static T EnableCascade<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Cascade, true));
    /// <inheritdoc cref="KubernetesReplaceSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Cascade))]
    public static T DisableCascade<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Cascade, false));
    /// <inheritdoc cref="KubernetesReplaceSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Cascade))]
    public static T ToggleCascade<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Cascade, !o.Cascade));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesReplaceSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesReplaceSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesReplaceSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesReplaceSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesReplaceSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Force
    /// <inheritdoc cref="KubernetesReplaceSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Force))]
    public static T ResetForce<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="KubernetesReplaceSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Force))]
    public static T EnableForce<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="KubernetesReplaceSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Force))]
    public static T DisableForce<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="KubernetesReplaceSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region GracePeriod
    /// <inheritdoc cref="KubernetesReplaceSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.GracePeriod))]
    public static T SetGracePeriod<T>(this T o, int? v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.GracePeriod, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.GracePeriod))]
    public static T ResetGracePeriod<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.GracePeriod));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesReplaceSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesReplaceOutput v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesReplaceSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesReplaceSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesReplaceSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesReplaceSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region SaveConfig
    /// <inheritdoc cref="KubernetesReplaceSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.SaveConfig))]
    public static T SetSaveConfig<T>(this T o, bool? v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.SaveConfig, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.SaveConfig))]
    public static T ResetSaveConfig<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.SaveConfig));
    /// <inheritdoc cref="KubernetesReplaceSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.SaveConfig))]
    public static T EnableSaveConfig<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.SaveConfig, true));
    /// <inheritdoc cref="KubernetesReplaceSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.SaveConfig))]
    public static T DisableSaveConfig<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.SaveConfig, false));
    /// <inheritdoc cref="KubernetesReplaceSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.SaveConfig))]
    public static T ToggleSaveConfig<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.SaveConfig, !o.SaveConfig));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesReplaceSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesReplaceSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
    #region Validate
    /// <inheritdoc cref="KubernetesReplaceSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Validate))]
    public static T SetValidate<T>(this T o, bool? v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Validate, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Validate))]
    public static T ResetValidate<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.Validate));
    /// <inheritdoc cref="KubernetesReplaceSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Validate))]
    public static T EnableValidate<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Validate, true));
    /// <inheritdoc cref="KubernetesReplaceSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Validate))]
    public static T DisableValidate<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Validate, false));
    /// <inheritdoc cref="KubernetesReplaceSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Validate))]
    public static T ToggleValidate<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Validate, !o.Validate));
    #endregion
    #region Wait
    /// <inheritdoc cref="KubernetesReplaceSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Wait))]
    public static T SetWait<T>(this T o, bool? v) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Wait, v));
    /// <inheritdoc cref="KubernetesReplaceSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Wait))]
    public static T ResetWait<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Remove(() => o.Wait));
    /// <inheritdoc cref="KubernetesReplaceSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Wait))]
    public static T EnableWait<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Wait, true));
    /// <inheritdoc cref="KubernetesReplaceSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Wait))]
    public static T DisableWait<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Wait, false));
    /// <inheritdoc cref="KubernetesReplaceSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesReplaceSettings), Property = nameof(KubernetesReplaceSettings.Wait))]
    public static T ToggleWait<T>(this T o) where T : KubernetesReplaceSettings => o.Modify(b => b.Set(() => o.Wait, !o.Wait));
    #endregion
}
#endregion
#region KubernetesTaintSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesTaint(Nuke.Common.Tools.Kubernetes.KubernetesTaintSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesTaintSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesTaintSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesTaintSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesTaintSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesTaintSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesTaintSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesTaintSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesTaintSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesTaintSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesTaintSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesTaintSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesTaintSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region TaintEffects
    /// <inheritdoc cref="KubernetesTaintSettings.TaintEffects"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TaintEffects))]
    public static T SetTaintEffects<T>(this T o, IDictionary<string, string> v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.TaintEffects, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="KubernetesTaintSettings.TaintEffects"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TaintEffects))]
    public static T SetTaintEffect<T>(this T o, string k, string v) where T : KubernetesTaintSettings => o.Modify(b => b.SetDictionary(() => o.TaintEffects, k, v));
    /// <inheritdoc cref="KubernetesTaintSettings.TaintEffects"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TaintEffects))]
    public static T AddTaintEffect<T>(this T o, string k, string v) where T : KubernetesTaintSettings => o.Modify(b => b.AddDictionary(() => o.TaintEffects, k, v));
    /// <inheritdoc cref="KubernetesTaintSettings.TaintEffects"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TaintEffects))]
    public static T RemoveTaintEffect<T>(this T o, string k) where T : KubernetesTaintSettings => o.Modify(b => b.RemoveDictionary(() => o.TaintEffects, k));
    /// <inheritdoc cref="KubernetesTaintSettings.TaintEffects"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.TaintEffects))]
    public static T ClearTaintEffects<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.ClearDictionary(() => o.TaintEffects));
    #endregion
    #region All
    /// <inheritdoc cref="KubernetesTaintSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.All))]
    public static T SetAll<T>(this T o, bool? v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.All, v));
    /// <inheritdoc cref="KubernetesTaintSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.All))]
    public static T ResetAll<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Remove(() => o.All));
    /// <inheritdoc cref="KubernetesTaintSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.All))]
    public static T EnableAll<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.All, true));
    /// <inheritdoc cref="KubernetesTaintSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.All))]
    public static T DisableAll<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.All, false));
    /// <inheritdoc cref="KubernetesTaintSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.All))]
    public static T ToggleAll<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.All, !o.All));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesTaintSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesTaintSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesTaintSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesTaintSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesTaintSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesTaintSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesTaintOutput v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesTaintSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Overwrite
    /// <inheritdoc cref="KubernetesTaintSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Overwrite))]
    public static T SetOverwrite<T>(this T o, bool? v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Overwrite, v));
    /// <inheritdoc cref="KubernetesTaintSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Overwrite))]
    public static T ResetOverwrite<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Remove(() => o.Overwrite));
    /// <inheritdoc cref="KubernetesTaintSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Overwrite))]
    public static T EnableOverwrite<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Overwrite, true));
    /// <inheritdoc cref="KubernetesTaintSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Overwrite))]
    public static T DisableOverwrite<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Overwrite, false));
    /// <inheritdoc cref="KubernetesTaintSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Overwrite))]
    public static T ToggleOverwrite<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Overwrite, !o.Overwrite));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesTaintSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesTaintSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesTaintSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesTaintSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Validate
    /// <inheritdoc cref="KubernetesTaintSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Validate))]
    public static T SetValidate<T>(this T o, bool? v) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Validate, v));
    /// <inheritdoc cref="KubernetesTaintSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Validate))]
    public static T ResetValidate<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Remove(() => o.Validate));
    /// <inheritdoc cref="KubernetesTaintSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Validate))]
    public static T EnableValidate<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Validate, true));
    /// <inheritdoc cref="KubernetesTaintSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Validate))]
    public static T DisableValidate<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Validate, false));
    /// <inheritdoc cref="KubernetesTaintSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesTaintSettings), Property = nameof(KubernetesTaintSettings.Validate))]
    public static T ToggleValidate<T>(this T o) where T : KubernetesTaintSettings => o.Modify(b => b.Set(() => o.Validate, !o.Validate));
    #endregion
}
#endregion
#region KubernetesDescribeSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesDescribe(Nuke.Common.Tools.Kubernetes.KubernetesDescribeSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesDescribeSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesDescribeSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesDescribeSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesDescribeSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesDescribeSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesDescribeSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region AllNamespaces
    /// <inheritdoc cref="KubernetesDescribeSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.AllNamespaces))]
    public static T SetAllNamespaces<T>(this T o, bool? v) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.AllNamespaces, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.AllNamespaces))]
    public static T ResetAllNamespaces<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Remove(() => o.AllNamespaces));
    /// <inheritdoc cref="KubernetesDescribeSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.AllNamespaces))]
    public static T EnableAllNamespaces<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.AllNamespaces, true));
    /// <inheritdoc cref="KubernetesDescribeSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.AllNamespaces))]
    public static T DisableAllNamespaces<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.AllNamespaces, false));
    /// <inheritdoc cref="KubernetesDescribeSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.AllNamespaces))]
    public static T ToggleAllNamespaces<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.AllNamespaces, !o.AllNamespaces));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesDescribeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesDescribeSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesDescribeSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesDescribeSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesDescribeSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region IncludeUninitialized
    /// <inheritdoc cref="KubernetesDescribeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.IncludeUninitialized))]
    public static T SetIncludeUninitialized<T>(this T o, bool? v) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.IncludeUninitialized))]
    public static T ResetIncludeUninitialized<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Remove(() => o.IncludeUninitialized));
    /// <inheritdoc cref="KubernetesDescribeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.IncludeUninitialized))]
    public static T EnableIncludeUninitialized<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, true));
    /// <inheritdoc cref="KubernetesDescribeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.IncludeUninitialized))]
    public static T DisableIncludeUninitialized<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, false));
    /// <inheritdoc cref="KubernetesDescribeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.IncludeUninitialized))]
    public static T ToggleIncludeUninitialized<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, !o.IncludeUninitialized));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesDescribeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesDescribeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesDescribeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesDescribeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesDescribeSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region ShowEvents
    /// <inheritdoc cref="KubernetesDescribeSettings.ShowEvents"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.ShowEvents))]
    public static T SetShowEvents<T>(this T o, bool? v) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.ShowEvents, v));
    /// <inheritdoc cref="KubernetesDescribeSettings.ShowEvents"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.ShowEvents))]
    public static T ResetShowEvents<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Remove(() => o.ShowEvents));
    /// <inheritdoc cref="KubernetesDescribeSettings.ShowEvents"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.ShowEvents))]
    public static T EnableShowEvents<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.ShowEvents, true));
    /// <inheritdoc cref="KubernetesDescribeSettings.ShowEvents"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.ShowEvents))]
    public static T DisableShowEvents<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.ShowEvents, false));
    /// <inheritdoc cref="KubernetesDescribeSettings.ShowEvents"/>
    [Pure] [Builder(Type = typeof(KubernetesDescribeSettings), Property = nameof(KubernetesDescribeSettings.ShowEvents))]
    public static T ToggleShowEvents<T>(this T o) where T : KubernetesDescribeSettings => o.Modify(b => b.Set(() => o.ShowEvents, !o.ShowEvents));
    #endregion
}
#endregion
#region KubernetesSetSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesSet(Nuke.Common.Tools.Kubernetes.KubernetesSetSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesSetSettingsExtensions
{
    #region Subcommand
    /// <inheritdoc cref="KubernetesSetSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesSetSettings), Property = nameof(KubernetesSetSettings.Subcommand))]
    public static T SetSubcommand<T>(this T o, params string[] v) where T : KubernetesSetSettings => o.Modify(b => b.Set(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesSetSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesSetSettings), Property = nameof(KubernetesSetSettings.Subcommand))]
    public static T SetSubcommand<T>(this T o, IEnumerable<string> v) where T : KubernetesSetSettings => o.Modify(b => b.Set(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesSetSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesSetSettings), Property = nameof(KubernetesSetSettings.Subcommand))]
    public static T AddSubcommand<T>(this T o, params string[] v) where T : KubernetesSetSettings => o.Modify(b => b.AddCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesSetSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesSetSettings), Property = nameof(KubernetesSetSettings.Subcommand))]
    public static T AddSubcommand<T>(this T o, IEnumerable<string> v) where T : KubernetesSetSettings => o.Modify(b => b.AddCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesSetSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesSetSettings), Property = nameof(KubernetesSetSettings.Subcommand))]
    public static T RemoveSubcommand<T>(this T o, params string[] v) where T : KubernetesSetSettings => o.Modify(b => b.RemoveCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesSetSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesSetSettings), Property = nameof(KubernetesSetSettings.Subcommand))]
    public static T RemoveSubcommand<T>(this T o, IEnumerable<string> v) where T : KubernetesSetSettings => o.Modify(b => b.RemoveCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesSetSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesSetSettings), Property = nameof(KubernetesSetSettings.Subcommand))]
    public static T ClearSubcommand<T>(this T o) where T : KubernetesSetSettings => o.Modify(b => b.ClearCollection(() => o.Subcommand));
    #endregion
}
#endregion
#region KubernetesAuthSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesAuth(Nuke.Common.Tools.Kubernetes.KubernetesAuthSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesAuthSettingsExtensions
{
    #region Subcommand
    /// <inheritdoc cref="KubernetesAuthSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesAuthSettings), Property = nameof(KubernetesAuthSettings.Subcommand))]
    public static T SetSubcommand<T>(this T o, string v) where T : KubernetesAuthSettings => o.Modify(b => b.Set(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesAuthSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesAuthSettings), Property = nameof(KubernetesAuthSettings.Subcommand))]
    public static T ResetSubcommand<T>(this T o) where T : KubernetesAuthSettings => o.Modify(b => b.Remove(() => o.Subcommand));
    #endregion
}
#endregion
#region KubernetesCertificateSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesCertificate(Nuke.Common.Tools.Kubernetes.KubernetesCertificateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesCertificateSettingsExtensions
{
    #region Subcommand
    /// <inheritdoc cref="KubernetesCertificateSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesCertificateSettings), Property = nameof(KubernetesCertificateSettings.Subcommand))]
    public static T SetSubcommand<T>(this T o, params string[] v) where T : KubernetesCertificateSettings => o.Modify(b => b.Set(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesCertificateSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesCertificateSettings), Property = nameof(KubernetesCertificateSettings.Subcommand))]
    public static T SetSubcommand<T>(this T o, IEnumerable<string> v) where T : KubernetesCertificateSettings => o.Modify(b => b.Set(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesCertificateSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesCertificateSettings), Property = nameof(KubernetesCertificateSettings.Subcommand))]
    public static T AddSubcommand<T>(this T o, params string[] v) where T : KubernetesCertificateSettings => o.Modify(b => b.AddCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesCertificateSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesCertificateSettings), Property = nameof(KubernetesCertificateSettings.Subcommand))]
    public static T AddSubcommand<T>(this T o, IEnumerable<string> v) where T : KubernetesCertificateSettings => o.Modify(b => b.AddCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesCertificateSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesCertificateSettings), Property = nameof(KubernetesCertificateSettings.Subcommand))]
    public static T RemoveSubcommand<T>(this T o, params string[] v) where T : KubernetesCertificateSettings => o.Modify(b => b.RemoveCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesCertificateSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesCertificateSettings), Property = nameof(KubernetesCertificateSettings.Subcommand))]
    public static T RemoveSubcommand<T>(this T o, IEnumerable<string> v) where T : KubernetesCertificateSettings => o.Modify(b => b.RemoveCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesCertificateSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesCertificateSettings), Property = nameof(KubernetesCertificateSettings.Subcommand))]
    public static T ClearSubcommand<T>(this T o) where T : KubernetesCertificateSettings => o.Modify(b => b.ClearCollection(() => o.Subcommand));
    #endregion
}
#endregion
#region KubernetesRolloutSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesRollout(Nuke.Common.Tools.Kubernetes.KubernetesRolloutSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesRolloutSettingsExtensions
{
    #region Subcommand
    /// <inheritdoc cref="KubernetesRolloutSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesRolloutSettings), Property = nameof(KubernetesRolloutSettings.Subcommand))]
    public static T SetSubcommand<T>(this T o, params string[] v) where T : KubernetesRolloutSettings => o.Modify(b => b.Set(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesRolloutSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesRolloutSettings), Property = nameof(KubernetesRolloutSettings.Subcommand))]
    public static T SetSubcommand<T>(this T o, IEnumerable<string> v) where T : KubernetesRolloutSettings => o.Modify(b => b.Set(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesRolloutSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesRolloutSettings), Property = nameof(KubernetesRolloutSettings.Subcommand))]
    public static T AddSubcommand<T>(this T o, params string[] v) where T : KubernetesRolloutSettings => o.Modify(b => b.AddCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesRolloutSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesRolloutSettings), Property = nameof(KubernetesRolloutSettings.Subcommand))]
    public static T AddSubcommand<T>(this T o, IEnumerable<string> v) where T : KubernetesRolloutSettings => o.Modify(b => b.AddCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesRolloutSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesRolloutSettings), Property = nameof(KubernetesRolloutSettings.Subcommand))]
    public static T RemoveSubcommand<T>(this T o, params string[] v) where T : KubernetesRolloutSettings => o.Modify(b => b.RemoveCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesRolloutSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesRolloutSettings), Property = nameof(KubernetesRolloutSettings.Subcommand))]
    public static T RemoveSubcommand<T>(this T o, IEnumerable<string> v) where T : KubernetesRolloutSettings => o.Modify(b => b.RemoveCollection(() => o.Subcommand, v));
    /// <inheritdoc cref="KubernetesRolloutSettings.Subcommand"/>
    [Pure] [Builder(Type = typeof(KubernetesRolloutSettings), Property = nameof(KubernetesRolloutSettings.Subcommand))]
    public static T ClearSubcommand<T>(this T o) where T : KubernetesRolloutSettings => o.Modify(b => b.ClearCollection(() => o.Subcommand));
    #endregion
}
#endregion
#region KubernetesApplySettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesApply(Nuke.Common.Tools.Kubernetes.KubernetesApplySettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesApplySettingsExtensions
{
    #region All
    /// <inheritdoc cref="KubernetesApplySettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.All))]
    public static T SetAll<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.All, v));
    /// <inheritdoc cref="KubernetesApplySettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.All))]
    public static T ResetAll<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.All));
    /// <inheritdoc cref="KubernetesApplySettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.All))]
    public static T EnableAll<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.All, true));
    /// <inheritdoc cref="KubernetesApplySettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.All))]
    public static T DisableAll<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.All, false));
    /// <inheritdoc cref="KubernetesApplySettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.All))]
    public static T ToggleAll<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.All, !o.All));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesApplySettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesApplySettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesApplySettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesApplySettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesApplySettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Cascade
    /// <inheritdoc cref="KubernetesApplySettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Cascade))]
    public static T SetCascade<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Cascade, v));
    /// <inheritdoc cref="KubernetesApplySettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Cascade))]
    public static T ResetCascade<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Cascade));
    /// <inheritdoc cref="KubernetesApplySettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Cascade))]
    public static T EnableCascade<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Cascade, true));
    /// <inheritdoc cref="KubernetesApplySettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Cascade))]
    public static T DisableCascade<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Cascade, false));
    /// <inheritdoc cref="KubernetesApplySettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Cascade))]
    public static T ToggleCascade<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Cascade, !o.Cascade));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesApplySettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesApplySettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesApplySettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesApplySettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesApplySettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesApplySettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplySettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplySettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesApplySettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplySettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesApplySettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplySettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesApplySettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplySettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesApplySettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplySettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Force
    /// <inheritdoc cref="KubernetesApplySettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="KubernetesApplySettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Force))]
    public static T ResetForce<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="KubernetesApplySettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Force))]
    public static T EnableForce<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="KubernetesApplySettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Force))]
    public static T DisableForce<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="KubernetesApplySettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Force))]
    public static T ToggleForce<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region GracePeriod
    /// <inheritdoc cref="KubernetesApplySettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.GracePeriod))]
    public static T SetGracePeriod<T>(this T o, int? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.GracePeriod, v));
    /// <inheritdoc cref="KubernetesApplySettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.GracePeriod))]
    public static T ResetGracePeriod<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.GracePeriod));
    #endregion
    #region IncludeUninitialized
    /// <inheritdoc cref="KubernetesApplySettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.IncludeUninitialized))]
    public static T SetIncludeUninitialized<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, v));
    /// <inheritdoc cref="KubernetesApplySettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.IncludeUninitialized))]
    public static T ResetIncludeUninitialized<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.IncludeUninitialized));
    /// <inheritdoc cref="KubernetesApplySettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.IncludeUninitialized))]
    public static T EnableIncludeUninitialized<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, true));
    /// <inheritdoc cref="KubernetesApplySettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.IncludeUninitialized))]
    public static T DisableIncludeUninitialized<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, false));
    /// <inheritdoc cref="KubernetesApplySettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.IncludeUninitialized))]
    public static T ToggleIncludeUninitialized<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, !o.IncludeUninitialized));
    #endregion
    #region OpenapiPatch
    /// <inheritdoc cref="KubernetesApplySettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.OpenapiPatch))]
    public static T SetOpenapiPatch<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.OpenapiPatch, v));
    /// <inheritdoc cref="KubernetesApplySettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.OpenapiPatch))]
    public static T ResetOpenapiPatch<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.OpenapiPatch));
    /// <inheritdoc cref="KubernetesApplySettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.OpenapiPatch))]
    public static T EnableOpenapiPatch<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.OpenapiPatch, true));
    /// <inheritdoc cref="KubernetesApplySettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.OpenapiPatch))]
    public static T DisableOpenapiPatch<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.OpenapiPatch, false));
    /// <inheritdoc cref="KubernetesApplySettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.OpenapiPatch))]
    public static T ToggleOpenapiPatch<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.OpenapiPatch, !o.OpenapiPatch));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesApplySettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesApplyOutput v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesApplySettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Overwrite
    /// <inheritdoc cref="KubernetesApplySettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Overwrite))]
    public static T SetOverwrite<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Overwrite, v));
    /// <inheritdoc cref="KubernetesApplySettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Overwrite))]
    public static T ResetOverwrite<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Overwrite));
    /// <inheritdoc cref="KubernetesApplySettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Overwrite))]
    public static T EnableOverwrite<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Overwrite, true));
    /// <inheritdoc cref="KubernetesApplySettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Overwrite))]
    public static T DisableOverwrite<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Overwrite, false));
    /// <inheritdoc cref="KubernetesApplySettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Overwrite))]
    public static T ToggleOverwrite<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Overwrite, !o.Overwrite));
    #endregion
    #region Prune
    /// <inheritdoc cref="KubernetesApplySettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Prune))]
    public static T SetPrune<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Prune, v));
    /// <inheritdoc cref="KubernetesApplySettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Prune))]
    public static T ResetPrune<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Prune));
    /// <inheritdoc cref="KubernetesApplySettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Prune))]
    public static T EnablePrune<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Prune, true));
    /// <inheritdoc cref="KubernetesApplySettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Prune))]
    public static T DisablePrune<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Prune, false));
    /// <inheritdoc cref="KubernetesApplySettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Prune))]
    public static T TogglePrune<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Prune, !o.Prune));
    #endregion
    #region PruneWhitelist
    /// <inheritdoc cref="KubernetesApplySettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.PruneWhitelist))]
    public static T SetPruneWhitelist<T>(this T o, params string[] v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplySettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.PruneWhitelist))]
    public static T SetPruneWhitelist<T>(this T o, IEnumerable<string> v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplySettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.PruneWhitelist))]
    public static T AddPruneWhitelist<T>(this T o, params string[] v) where T : KubernetesApplySettings => o.Modify(b => b.AddCollection(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplySettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.PruneWhitelist))]
    public static T AddPruneWhitelist<T>(this T o, IEnumerable<string> v) where T : KubernetesApplySettings => o.Modify(b => b.AddCollection(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplySettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.PruneWhitelist))]
    public static T RemovePruneWhitelist<T>(this T o, params string[] v) where T : KubernetesApplySettings => o.Modify(b => b.RemoveCollection(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplySettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.PruneWhitelist))]
    public static T RemovePruneWhitelist<T>(this T o, IEnumerable<string> v) where T : KubernetesApplySettings => o.Modify(b => b.RemoveCollection(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplySettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.PruneWhitelist))]
    public static T ClearPruneWhitelist<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.ClearCollection(() => o.PruneWhitelist));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesApplySettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesApplySettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesApplySettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesApplySettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesApplySettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesApplySettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesApplySettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesApplySettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesApplySettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesApplySettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesApplySettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesApplySettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesApplySettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesApplySettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesApplySettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesApplySettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
    #region Validate
    /// <inheritdoc cref="KubernetesApplySettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Validate))]
    public static T SetValidate<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Validate, v));
    /// <inheritdoc cref="KubernetesApplySettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Validate))]
    public static T ResetValidate<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Validate));
    /// <inheritdoc cref="KubernetesApplySettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Validate))]
    public static T EnableValidate<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Validate, true));
    /// <inheritdoc cref="KubernetesApplySettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Validate))]
    public static T DisableValidate<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Validate, false));
    /// <inheritdoc cref="KubernetesApplySettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Validate))]
    public static T ToggleValidate<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Validate, !o.Validate));
    #endregion
    #region Wait
    /// <inheritdoc cref="KubernetesApplySettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Wait))]
    public static T SetWait<T>(this T o, bool? v) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Wait, v));
    /// <inheritdoc cref="KubernetesApplySettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Wait))]
    public static T ResetWait<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Remove(() => o.Wait));
    /// <inheritdoc cref="KubernetesApplySettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Wait))]
    public static T EnableWait<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Wait, true));
    /// <inheritdoc cref="KubernetesApplySettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Wait))]
    public static T DisableWait<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Wait, false));
    /// <inheritdoc cref="KubernetesApplySettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplySettings), Property = nameof(KubernetesApplySettings.Wait))]
    public static T ToggleWait<T>(this T o) where T : KubernetesApplySettings => o.Modify(b => b.Set(() => o.Wait, !o.Wait));
    #endregion
}
#endregion
#region KubernetesApplyKustomizeSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesApplyKustomize(Nuke.Common.Tools.Kubernetes.KubernetesApplyKustomizeSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesApplyKustomizeSettingsExtensions
{
    #region Kustomize
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Kustomize"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Kustomize))]
    public static T SetKustomize<T>(this T o, string v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Kustomize, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Kustomize"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Kustomize))]
    public static T ResetKustomize<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Kustomize));
    #endregion
    #region All
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.All))]
    public static T SetAll<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.All, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.All))]
    public static T ResetAll<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.All));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.All))]
    public static T EnableAll<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.All, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.All))]
    public static T DisableAll<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.All, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.All))]
    public static T ToggleAll<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.All, !o.All));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Cascade
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Cascade))]
    public static T SetCascade<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Cascade, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Cascade))]
    public static T ResetCascade<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Cascade));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Cascade))]
    public static T EnableCascade<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Cascade, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Cascade))]
    public static T DisableCascade<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Cascade, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Cascade))]
    public static T ToggleCascade<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Cascade, !o.Cascade));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Force
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Force))]
    public static T ResetForce<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Force))]
    public static T EnableForce<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Force))]
    public static T DisableForce<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region GracePeriod
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.GracePeriod))]
    public static T SetGracePeriod<T>(this T o, int? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.GracePeriod, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.GracePeriod))]
    public static T ResetGracePeriod<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.GracePeriod));
    #endregion
    #region IncludeUninitialized
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.IncludeUninitialized))]
    public static T SetIncludeUninitialized<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.IncludeUninitialized))]
    public static T ResetIncludeUninitialized<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.IncludeUninitialized));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.IncludeUninitialized))]
    public static T EnableIncludeUninitialized<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.IncludeUninitialized))]
    public static T DisableIncludeUninitialized<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.IncludeUninitialized))]
    public static T ToggleIncludeUninitialized<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, !o.IncludeUninitialized));
    #endregion
    #region OpenapiPatch
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.OpenapiPatch))]
    public static T SetOpenapiPatch<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.OpenapiPatch, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.OpenapiPatch))]
    public static T ResetOpenapiPatch<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.OpenapiPatch));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.OpenapiPatch))]
    public static T EnableOpenapiPatch<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.OpenapiPatch, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.OpenapiPatch))]
    public static T DisableOpenapiPatch<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.OpenapiPatch, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.OpenapiPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.OpenapiPatch))]
    public static T ToggleOpenapiPatch<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.OpenapiPatch, !o.OpenapiPatch));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesApplyOutput v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Overwrite
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Overwrite))]
    public static T SetOverwrite<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Overwrite, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Overwrite))]
    public static T ResetOverwrite<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Overwrite));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Overwrite))]
    public static T EnableOverwrite<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Overwrite, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Overwrite))]
    public static T DisableOverwrite<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Overwrite, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Overwrite"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Overwrite))]
    public static T ToggleOverwrite<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Overwrite, !o.Overwrite));
    #endregion
    #region Prune
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Prune))]
    public static T SetPrune<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Prune, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Prune))]
    public static T ResetPrune<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Prune));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Prune))]
    public static T EnablePrune<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Prune, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Prune))]
    public static T DisablePrune<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Prune, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Prune"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Prune))]
    public static T TogglePrune<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Prune, !o.Prune));
    #endregion
    #region PruneWhitelist
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.PruneWhitelist))]
    public static T SetPruneWhitelist<T>(this T o, params string[] v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.PruneWhitelist))]
    public static T SetPruneWhitelist<T>(this T o, IEnumerable<string> v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.PruneWhitelist))]
    public static T AddPruneWhitelist<T>(this T o, params string[] v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.AddCollection(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.PruneWhitelist))]
    public static T AddPruneWhitelist<T>(this T o, IEnumerable<string> v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.AddCollection(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.PruneWhitelist))]
    public static T RemovePruneWhitelist<T>(this T o, params string[] v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.RemoveCollection(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.PruneWhitelist))]
    public static T RemovePruneWhitelist<T>(this T o, IEnumerable<string> v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.RemoveCollection(() => o.PruneWhitelist, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.PruneWhitelist"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.PruneWhitelist))]
    public static T ClearPruneWhitelist<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.ClearCollection(() => o.PruneWhitelist));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
    #region Validate
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Validate))]
    public static T SetValidate<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Validate, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Validate))]
    public static T ResetValidate<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Validate));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Validate))]
    public static T EnableValidate<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Validate, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Validate))]
    public static T DisableValidate<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Validate, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Validate))]
    public static T ToggleValidate<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Validate, !o.Validate));
    #endregion
    #region Wait
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Wait))]
    public static T SetWait<T>(this T o, bool? v) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Wait, v));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Wait))]
    public static T ResetWait<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Remove(() => o.Wait));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Wait))]
    public static T EnableWait<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Wait, true));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Wait))]
    public static T DisableWait<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Wait, false));
    /// <inheritdoc cref="KubernetesApplyKustomizeSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesApplyKustomizeSettings), Property = nameof(KubernetesApplyKustomizeSettings.Wait))]
    public static T ToggleWait<T>(this T o) where T : KubernetesApplyKustomizeSettings => o.Modify(b => b.Set(() => o.Wait, !o.Wait));
    #endregion
}
#endregion
#region KubernetesCordonSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesCordon(Nuke.Common.Tools.Kubernetes.KubernetesCordonSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesCordonSettingsExtensions
{
    #region Node
    /// <inheritdoc cref="KubernetesCordonSettings.Node"/>
    [Pure] [Builder(Type = typeof(KubernetesCordonSettings), Property = nameof(KubernetesCordonSettings.Node))]
    public static T SetNode<T>(this T o, string v) where T : KubernetesCordonSettings => o.Modify(b => b.Set(() => o.Node, v));
    /// <inheritdoc cref="KubernetesCordonSettings.Node"/>
    [Pure] [Builder(Type = typeof(KubernetesCordonSettings), Property = nameof(KubernetesCordonSettings.Node))]
    public static T ResetNode<T>(this T o) where T : KubernetesCordonSettings => o.Modify(b => b.Remove(() => o.Node));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesCordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCordonSettings), Property = nameof(KubernetesCordonSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesCordonSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesCordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCordonSettings), Property = nameof(KubernetesCordonSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesCordonSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesCordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCordonSettings), Property = nameof(KubernetesCordonSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesCordonSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesCordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCordonSettings), Property = nameof(KubernetesCordonSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesCordonSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesCordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCordonSettings), Property = nameof(KubernetesCordonSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesCordonSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesCordonSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesCordonSettings), Property = nameof(KubernetesCordonSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesCordonSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesCordonSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesCordonSettings), Property = nameof(KubernetesCordonSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesCordonSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
}
#endregion
#region KubernetesCpSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesCp(Nuke.Common.Tools.Kubernetes.KubernetesCpSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesCpSettingsExtensions
{
    #region SrcFileSpec
    /// <inheritdoc cref="KubernetesCpSettings.SrcFileSpec"/>
    [Pure] [Builder(Type = typeof(KubernetesCpSettings), Property = nameof(KubernetesCpSettings.SrcFileSpec))]
    public static T SetSrcFileSpec<T>(this T o, string v) where T : KubernetesCpSettings => o.Modify(b => b.Set(() => o.SrcFileSpec, v));
    /// <inheritdoc cref="KubernetesCpSettings.SrcFileSpec"/>
    [Pure] [Builder(Type = typeof(KubernetesCpSettings), Property = nameof(KubernetesCpSettings.SrcFileSpec))]
    public static T ResetSrcFileSpec<T>(this T o) where T : KubernetesCpSettings => o.Modify(b => b.Remove(() => o.SrcFileSpec));
    #endregion
    #region DestFileSpec
    /// <inheritdoc cref="KubernetesCpSettings.DestFileSpec"/>
    [Pure] [Builder(Type = typeof(KubernetesCpSettings), Property = nameof(KubernetesCpSettings.DestFileSpec))]
    public static T SetDestFileSpec<T>(this T o, string v) where T : KubernetesCpSettings => o.Modify(b => b.Set(() => o.DestFileSpec, v));
    /// <inheritdoc cref="KubernetesCpSettings.DestFileSpec"/>
    [Pure] [Builder(Type = typeof(KubernetesCpSettings), Property = nameof(KubernetesCpSettings.DestFileSpec))]
    public static T ResetDestFileSpec<T>(this T o) where T : KubernetesCpSettings => o.Modify(b => b.Remove(() => o.DestFileSpec));
    #endregion
    #region Container
    /// <inheritdoc cref="KubernetesCpSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesCpSettings), Property = nameof(KubernetesCpSettings.Container))]
    public static T SetContainer<T>(this T o, string v) where T : KubernetesCpSettings => o.Modify(b => b.Set(() => o.Container, v));
    /// <inheritdoc cref="KubernetesCpSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesCpSettings), Property = nameof(KubernetesCpSettings.Container))]
    public static T ResetContainer<T>(this T o) where T : KubernetesCpSettings => o.Modify(b => b.Remove(() => o.Container));
    #endregion
}
#endregion
#region KubernetesApiVersionsSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesApiVersions(Nuke.Common.Tools.Kubernetes.KubernetesApiVersionsSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesApiVersionsSettingsExtensions
{
}
#endregion
#region KubernetesUncordonSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesUncordon(Nuke.Common.Tools.Kubernetes.KubernetesUncordonSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesUncordonSettingsExtensions
{
    #region Node
    /// <inheritdoc cref="KubernetesUncordonSettings.Node"/>
    [Pure] [Builder(Type = typeof(KubernetesUncordonSettings), Property = nameof(KubernetesUncordonSettings.Node))]
    public static T SetNode<T>(this T o, string v) where T : KubernetesUncordonSettings => o.Modify(b => b.Set(() => o.Node, v));
    /// <inheritdoc cref="KubernetesUncordonSettings.Node"/>
    [Pure] [Builder(Type = typeof(KubernetesUncordonSettings), Property = nameof(KubernetesUncordonSettings.Node))]
    public static T ResetNode<T>(this T o) where T : KubernetesUncordonSettings => o.Modify(b => b.Remove(() => o.Node));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesUncordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesUncordonSettings), Property = nameof(KubernetesUncordonSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesUncordonSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesUncordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesUncordonSettings), Property = nameof(KubernetesUncordonSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesUncordonSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesUncordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesUncordonSettings), Property = nameof(KubernetesUncordonSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesUncordonSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesUncordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesUncordonSettings), Property = nameof(KubernetesUncordonSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesUncordonSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesUncordonSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesUncordonSettings), Property = nameof(KubernetesUncordonSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesUncordonSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesUncordonSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesUncordonSettings), Property = nameof(KubernetesUncordonSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesUncordonSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesUncordonSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesUncordonSettings), Property = nameof(KubernetesUncordonSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesUncordonSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
}
#endregion
#region KubernetesAutoscaleSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesAutoscale(Nuke.Common.Tools.Kubernetes.KubernetesAutoscaleSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesAutoscaleSettingsExtensions
{
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesAutoscaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region CpuPercent
    /// <inheritdoc cref="KubernetesAutoscaleSettings.CpuPercent"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.CpuPercent))]
    public static T SetCpuPercent<T>(this T o, int? v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.CpuPercent, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.CpuPercent"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.CpuPercent))]
    public static T ResetCpuPercent<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.CpuPercent));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesAutoscaleSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Generator
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Generator"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Generator))]
    public static T SetGenerator<T>(this T o, string v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Generator, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Generator"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Generator))]
    public static T ResetGenerator<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.Generator));
    #endregion
    #region Max
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Max"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Max))]
    public static T SetMax<T>(this T o, int? v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Max, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Max"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Max))]
    public static T ResetMax<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.Max));
    #endregion
    #region Min
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Min"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Min))]
    public static T SetMin<T>(this T o, int? v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Min, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Min"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Min))]
    public static T ResetMin<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.Min));
    #endregion
    #region Name
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Name"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Name))]
    public static T SetName<T>(this T o, string v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Name, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Name"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Name))]
    public static T ResetName<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.Name));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesAutoscaleOutput v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region SaveConfig
    /// <inheritdoc cref="KubernetesAutoscaleSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.SaveConfig))]
    public static T SetSaveConfig<T>(this T o, bool? v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.SaveConfig, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.SaveConfig))]
    public static T ResetSaveConfig<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.SaveConfig));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.SaveConfig))]
    public static T EnableSaveConfig<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.SaveConfig, true));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.SaveConfig))]
    public static T DisableSaveConfig<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.SaveConfig, false));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.SaveConfig))]
    public static T ToggleSaveConfig<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.SaveConfig, !o.SaveConfig));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesAutoscaleSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesAutoscaleSettings), Property = nameof(KubernetesAutoscaleSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesAutoscaleSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
}
#endregion
#region KubernetesPluginSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesPlugin(Nuke.Common.Tools.Kubernetes.KubernetesPluginSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesPluginSettingsExtensions
{
    #region Name
    /// <inheritdoc cref="KubernetesPluginSettings.Name"/>
    [Pure] [Builder(Type = typeof(KubernetesPluginSettings), Property = nameof(KubernetesPluginSettings.Name))]
    public static T SetName<T>(this T o, string v) where T : KubernetesPluginSettings => o.Modify(b => b.Set(() => o.Name, v));
    /// <inheritdoc cref="KubernetesPluginSettings.Name"/>
    [Pure] [Builder(Type = typeof(KubernetesPluginSettings), Property = nameof(KubernetesPluginSettings.Name))]
    public static T ResetName<T>(this T o) where T : KubernetesPluginSettings => o.Modify(b => b.Remove(() => o.Name));
    #endregion
}
#endregion
#region KubernetesClusterInfoSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesClusterInfo(Nuke.Common.Tools.Kubernetes.KubernetesClusterInfoSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesClusterInfoSettingsExtensions
{
}
#endregion
#region KubernetesWaitSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesWait(Nuke.Common.Tools.Kubernetes.KubernetesWaitSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesWaitSettingsExtensions
{
    #region AllNamespaces
    /// <inheritdoc cref="KubernetesWaitSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllNamespaces))]
    public static T SetAllNamespaces<T>(this T o, bool? v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.AllNamespaces, v));
    /// <inheritdoc cref="KubernetesWaitSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllNamespaces))]
    public static T ResetAllNamespaces<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Remove(() => o.AllNamespaces));
    /// <inheritdoc cref="KubernetesWaitSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllNamespaces))]
    public static T EnableAllNamespaces<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.AllNamespaces, true));
    /// <inheritdoc cref="KubernetesWaitSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllNamespaces))]
    public static T DisableAllNamespaces<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.AllNamespaces, false));
    /// <inheritdoc cref="KubernetesWaitSettings.AllNamespaces"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllNamespaces))]
    public static T ToggleAllNamespaces<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.AllNamespaces, !o.AllNamespaces));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesWaitSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesWaitSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesWaitSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesWaitSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesWaitSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesWaitSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesWaitSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesWaitSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesWaitSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesWaitSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region For
    /// <inheritdoc cref="KubernetesWaitSettings.For"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.For))]
    public static T SetFor<T>(this T o, string v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.For, v));
    /// <inheritdoc cref="KubernetesWaitSettings.For"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.For))]
    public static T ResetFor<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Remove(() => o.For));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesWaitSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesWaitOutput v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesWaitSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesWaitSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesWaitSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesWaitSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesWaitSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesWaitSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesWaitSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesWaitSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesWaitSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesWaitSettings), Property = nameof(KubernetesWaitSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesWaitSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
}
#endregion
#region KubernetesConvertSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesConvert(Nuke.Common.Tools.Kubernetes.KubernetesConvertSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesConvertSettingsExtensions
{
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesConvertSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesConvertSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesConvertSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesConvertSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesConvertSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesConvertSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesConvertSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesConvertSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesConvertSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesConvertSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Local
    /// <inheritdoc cref="KubernetesConvertSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Local))]
    public static T SetLocal<T>(this T o, bool? v) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Local, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Local))]
    public static T ResetLocal<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Remove(() => o.Local));
    /// <inheritdoc cref="KubernetesConvertSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Local))]
    public static T EnableLocal<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Local, true));
    /// <inheritdoc cref="KubernetesConvertSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Local))]
    public static T DisableLocal<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Local, false));
    /// <inheritdoc cref="KubernetesConvertSettings.Local"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Local))]
    public static T ToggleLocal<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Local, !o.Local));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesConvertSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesConvertOutput v) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region OutputVersion
    /// <inheritdoc cref="KubernetesConvertSettings.OutputVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.OutputVersion))]
    public static T SetOutputVersion<T>(this T o, string v) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.OutputVersion, v));
    /// <inheritdoc cref="KubernetesConvertSettings.OutputVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.OutputVersion))]
    public static T ResetOutputVersion<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Remove(() => o.OutputVersion));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesConvertSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesConvertSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesConvertSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesConvertSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesConvertSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Validate
    /// <inheritdoc cref="KubernetesConvertSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Validate))]
    public static T SetValidate<T>(this T o, bool? v) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Validate, v));
    /// <inheritdoc cref="KubernetesConvertSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Validate))]
    public static T ResetValidate<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Remove(() => o.Validate));
    /// <inheritdoc cref="KubernetesConvertSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Validate))]
    public static T EnableValidate<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Validate, true));
    /// <inheritdoc cref="KubernetesConvertSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Validate))]
    public static T DisableValidate<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Validate, false));
    /// <inheritdoc cref="KubernetesConvertSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesConvertSettings), Property = nameof(KubernetesConvertSettings.Validate))]
    public static T ToggleValidate<T>(this T o) where T : KubernetesConvertSettings => o.Modify(b => b.Set(() => o.Validate, !o.Validate));
    #endregion
}
#endregion
#region KubernetesCreateSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesCreate(Nuke.Common.Tools.Kubernetes.KubernetesCreateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesCreateSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesCreateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesCreateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesCreateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesCreateSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesCreateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesCreateSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesCreateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesCreateSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesCreateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesCreateSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesCreateSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesCreateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesCreateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesCreateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesCreateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesCreateSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesCreateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesCreateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesCreateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesCreateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesCreateSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Edit
    /// <inheritdoc cref="KubernetesCreateSettings.Edit"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Edit))]
    public static T SetEdit<T>(this T o, bool? v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Edit, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Edit"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Edit))]
    public static T ResetEdit<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.Edit));
    /// <inheritdoc cref="KubernetesCreateSettings.Edit"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Edit))]
    public static T EnableEdit<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Edit, true));
    /// <inheritdoc cref="KubernetesCreateSettings.Edit"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Edit))]
    public static T DisableEdit<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Edit, false));
    /// <inheritdoc cref="KubernetesCreateSettings.Edit"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Edit))]
    public static T ToggleEdit<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Edit, !o.Edit));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesCreateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesCreateSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesCreateSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesCreateSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesCreateSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesCreateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesCreateOutput v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Raw
    /// <inheritdoc cref="KubernetesCreateSettings.Raw"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Raw))]
    public static T SetRaw<T>(this T o, string v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Raw, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Raw"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Raw))]
    public static T ResetRaw<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.Raw));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesCreateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesCreateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesCreateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesCreateSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesCreateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesCreateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesCreateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesCreateSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region SaveConfig
    /// <inheritdoc cref="KubernetesCreateSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.SaveConfig))]
    public static T SetSaveConfig<T>(this T o, bool? v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.SaveConfig, v));
    /// <inheritdoc cref="KubernetesCreateSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.SaveConfig))]
    public static T ResetSaveConfig<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.SaveConfig));
    /// <inheritdoc cref="KubernetesCreateSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.SaveConfig))]
    public static T EnableSaveConfig<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.SaveConfig, true));
    /// <inheritdoc cref="KubernetesCreateSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.SaveConfig))]
    public static T DisableSaveConfig<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.SaveConfig, false));
    /// <inheritdoc cref="KubernetesCreateSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.SaveConfig))]
    public static T ToggleSaveConfig<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.SaveConfig, !o.SaveConfig));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesCreateSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesCreateSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Validate
    /// <inheritdoc cref="KubernetesCreateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Validate))]
    public static T SetValidate<T>(this T o, bool? v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Validate, v));
    /// <inheritdoc cref="KubernetesCreateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Validate))]
    public static T ResetValidate<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.Validate));
    /// <inheritdoc cref="KubernetesCreateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Validate))]
    public static T EnableValidate<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Validate, true));
    /// <inheritdoc cref="KubernetesCreateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Validate))]
    public static T DisableValidate<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Validate, false));
    /// <inheritdoc cref="KubernetesCreateSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.Validate))]
    public static T ToggleValidate<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.Validate, !o.Validate));
    #endregion
    #region WindowsLineEndings
    /// <inheritdoc cref="KubernetesCreateSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.WindowsLineEndings))]
    public static T SetWindowsLineEndings<T>(this T o, bool? v) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.WindowsLineEndings, v));
    /// <inheritdoc cref="KubernetesCreateSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.WindowsLineEndings))]
    public static T ResetWindowsLineEndings<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Remove(() => o.WindowsLineEndings));
    /// <inheritdoc cref="KubernetesCreateSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.WindowsLineEndings))]
    public static T EnableWindowsLineEndings<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.WindowsLineEndings, true));
    /// <inheritdoc cref="KubernetesCreateSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.WindowsLineEndings))]
    public static T DisableWindowsLineEndings<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.WindowsLineEndings, false));
    /// <inheritdoc cref="KubernetesCreateSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesCreateSettings), Property = nameof(KubernetesCreateSettings.WindowsLineEndings))]
    public static T ToggleWindowsLineEndings<T>(this T o) where T : KubernetesCreateSettings => o.Modify(b => b.Set(() => o.WindowsLineEndings, !o.WindowsLineEndings));
    #endregion
}
#endregion
#region KubernetesPortForwardSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesPortForward(Nuke.Common.Tools.Kubernetes.KubernetesPortForwardSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesPortForwardSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesPortForwardSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesPortForwardSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPortForwardSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesPortForwardSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPortForwardSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesPortForwardSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPortForwardSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesPortForwardSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPortForwardSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesPortForwardSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPortForwardSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesPortForwardSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesPortForwardSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesPortForwardSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region Ports
    /// <inheritdoc cref="KubernetesPortForwardSettings.Ports"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.Ports))]
    public static T SetPorts<T>(this T o, IDictionary<int, int> v) where T : KubernetesPortForwardSettings => o.Modify(b => b.Set(() => o.Ports, v.ToDictionary(x => x.Key, x => x.Value, EqualityComparer<int>.Default)));
    /// <inheritdoc cref="KubernetesPortForwardSettings.Ports"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.Ports))]
    public static T SetPort<T>(this T o, int k, int v) where T : KubernetesPortForwardSettings => o.Modify(b => b.SetDictionary(() => o.Ports, k, v));
    /// <inheritdoc cref="KubernetesPortForwardSettings.Ports"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.Ports))]
    public static T AddPort<T>(this T o, int k, int v) where T : KubernetesPortForwardSettings => o.Modify(b => b.AddDictionary(() => o.Ports, k, v));
    /// <inheritdoc cref="KubernetesPortForwardSettings.Ports"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.Ports))]
    public static T RemovePort<T>(this T o, int k) where T : KubernetesPortForwardSettings => o.Modify(b => b.RemoveDictionary(() => o.Ports, k));
    /// <inheritdoc cref="KubernetesPortForwardSettings.Ports"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.Ports))]
    public static T ClearPorts<T>(this T o) where T : KubernetesPortForwardSettings => o.Modify(b => b.ClearDictionary(() => o.Ports));
    #endregion
    #region PodRunningTimeout
    /// <inheritdoc cref="KubernetesPortForwardSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.PodRunningTimeout))]
    public static T SetPodRunningTimeout<T>(this T o, TimeSpan? v) where T : KubernetesPortForwardSettings => o.Modify(b => b.Set(() => o.PodRunningTimeout, v));
    /// <inheritdoc cref="KubernetesPortForwardSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesPortForwardSettings), Property = nameof(KubernetesPortForwardSettings.PodRunningTimeout))]
    public static T ResetPodRunningTimeout<T>(this T o) where T : KubernetesPortForwardSettings => o.Modify(b => b.Remove(() => o.PodRunningTimeout));
    #endregion
}
#endregion
#region KubernetesRunContainerSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesRunContainer(Nuke.Common.Tools.Kubernetes.KubernetesRunContainerSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesRunContainerSettingsExtensions
{
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesRunContainerSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesRunContainerSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Attach
    /// <inheritdoc cref="KubernetesRunContainerSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Attach))]
    public static T SetAttach<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Attach, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Attach))]
    public static T ResetAttach<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Attach));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Attach))]
    public static T EnableAttach<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Attach, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Attach))]
    public static T DisableAttach<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Attach, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Attach"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Attach))]
    public static T ToggleAttach<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Attach, !o.Attach));
    #endregion
    #region Cascade
    /// <inheritdoc cref="KubernetesRunContainerSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Cascade))]
    public static T SetCascade<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Cascade, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Cascade))]
    public static T ResetCascade<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Cascade));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Cascade))]
    public static T EnableCascade<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Cascade, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Cascade))]
    public static T DisableCascade<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Cascade, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Cascade"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Cascade))]
    public static T ToggleCascade<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Cascade, !o.Cascade));
    #endregion
    #region Command
    /// <inheritdoc cref="KubernetesRunContainerSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Command))]
    public static T SetCommand<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Command, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Command))]
    public static T ResetCommand<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Command));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Command))]
    public static T EnableCommand<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Command, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Command))]
    public static T DisableCommand<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Command, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Command"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Command))]
    public static T ToggleCommand<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Command, !o.Command));
    #endregion
    #region DryRun
    /// <inheritdoc cref="KubernetesRunContainerSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.DryRun))]
    public static T SetDryRun<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.DryRun, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.DryRun))]
    public static T ResetDryRun<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.DryRun));
    /// <inheritdoc cref="KubernetesRunContainerSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.DryRun))]
    public static T EnableDryRun<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.DryRun, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.DryRun))]
    public static T DisableDryRun<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.DryRun, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.DryRun"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.DryRun))]
    public static T ToggleDryRun<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.DryRun, !o.DryRun));
    #endregion
    #region Env
    /// <inheritdoc cref="KubernetesRunContainerSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Env))]
    public static T SetEnv<T>(this T o, params string[] v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Env))]
    public static T SetEnv<T>(this T o, IEnumerable<string> v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Env))]
    public static T AddEnv<T>(this T o, params string[] v) where T : KubernetesRunContainerSettings => o.Modify(b => b.AddCollection(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Env))]
    public static T AddEnv<T>(this T o, IEnumerable<string> v) where T : KubernetesRunContainerSettings => o.Modify(b => b.AddCollection(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Env))]
    public static T RemoveEnv<T>(this T o, params string[] v) where T : KubernetesRunContainerSettings => o.Modify(b => b.RemoveCollection(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Env))]
    public static T RemoveEnv<T>(this T o, IEnumerable<string> v) where T : KubernetesRunContainerSettings => o.Modify(b => b.RemoveCollection(() => o.Env, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Env"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Env))]
    public static T ClearEnv<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.ClearCollection(() => o.Env));
    #endregion
    #region Expose
    /// <inheritdoc cref="KubernetesRunContainerSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Expose))]
    public static T SetExpose<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Expose, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Expose))]
    public static T ResetExpose<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Expose));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Expose))]
    public static T EnableExpose<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Expose, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Expose))]
    public static T DisableExpose<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Expose, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Expose"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Expose))]
    public static T ToggleExpose<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Expose, !o.Expose));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesRunContainerSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesRunContainerSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesRunContainerSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesRunContainerSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesRunContainerSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Force
    /// <inheritdoc cref="KubernetesRunContainerSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Force))]
    public static T SetForce<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Force, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Force))]
    public static T ResetForce<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Force));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Force))]
    public static T EnableForce<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Force, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Force))]
    public static T DisableForce<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Force, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Force"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Force))]
    public static T ToggleForce<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Force, !o.Force));
    #endregion
    #region Generator
    /// <inheritdoc cref="KubernetesRunContainerSettings.Generator"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Generator))]
    public static T SetGenerator<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Generator, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Generator"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Generator))]
    public static T ResetGenerator<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Generator));
    #endregion
    #region GracePeriod
    /// <inheritdoc cref="KubernetesRunContainerSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.GracePeriod))]
    public static T SetGracePeriod<T>(this T o, int? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.GracePeriod, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.GracePeriod"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.GracePeriod))]
    public static T ResetGracePeriod<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.GracePeriod));
    #endregion
    #region Hostport
    /// <inheritdoc cref="KubernetesRunContainerSettings.Hostport"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Hostport))]
    public static T SetHostport<T>(this T o, int? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Hostport, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Hostport"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Hostport))]
    public static T ResetHostport<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Hostport));
    #endregion
    #region Image
    /// <inheritdoc cref="KubernetesRunContainerSettings.Image"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Image))]
    public static T SetImage<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Image, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Image"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Image))]
    public static T ResetImage<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Image));
    #endregion
    #region ImagePullPolicy
    /// <inheritdoc cref="KubernetesRunContainerSettings.ImagePullPolicy"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.ImagePullPolicy))]
    public static T SetImagePullPolicy<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.ImagePullPolicy, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.ImagePullPolicy"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.ImagePullPolicy))]
    public static T ResetImagePullPolicy<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.ImagePullPolicy));
    #endregion
    #region Labels
    /// <inheritdoc cref="KubernetesRunContainerSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Labels))]
    public static T SetLabels<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Labels, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Labels"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Labels))]
    public static T ResetLabels<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Labels));
    #endregion
    #region LeaveStdinOpen
    /// <inheritdoc cref="KubernetesRunContainerSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.LeaveStdinOpen))]
    public static T SetLeaveStdinOpen<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.LeaveStdinOpen, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.LeaveStdinOpen))]
    public static T ResetLeaveStdinOpen<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.LeaveStdinOpen));
    /// <inheritdoc cref="KubernetesRunContainerSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.LeaveStdinOpen))]
    public static T EnableLeaveStdinOpen<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.LeaveStdinOpen, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.LeaveStdinOpen))]
    public static T DisableLeaveStdinOpen<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.LeaveStdinOpen, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.LeaveStdinOpen"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.LeaveStdinOpen))]
    public static T ToggleLeaveStdinOpen<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.LeaveStdinOpen, !o.LeaveStdinOpen));
    #endregion
    #region Limits
    /// <inheritdoc cref="KubernetesRunContainerSettings.Limits"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Limits))]
    public static T SetLimits<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Limits, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Limits"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Limits))]
    public static T ResetLimits<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Limits));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesRunContainerSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesRunContainerOutput v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Overrides
    /// <inheritdoc cref="KubernetesRunContainerSettings.Overrides"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Overrides))]
    public static T SetOverrides<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Overrides, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Overrides"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Overrides))]
    public static T ResetOverrides<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Overrides));
    #endregion
    #region PodRunningTimeout
    /// <inheritdoc cref="KubernetesRunContainerSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.PodRunningTimeout))]
    public static T SetPodRunningTimeout<T>(this T o, TimeSpan? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.PodRunningTimeout, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.PodRunningTimeout))]
    public static T ResetPodRunningTimeout<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.PodRunningTimeout));
    #endregion
    #region Port
    /// <inheritdoc cref="KubernetesRunContainerSettings.Port"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Port))]
    public static T SetPort<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Port, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Port"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Port))]
    public static T ResetPort<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Port));
    #endregion
    #region Quiet
    /// <inheritdoc cref="KubernetesRunContainerSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Quiet))]
    public static T SetQuiet<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Quiet, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Quiet))]
    public static T ResetQuiet<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Quiet));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Quiet))]
    public static T EnableQuiet<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Quiet, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Quiet))]
    public static T DisableQuiet<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Quiet, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Quiet"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Quiet))]
    public static T ToggleQuiet<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Quiet, !o.Quiet));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesRunContainerSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesRunContainerSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Replicas
    /// <inheritdoc cref="KubernetesRunContainerSettings.Replicas"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Replicas))]
    public static T SetReplicas<T>(this T o, int? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Replicas, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Replicas"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Replicas))]
    public static T ResetReplicas<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Replicas));
    #endregion
    #region Requests
    /// <inheritdoc cref="KubernetesRunContainerSettings.Requests"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Requests))]
    public static T SetRequests<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Requests, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Requests"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Requests))]
    public static T ResetRequests<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Requests));
    #endregion
    #region Restart
    /// <inheritdoc cref="KubernetesRunContainerSettings.Restart"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Restart))]
    public static T SetRestart<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Restart, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Restart"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Restart))]
    public static T ResetRestart<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Restart));
    #endregion
    #region Rm
    /// <inheritdoc cref="KubernetesRunContainerSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Rm))]
    public static T SetRm<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Rm, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Rm))]
    public static T ResetRm<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Rm));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Rm))]
    public static T EnableRm<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Rm, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Rm))]
    public static T DisableRm<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Rm, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Rm"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Rm))]
    public static T ToggleRm<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Rm, !o.Rm));
    #endregion
    #region SaveConfig
    /// <inheritdoc cref="KubernetesRunContainerSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.SaveConfig))]
    public static T SetSaveConfig<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.SaveConfig, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.SaveConfig))]
    public static T ResetSaveConfig<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.SaveConfig));
    /// <inheritdoc cref="KubernetesRunContainerSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.SaveConfig))]
    public static T EnableSaveConfig<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.SaveConfig, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.SaveConfig))]
    public static T DisableSaveConfig<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.SaveConfig, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.SaveConfig))]
    public static T ToggleSaveConfig<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.SaveConfig, !o.SaveConfig));
    #endregion
    #region Schedule
    /// <inheritdoc cref="KubernetesRunContainerSettings.Schedule"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Schedule))]
    public static T SetSchedule<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Schedule, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Schedule"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Schedule))]
    public static T ResetSchedule<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Schedule));
    #endregion
    #region ServiceGenerator
    /// <inheritdoc cref="KubernetesRunContainerSettings.ServiceGenerator"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.ServiceGenerator))]
    public static T SetServiceGenerator<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.ServiceGenerator, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.ServiceGenerator"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.ServiceGenerator))]
    public static T ResetServiceGenerator<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.ServiceGenerator));
    #endregion
    #region ServiceOverrides
    /// <inheritdoc cref="KubernetesRunContainerSettings.ServiceOverrides"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.ServiceOverrides))]
    public static T SetServiceOverrides<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.ServiceOverrides, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.ServiceOverrides"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.ServiceOverrides))]
    public static T ResetServiceOverrides<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.ServiceOverrides));
    #endregion
    #region Serviceaccount
    /// <inheritdoc cref="KubernetesRunContainerSettings.Serviceaccount"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Serviceaccount))]
    public static T SetServiceaccount<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Serviceaccount, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Serviceaccount"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Serviceaccount))]
    public static T ResetServiceaccount<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Serviceaccount));
    #endregion
    #region Stdin
    /// <inheritdoc cref="KubernetesRunContainerSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Stdin))]
    public static T SetStdin<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Stdin, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Stdin))]
    public static T ResetStdin<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Stdin));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Stdin))]
    public static T EnableStdin<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Stdin, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Stdin))]
    public static T DisableStdin<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Stdin, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Stdin"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Stdin))]
    public static T ToggleStdin<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Stdin, !o.Stdin));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesRunContainerSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesRunContainerSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
    #region Tty
    /// <inheritdoc cref="KubernetesRunContainerSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Tty))]
    public static T SetTty<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Tty, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Tty))]
    public static T ResetTty<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Tty));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Tty))]
    public static T EnableTty<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Tty, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Tty))]
    public static T DisableTty<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Tty, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Tty"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Tty))]
    public static T ToggleTty<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Tty, !o.Tty));
    #endregion
    #region Wait
    /// <inheritdoc cref="KubernetesRunContainerSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Wait))]
    public static T SetWait<T>(this T o, bool? v) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Wait, v));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Wait))]
    public static T ResetWait<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Remove(() => o.Wait));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Wait))]
    public static T EnableWait<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Wait, true));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Wait))]
    public static T DisableWait<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Wait, false));
    /// <inheritdoc cref="KubernetesRunContainerSettings.Wait"/>
    [Pure] [Builder(Type = typeof(KubernetesRunContainerSettings), Property = nameof(KubernetesRunContainerSettings.Wait))]
    public static T ToggleWait<T>(this T o) where T : KubernetesRunContainerSettings => o.Modify(b => b.Set(() => o.Wait, !o.Wait));
    #endregion
}
#endregion
#region KubernetesEditSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesEdit(Nuke.Common.Tools.Kubernetes.KubernetesEditSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesEditSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesEditSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesEditSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesEditSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesEditSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesEditSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesEditSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesEditSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesEditSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesEditSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesEditSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesEditSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesEditSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesEditSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesEditSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesEditSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesEditSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesEditSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesEditSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesEditSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesEditSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesEditSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesEditSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesEditSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesEditSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesEditSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesEditSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesEditSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region IncludeUninitialized
    /// <inheritdoc cref="KubernetesEditSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.IncludeUninitialized))]
    public static T SetIncludeUninitialized<T>(this T o, bool? v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, v));
    /// <inheritdoc cref="KubernetesEditSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.IncludeUninitialized))]
    public static T ResetIncludeUninitialized<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.IncludeUninitialized));
    /// <inheritdoc cref="KubernetesEditSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.IncludeUninitialized))]
    public static T EnableIncludeUninitialized<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, true));
    /// <inheritdoc cref="KubernetesEditSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.IncludeUninitialized))]
    public static T DisableIncludeUninitialized<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, false));
    /// <inheritdoc cref="KubernetesEditSettings.IncludeUninitialized"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.IncludeUninitialized))]
    public static T ToggleIncludeUninitialized<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.IncludeUninitialized, !o.IncludeUninitialized));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesEditSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesEditOutput v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesEditSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region OutputPatch
    /// <inheritdoc cref="KubernetesEditSettings.OutputPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.OutputPatch))]
    public static T SetOutputPatch<T>(this T o, bool? v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.OutputPatch, v));
    /// <inheritdoc cref="KubernetesEditSettings.OutputPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.OutputPatch))]
    public static T ResetOutputPatch<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.OutputPatch));
    /// <inheritdoc cref="KubernetesEditSettings.OutputPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.OutputPatch))]
    public static T EnableOutputPatch<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.OutputPatch, true));
    /// <inheritdoc cref="KubernetesEditSettings.OutputPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.OutputPatch))]
    public static T DisableOutputPatch<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.OutputPatch, false));
    /// <inheritdoc cref="KubernetesEditSettings.OutputPatch"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.OutputPatch))]
    public static T ToggleOutputPatch<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.OutputPatch, !o.OutputPatch));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesEditSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesEditSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesEditSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesEditSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesEditSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesEditSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesEditSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesEditSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesEditSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesEditSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region SaveConfig
    /// <inheritdoc cref="KubernetesEditSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.SaveConfig))]
    public static T SetSaveConfig<T>(this T o, bool? v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.SaveConfig, v));
    /// <inheritdoc cref="KubernetesEditSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.SaveConfig))]
    public static T ResetSaveConfig<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.SaveConfig));
    /// <inheritdoc cref="KubernetesEditSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.SaveConfig))]
    public static T EnableSaveConfig<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.SaveConfig, true));
    /// <inheritdoc cref="KubernetesEditSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.SaveConfig))]
    public static T DisableSaveConfig<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.SaveConfig, false));
    /// <inheritdoc cref="KubernetesEditSettings.SaveConfig"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.SaveConfig))]
    public static T ToggleSaveConfig<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.SaveConfig, !o.SaveConfig));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesEditSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesEditSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Validate
    /// <inheritdoc cref="KubernetesEditSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Validate))]
    public static T SetValidate<T>(this T o, bool? v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Validate, v));
    /// <inheritdoc cref="KubernetesEditSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Validate))]
    public static T ResetValidate<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.Validate));
    /// <inheritdoc cref="KubernetesEditSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Validate))]
    public static T EnableValidate<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Validate, true));
    /// <inheritdoc cref="KubernetesEditSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Validate))]
    public static T DisableValidate<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Validate, false));
    /// <inheritdoc cref="KubernetesEditSettings.Validate"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.Validate))]
    public static T ToggleValidate<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.Validate, !o.Validate));
    #endregion
    #region WindowsLineEndings
    /// <inheritdoc cref="KubernetesEditSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.WindowsLineEndings))]
    public static T SetWindowsLineEndings<T>(this T o, bool? v) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.WindowsLineEndings, v));
    /// <inheritdoc cref="KubernetesEditSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.WindowsLineEndings))]
    public static T ResetWindowsLineEndings<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Remove(() => o.WindowsLineEndings));
    /// <inheritdoc cref="KubernetesEditSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.WindowsLineEndings))]
    public static T EnableWindowsLineEndings<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.WindowsLineEndings, true));
    /// <inheritdoc cref="KubernetesEditSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.WindowsLineEndings))]
    public static T DisableWindowsLineEndings<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.WindowsLineEndings, false));
    /// <inheritdoc cref="KubernetesEditSettings.WindowsLineEndings"/>
    [Pure] [Builder(Type = typeof(KubernetesEditSettings), Property = nameof(KubernetesEditSettings.WindowsLineEndings))]
    public static T ToggleWindowsLineEndings<T>(this T o) where T : KubernetesEditSettings => o.Modify(b => b.Set(() => o.WindowsLineEndings, !o.WindowsLineEndings));
    #endregion
}
#endregion
#region KubernetesScaleSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesScale(Nuke.Common.Tools.Kubernetes.KubernetesScaleSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesScaleSettingsExtensions
{
    #region All
    /// <inheritdoc cref="KubernetesScaleSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.All))]
    public static T SetAll<T>(this T o, bool? v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.All, v));
    /// <inheritdoc cref="KubernetesScaleSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.All))]
    public static T ResetAll<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.All));
    /// <inheritdoc cref="KubernetesScaleSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.All))]
    public static T EnableAll<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.All, true));
    /// <inheritdoc cref="KubernetesScaleSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.All))]
    public static T DisableAll<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.All, false));
    /// <inheritdoc cref="KubernetesScaleSettings.All"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.All))]
    public static T ToggleAll<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.All, !o.All));
    #endregion
    #region AllowMissingTemplateKeys
    /// <inheritdoc cref="KubernetesScaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.AllowMissingTemplateKeys))]
    public static T SetAllowMissingTemplateKeys<T>(this T o, bool? v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, v));
    /// <inheritdoc cref="KubernetesScaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.AllowMissingTemplateKeys))]
    public static T ResetAllowMissingTemplateKeys<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.AllowMissingTemplateKeys));
    /// <inheritdoc cref="KubernetesScaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.AllowMissingTemplateKeys))]
    public static T EnableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, true));
    /// <inheritdoc cref="KubernetesScaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.AllowMissingTemplateKeys))]
    public static T DisableAllowMissingTemplateKeys<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, false));
    /// <inheritdoc cref="KubernetesScaleSettings.AllowMissingTemplateKeys"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.AllowMissingTemplateKeys))]
    public static T ToggleAllowMissingTemplateKeys<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.AllowMissingTemplateKeys, !o.AllowMissingTemplateKeys));
    #endregion
    #region CurrentReplicas
    /// <inheritdoc cref="KubernetesScaleSettings.CurrentReplicas"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.CurrentReplicas))]
    public static T SetCurrentReplicas<T>(this T o, int? v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.CurrentReplicas, v));
    /// <inheritdoc cref="KubernetesScaleSettings.CurrentReplicas"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.CurrentReplicas))]
    public static T ResetCurrentReplicas<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.CurrentReplicas));
    #endregion
    #region Filename
    /// <inheritdoc cref="KubernetesScaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Filename))]
    public static T SetFilename<T>(this T o, params string[] v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Filename))]
    public static T SetFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Filename))]
    public static T AddFilename<T>(this T o, params string[] v) where T : KubernetesScaleSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Filename))]
    public static T AddFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesScaleSettings => o.Modify(b => b.AddCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Filename))]
    public static T RemoveFilename<T>(this T o, params string[] v) where T : KubernetesScaleSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Filename))]
    public static T RemoveFilename<T>(this T o, IEnumerable<string> v) where T : KubernetesScaleSettings => o.Modify(b => b.RemoveCollection(() => o.Filename, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Filename"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Filename))]
    public static T ClearFilename<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.ClearCollection(() => o.Filename));
    #endregion
    #region Output
    /// <inheritdoc cref="KubernetesScaleSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Output))]
    public static T SetOutput<T>(this T o, KubernetesScaleOutput v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Output"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Record
    /// <inheritdoc cref="KubernetesScaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Record))]
    public static T SetRecord<T>(this T o, bool? v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Record, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Record))]
    public static T ResetRecord<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.Record));
    /// <inheritdoc cref="KubernetesScaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Record))]
    public static T EnableRecord<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Record, true));
    /// <inheritdoc cref="KubernetesScaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Record))]
    public static T DisableRecord<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Record, false));
    /// <inheritdoc cref="KubernetesScaleSettings.Record"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Record))]
    public static T ToggleRecord<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Record, !o.Record));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesScaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesScaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesScaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesScaleSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Replicas
    /// <inheritdoc cref="KubernetesScaleSettings.Replicas"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Replicas))]
    public static T SetReplicas<T>(this T o, int? v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Replicas, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Replicas"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Replicas))]
    public static T ResetReplicas<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.Replicas));
    #endregion
    #region ResourceVersion
    /// <inheritdoc cref="KubernetesScaleSettings.ResourceVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.ResourceVersion))]
    public static T SetResourceVersion<T>(this T o, string v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.ResourceVersion, v));
    /// <inheritdoc cref="KubernetesScaleSettings.ResourceVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.ResourceVersion))]
    public static T ResetResourceVersion<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.ResourceVersion));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesScaleSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Template
    /// <inheritdoc cref="KubernetesScaleSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Template))]
    public static T SetTemplate<T>(this T o, string v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Template, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Template"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Template))]
    public static T ResetTemplate<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.Template));
    #endregion
    #region Timeout
    /// <inheritdoc cref="KubernetesScaleSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Timeout))]
    public static T SetTimeout<T>(this T o, TimeSpan? v) where T : KubernetesScaleSettings => o.Modify(b => b.Set(() => o.Timeout, v));
    /// <inheritdoc cref="KubernetesScaleSettings.Timeout"/>
    [Pure] [Builder(Type = typeof(KubernetesScaleSettings), Property = nameof(KubernetesScaleSettings.Timeout))]
    public static T ResetTimeout<T>(this T o) where T : KubernetesScaleSettings => o.Modify(b => b.Remove(() => o.Timeout));
    #endregion
}
#endregion
#region KubernetesExplainSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesExplain(Nuke.Common.Tools.Kubernetes.KubernetesExplainSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesExplainSettingsExtensions
{
    #region ApiVersion
    /// <inheritdoc cref="KubernetesExplainSettings.ApiVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.ApiVersion))]
    public static T SetApiVersion<T>(this T o, string v) where T : KubernetesExplainSettings => o.Modify(b => b.Set(() => o.ApiVersion, v));
    /// <inheritdoc cref="KubernetesExplainSettings.ApiVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.ApiVersion))]
    public static T ResetApiVersion<T>(this T o) where T : KubernetesExplainSettings => o.Modify(b => b.Remove(() => o.ApiVersion));
    #endregion
    #region Recursive
    /// <inheritdoc cref="KubernetesExplainSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Recursive))]
    public static T SetRecursive<T>(this T o, bool? v) where T : KubernetesExplainSettings => o.Modify(b => b.Set(() => o.Recursive, v));
    /// <inheritdoc cref="KubernetesExplainSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Recursive))]
    public static T ResetRecursive<T>(this T o) where T : KubernetesExplainSettings => o.Modify(b => b.Remove(() => o.Recursive));
    /// <inheritdoc cref="KubernetesExplainSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Recursive))]
    public static T EnableRecursive<T>(this T o) where T : KubernetesExplainSettings => o.Modify(b => b.Set(() => o.Recursive, true));
    /// <inheritdoc cref="KubernetesExplainSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Recursive))]
    public static T DisableRecursive<T>(this T o) where T : KubernetesExplainSettings => o.Modify(b => b.Set(() => o.Recursive, false));
    /// <inheritdoc cref="KubernetesExplainSettings.Recursive"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Recursive))]
    public static T ToggleRecursive<T>(this T o) where T : KubernetesExplainSettings => o.Modify(b => b.Set(() => o.Recursive, !o.Recursive));
    #endregion
    #region Resource
    /// <inheritdoc cref="KubernetesExplainSettings.Resource"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Resource))]
    public static T SetResource<T>(this T o, params string[] v) where T : KubernetesExplainSettings => o.Modify(b => b.Set(() => o.Resource, v));
    /// <inheritdoc cref="KubernetesExplainSettings.Resource"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Resource))]
    public static T SetResource<T>(this T o, IEnumerable<string> v) where T : KubernetesExplainSettings => o.Modify(b => b.Set(() => o.Resource, v));
    /// <inheritdoc cref="KubernetesExplainSettings.Resource"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Resource))]
    public static T AddResource<T>(this T o, params string[] v) where T : KubernetesExplainSettings => o.Modify(b => b.AddCollection(() => o.Resource, v));
    /// <inheritdoc cref="KubernetesExplainSettings.Resource"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Resource))]
    public static T AddResource<T>(this T o, IEnumerable<string> v) where T : KubernetesExplainSettings => o.Modify(b => b.AddCollection(() => o.Resource, v));
    /// <inheritdoc cref="KubernetesExplainSettings.Resource"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Resource))]
    public static T RemoveResource<T>(this T o, params string[] v) where T : KubernetesExplainSettings => o.Modify(b => b.RemoveCollection(() => o.Resource, v));
    /// <inheritdoc cref="KubernetesExplainSettings.Resource"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Resource))]
    public static T RemoveResource<T>(this T o, IEnumerable<string> v) where T : KubernetesExplainSettings => o.Modify(b => b.RemoveCollection(() => o.Resource, v));
    /// <inheritdoc cref="KubernetesExplainSettings.Resource"/>
    [Pure] [Builder(Type = typeof(KubernetesExplainSettings), Property = nameof(KubernetesExplainSettings.Resource))]
    public static T ClearResource<T>(this T o) where T : KubernetesExplainSettings => o.Modify(b => b.ClearCollection(() => o.Resource));
    #endregion
}
#endregion
#region KubernetesLogsSettingsExtensions
/// <inheritdoc cref="KubernetesTasks.KubernetesLogs(Nuke.Common.Tools.Kubernetes.KubernetesLogsSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesLogsSettingsExtensions
{
    #region TypeName
    /// <inheritdoc cref="KubernetesLogsSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.TypeName))]
    public static T SetTypeName<T>(this T o, params string[] v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLogsSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.TypeName))]
    public static T SetTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLogsSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.TypeName))]
    public static T AddTypeName<T>(this T o, params string[] v) where T : KubernetesLogsSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLogsSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.TypeName))]
    public static T AddTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesLogsSettings => o.Modify(b => b.AddCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLogsSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, params string[] v) where T : KubernetesLogsSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLogsSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.TypeName))]
    public static T RemoveTypeName<T>(this T o, IEnumerable<string> v) where T : KubernetesLogsSettings => o.Modify(b => b.RemoveCollection(() => o.TypeName, v));
    /// <inheritdoc cref="KubernetesLogsSettings.TypeName"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.TypeName))]
    public static T ClearTypeName<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.ClearCollection(() => o.TypeName));
    #endregion
    #region AllContainers
    /// <inheritdoc cref="KubernetesLogsSettings.AllContainers"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.AllContainers))]
    public static T SetAllContainers<T>(this T o, bool? v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.AllContainers, v));
    /// <inheritdoc cref="KubernetesLogsSettings.AllContainers"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.AllContainers))]
    public static T ResetAllContainers<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.AllContainers));
    /// <inheritdoc cref="KubernetesLogsSettings.AllContainers"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.AllContainers))]
    public static T EnableAllContainers<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.AllContainers, true));
    /// <inheritdoc cref="KubernetesLogsSettings.AllContainers"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.AllContainers))]
    public static T DisableAllContainers<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.AllContainers, false));
    /// <inheritdoc cref="KubernetesLogsSettings.AllContainers"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.AllContainers))]
    public static T ToggleAllContainers<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.AllContainers, !o.AllContainers));
    #endregion
    #region Container
    /// <inheritdoc cref="KubernetesLogsSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Container))]
    public static T SetContainer<T>(this T o, string v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Container, v));
    /// <inheritdoc cref="KubernetesLogsSettings.Container"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Container))]
    public static T ResetContainer<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.Container));
    #endregion
    #region Follow
    /// <inheritdoc cref="KubernetesLogsSettings.Follow"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Follow))]
    public static T SetFollow<T>(this T o, bool? v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Follow, v));
    /// <inheritdoc cref="KubernetesLogsSettings.Follow"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Follow))]
    public static T ResetFollow<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.Follow));
    /// <inheritdoc cref="KubernetesLogsSettings.Follow"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Follow))]
    public static T EnableFollow<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Follow, true));
    /// <inheritdoc cref="KubernetesLogsSettings.Follow"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Follow))]
    public static T DisableFollow<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Follow, false));
    /// <inheritdoc cref="KubernetesLogsSettings.Follow"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Follow))]
    public static T ToggleFollow<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Follow, !o.Follow));
    #endregion
    #region Interactive
    /// <inheritdoc cref="KubernetesLogsSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Interactive))]
    public static T SetInteractive<T>(this T o, bool? v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Interactive, v));
    /// <inheritdoc cref="KubernetesLogsSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Interactive))]
    public static T ResetInteractive<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.Interactive));
    /// <inheritdoc cref="KubernetesLogsSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Interactive))]
    public static T EnableInteractive<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Interactive, true));
    /// <inheritdoc cref="KubernetesLogsSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Interactive))]
    public static T DisableInteractive<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Interactive, false));
    /// <inheritdoc cref="KubernetesLogsSettings.Interactive"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Interactive))]
    public static T ToggleInteractive<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Interactive, !o.Interactive));
    #endregion
    #region LimitBytes
    /// <inheritdoc cref="KubernetesLogsSettings.LimitBytes"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.LimitBytes))]
    public static T SetLimitBytes<T>(this T o, long? v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.LimitBytes, v));
    /// <inheritdoc cref="KubernetesLogsSettings.LimitBytes"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.LimitBytes))]
    public static T ResetLimitBytes<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.LimitBytes));
    #endregion
    #region PodRunningTimeout
    /// <inheritdoc cref="KubernetesLogsSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.PodRunningTimeout))]
    public static T SetPodRunningTimeout<T>(this T o, TimeSpan? v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.PodRunningTimeout, v));
    /// <inheritdoc cref="KubernetesLogsSettings.PodRunningTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.PodRunningTimeout))]
    public static T ResetPodRunningTimeout<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.PodRunningTimeout));
    #endregion
    #region Previous
    /// <inheritdoc cref="KubernetesLogsSettings.Previous"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Previous))]
    public static T SetPrevious<T>(this T o, bool? v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Previous, v));
    /// <inheritdoc cref="KubernetesLogsSettings.Previous"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Previous))]
    public static T ResetPrevious<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.Previous));
    /// <inheritdoc cref="KubernetesLogsSettings.Previous"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Previous))]
    public static T EnablePrevious<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Previous, true));
    /// <inheritdoc cref="KubernetesLogsSettings.Previous"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Previous))]
    public static T DisablePrevious<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Previous, false));
    /// <inheritdoc cref="KubernetesLogsSettings.Previous"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Previous))]
    public static T TogglePrevious<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Previous, !o.Previous));
    #endregion
    #region Selector
    /// <inheritdoc cref="KubernetesLogsSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Selector))]
    public static T SetSelector<T>(this T o, string v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Selector, v));
    /// <inheritdoc cref="KubernetesLogsSettings.Selector"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Selector))]
    public static T ResetSelector<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.Selector));
    #endregion
    #region Since
    /// <inheritdoc cref="KubernetesLogsSettings.Since"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Since))]
    public static T SetSince<T>(this T o, TimeSpan? v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Since, v));
    /// <inheritdoc cref="KubernetesLogsSettings.Since"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Since))]
    public static T ResetSince<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.Since));
    #endregion
    #region SinceTime
    /// <inheritdoc cref="KubernetesLogsSettings.SinceTime"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.SinceTime))]
    public static T SetSinceTime<T>(this T o, string v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.SinceTime, v));
    /// <inheritdoc cref="KubernetesLogsSettings.SinceTime"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.SinceTime))]
    public static T ResetSinceTime<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.SinceTime));
    #endregion
    #region Tail
    /// <inheritdoc cref="KubernetesLogsSettings.Tail"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Tail))]
    public static T SetTail<T>(this T o, long? v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Tail, v));
    /// <inheritdoc cref="KubernetesLogsSettings.Tail"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Tail))]
    public static T ResetTail<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.Tail));
    #endregion
    #region Timestamps
    /// <inheritdoc cref="KubernetesLogsSettings.Timestamps"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Timestamps))]
    public static T SetTimestamps<T>(this T o, bool? v) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Timestamps, v));
    /// <inheritdoc cref="KubernetesLogsSettings.Timestamps"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Timestamps))]
    public static T ResetTimestamps<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Remove(() => o.Timestamps));
    /// <inheritdoc cref="KubernetesLogsSettings.Timestamps"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Timestamps))]
    public static T EnableTimestamps<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Timestamps, true));
    /// <inheritdoc cref="KubernetesLogsSettings.Timestamps"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Timestamps))]
    public static T DisableTimestamps<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Timestamps, false));
    /// <inheritdoc cref="KubernetesLogsSettings.Timestamps"/>
    [Pure] [Builder(Type = typeof(KubernetesLogsSettings), Property = nameof(KubernetesLogsSettings.Timestamps))]
    public static T ToggleTimestamps<T>(this T o) where T : KubernetesLogsSettings => o.Modify(b => b.Set(() => o.Timestamps, !o.Timestamps));
    #endregion
}
#endregion
#region KubernetesOptionsBaseExtensions
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KubernetesOptionsBaseExtensions
{
    #region Alsologtostderr
    /// <inheritdoc cref="KubernetesOptionsBase.Alsologtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Alsologtostderr))]
    public static T SetAlsologtostderr<T>(this T o, bool? v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Alsologtostderr, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Alsologtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Alsologtostderr))]
    public static T ResetAlsologtostderr<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.Alsologtostderr));
    /// <inheritdoc cref="KubernetesOptionsBase.Alsologtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Alsologtostderr))]
    public static T EnableAlsologtostderr<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Alsologtostderr, true));
    /// <inheritdoc cref="KubernetesOptionsBase.Alsologtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Alsologtostderr))]
    public static T DisableAlsologtostderr<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Alsologtostderr, false));
    /// <inheritdoc cref="KubernetesOptionsBase.Alsologtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Alsologtostderr))]
    public static T ToggleAlsologtostderr<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Alsologtostderr, !o.Alsologtostderr));
    #endregion
    #region As
    /// <inheritdoc cref="KubernetesOptionsBase.As"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.As))]
    public static T SetAs<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.As, v));
    /// <inheritdoc cref="KubernetesOptionsBase.As"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.As))]
    public static T ResetAs<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.As));
    #endregion
    #region AsGroup
    /// <inheritdoc cref="KubernetesOptionsBase.AsGroup"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.AsGroup))]
    public static T SetAsGroup<T>(this T o, params string[] v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.AsGroup, v));
    /// <inheritdoc cref="KubernetesOptionsBase.AsGroup"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.AsGroup))]
    public static T SetAsGroup<T>(this T o, IEnumerable<string> v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.AsGroup, v));
    /// <inheritdoc cref="KubernetesOptionsBase.AsGroup"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.AsGroup))]
    public static T AddAsGroup<T>(this T o, params string[] v) where T : KubernetesOptionsBase => o.Modify(b => b.AddCollection(() => o.AsGroup, v));
    /// <inheritdoc cref="KubernetesOptionsBase.AsGroup"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.AsGroup))]
    public static T AddAsGroup<T>(this T o, IEnumerable<string> v) where T : KubernetesOptionsBase => o.Modify(b => b.AddCollection(() => o.AsGroup, v));
    /// <inheritdoc cref="KubernetesOptionsBase.AsGroup"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.AsGroup))]
    public static T RemoveAsGroup<T>(this T o, params string[] v) where T : KubernetesOptionsBase => o.Modify(b => b.RemoveCollection(() => o.AsGroup, v));
    /// <inheritdoc cref="KubernetesOptionsBase.AsGroup"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.AsGroup))]
    public static T RemoveAsGroup<T>(this T o, IEnumerable<string> v) where T : KubernetesOptionsBase => o.Modify(b => b.RemoveCollection(() => o.AsGroup, v));
    /// <inheritdoc cref="KubernetesOptionsBase.AsGroup"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.AsGroup))]
    public static T ClearAsGroup<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.ClearCollection(() => o.AsGroup));
    #endregion
    #region CacheDir
    /// <inheritdoc cref="KubernetesOptionsBase.CacheDir"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.CacheDir))]
    public static T SetCacheDir<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.CacheDir, v));
    /// <inheritdoc cref="KubernetesOptionsBase.CacheDir"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.CacheDir))]
    public static T ResetCacheDir<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.CacheDir));
    #endregion
    #region CertificateAuthority
    /// <inheritdoc cref="KubernetesOptionsBase.CertificateAuthority"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.CertificateAuthority))]
    public static T SetCertificateAuthority<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.CertificateAuthority, v));
    /// <inheritdoc cref="KubernetesOptionsBase.CertificateAuthority"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.CertificateAuthority))]
    public static T ResetCertificateAuthority<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.CertificateAuthority));
    #endregion
    #region ClientCertificate
    /// <inheritdoc cref="KubernetesOptionsBase.ClientCertificate"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.ClientCertificate))]
    public static T SetClientCertificate<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.ClientCertificate, v));
    /// <inheritdoc cref="KubernetesOptionsBase.ClientCertificate"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.ClientCertificate))]
    public static T ResetClientCertificate<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.ClientCertificate));
    #endregion
    #region ClientKey
    /// <inheritdoc cref="KubernetesOptionsBase.ClientKey"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.ClientKey))]
    public static T SetClientKey<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.ClientKey, v));
    /// <inheritdoc cref="KubernetesOptionsBase.ClientKey"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.ClientKey))]
    public static T ResetClientKey<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.ClientKey));
    #endregion
    #region Cluster
    /// <inheritdoc cref="KubernetesOptionsBase.Cluster"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Cluster))]
    public static T SetCluster<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Cluster, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Cluster"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Cluster))]
    public static T ResetCluster<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.Cluster));
    #endregion
    #region Context
    /// <inheritdoc cref="KubernetesOptionsBase.Context"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Context))]
    public static T SetContext<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Context, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Context"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Context))]
    public static T ResetContext<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.Context));
    #endregion
    #region InsecureSkipTlsVerify
    /// <inheritdoc cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.InsecureSkipTlsVerify))]
    public static T SetInsecureSkipTlsVerify<T>(this T o, bool? v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.InsecureSkipTlsVerify, v));
    /// <inheritdoc cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.InsecureSkipTlsVerify))]
    public static T ResetInsecureSkipTlsVerify<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.InsecureSkipTlsVerify));
    /// <inheritdoc cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.InsecureSkipTlsVerify))]
    public static T EnableInsecureSkipTlsVerify<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.InsecureSkipTlsVerify, true));
    /// <inheritdoc cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.InsecureSkipTlsVerify))]
    public static T DisableInsecureSkipTlsVerify<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.InsecureSkipTlsVerify, false));
    /// <inheritdoc cref="KubernetesOptionsBase.InsecureSkipTlsVerify"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.InsecureSkipTlsVerify))]
    public static T ToggleInsecureSkipTlsVerify<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.InsecureSkipTlsVerify, !o.InsecureSkipTlsVerify));
    #endregion
    #region Kubeconfig
    /// <inheritdoc cref="KubernetesOptionsBase.Kubeconfig"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Kubeconfig))]
    public static T SetKubeconfig<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Kubeconfig, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Kubeconfig"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Kubeconfig))]
    public static T ResetKubeconfig<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.Kubeconfig));
    #endregion
    #region LogBacktraceAt
    /// <inheritdoc cref="KubernetesOptionsBase.LogBacktraceAt"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.LogBacktraceAt))]
    public static T SetLogBacktraceAt<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.LogBacktraceAt, v));
    /// <inheritdoc cref="KubernetesOptionsBase.LogBacktraceAt"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.LogBacktraceAt))]
    public static T ResetLogBacktraceAt<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.LogBacktraceAt));
    #endregion
    #region LogDir
    /// <inheritdoc cref="KubernetesOptionsBase.LogDir"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.LogDir))]
    public static T SetLogDir<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.LogDir, v));
    /// <inheritdoc cref="KubernetesOptionsBase.LogDir"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.LogDir))]
    public static T ResetLogDir<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.LogDir));
    #endregion
    #region Logtostderr
    /// <inheritdoc cref="KubernetesOptionsBase.Logtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Logtostderr))]
    public static T SetLogtostderr<T>(this T o, bool? v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Logtostderr, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Logtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Logtostderr))]
    public static T ResetLogtostderr<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.Logtostderr));
    /// <inheritdoc cref="KubernetesOptionsBase.Logtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Logtostderr))]
    public static T EnableLogtostderr<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Logtostderr, true));
    /// <inheritdoc cref="KubernetesOptionsBase.Logtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Logtostderr))]
    public static T DisableLogtostderr<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Logtostderr, false));
    /// <inheritdoc cref="KubernetesOptionsBase.Logtostderr"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Logtostderr))]
    public static T ToggleLogtostderr<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Logtostderr, !o.Logtostderr));
    #endregion
    #region MatchServerVersion
    /// <inheritdoc cref="KubernetesOptionsBase.MatchServerVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.MatchServerVersion))]
    public static T SetMatchServerVersion<T>(this T o, bool? v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.MatchServerVersion, v));
    /// <inheritdoc cref="KubernetesOptionsBase.MatchServerVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.MatchServerVersion))]
    public static T ResetMatchServerVersion<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.MatchServerVersion));
    /// <inheritdoc cref="KubernetesOptionsBase.MatchServerVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.MatchServerVersion))]
    public static T EnableMatchServerVersion<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.MatchServerVersion, true));
    /// <inheritdoc cref="KubernetesOptionsBase.MatchServerVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.MatchServerVersion))]
    public static T DisableMatchServerVersion<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.MatchServerVersion, false));
    /// <inheritdoc cref="KubernetesOptionsBase.MatchServerVersion"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.MatchServerVersion))]
    public static T ToggleMatchServerVersion<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.MatchServerVersion, !o.MatchServerVersion));
    #endregion
    #region Namespace
    /// <inheritdoc cref="KubernetesOptionsBase.Namespace"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Namespace))]
    public static T SetNamespace<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Namespace, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Namespace"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Namespace))]
    public static T ResetNamespace<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.Namespace));
    #endregion
    #region RequestTimeout
    /// <inheritdoc cref="KubernetesOptionsBase.RequestTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.RequestTimeout))]
    public static T SetRequestTimeout<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.RequestTimeout, v));
    /// <inheritdoc cref="KubernetesOptionsBase.RequestTimeout"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.RequestTimeout))]
    public static T ResetRequestTimeout<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.RequestTimeout));
    #endregion
    #region Server
    /// <inheritdoc cref="KubernetesOptionsBase.Server"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Server))]
    public static T SetServer<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Server, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Server"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Server))]
    public static T ResetServer<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.Server));
    #endregion
    #region Stderrthreshold
    /// <inheritdoc cref="KubernetesOptionsBase.Stderrthreshold"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Stderrthreshold))]
    public static T SetStderrthreshold<T>(this T o, int? v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Stderrthreshold, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Stderrthreshold"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Stderrthreshold))]
    public static T ResetStderrthreshold<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.Stderrthreshold));
    #endregion
    #region Token
    /// <inheritdoc cref="KubernetesOptionsBase.Token"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Token))]
    public static T SetToken<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Token, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Token"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Token))]
    public static T ResetToken<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.Token));
    #endregion
    #region User
    /// <inheritdoc cref="KubernetesOptionsBase.User"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.User))]
    public static T SetUser<T>(this T o, string v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.User, v));
    /// <inheritdoc cref="KubernetesOptionsBase.User"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.User))]
    public static T ResetUser<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.User));
    #endregion
    #region V
    /// <inheritdoc cref="KubernetesOptionsBase.V"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.V))]
    public static T SetV<T>(this T o, int? v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.V, v));
    /// <inheritdoc cref="KubernetesOptionsBase.V"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.V))]
    public static T ResetV<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.Remove(() => o.V));
    #endregion
    #region Vmodule
    /// <inheritdoc cref="KubernetesOptionsBase.Vmodule"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Vmodule))]
    public static T SetVmodule<T>(this T o, IDictionary<string, string> v) where T : KubernetesOptionsBase => o.Modify(b => b.Set(() => o.Vmodule, v.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase)));
    /// <inheritdoc cref="KubernetesOptionsBase.Vmodule"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Vmodule))]
    public static T SetVmodule<T>(this T o, string k, string v) where T : KubernetesOptionsBase => o.Modify(b => b.SetDictionary(() => o.Vmodule, k, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Vmodule"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Vmodule))]
    public static T AddVmodule<T>(this T o, string k, string v) where T : KubernetesOptionsBase => o.Modify(b => b.AddDictionary(() => o.Vmodule, k, v));
    /// <inheritdoc cref="KubernetesOptionsBase.Vmodule"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Vmodule))]
    public static T RemoveVmodule<T>(this T o, string k) where T : KubernetesOptionsBase => o.Modify(b => b.RemoveDictionary(() => o.Vmodule, k));
    /// <inheritdoc cref="KubernetesOptionsBase.Vmodule"/>
    [Pure] [Builder(Type = typeof(KubernetesOptionsBase), Property = nameof(KubernetesOptionsBase.Vmodule))]
    public static T ClearVmodule<T>(this T o) where T : KubernetesOptionsBase => o.Modify(b => b.ClearDictionary(() => o.Vmodule));
    #endregion
}
#endregion
#region KubernetesApiResourcesOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesApiResourcesOutput>))]
public partial class KubernetesApiResourcesOutput : Enumeration
{
    public static KubernetesApiResourcesOutput wide = (KubernetesApiResourcesOutput) "wide";
    public static KubernetesApiResourcesOutput name = (KubernetesApiResourcesOutput) "name";
    public static implicit operator KubernetesApiResourcesOutput(string value)
    {
        return new KubernetesApiResourcesOutput { Value = value };
    }
}
#endregion
#region KubernetesRunOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesRunOutput>))]
public partial class KubernetesRunOutput : Enumeration
{
    public static KubernetesRunOutput json = (KubernetesRunOutput) "json";
    public static KubernetesRunOutput yaml = (KubernetesRunOutput) "yaml";
    public static KubernetesRunOutput name = (KubernetesRunOutput) "name";
    public static KubernetesRunOutput templatefile = (KubernetesRunOutput) "templatefile";
    public static KubernetesRunOutput template = (KubernetesRunOutput) "template";
    public static KubernetesRunOutput go_template = (KubernetesRunOutput) "go-template";
    public static KubernetesRunOutput go_template_file = (KubernetesRunOutput) "go-template-file";
    public static KubernetesRunOutput jsonpath = (KubernetesRunOutput) "jsonpath";
    public static KubernetesRunOutput jsonpath_file = (KubernetesRunOutput) "jsonpath-file";
    public static implicit operator KubernetesRunOutput(string value)
    {
        return new KubernetesRunOutput { Value = value };
    }
}
#endregion
#region KubernetesGetOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesGetOutput>))]
public partial class KubernetesGetOutput : Enumeration
{
    public static KubernetesGetOutput json = (KubernetesGetOutput) "json";
    public static KubernetesGetOutput yaml = (KubernetesGetOutput) "yaml";
    public static KubernetesGetOutput wide = (KubernetesGetOutput) "wide";
    public static KubernetesGetOutput name = (KubernetesGetOutput) "name";
    public static KubernetesGetOutput custom_columns = (KubernetesGetOutput) "custom-columns";
    public static implicit operator KubernetesGetOutput(string value)
    {
        return new KubernetesGetOutput { Value = value };
    }
}
#endregion
#region KubernetesRollingUpdateOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesRollingUpdateOutput>))]
public partial class KubernetesRollingUpdateOutput : Enumeration
{
    public static KubernetesRollingUpdateOutput json = (KubernetesRollingUpdateOutput) "json";
    public static KubernetesRollingUpdateOutput yaml = (KubernetesRollingUpdateOutput) "yaml";
    public static KubernetesRollingUpdateOutput name = (KubernetesRollingUpdateOutput) "name";
    public static KubernetesRollingUpdateOutput go_template_file = (KubernetesRollingUpdateOutput) "go-template-file";
    public static KubernetesRollingUpdateOutput templatefile = (KubernetesRollingUpdateOutput) "templatefile";
    public static KubernetesRollingUpdateOutput template = (KubernetesRollingUpdateOutput) "template";
    public static KubernetesRollingUpdateOutput go_template = (KubernetesRollingUpdateOutput) "go-template";
    public static KubernetesRollingUpdateOutput jsonpath = (KubernetesRollingUpdateOutput) "jsonpath";
    public static KubernetesRollingUpdateOutput jsonpath_file = (KubernetesRollingUpdateOutput) "jsonpath-file";
    public static implicit operator KubernetesRollingUpdateOutput(string value)
    {
        return new KubernetesRollingUpdateOutput { Value = value };
    }
}
#endregion
#region KubernetesLabelOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesLabelOutput>))]
public partial class KubernetesLabelOutput : Enumeration
{
    public static KubernetesLabelOutput json = (KubernetesLabelOutput) "json";
    public static KubernetesLabelOutput yaml = (KubernetesLabelOutput) "yaml";
    public static KubernetesLabelOutput name = (KubernetesLabelOutput) "name";
    public static KubernetesLabelOutput template = (KubernetesLabelOutput) "template";
    public static KubernetesLabelOutput go_template = (KubernetesLabelOutput) "go-template";
    public static KubernetesLabelOutput go_template_file = (KubernetesLabelOutput) "go-template-file";
    public static KubernetesLabelOutput templatefile = (KubernetesLabelOutput) "templatefile";
    public static KubernetesLabelOutput jsonpath = (KubernetesLabelOutput) "jsonpath";
    public static KubernetesLabelOutput jsonpath_file = (KubernetesLabelOutput) "jsonpath-file";
    public static implicit operator KubernetesLabelOutput(string value)
    {
        return new KubernetesLabelOutput { Value = value };
    }
}
#endregion
#region KubernetesAnnotateOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesAnnotateOutput>))]
public partial class KubernetesAnnotateOutput : Enumeration
{
    public static KubernetesAnnotateOutput json = (KubernetesAnnotateOutput) "json";
    public static KubernetesAnnotateOutput yaml = (KubernetesAnnotateOutput) "yaml";
    public static KubernetesAnnotateOutput name = (KubernetesAnnotateOutput) "name";
    public static KubernetesAnnotateOutput templatefile = (KubernetesAnnotateOutput) "templatefile";
    public static KubernetesAnnotateOutput template = (KubernetesAnnotateOutput) "template";
    public static KubernetesAnnotateOutput go_template = (KubernetesAnnotateOutput) "go-template";
    public static KubernetesAnnotateOutput go_template_file = (KubernetesAnnotateOutput) "go-template-file";
    public static KubernetesAnnotateOutput jsonpath = (KubernetesAnnotateOutput) "jsonpath";
    public static KubernetesAnnotateOutput jsonpath_file = (KubernetesAnnotateOutput) "jsonpath-file";
    public static implicit operator KubernetesAnnotateOutput(string value)
    {
        return new KubernetesAnnotateOutput { Value = value };
    }
}
#endregion
#region KubernetesExposeOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesExposeOutput>))]
public partial class KubernetesExposeOutput : Enumeration
{
    public static KubernetesExposeOutput json = (KubernetesExposeOutput) "json";
    public static KubernetesExposeOutput yaml = (KubernetesExposeOutput) "yaml";
    public static KubernetesExposeOutput name = (KubernetesExposeOutput) "name";
    public static KubernetesExposeOutput template = (KubernetesExposeOutput) "template";
    public static KubernetesExposeOutput go_template = (KubernetesExposeOutput) "go-template";
    public static KubernetesExposeOutput go_template_file = (KubernetesExposeOutput) "go-template-file";
    public static KubernetesExposeOutput templatefile = (KubernetesExposeOutput) "templatefile";
    public static KubernetesExposeOutput jsonpath = (KubernetesExposeOutput) "jsonpath";
    public static KubernetesExposeOutput jsonpath_file = (KubernetesExposeOutput) "jsonpath-file";
    public static implicit operator KubernetesExposeOutput(string value)
    {
        return new KubernetesExposeOutput { Value = value };
    }
}
#endregion
#region KubernetesPatchOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesPatchOutput>))]
public partial class KubernetesPatchOutput : Enumeration
{
    public static KubernetesPatchOutput json = (KubernetesPatchOutput) "json";
    public static KubernetesPatchOutput yaml = (KubernetesPatchOutput) "yaml";
    public static KubernetesPatchOutput name = (KubernetesPatchOutput) "name";
    public static KubernetesPatchOutput template = (KubernetesPatchOutput) "template";
    public static KubernetesPatchOutput go_template = (KubernetesPatchOutput) "go-template";
    public static KubernetesPatchOutput go_template_file = (KubernetesPatchOutput) "go-template-file";
    public static KubernetesPatchOutput templatefile = (KubernetesPatchOutput) "templatefile";
    public static KubernetesPatchOutput jsonpath = (KubernetesPatchOutput) "jsonpath";
    public static KubernetesPatchOutput jsonpath_file = (KubernetesPatchOutput) "jsonpath-file";
    public static implicit operator KubernetesPatchOutput(string value)
    {
        return new KubernetesPatchOutput { Value = value };
    }
}
#endregion
#region KubernetesPatchType
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesPatchType>))]
public partial class KubernetesPatchType : Enumeration
{
    public static KubernetesPatchType json = (KubernetesPatchType) "json";
    public static KubernetesPatchType merge = (KubernetesPatchType) "merge";
    public static KubernetesPatchType strategic = (KubernetesPatchType) "strategic";
    public static implicit operator KubernetesPatchType(string value)
    {
        return new KubernetesPatchType { Value = value };
    }
}
#endregion
#region KubernetesReplaceOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesReplaceOutput>))]
public partial class KubernetesReplaceOutput : Enumeration
{
    public static KubernetesReplaceOutput json = (KubernetesReplaceOutput) "json";
    public static KubernetesReplaceOutput yaml = (KubernetesReplaceOutput) "yaml";
    public static KubernetesReplaceOutput name = (KubernetesReplaceOutput) "name";
    public static KubernetesReplaceOutput template = (KubernetesReplaceOutput) "template";
    public static KubernetesReplaceOutput go_template = (KubernetesReplaceOutput) "go-template";
    public static KubernetesReplaceOutput go_template_file = (KubernetesReplaceOutput) "go-template-file";
    public static KubernetesReplaceOutput templatefile = (KubernetesReplaceOutput) "templatefile";
    public static KubernetesReplaceOutput jsonpath = (KubernetesReplaceOutput) "jsonpath";
    public static KubernetesReplaceOutput jsonpath_file = (KubernetesReplaceOutput) "jsonpath-file";
    public static implicit operator KubernetesReplaceOutput(string value)
    {
        return new KubernetesReplaceOutput { Value = value };
    }
}
#endregion
#region KubernetesTaintOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesTaintOutput>))]
public partial class KubernetesTaintOutput : Enumeration
{
    public static KubernetesTaintOutput json = (KubernetesTaintOutput) "json";
    public static KubernetesTaintOutput yaml = (KubernetesTaintOutput) "yaml";
    public static KubernetesTaintOutput name = (KubernetesTaintOutput) "name";
    public static KubernetesTaintOutput template = (KubernetesTaintOutput) "template";
    public static KubernetesTaintOutput go_template = (KubernetesTaintOutput) "go-template";
    public static KubernetesTaintOutput go_template_file = (KubernetesTaintOutput) "go-template-file";
    public static KubernetesTaintOutput templatefile = (KubernetesTaintOutput) "templatefile";
    public static KubernetesTaintOutput jsonpath = (KubernetesTaintOutput) "jsonpath";
    public static KubernetesTaintOutput jsonpath_file = (KubernetesTaintOutput) "jsonpath-file";
    public static implicit operator KubernetesTaintOutput(string value)
    {
        return new KubernetesTaintOutput { Value = value };
    }
}
#endregion
#region KubernetesApplyOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesApplyOutput>))]
public partial class KubernetesApplyOutput : Enumeration
{
    public static KubernetesApplyOutput json = (KubernetesApplyOutput) "json";
    public static KubernetesApplyOutput yaml = (KubernetesApplyOutput) "yaml";
    public static KubernetesApplyOutput name = (KubernetesApplyOutput) "name";
    public static KubernetesApplyOutput template = (KubernetesApplyOutput) "template";
    public static KubernetesApplyOutput go_template = (KubernetesApplyOutput) "go-template";
    public static KubernetesApplyOutput go_template_file = (KubernetesApplyOutput) "go-template-file";
    public static KubernetesApplyOutput templatefile = (KubernetesApplyOutput) "templatefile";
    public static KubernetesApplyOutput jsonpath = (KubernetesApplyOutput) "jsonpath";
    public static KubernetesApplyOutput jsonpath_file = (KubernetesApplyOutput) "jsonpath-file";
    public static implicit operator KubernetesApplyOutput(string value)
    {
        return new KubernetesApplyOutput { Value = value };
    }
}
#endregion
#region KubernetesAutoscaleOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesAutoscaleOutput>))]
public partial class KubernetesAutoscaleOutput : Enumeration
{
    public static KubernetesAutoscaleOutput json = (KubernetesAutoscaleOutput) "json";
    public static KubernetesAutoscaleOutput yaml = (KubernetesAutoscaleOutput) "yaml";
    public static KubernetesAutoscaleOutput name = (KubernetesAutoscaleOutput) "name";
    public static KubernetesAutoscaleOutput template = (KubernetesAutoscaleOutput) "template";
    public static KubernetesAutoscaleOutput go_template = (KubernetesAutoscaleOutput) "go-template";
    public static KubernetesAutoscaleOutput go_template_file = (KubernetesAutoscaleOutput) "go-template-file";
    public static KubernetesAutoscaleOutput templatefile = (KubernetesAutoscaleOutput) "templatefile";
    public static KubernetesAutoscaleOutput jsonpath = (KubernetesAutoscaleOutput) "jsonpath";
    public static KubernetesAutoscaleOutput jsonpath_file = (KubernetesAutoscaleOutput) "jsonpath-file";
    public static implicit operator KubernetesAutoscaleOutput(string value)
    {
        return new KubernetesAutoscaleOutput { Value = value };
    }
}
#endregion
#region KubernetesWaitOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesWaitOutput>))]
public partial class KubernetesWaitOutput : Enumeration
{
    public static KubernetesWaitOutput json = (KubernetesWaitOutput) "json";
    public static KubernetesWaitOutput yaml = (KubernetesWaitOutput) "yaml";
    public static KubernetesWaitOutput name = (KubernetesWaitOutput) "name";
    public static KubernetesWaitOutput template = (KubernetesWaitOutput) "template";
    public static KubernetesWaitOutput go_template = (KubernetesWaitOutput) "go-template";
    public static KubernetesWaitOutput go_template_file = (KubernetesWaitOutput) "go-template-file";
    public static KubernetesWaitOutput templatefile = (KubernetesWaitOutput) "templatefile";
    public static KubernetesWaitOutput jsonpath = (KubernetesWaitOutput) "jsonpath";
    public static KubernetesWaitOutput jsonpath_file = (KubernetesWaitOutput) "jsonpath-file";
    public static implicit operator KubernetesWaitOutput(string value)
    {
        return new KubernetesWaitOutput { Value = value };
    }
}
#endregion
#region KubernetesConvertOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesConvertOutput>))]
public partial class KubernetesConvertOutput : Enumeration
{
    public static KubernetesConvertOutput json = (KubernetesConvertOutput) "json";
    public static KubernetesConvertOutput yaml = (KubernetesConvertOutput) "yaml";
    public static KubernetesConvertOutput name = (KubernetesConvertOutput) "name";
    public static KubernetesConvertOutput go_template = (KubernetesConvertOutput) "go-template";
    public static KubernetesConvertOutput go_template_file = (KubernetesConvertOutput) "go-template-file";
    public static KubernetesConvertOutput templatefile = (KubernetesConvertOutput) "templatefile";
    public static KubernetesConvertOutput template = (KubernetesConvertOutput) "template";
    public static KubernetesConvertOutput jsonpath = (KubernetesConvertOutput) "jsonpath";
    public static KubernetesConvertOutput jsonpath_file = (KubernetesConvertOutput) "jsonpath-file";
    public static implicit operator KubernetesConvertOutput(string value)
    {
        return new KubernetesConvertOutput { Value = value };
    }
}
#endregion
#region KubernetesCreateOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesCreateOutput>))]
public partial class KubernetesCreateOutput : Enumeration
{
    public static KubernetesCreateOutput json = (KubernetesCreateOutput) "json";
    public static KubernetesCreateOutput yaml = (KubernetesCreateOutput) "yaml";
    public static KubernetesCreateOutput name = (KubernetesCreateOutput) "name";
    public static KubernetesCreateOutput template = (KubernetesCreateOutput) "template";
    public static KubernetesCreateOutput go_template = (KubernetesCreateOutput) "go-template";
    public static KubernetesCreateOutput go_template_file = (KubernetesCreateOutput) "go-template-file";
    public static KubernetesCreateOutput templatefile = (KubernetesCreateOutput) "templatefile";
    public static KubernetesCreateOutput jsonpath = (KubernetesCreateOutput) "jsonpath";
    public static KubernetesCreateOutput jsonpath_file = (KubernetesCreateOutput) "jsonpath-file";
    public static implicit operator KubernetesCreateOutput(string value)
    {
        return new KubernetesCreateOutput { Value = value };
    }
}
#endregion
#region KubernetesRunContainerOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesRunContainerOutput>))]
public partial class KubernetesRunContainerOutput : Enumeration
{
    public static KubernetesRunContainerOutput json = (KubernetesRunContainerOutput) "json";
    public static KubernetesRunContainerOutput yaml = (KubernetesRunContainerOutput) "yaml";
    public static KubernetesRunContainerOutput name = (KubernetesRunContainerOutput) "name";
    public static KubernetesRunContainerOutput template = (KubernetesRunContainerOutput) "template";
    public static KubernetesRunContainerOutput go_template = (KubernetesRunContainerOutput) "go-template";
    public static KubernetesRunContainerOutput go_template_file = (KubernetesRunContainerOutput) "go-template-file";
    public static KubernetesRunContainerOutput templatefile = (KubernetesRunContainerOutput) "templatefile";
    public static KubernetesRunContainerOutput jsonpath = (KubernetesRunContainerOutput) "jsonpath";
    public static KubernetesRunContainerOutput jsonpath_file = (KubernetesRunContainerOutput) "jsonpath-file";
    public static implicit operator KubernetesRunContainerOutput(string value)
    {
        return new KubernetesRunContainerOutput { Value = value };
    }
}
#endregion
#region KubernetesEditOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesEditOutput>))]
public partial class KubernetesEditOutput : Enumeration
{
    public static KubernetesEditOutput json = (KubernetesEditOutput) "json";
    public static KubernetesEditOutput yaml = (KubernetesEditOutput) "yaml";
    public static KubernetesEditOutput name = (KubernetesEditOutput) "name";
    public static KubernetesEditOutput template = (KubernetesEditOutput) "template";
    public static KubernetesEditOutput go_template = (KubernetesEditOutput) "go-template";
    public static KubernetesEditOutput go_template_file = (KubernetesEditOutput) "go-template-file";
    public static KubernetesEditOutput templatefile = (KubernetesEditOutput) "templatefile";
    public static KubernetesEditOutput jsonpath = (KubernetesEditOutput) "jsonpath";
    public static KubernetesEditOutput jsonpath_file = (KubernetesEditOutput) "jsonpath-file";
    public static implicit operator KubernetesEditOutput(string value)
    {
        return new KubernetesEditOutput { Value = value };
    }
}
#endregion
#region KubernetesScaleOutput
/// <summary>Used within <see cref="KubernetesTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<KubernetesScaleOutput>))]
public partial class KubernetesScaleOutput : Enumeration
{
    public static KubernetesScaleOutput json = (KubernetesScaleOutput) "json";
    public static KubernetesScaleOutput yaml = (KubernetesScaleOutput) "yaml";
    public static KubernetesScaleOutput name = (KubernetesScaleOutput) "name";
    public static KubernetesScaleOutput template = (KubernetesScaleOutput) "template";
    public static KubernetesScaleOutput go_template = (KubernetesScaleOutput) "go-template";
    public static KubernetesScaleOutput go_template_file = (KubernetesScaleOutput) "go-template-file";
    public static KubernetesScaleOutput templatefile = (KubernetesScaleOutput) "templatefile";
    public static KubernetesScaleOutput jsonpath = (KubernetesScaleOutput) "jsonpath";
    public static KubernetesScaleOutput jsonpath_file = (KubernetesScaleOutput) "jsonpath-file";
    public static implicit operator KubernetesScaleOutput(string value)
    {
        return new KubernetesScaleOutput { Value = value };
    }
}
#endregion

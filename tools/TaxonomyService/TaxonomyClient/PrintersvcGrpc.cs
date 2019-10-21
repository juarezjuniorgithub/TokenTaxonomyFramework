// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: printersvc.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TTI.TTF.Taxonomy {
  public static partial class PrinterService
  {
    static readonly string __ServiceName = "taxonomy.ttfprinter.PrinterService";

    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.PrintArtifact> __Marshaller_taxonomy_ttfprinter_PrintArtifact = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.PrintArtifact.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.PrintResult> __Marshaller_taxonomy_ttfprinter_PrintResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.PrintResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.PrintTTFOptions> __Marshaller_taxonomy_ttfprinter_PrintTTFOptions = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.PrintTTFOptions.Parser.ParseFrom);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.PrintArtifact, global::TTI.TTF.Taxonomy.PrintResult> __Method_PrintTTFArtifact = new grpc::Method<global::TTI.TTF.Taxonomy.PrintArtifact, global::TTI.TTF.Taxonomy.PrintResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PrintTTFArtifact",
        __Marshaller_taxonomy_ttfprinter_PrintArtifact,
        __Marshaller_taxonomy_ttfprinter_PrintResult);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.PrintTTFOptions, global::TTI.TTF.Taxonomy.PrintResult> __Method_PrintTTF = new grpc::Method<global::TTI.TTF.Taxonomy.PrintTTFOptions, global::TTI.TTF.Taxonomy.PrintResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PrintTTF",
        __Marshaller_taxonomy_ttfprinter_PrintTTFOptions,
        __Marshaller_taxonomy_ttfprinter_PrintResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TTI.TTF.Taxonomy.PrintersvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for PrinterService</summary>
    public partial class PrinterServiceClient : grpc::ClientBase<PrinterServiceClient>
    {
      /// <summary>Creates a new client for PrinterService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PrinterServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PrinterService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PrinterServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PrinterServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PrinterServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::TTI.TTF.Taxonomy.PrintResult PrintTTFArtifact(global::TTI.TTF.Taxonomy.PrintArtifact request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PrintTTFArtifact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TTI.TTF.Taxonomy.PrintResult PrintTTFArtifact(global::TTI.TTF.Taxonomy.PrintArtifact request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PrintTTFArtifact, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.PrintResult> PrintTTFArtifactAsync(global::TTI.TTF.Taxonomy.PrintArtifact request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PrintTTFArtifactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.PrintResult> PrintTTFArtifactAsync(global::TTI.TTF.Taxonomy.PrintArtifact request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PrintTTFArtifact, null, options, request);
      }
      public virtual global::TTI.TTF.Taxonomy.PrintResult PrintTTF(global::TTI.TTF.Taxonomy.PrintTTFOptions request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PrintTTF(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TTI.TTF.Taxonomy.PrintResult PrintTTF(global::TTI.TTF.Taxonomy.PrintTTFOptions request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PrintTTF, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.PrintResult> PrintTTFAsync(global::TTI.TTF.Taxonomy.PrintTTFOptions request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PrintTTFAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.PrintResult> PrintTTFAsync(global::TTI.TTF.Taxonomy.PrintTTFOptions request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PrintTTF, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PrinterServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PrinterServiceClient(configuration);
      }
    }

  }
}
#endregion

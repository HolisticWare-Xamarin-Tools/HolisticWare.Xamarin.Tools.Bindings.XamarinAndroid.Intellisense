using System;

namespace IO.Grpc.Stub.Annotations {

	[global::Android.Runtime.Annotation ("io.grpc.stub.annotations.RpcMethod")]
	public partial class RpcMethodAttribute : Attribute
	{
		[global::Android.Runtime.Register ("fullMethodName")]
		public string FullMethodName { get; set; }

		[global::Android.Runtime.Register ("requestType")]
		public global::Java.Lang.Class RequestType { get; set; }

		[global::Android.Runtime.Register ("responseType")]
		public global::Java.Lang.Class ResponseType { get; set; }

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace IO.Grpc.Stub {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='MetadataUtils']"
	[global::Android.Runtime.Register ("io/grpc/stub/MetadataUtils", DoNotGenerateAcw=true)]
	public sealed partial class MetadataUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("io/grpc/stub/MetadataUtils", typeof (MetadataUtils));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal MetadataUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

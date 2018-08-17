using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Grpc.Stub {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='ClientCalls']"
	[global::Android.Runtime.Register ("io/grpc/stub/ClientCalls", DoNotGenerateAcw=true)]
	public sealed partial class ClientCalls : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("io/grpc/stub/ClientCalls", typeof (ClientCalls));
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

		internal ClientCalls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Grpc.Stub {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='StreamObservers']"
	[global::Android.Runtime.Register ("io/grpc/stub/StreamObservers", DoNotGenerateAcw=true)]
	public sealed partial class StreamObservers : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("io/grpc/stub/StreamObservers", typeof (StreamObservers));
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

		internal StreamObservers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.grpc.stub']/class[@name='StreamObservers']/constructor[@name='StreamObservers' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StreamObservers ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='StreamObservers']/method[@name='copyWithFlowControl' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;V&gt;'] and parameter[2][@type='io.grpc.stub.CallStreamObserver&lt;V&gt;']]"
		[Register ("copyWithFlowControl", "(Ljava/lang/Iterable;Lio/grpc/stub/CallStreamObserver;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe void CopyWithFlowControl (global::Java.Lang.IIterable source, global::Xamarin.Grpc.Stub.CallStreamObserver target)
		{
			const string __id = "copyWithFlowControl.(Ljava/lang/Iterable;Lio/grpc/stub/CallStreamObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='StreamObservers']/method[@name='copyWithFlowControl' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;V&gt;'] and parameter[2][@type='io.grpc.stub.CallStreamObserver&lt;V&gt;']]"
		[Register ("copyWithFlowControl", "(Ljava/util/Iterator;Lio/grpc/stub/CallStreamObserver;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe void CopyWithFlowControl (global::Java.Util.IIterator source, global::Xamarin.Grpc.Stub.CallStreamObserver target)
		{
			const string __id = "copyWithFlowControl.(Ljava/util/Iterator;Lio/grpc/stub/CallStreamObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Grpc.Stub {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='AbstractStub']"
	[global::Android.Runtime.Register ("io/grpc/stub/AbstractStub", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S extends io.grpc.stub.AbstractStub<S>"})]
	public abstract partial class AbstractStub : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("io/grpc/stub/AbstractStub", typeof (AbstractStub));
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

		protected AbstractStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='AbstractStub']/method[@name='withCompression' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withCompression", "(Ljava/lang/String;)Lio/grpc/stub/AbstractStub;", "")]
		public unsafe global::Java.Lang.Object WithCompression (string compressorName)
		{
			const string __id = "withCompression.(Ljava/lang/String;)Lio/grpc/stub/AbstractStub;";
			IntPtr native_compressorName = JNIEnv.NewString (compressorName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_compressorName);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_compressorName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='AbstractStub']/method[@name='withDeadlineAfter' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("withDeadlineAfter", "(JLjava/util/concurrent/TimeUnit;)Lio/grpc/stub/AbstractStub;", "")]
		public unsafe global::Java.Lang.Object WithDeadlineAfter (long duration, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "withDeadlineAfter.(JLjava/util/concurrent/TimeUnit;)Lio/grpc/stub/AbstractStub;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (duration);
				__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='AbstractStub']/method[@name='withExecutor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
		[Register ("withExecutor", "(Ljava/util/concurrent/Executor;)Lio/grpc/stub/AbstractStub;", "")]
		public unsafe global::Java.Lang.Object WithExecutor (global::Java.Util.Concurrent.IExecutor executor)
		{
			const string __id = "withExecutor.(Ljava/util/concurrent/Executor;)Lio/grpc/stub/AbstractStub;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((executor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executor).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='AbstractStub']/method[@name='withMaxInboundMessageSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withMaxInboundMessageSize", "(I)Lio/grpc/stub/AbstractStub;", "")]
		public unsafe global::Java.Lang.Object WithMaxInboundMessageSize (int maxSize)
		{
			const string __id = "withMaxInboundMessageSize.(I)Lio/grpc/stub/AbstractStub;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxSize);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='AbstractStub']/method[@name='withMaxOutboundMessageSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withMaxOutboundMessageSize", "(I)Lio/grpc/stub/AbstractStub;", "")]
		public unsafe global::Java.Lang.Object WithMaxOutboundMessageSize (int maxSize)
		{
			const string __id = "withMaxOutboundMessageSize.(I)Lio/grpc/stub/AbstractStub;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxSize);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='AbstractStub']/method[@name='withWaitForReady' and count(parameter)=0]"
		[Register ("withWaitForReady", "()Lio/grpc/stub/AbstractStub;", "")]
		public unsafe global::Java.Lang.Object WithWaitForReady ()
		{
			const string __id = "withWaitForReady.()Lio/grpc/stub/AbstractStub;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/grpc/stub/AbstractStub", DoNotGenerateAcw=true)]
	internal partial class AbstractStubInvoker : AbstractStub {

		public AbstractStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/AbstractStub", typeof (AbstractStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}

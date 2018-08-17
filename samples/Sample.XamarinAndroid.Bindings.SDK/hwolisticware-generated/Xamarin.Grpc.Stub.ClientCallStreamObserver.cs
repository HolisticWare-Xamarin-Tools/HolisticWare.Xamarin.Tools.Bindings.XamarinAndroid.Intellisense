using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Grpc.Stub {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='ClientCallStreamObserver']"
	[global::Android.Runtime.Register ("io/grpc/stub/ClientCallStreamObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
	public abstract partial class ClientCallStreamObserver : global::Xamarin.Grpc.Stub.CallStreamObserver {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("io/grpc/stub/ClientCallStreamObserver", typeof (ClientCallStreamObserver));
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

		protected ClientCallStreamObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.grpc.stub']/class[@name='ClientCallStreamObserver']/constructor[@name='ClientCallStreamObserver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClientCallStreamObserver ()
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

		static Delegate cb_cancel_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetCancel_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_cancel_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_cancel_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Cancel_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_cancel_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Cancel_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.Grpc.Stub.ClientCallStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ClientCallStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ClientCallStreamObserver']/method[@name='cancel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("cancel", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetCancel_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public abstract void Cancel (string p0, global::Java.Lang.Throwable p1);

	}

	[global::Android.Runtime.Register ("io/grpc/stub/ClientCallStreamObserver", DoNotGenerateAcw=true)]
	internal partial class ClientCallStreamObserverInvoker : ClientCallStreamObserver {

		public ClientCallStreamObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/ClientCallStreamObserver", typeof (ClientCallStreamObserverInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ClientCallStreamObserver']/method[@name='cancel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("cancel", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetCancel_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public override unsafe void Cancel (string p0, global::Java.Lang.Throwable p1)
		{
			const string __id = "cancel.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public override unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				const string __id = "isReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='disableAutoInboundFlowControl' and count(parameter)=0]"
		[Register ("disableAutoInboundFlowControl", "()V", "GetDisableAutoInboundFlowControlHandler")]
		public override unsafe void DisableAutoInboundFlowControl ()
		{
			const string __id = "disableAutoInboundFlowControl.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='request' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("request", "(I)V", "GetRequest_IHandler")]
		public override unsafe void Request (int p0)
		{
			const string __id = "request.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='setMessageCompression' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMessageCompression", "(Z)V", "GetSetMessageCompression_ZHandler")]
		public override unsafe void SetMessageCompression (bool p0)
		{
			const string __id = "setMessageCompression.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='setOnReadyHandler' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setOnReadyHandler", "(Ljava/lang/Runnable;)V", "GetSetOnReadyHandler_Ljava_lang_Runnable_Handler")]
		public override unsafe void SetOnReadyHandler (global::Java.Lang.IRunnable p0)
		{
			const string __id = "setOnReadyHandler.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}

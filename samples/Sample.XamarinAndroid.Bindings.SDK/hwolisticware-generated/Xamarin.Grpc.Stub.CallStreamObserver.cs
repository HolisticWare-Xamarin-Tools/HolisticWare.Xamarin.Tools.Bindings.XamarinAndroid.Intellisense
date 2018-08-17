using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Grpc.Stub {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']"
	[global::Android.Runtime.Register ("io/grpc/stub/CallStreamObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
	public abstract partial class CallStreamObserver : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("io/grpc/stub/CallStreamObserver", typeof (CallStreamObserver));
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

		protected CallStreamObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/constructor[@name='CallStreamObserver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallStreamObserver ()
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

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.Grpc.Stub.CallStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.CallStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		public abstract bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")] get;
		}

		static Delegate cb_disableAutoInboundFlowControl;
#pragma warning disable 0169
		static Delegate GetDisableAutoInboundFlowControlHandler ()
		{
			if (cb_disableAutoInboundFlowControl == null)
				cb_disableAutoInboundFlowControl = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableAutoInboundFlowControl);
			return cb_disableAutoInboundFlowControl;
		}

		static void n_DisableAutoInboundFlowControl (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.Grpc.Stub.CallStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.CallStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableAutoInboundFlowControl ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='disableAutoInboundFlowControl' and count(parameter)=0]"
		[Register ("disableAutoInboundFlowControl", "()V", "GetDisableAutoInboundFlowControlHandler")]
		public abstract void DisableAutoInboundFlowControl ();

		static Delegate cb_request_I;
#pragma warning disable 0169
		static Delegate GetRequest_IHandler ()
		{
			if (cb_request_I == null)
				cb_request_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Request_I);
			return cb_request_I;
		}

		static void n_Request_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Xamarin.Grpc.Stub.CallStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.CallStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='request' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("request", "(I)V", "GetRequest_IHandler")]
		public abstract void Request (int p0);

		static Delegate cb_setMessageCompression_Z;
#pragma warning disable 0169
		static Delegate GetSetMessageCompression_ZHandler ()
		{
			if (cb_setMessageCompression_Z == null)
				cb_setMessageCompression_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMessageCompression_Z);
			return cb_setMessageCompression_Z;
		}

		static void n_SetMessageCompression_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Xamarin.Grpc.Stub.CallStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.CallStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageCompression (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='setMessageCompression' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMessageCompression", "(Z)V", "GetSetMessageCompression_ZHandler")]
		public abstract void SetMessageCompression (bool p0);

		static Delegate cb_setOnReadyHandler_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetOnReadyHandler_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setOnReadyHandler_Ljava_lang_Runnable_ == null)
				cb_setOnReadyHandler_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnReadyHandler_Ljava_lang_Runnable_);
			return cb_setOnReadyHandler_Ljava_lang_Runnable_;
		}

		static void n_SetOnReadyHandler_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.Grpc.Stub.CallStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.CallStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnReadyHandler (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='CallStreamObserver']/method[@name='setOnReadyHandler' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setOnReadyHandler", "(Ljava/lang/Runnable;)V", "GetSetOnReadyHandler_Ljava_lang_Runnable_Handler")]
		public abstract void SetOnReadyHandler (global::Java.Lang.IRunnable p0);

	}

	[global::Android.Runtime.Register ("io/grpc/stub/CallStreamObserver", DoNotGenerateAcw=true)]
	internal partial class CallStreamObserverInvoker : CallStreamObserver {

		public CallStreamObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/CallStreamObserver", typeof (CallStreamObserverInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
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

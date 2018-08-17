using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Grpc.Stub {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCallStreamObserver']"
	[global::Android.Runtime.Register ("io/grpc/stub/ServerCallStreamObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
	public abstract partial class ServerCallStreamObserver : global::Xamarin.Grpc.Stub.CallStreamObserver {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("io/grpc/stub/ServerCallStreamObserver", typeof (ServerCallStreamObserver));
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

		protected ServerCallStreamObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCallStreamObserver']/constructor[@name='ServerCallStreamObserver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServerCallStreamObserver ()
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

		static Delegate cb_isCancelled;
#pragma warning disable 0169
		static Delegate GetIsCancelledHandler ()
		{
			if (cb_isCancelled == null)
				cb_isCancelled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCancelled);
			return cb_isCancelled;
		}

		static bool n_IsCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.Grpc.Stub.ServerCallStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCallStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		public abstract bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCallStreamObserver']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")] get;
		}

		static Delegate cb_setCompression_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCompression_Ljava_lang_String_Handler ()
		{
			if (cb_setCompression_Ljava_lang_String_ == null)
				cb_setCompression_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompression_Ljava_lang_String_);
			return cb_setCompression_Ljava_lang_String_;
		}

		static void n_SetCompression_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.Grpc.Stub.ServerCallStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCallStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCompression (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCallStreamObserver']/method[@name='setCompression' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCompression", "(Ljava/lang/String;)V", "GetSetCompression_Ljava_lang_String_Handler")]
		public abstract void SetCompression (string p0);

		static Delegate cb_setOnCancelHandler_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetOnCancelHandler_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setOnCancelHandler_Ljava_lang_Runnable_ == null)
				cb_setOnCancelHandler_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCancelHandler_Ljava_lang_Runnable_);
			return cb_setOnCancelHandler_Ljava_lang_Runnable_;
		}

		static void n_SetOnCancelHandler_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.Grpc.Stub.ServerCallStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCallStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCancelHandler (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCallStreamObserver']/method[@name='setOnCancelHandler' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setOnCancelHandler", "(Ljava/lang/Runnable;)V", "GetSetOnCancelHandler_Ljava_lang_Runnable_Handler")]
		public abstract void SetOnCancelHandler (global::Java.Lang.IRunnable p0);

	}

	[global::Android.Runtime.Register ("io/grpc/stub/ServerCallStreamObserver", DoNotGenerateAcw=true)]
	internal partial class ServerCallStreamObserverInvoker : ServerCallStreamObserver {

		public ServerCallStreamObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/ServerCallStreamObserver", typeof (ServerCallStreamObserverInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCallStreamObserver']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				const string __id = "isCancelled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCallStreamObserver']/method[@name='setCompression' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCompression", "(Ljava/lang/String;)V", "GetSetCompression_Ljava_lang_String_Handler")]
		public override unsafe void SetCompression (string p0)
		{
			const string __id = "setCompression.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCallStreamObserver']/method[@name='setOnCancelHandler' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setOnCancelHandler", "(Ljava/lang/Runnable;)V", "GetSetOnCancelHandler_Ljava_lang_Runnable_Handler")]
		public override unsafe void SetOnCancelHandler (global::Java.Lang.IRunnable p0)
		{
			const string __id = "setOnCancelHandler.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
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

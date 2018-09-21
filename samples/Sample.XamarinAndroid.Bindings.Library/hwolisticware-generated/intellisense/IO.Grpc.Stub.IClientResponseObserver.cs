using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace IO.Grpc.Stub {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ClientResponseObserver']"
	[Register ("io/grpc/stub/ClientResponseObserver", "", "IO.Grpc.Stub.IClientResponseObserverInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"ReqT", "RespT"})]
	public partial interface IClientResponseObserver : global::IO.Grpc.Stub.IStreamObserver {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ClientResponseObserver']/method[@name='beforeStart' and count(parameter)=1 and parameter[1][@type='io.grpc.stub.ClientCallStreamObserver&lt;ReqT&gt;']]"
		[Register ("beforeStart", "(Lio/grpc/stub/ClientCallStreamObserver;)V", "GetBeforeStart_Lio_grpc_stub_ClientCallStreamObserver_Handler:IO.Grpc.Stub.IClientResponseObserverInvoker, Sample.XamarinAndroid.Bindings.Library")]
		void BeforeStart (global::IO.Grpc.Stub.ClientCallStreamObserver p0);

	}

	[global::Android.Runtime.Register ("io/grpc/stub/ClientResponseObserver", DoNotGenerateAcw=true)]
	internal class IClientResponseObserverInvoker : global::Java.Lang.Object, IClientResponseObserver {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/ClientResponseObserver", typeof (IClientResponseObserverInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IClientResponseObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClientResponseObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.grpc.stub.ClientResponseObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClientResponseObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_beforeStart_Lio_grpc_stub_ClientCallStreamObserver_;
#pragma warning disable 0169
		static Delegate GetBeforeStart_Lio_grpc_stub_ClientCallStreamObserver_Handler ()
		{
			if (cb_beforeStart_Lio_grpc_stub_ClientCallStreamObserver_ == null)
				cb_beforeStart_Lio_grpc_stub_ClientCallStreamObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BeforeStart_Lio_grpc_stub_ClientCallStreamObserver_);
			return cb_beforeStart_Lio_grpc_stub_ClientCallStreamObserver_;
		}

		static void n_BeforeStart_Lio_grpc_stub_ClientCallStreamObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Grpc.Stub.IClientResponseObserver __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.IClientResponseObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Grpc.Stub.ClientCallStreamObserver p0 = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.ClientCallStreamObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BeforeStart (p0);
		}
#pragma warning restore 0169

		IntPtr id_beforeStart_Lio_grpc_stub_ClientCallStreamObserver_;
		public unsafe void BeforeStart (global::IO.Grpc.Stub.ClientCallStreamObserver p0)
		{
			if (id_beforeStart_Lio_grpc_stub_ClientCallStreamObserver_ == IntPtr.Zero)
				id_beforeStart_Lio_grpc_stub_ClientCallStreamObserver_ = JNIEnv.GetMethodID (class_ref, "beforeStart", "(Lio/grpc/stub/ClientCallStreamObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_beforeStart_Lio_grpc_stub_ClientCallStreamObserver_, __args);
		}

		static Delegate cb_onCompleted;
#pragma warning disable 0169
		static Delegate GetOnCompletedHandler ()
		{
			if (cb_onCompleted == null)
				cb_onCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCompleted);
			return cb_onCompleted;
		}

		static void n_OnCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Grpc.Stub.IClientResponseObserver __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.IClientResponseObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted ();
		}
#pragma warning restore 0169

		IntPtr id_onCompleted;
		public unsafe void OnCompleted ()
		{
			if (id_onCompleted == IntPtr.Zero)
				id_onCompleted = JNIEnv.GetMethodID (class_ref, "onCompleted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompleted);
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Grpc.Stub.IClientResponseObserver __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.IClientResponseObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_onNext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnNext_Ljava_lang_Object_Handler ()
		{
			if (cb_onNext_Ljava_lang_Object_ == null)
				cb_onNext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNext_Ljava_lang_Object_);
			return cb_onNext_Ljava_lang_Object_;
		}

		static void n_OnNext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Grpc.Stub.IClientResponseObserver __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.IClientResponseObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNext (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNext_Ljava_lang_Object_;
		public unsafe void OnNext (global::Java.Lang.Object p0)
		{
			if (id_onNext_Ljava_lang_Object_ == IntPtr.Zero)
				id_onNext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onNext", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNext_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}

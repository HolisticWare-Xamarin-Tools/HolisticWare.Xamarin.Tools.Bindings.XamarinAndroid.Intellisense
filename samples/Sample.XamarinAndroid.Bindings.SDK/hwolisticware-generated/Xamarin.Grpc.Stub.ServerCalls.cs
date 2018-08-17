using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Grpc.Stub {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCalls']"
	[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls", DoNotGenerateAcw=true)]
	public sealed partial class ServerCalls : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ServerCalls.BidiStreamingMethod']"
		[Register ("io/grpc/stub/ServerCalls$BidiStreamingMethod", "", "Xamarin.Grpc.Stub.ServerCalls/IBidiStreamingMethodInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ReqT", "RespT"})]
		public partial interface IBidiStreamingMethod : global::Xamarin.Grpc.Stub.ServerCalls.IStreamingRequestMethod {

		}

		[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls$BidiStreamingMethod", DoNotGenerateAcw=true)]
		internal class IBidiStreamingMethodInvoker : global::Java.Lang.Object, IBidiStreamingMethod {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/ServerCalls$BidiStreamingMethod", typeof (IBidiStreamingMethodInvoker));

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

			public static IBidiStreamingMethod GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBidiStreamingMethod> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.grpc.stub.ServerCalls.BidiStreamingMethod"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBidiStreamingMethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_invoke_Lio_grpc_stub_StreamObserver_;
#pragma warning disable 0169
			static Delegate GetInvoke_Lio_grpc_stub_StreamObserver_Handler ()
			{
				if (cb_invoke_Lio_grpc_stub_StreamObserver_ == null)
					cb_invoke_Lio_grpc_stub_StreamObserver_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Lio_grpc_stub_StreamObserver_);
				return cb_invoke_Lio_grpc_stub_StreamObserver_;
			}

			static IntPtr n_Invoke_Lio_grpc_stub_StreamObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.Grpc.Stub.ServerCalls.IBidiStreamingMethod __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCalls.IBidiStreamingMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.Grpc.Stub.IStreamObserver p0 = (global::Xamarin.Grpc.Stub.IStreamObserver)global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_invoke_Lio_grpc_stub_StreamObserver_;
			public unsafe global::Xamarin.Grpc.Stub.IStreamObserver Invoke (global::Xamarin.Grpc.Stub.IStreamObserver p0)
			{
				if (id_invoke_Lio_grpc_stub_StreamObserver_ == IntPtr.Zero)
					id_invoke_Lio_grpc_stub_StreamObserver_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Lio/grpc/stub/StreamObserver;)Lio/grpc/stub/StreamObserver;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Xamarin.Grpc.Stub.IStreamObserver __ret = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Lio_grpc_stub_StreamObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ServerCalls.ClientStreamingMethod']"
		[Register ("io/grpc/stub/ServerCalls$ClientStreamingMethod", "", "Xamarin.Grpc.Stub.ServerCalls/IClientStreamingMethodInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ReqT", "RespT"})]
		public partial interface IClientStreamingMethod : global::Xamarin.Grpc.Stub.ServerCalls.IStreamingRequestMethod {

		}

		[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls$ClientStreamingMethod", DoNotGenerateAcw=true)]
		internal class IClientStreamingMethodInvoker : global::Java.Lang.Object, IClientStreamingMethod {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/ServerCalls$ClientStreamingMethod", typeof (IClientStreamingMethodInvoker));

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

			public static IClientStreamingMethod GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IClientStreamingMethod> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.grpc.stub.ServerCalls.ClientStreamingMethod"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IClientStreamingMethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_invoke_Lio_grpc_stub_StreamObserver_;
#pragma warning disable 0169
			static Delegate GetInvoke_Lio_grpc_stub_StreamObserver_Handler ()
			{
				if (cb_invoke_Lio_grpc_stub_StreamObserver_ == null)
					cb_invoke_Lio_grpc_stub_StreamObserver_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Lio_grpc_stub_StreamObserver_);
				return cb_invoke_Lio_grpc_stub_StreamObserver_;
			}

			static IntPtr n_Invoke_Lio_grpc_stub_StreamObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.Grpc.Stub.ServerCalls.IClientStreamingMethod __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCalls.IClientStreamingMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.Grpc.Stub.IStreamObserver p0 = (global::Xamarin.Grpc.Stub.IStreamObserver)global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_invoke_Lio_grpc_stub_StreamObserver_;
			public unsafe global::Xamarin.Grpc.Stub.IStreamObserver Invoke (global::Xamarin.Grpc.Stub.IStreamObserver p0)
			{
				if (id_invoke_Lio_grpc_stub_StreamObserver_ == IntPtr.Zero)
					id_invoke_Lio_grpc_stub_StreamObserver_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Lio/grpc/stub/StreamObserver;)Lio/grpc/stub/StreamObserver;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Xamarin.Grpc.Stub.IStreamObserver __ret = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Lio_grpc_stub_StreamObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCalls.NoopStreamObserver']"
		[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls$NoopStreamObserver", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public partial class NoopStreamObserver : global::Java.Lang.Object, global::Xamarin.Grpc.Stub.IStreamObserver {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("io/grpc/stub/ServerCalls$NoopStreamObserver", typeof (NoopStreamObserver));
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

			protected NoopStreamObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Xamarin.Grpc.Stub.ServerCalls.NoopStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCalls.NoopStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCompleted ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCalls.NoopStreamObserver']/method[@name='onCompleted' and count(parameter)=0]"
			[Register ("onCompleted", "()V", "GetOnCompletedHandler")]
			public virtual unsafe void OnCompleted ()
			{
				const string __id = "onCompleted.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onError_Ljava_lang_Throwable_ == null)
					cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
				return cb_onError_Ljava_lang_Throwable_;
			}

			static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
			{
				global::Xamarin.Grpc.Stub.ServerCalls.NoopStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCalls.NoopStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
				__this.OnError (t);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCalls.NoopStreamObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void OnError (global::Java.Lang.Throwable t)
			{
				const string __id = "onError.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onNext_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnNext_Ljava_lang_Object_Handler ()
			{
				if (cb_onNext_Ljava_lang_Object_ == null)
					cb_onNext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNext_Ljava_lang_Object_);
				return cb_onNext_Ljava_lang_Object_;
			}

			static void n_OnNext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
			{
				global::Xamarin.Grpc.Stub.ServerCalls.NoopStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCalls.NoopStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
				__this.OnNext (value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCalls.NoopStreamObserver']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='V']]"
			[Register ("onNext", "(Ljava/lang/Object;)V", "GetOnNext_Ljava_lang_Object_Handler")]
			public virtual unsafe void OnNext (global::Java.Lang.Object value)
			{
				const string __id = "onNext.(Ljava/lang/Object;)V";
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ServerCalls.ServerStreamingMethod']"
		[Register ("io/grpc/stub/ServerCalls$ServerStreamingMethod", "", "Xamarin.Grpc.Stub.ServerCalls/IServerStreamingMethodInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ReqT", "RespT"})]
		public partial interface IServerStreamingMethod : global::Xamarin.Grpc.Stub.ServerCalls.IUnaryRequestMethod {

		}

		[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls$ServerStreamingMethod", DoNotGenerateAcw=true)]
		internal class IServerStreamingMethodInvoker : global::Java.Lang.Object, IServerStreamingMethod {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/ServerCalls$ServerStreamingMethod", typeof (IServerStreamingMethodInvoker));

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

			public static IServerStreamingMethod GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IServerStreamingMethod> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.grpc.stub.ServerCalls.ServerStreamingMethod"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IServerStreamingMethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_;
#pragma warning disable 0169
			static Delegate GetInvoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_Handler ()
			{
				if (cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ == null)
					cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_);
				return cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_;
			}

			static void n_Invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.Grpc.Stub.ServerCalls.IServerStreamingMethod __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCalls.IServerStreamingMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.Grpc.Stub.IStreamObserver p1 = (global::Xamarin.Grpc.Stub.IStreamObserver)global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Invoke (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_;
			public unsafe void Invoke (global::Java.Lang.Object p0, global::Xamarin.Grpc.Stub.IStreamObserver p1)
			{
				if (id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ == IntPtr.Zero)
					id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Lio/grpc/stub/StreamObserver;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ServerCalls.StreamingRequestMethod']"
		[Register ("io/grpc/stub/ServerCalls$StreamingRequestMethod", "", "Xamarin.Grpc.Stub.ServerCalls/IStreamingRequestMethodInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ReqT", "RespT"})]
		public partial interface IStreamingRequestMethod : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ServerCalls.StreamingRequestMethod']/method[@name='invoke' and count(parameter)=1 and parameter[1][@type='io.grpc.stub.StreamObserver&lt;RespT&gt;']]"
			[Register ("invoke", "(Lio/grpc/stub/StreamObserver;)Lio/grpc/stub/StreamObserver;", "GetInvoke_Lio_grpc_stub_StreamObserver_Handler:Xamarin.Grpc.Stub.ServerCalls/IStreamingRequestMethodInvoker, Sample.XamarinAndroid.Bindings.SDK")]
			global::Xamarin.Grpc.Stub.IStreamObserver Invoke (global::Xamarin.Grpc.Stub.IStreamObserver p0);

		}

		[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls$StreamingRequestMethod", DoNotGenerateAcw=true)]
		internal class IStreamingRequestMethodInvoker : global::Java.Lang.Object, IStreamingRequestMethod {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/ServerCalls$StreamingRequestMethod", typeof (IStreamingRequestMethodInvoker));

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

			public static IStreamingRequestMethod GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStreamingRequestMethod> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.grpc.stub.ServerCalls.StreamingRequestMethod"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStreamingRequestMethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_invoke_Lio_grpc_stub_StreamObserver_;
#pragma warning disable 0169
			static Delegate GetInvoke_Lio_grpc_stub_StreamObserver_Handler ()
			{
				if (cb_invoke_Lio_grpc_stub_StreamObserver_ == null)
					cb_invoke_Lio_grpc_stub_StreamObserver_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Lio_grpc_stub_StreamObserver_);
				return cb_invoke_Lio_grpc_stub_StreamObserver_;
			}

			static IntPtr n_Invoke_Lio_grpc_stub_StreamObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.Grpc.Stub.ServerCalls.IStreamingRequestMethod __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCalls.IStreamingRequestMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.Grpc.Stub.IStreamObserver p0 = (global::Xamarin.Grpc.Stub.IStreamObserver)global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_invoke_Lio_grpc_stub_StreamObserver_;
			public unsafe global::Xamarin.Grpc.Stub.IStreamObserver Invoke (global::Xamarin.Grpc.Stub.IStreamObserver p0)
			{
				if (id_invoke_Lio_grpc_stub_StreamObserver_ == IntPtr.Zero)
					id_invoke_Lio_grpc_stub_StreamObserver_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Lio/grpc/stub/StreamObserver;)Lio/grpc/stub/StreamObserver;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Xamarin.Grpc.Stub.IStreamObserver __ret = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Lio_grpc_stub_StreamObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ServerCalls.UnaryMethod']"
		[Register ("io/grpc/stub/ServerCalls$UnaryMethod", "", "Xamarin.Grpc.Stub.ServerCalls/IUnaryMethodInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ReqT", "RespT"})]
		public partial interface IUnaryMethod : global::Xamarin.Grpc.Stub.ServerCalls.IUnaryRequestMethod {

		}

		[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls$UnaryMethod", DoNotGenerateAcw=true)]
		internal class IUnaryMethodInvoker : global::Java.Lang.Object, IUnaryMethod {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/ServerCalls$UnaryMethod", typeof (IUnaryMethodInvoker));

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

			public static IUnaryMethod GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUnaryMethod> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.grpc.stub.ServerCalls.UnaryMethod"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUnaryMethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_;
#pragma warning disable 0169
			static Delegate GetInvoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_Handler ()
			{
				if (cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ == null)
					cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_);
				return cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_;
			}

			static void n_Invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.Grpc.Stub.ServerCalls.IUnaryMethod __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCalls.IUnaryMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.Grpc.Stub.IStreamObserver p1 = (global::Xamarin.Grpc.Stub.IStreamObserver)global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Invoke (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_;
			public unsafe void Invoke (global::Java.Lang.Object p0, global::Xamarin.Grpc.Stub.IStreamObserver p1)
			{
				if (id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ == IntPtr.Zero)
					id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Lio/grpc/stub/StreamObserver;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ServerCalls.UnaryRequestMethod']"
		[Register ("io/grpc/stub/ServerCalls$UnaryRequestMethod", "", "Xamarin.Grpc.Stub.ServerCalls/IUnaryRequestMethodInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ReqT", "RespT"})]
		public partial interface IUnaryRequestMethod : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/interface[@name='ServerCalls.UnaryRequestMethod']/method[@name='invoke' and count(parameter)=2 and parameter[1][@type='ReqT'] and parameter[2][@type='io.grpc.stub.StreamObserver&lt;RespT&gt;']]"
			[Register ("invoke", "(Ljava/lang/Object;Lio/grpc/stub/StreamObserver;)V", "GetInvoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_Handler:Xamarin.Grpc.Stub.ServerCalls/IUnaryRequestMethodInvoker, Sample.XamarinAndroid.Bindings.SDK")]
			void Invoke (global::Java.Lang.Object p0, global::Xamarin.Grpc.Stub.IStreamObserver p1);

		}

		[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls$UnaryRequestMethod", DoNotGenerateAcw=true)]
		internal class IUnaryRequestMethodInvoker : global::Java.Lang.Object, IUnaryRequestMethod {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/ServerCalls$UnaryRequestMethod", typeof (IUnaryRequestMethodInvoker));

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

			public static IUnaryRequestMethod GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUnaryRequestMethod> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.grpc.stub.ServerCalls.UnaryRequestMethod"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUnaryRequestMethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_;
#pragma warning disable 0169
			static Delegate GetInvoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_Handler ()
			{
				if (cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ == null)
					cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_);
				return cb_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_;
			}

			static void n_Invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.Grpc.Stub.ServerCalls.IUnaryRequestMethod __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.ServerCalls.IUnaryRequestMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.Grpc.Stub.IStreamObserver p1 = (global::Xamarin.Grpc.Stub.IStreamObserver)global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Invoke (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_;
			public unsafe void Invoke (global::Java.Lang.Object p0, global::Xamarin.Grpc.Stub.IStreamObserver p1)
			{
				if (id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ == IntPtr.Zero)
					id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Lio/grpc/stub/StreamObserver;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_Object_Lio_grpc_stub_StreamObserver_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("io/grpc/stub/ServerCalls", typeof (ServerCalls));
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

		internal ServerCalls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}

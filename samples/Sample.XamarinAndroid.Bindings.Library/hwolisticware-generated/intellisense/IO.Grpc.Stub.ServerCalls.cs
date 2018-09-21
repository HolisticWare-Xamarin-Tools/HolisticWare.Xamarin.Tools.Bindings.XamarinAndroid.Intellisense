using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace IO.Grpc.Stub {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCalls']"
	[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls", DoNotGenerateAcw=true)]
	public sealed partial class ServerCalls : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.grpc.stub']/class[@name='ServerCalls.NoopStreamObserver']"
		[global::Android.Runtime.Register ("io/grpc/stub/ServerCalls$NoopStreamObserver", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public partial class NoopStreamObserver : global::Java.Lang.Object, global::IO.Grpc.Stub.IStreamObserver {

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
				global::IO.Grpc.Stub.ServerCalls.NoopStreamObserver __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.ServerCalls.NoopStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::IO.Grpc.Stub.ServerCalls.NoopStreamObserver __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.ServerCalls.NoopStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::IO.Grpc.Stub.ServerCalls.NoopStreamObserver __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.ServerCalls.NoopStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

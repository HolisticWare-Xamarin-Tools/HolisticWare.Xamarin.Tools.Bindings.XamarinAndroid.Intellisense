using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace IO.Grpc.Stub.Annotations {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.grpc.stub.annotations']/interface[@name='RpcMethod']"
	[Register ("io/grpc/stub/annotations/RpcMethod", "", "IO.Grpc.Stub.Annotations.IRpcMethodInvoker")]
	public partial interface IRpcMethod : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub.annotations']/interface[@name='RpcMethod']/method[@name='fullMethodName' and count(parameter)=0]"
		[Register ("fullMethodName", "()Ljava/lang/String;", "GetFullMethodNameHandler:IO.Grpc.Stub.Annotations.IRpcMethodInvoker, Sample.XamarinAndroid.Bindings.SDK")]
		string FullMethodName ();

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub.annotations']/interface[@name='RpcMethod']/method[@name='requestType' and count(parameter)=0]"
		[Register ("requestType", "()Ljava/lang/Class;", "GetRequestTypeHandler:IO.Grpc.Stub.Annotations.IRpcMethodInvoker, Sample.XamarinAndroid.Bindings.SDK")]
		global::Java.Lang.Class RequestType ();

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub.annotations']/interface[@name='RpcMethod']/method[@name='responseType' and count(parameter)=0]"
		[Register ("responseType", "()Ljava/lang/Class;", "GetResponseTypeHandler:IO.Grpc.Stub.Annotations.IRpcMethodInvoker, Sample.XamarinAndroid.Bindings.SDK")]
		global::Java.Lang.Class ResponseType ();

	}

	[global::Android.Runtime.Register ("io/grpc/stub/annotations/RpcMethod", DoNotGenerateAcw=true)]
	internal class IRpcMethodInvoker : global::Java.Lang.Object, IRpcMethod {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/annotations/RpcMethod", typeof (IRpcMethodInvoker));

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

		public static IRpcMethod GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRpcMethod> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.grpc.stub.annotations.RpcMethod"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRpcMethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_fullMethodName;
#pragma warning disable 0169
		static Delegate GetFullMethodNameHandler ()
		{
			if (cb_fullMethodName == null)
				cb_fullMethodName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FullMethodName);
			return cb_fullMethodName;
		}

		static IntPtr n_FullMethodName (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Grpc.Stub.Annotations.IRpcMethod __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.Annotations.IRpcMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FullMethodName ());
		}
#pragma warning restore 0169

		IntPtr id_fullMethodName;
		public unsafe string FullMethodName ()
		{
			if (id_fullMethodName == IntPtr.Zero)
				id_fullMethodName = JNIEnv.GetMethodID (class_ref, "fullMethodName", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fullMethodName), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_requestType;
#pragma warning disable 0169
		static Delegate GetRequestTypeHandler ()
		{
			if (cb_requestType == null)
				cb_requestType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RequestType);
			return cb_requestType;
		}

		static IntPtr n_RequestType (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Grpc.Stub.Annotations.IRpcMethod __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.Annotations.IRpcMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestType ());
		}
#pragma warning restore 0169

		IntPtr id_requestType;
		public unsafe global::Java.Lang.Class RequestType ()
		{
			if (id_requestType == IntPtr.Zero)
				id_requestType = JNIEnv.GetMethodID (class_ref, "requestType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_responseType;
#pragma warning disable 0169
		static Delegate GetResponseTypeHandler ()
		{
			if (cb_responseType == null)
				cb_responseType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ResponseType);
			return cb_responseType;
		}

		static IntPtr n_ResponseType (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Grpc.Stub.Annotations.IRpcMethod __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.Annotations.IRpcMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseType ());
		}
#pragma warning restore 0169

		IntPtr id_responseType;
		public unsafe global::Java.Lang.Class ResponseType ()
		{
			if (id_responseType == IntPtr.Zero)
				id_responseType = JNIEnv.GetMethodID (class_ref, "responseType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_responseType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Grpc.Stub.Annotations.IRpcMethod __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.Annotations.IRpcMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::IO.Grpc.Stub.Annotations.IRpcMethod __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.Annotations.IRpcMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Grpc.Stub.Annotations.IRpcMethod __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.Annotations.IRpcMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Grpc.Stub.Annotations.IRpcMethod __this = global::Java.Lang.Object.GetObject<global::IO.Grpc.Stub.Annotations.IRpcMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
